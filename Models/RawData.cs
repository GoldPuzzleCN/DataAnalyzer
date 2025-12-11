using System.Collections.Generic;
using System.Linq;

namespace DataAnalyzer_Oceanparadise.Models
{
    /// <summary>
    /// 存储原始压强-时间（P-t）数据
    /// </summary>
    public class RawData
    {
        // 时间点集合（单位：s）
        public List<double> TimePoints { get; set; } = new List<double>();

        // 压强集合（单位：Pa）
        public List<double> PressurePoints { get; set; } = new List<double>();

        // 数据点总数
        public int DataCount => TimePoints.Count;

        // 时间范围描述（格式化显示）
        public string TimeRange => DataCount > 0
            ? $"{TimePoints.First():F3} ~ {TimePoints.Last():F3} s"
            : "未导入数据";

        // 压强范围描述
        public string PressureRange => DataCount > 0
            ? $"{PressurePoints.Min():F0} ~ {PressurePoints.Max():F0} Pa"
            : "未导入数据";
    }
}