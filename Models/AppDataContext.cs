using System.ComponentModel;

namespace DataAnalyzer_Oceanparadise.Models
{
    /// <summary>
    /// 全局数据上下文（统一管理所有数据，支持UI绑定）
    /// </summary>
    public class AppDataContext : INotifyPropertyChanged
    {


        // 原始P-t数据
        private RawData _rawData = new RawData();
        public RawData RawData
        {
            get => _rawData;
            set { _rawData = value; OnPropertyChanged(); }
        }

        // 时间步长统计
        private TimeStepStats _timeStepStats = new TimeStepStats();
        public TimeStepStats TimeStepStats
        {
            get => _timeStepStats;
            set { _timeStepStats = value; OnPropertyChanged(); }
        }

        // 计算参数
        private CalculationParams _calcParams = new CalculationParams();
        public CalculationParams CalcParams
        {
            get => _calcParams;
            set { _calcParams = value; OnPropertyChanged(); }
        }

        // 计算结果
        private CalculationResults _calcResults = new CalculationResults();
        public CalculationResults CalcResults
        {
            get => _calcResults;
            set { _calcResults = value; OnPropertyChanged(); }
        }

        // 属性变化通知（UI绑定必备）
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}