using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAnalyzer_Oceanparadise.Models
{
    /// <summary>
    /// 时间步长（T）的统计数据（从原始时间点自动计算）
    /// </summary>
    public class TimeStepStats
    {
        // 最小时间间隔（s）
        public double MinInterval { get; set; }

        // 最大时间间隔（s）
        public double MaxInterval { get; set; }

        // 时间间隔标准差（反映稳定性）
        public double StdDevInterval { get; set; }

        // 默认时间步长（平均间隔，s）
        public double DefaultTStep { get; set; }

    }
}