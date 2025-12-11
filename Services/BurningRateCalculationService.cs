using System;
using System.Collections.Generic;
using DataAnalyzer_Oceanparadise.Models;
using System.Windows.Forms;

namespace DataAnalyzer_Oceanparadise.Services
{
    /// <summary>
    /// 燃速计算服务：根据P-t数据和参数计算燃速等关键指标
    /// </summary>
    public class BurningRateCalculationService
    {
        private readonly AppDataContext _appDataContext;

        public BurningRateCalculationService(AppDataContext appDataContext)
        {
            _appDataContext = appDataContext;
        }

        /// <summary>
        /// 计算燃速及相关参数
        /// </summary>
        /// <returns>计算是否成功</returns>
        public bool CalculateBurningRates()
        {
            try
            {
                // 验证必要数据
                if (_appDataContext.RawData == null || _appDataContext.RawData.DataCount == 0)
                {
                    throw new InvalidOperationException("没有可用的P-t数据，请先导入");
                }

                if (_appDataContext.CalcParams == null)
                {
                    throw new InvalidOperationException("计算参数未初始化");
                }

                var rawData = _appDataContext.RawData;
                var parameters = _appDataContext.CalcParams;

                // 验证参数有效性
                if (parameters.TimeStep <= 0)
                {
                    throw new InvalidOperationException("时间步长必须大于0");
                }

                if (parameters.Density <= 0)
                {
                    throw new InvalidOperationException("燃料密度必须大于0");
                }

                if (parameters.CharacteristicVelocity <= 0)
                {
                    throw new InvalidOperationException("特征速度必须大于0");
                }

                if (parameters.ThroatArea <= 0)
                {
                    throw new InvalidOperationException("喷喉面积必须大于0");
                }

                // 初始化计算结果
                var results = new CalculationResults();
                var stepResults = new List<StepResult>();

                // 计算初始燃面面积 Ab0 = π × D × h
                double initialBurningArea = Math.PI * parameters.InitialDiameter * parameters.GrainLength;
                results.InitialBurningArea = initialBurningArea;

                // 迭代计算每一步的结果
                for (int i = 0; i < rawData.DataCount; i++)
                {
                    double time = rawData.TimePoints[i];
                    double pressure = rawData.PressurePoints[i];
                    double currentDiameter;
                    double currentBurningArea;
                    double burningRate;

                    if (i == 0)
                    {
                        // 第一步使用初始参数
                        currentDiameter = parameters.InitialDiameter;
                        currentBurningArea = initialBurningArea;
                    }
                    else
                    {
                        // 后续步骤基于上一步结果计算
                        var previousStep = stepResults[i - 1];
                        // 当前直径 = 上一步直径 + 2 × 上一步燃速 × 时间步长
                        currentDiameter = previousStep.CurrentDiameter + 2 * previousStep.BurningRate * parameters.TimeStep;
                        // 当前燃面面积 = π × 当前直径 × 药柱长度
                        currentBurningArea = Math.PI * currentDiameter * parameters.GrainLength;
                    }

                    // 计算燃速: r = P / [(Ab/At) × ρ × C']
                    burningRate = pressure / ((currentBurningArea / parameters.ThroatArea) * parameters.Density * parameters.CharacteristicVelocity);

                    // 添加到结果集合
                    stepResults.Add(new StepResult
                    {
                        Time = time,
                        Pressure = pressure,
                        BurningRate = burningRate,
                        CurrentDiameter = currentDiameter,
                        BurningArea = currentBurningArea
                    });
                }

                // 保存计算结果
                results.StepResults = stepResults;
                _appDataContext.CalcResults = results;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"计算失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
