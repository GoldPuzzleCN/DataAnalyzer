using System.Collections.Generic;

namespace DataAnalyzer_Oceanparadise.Models
{
    /// <summary>
    /// 单步计算结果（每个时间点的参数）
    /// </summary>
    public class StepResult
    {
        public double Time { get; set; }          // 时间点（s）
        public double Pressure { get; set; }      // 压强（Pa）
        public double BurningRate { get; set; }   // 燃速r（m/s）
        public double CurrentDiameter { get; set; } // 当前内孔直径（m）
        public double BurningArea { get; set; }   // 当前燃面面积（m²）
    }

    /// <summary>
    /// 所有计算结果的集合
    /// </summary>
    public class CalculationResults
    {
        // 每一步的计算结果
        public List<StepResult> StepResults { get; set; } = new List<StepResult>();

        // 初始燃面面积Ab0（m²）
        public double InitialBurningArea { get; set; }
    }
}