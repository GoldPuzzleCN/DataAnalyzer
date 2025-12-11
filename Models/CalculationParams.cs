namespace DataAnalyzer_Oceanparadise.Models
{
    /// <summary>
    /// 燃烧计算所需的输入参数（用户可配置）
    /// </summary>
    public class CalculationParams
    {
        // 燃料密度ρ（kg/m³）
        public double Density { get; set; } = 1600;  // 示例默认值（固体燃料）

        // 特征速度C`（m/s）
        public double CharacteristicVelocity { get; set; } = 1500;  // 示例默认值

        // 喷喉截面积At（m²）
        public double ThroatArea { get; set; } = 0.001;  // 示例默认值

        // 初始内孔直径D（m）
        public double InitialDiameter { get; set; } = 0.05;  // 示例默认值

        // 药柱长度h（m）
        public double GrainLength { get; set; } = 0.5;  // 示例默认值

        // 时间步长T（s，默认从原始数据计算）
        public double TimeStep { get; set; }
    }
}