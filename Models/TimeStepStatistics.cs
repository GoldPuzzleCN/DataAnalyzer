using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// TimeStepStatistics.cs
namespace DataAnalyzer_Oceanparadise.Models
{
    /// <summary>
    /// 时间步长统计信息（存储T值及相关数据）
    /// </summary>
    public class TimeStepStatistics
    {
        // 默认时间步长（平均T值）
        public double DefaultTStep { get; set; }

        // 最小时间间隔（可选，用于统计显示）
        public double MinInterval { get; set; }

        // 最大时间间隔（可选，用于统计显示）
        public double MaxInterval { get; set; }
    }
}