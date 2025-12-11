using CsvHelper;
using CsvHelper.Configuration;
using DataAnalyzer_Oceanparadise.Models;
using MathNet.Numerics.Statistics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DataAnalyzer_Oceanparadise.Services
{
    /// <summary>
    /// 文件导入服务：负责解析CSV/TXT格式的P-t数据，并计算时间步长
    /// </summary>
    public class FileImportService
    {
        private readonly AppDataContext _appDataContext;

        public FileImportService(AppDataContext appDataContext)
        {
            _appDataContext = appDataContext;
        }

        /// <summary>
        /// 导入P-t数据文件（支持CSV/TXT）
        /// </summary>
        public bool ImportPtData(string filePath)
        {
            try
            {
                var extension = Path.GetExtension(filePath).ToLower();
                var stepResults = new List<StepResult>(); // 假设 StepResult 存时间、压强
                var timeData = new List<double>();        // 存解析的时间列
                if (extension != ".csv" && extension != ".txt")
                {
                    MessageBox.Show("请选择CSV或TXT格式的文件", "格式错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                int invalidRows = 0;
                var (timePoints, pressurePoints, invalidCount) = extension == ".csv"
                    ? ParseCsvFile(filePath)
                    : ParseTxtFile(filePath);

                invalidRows = invalidCount;

                if (timePoints.Count == 0 || pressurePoints.Count == 0 || timePoints.Count != pressurePoints.Count)
                {
                    MessageBox.Show("数据解析失败，请检查文件格式（应为时间,压强）", "数据错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (invalidRows > 0)
                {
                    MessageBox.Show($"导入过程中发现 {invalidRows} 行无效数据，已自动跳过", "数据警告",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                _appDataContext.RawData = new RawData
                {
                    TimePoints = timePoints,
                    PressurePoints = pressurePoints
                };

                CalculateTimeStep(timePoints);

                MessageBox.Show($"导入成功！共{timePoints.Count}条有效数据", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"导入失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// 解析CSV文件（逗号分隔）
        /// </summary>
        private (List<double> time, List<double> pressure, int invalidRows) ParseCsvFile(string filePath)
        {
            var timePoints = new List<double>();
            var pressurePoints = new List<double>();
            int invalidRows = 0;

            var config = new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                Delimiter = ",",
                IgnoreBlankLines = true
            };

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, config))
            {
                // 逐行读取，不用 GetRecords<dynamic>
                while (csv.Read())
                {
                    double t = 0;
                    double p = 0;
                    bool isTimeValid = csv.TryGetField(0, out t);
                    bool isPressureValid = csv.TryGetField(1, out p);

                    if (isTimeValid && isPressureValid)
                    {
                        timePoints.Add(t);
                        pressurePoints.Add(p);
                    }
                    else
                    {
                        invalidRows++;
                    }
                }
            }

            return (timePoints, pressurePoints, invalidRows);
        }
        /// <summary>
        /// 解析TXT文件（支持空格、制表符分隔）
        /// </summary>
        private (List<double> time, List<double> pressure, int invalidRows) ParseTxtFile(string filePath)
        {
            var timePoints = new List<double>();
            var pressurePoints = new List<double>();
            int invalidRows = 0;
            var lines = File.ReadAllLines(filePath)
                .Where(line => !string.IsNullOrWhiteSpace(line) && !line.StartsWith("#"))
                .ToList();

            foreach (var line in lines)
            {
                var parts = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length >= 2)
                {
                    // 明确声明变量并初始化
                    double t = 0;
                    double p = 0;
                    bool isTimeValid = double.TryParse(parts[0], out t);
                    bool isPressureValid = double.TryParse(parts[1], out p);

                    if (isTimeValid && isPressureValid)
                    {
                        timePoints.Add(t);
                        pressurePoints.Add(p);
                    }
                    else
                    {
                        invalidRows++;
                    }
                }
                else
                {
                    invalidRows++;
                }
            }

            return (timePoints, pressurePoints, invalidRows);
        }

        /// <summary>
        /// 计算时间步长T及统计信息
        /// </summary>
        private void CalculateTimeStep(List<double> timePoints)
        {
            var intervals = new List<double>();
            for (int i = 1; i < timePoints.Count; i++)
            {
                var interval = timePoints[i] - timePoints[i - 1];
                if (interval > 0)
                {
                    intervals.Add(interval);
                }
            }

            if (intervals.Count == 0)
            {
                MessageBox.Show("无法计算时间步长，数据可能不足或时间倒序", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var stats = new TimeStepStats
            {
                MinInterval = intervals.Min(),
                MaxInterval = intervals.Max(),
                DefaultTStep = intervals.Average(),
                StdDevInterval = intervals.StandardDeviation()
            };

            _appDataContext.TimeStepStats = stats;
            _appDataContext.CalcParams.TimeStep = stats.DefaultTStep;
        }

    }
}
