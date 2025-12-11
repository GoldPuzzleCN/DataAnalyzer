using System.Collections.Generic;
using System.Windows.Forms;
using DataAnalyzer_Oceanparadise.Models;
using DataAnalyzer_Oceanparadise.Services;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;


namespace DataAnalyzer_Oceanparadise
{

    public partial class Form1 : Form
    {// 暴露txtT控件给ImportService


        // 全局数据和服务
        private readonly AppDataContext _appDataContext;
        private readonly FileImportService _importService;
        private readonly BurningRateCalculationService _calculationService;

        public Form1()
        {



            InitializeComponent();
            // 初始化数据和服务
            _appDataContext = new AppDataContext();
            _importService = new FileImportService(_appDataContext);
            _calculationService = new BurningRateCalculationService(_appDataContext);

            // 初始化表格
            InitRawDataGridView();
            InitResultsGridView();
        }
        // 在 Form1.cs 中
        public TextBox TxtT => txtT; // 提供属性暴露 txtT，代替静态字段
        /// <summary>
        /// 初始化原始数据表格（现有控件）
        /// </summary>
        private void InitRawDataGridView()
        {
            dgvRawData.Columns.Add("TimeColumn", "时间t(s)");
            dgvRawData.Columns.Add("PressureColumn", "压强P(Pa)");
            dgvRawData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// 初始化计算结果表格（新增控件）
        /// </summary>
        private void InitResultsGridView()
        {
            dgvResults.Columns.Add("TimeColumn", "时间t(s)");
            dgvResults.Columns.Add("PressureColumn", "压强P(Pa)");
            dgvResults.Columns.Add("BurningRateColumn", "燃速r(m/s)");
            dgvResults.Columns.Add("DiameterColumn", "内孔直径(m)");
            dgvResults.Columns.Add("AreaColumn", "燃面面积(m²)");
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// 导入按钮点击事件（现有控件）
        /// </summary>
        private void btnImport_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "P-t数据文件|*.csv;*.txt|所有文件|*.*";
                openFileDialog.Title = "选择P-t数据文件";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bool success = _importService.ImportPtData(openFileDialog.FileName);
                    if (success)
                    {
                        UpdateRawDataUI();
                        // 导入成功后启用计算按钮
                        btnCalculate.Enabled = true;
                    }
                }
            }
        }

        /// <summary>
        /// 更新原始数据UI（现有控件）
        /// </summary>
        private void UpdateRawDataUI()
        {
            lblDataCount.Text = $"数据条数：{_appDataContext.RawData.DataCount}";
            lblTimeRange.Text = $"时间范围：{_appDataContext.RawData.TimeRange}";

            var timeStats = _appDataContext.TimeStepStats;
            lblTimeStepInfo.Text = $"时间步长T：{timeStats.DefaultTStep:F6} s | " +
                                 $"最小间隔：{timeStats.MinInterval:F6} s | " +
                                 $"最大间隔：{timeStats.MaxInterval:F6} s";
            DrawRawDataChart(); // 新增：绘制原始数据折线图
            dgvRawData.Rows.Clear();
            // 取消20条限制，显示所有数据
            for (int i = 0; i < _appDataContext.RawData.DataCount; i++)
            {
                dgvRawData.Rows.Add(
                    _appDataContext.RawData.TimePoints[i].ToString("F6"),
                    _appDataContext.RawData.PressurePoints[i].ToString("F0")
                );
            }
        }

        /// <summary>
        /// 计算按钮点击事件（新增控件）
        /// </summary>
        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            // 切换到结果标签页
            tabControl1.SelectedTab = tabPageResults;

            // 执行计算
            bool success = _calculationService.CalculateBurningRates();
            if (success)
            {
                UpdateResultsUI();
            }
            // 新增：自动绘制r-P曲线
            DrawRPCurve();
        }

        /// <summary>
        /// 更新计算结果UI（新增控件）
        /// </summary>
        private void UpdateResultsUI()
        {
            // 显示初始燃面面积
            lblInitialArea.Text = $"初始燃面面积：{_appDataContext.CalcResults.InitialBurningArea:F6} m²";
            DrawResultsChart();
            // 显示计算结果表格
            dgvResults.Rows.Clear();
            for (int i = 0; i < _appDataContext.CalcResults.StepResults.Count; i++)
            {
                var result = _appDataContext.CalcResults.StepResults[i];
                dgvResults.Rows.Add(
                    result.Time.ToString("F6"),
                    result.Pressure.ToString("F0"),
                    result.BurningRate.ToString("E6"),
                    result.CurrentDiameter.ToString("F6"),
                    result.BurningArea.ToString("F6")
                );
            }

        }
        // 绘制原始数据折线图
        private void DrawRawDataChart()
        {
            // 创建图表模型
            var plotModel = new PlotModel { Title = "压强-时间曲线" };

            // 添加折线系列（X轴：时间，Y轴：压强）
            var series = new LineSeries { Title = "压强(Pa)", MarkerType = MarkerType.None };
            for (int i = 0; i < _appDataContext.RawData.DataCount; i++)
            {
                series.Points.Add(new DataPoint(
                    _appDataContext.RawData.TimePoints[i],
                    _appDataContext.RawData.PressurePoints[i]
                ));
            }
            plotModel.Series.Add(series);

            // 设置X轴和Y轴标签
            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Title = "时间 t(s)" });
            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Title = "压强 P(Pa)" });

            // 绑定到控件
            plotViewRaw.Model = plotModel;
        }


        // 绘制计算结果折线图
        private void DrawResultsChart()
        {
            var plotModel = new PlotModel { Title = "燃速-时间曲线" };

            var series = new LineSeries { Title = "燃速(m/s)", MarkerType = MarkerType.None, Color = OxyColors.Red };
            for (int i = 0; i < _appDataContext.CalcResults.StepResults.Count; i++)
            {
                var result = _appDataContext.CalcResults.StepResults[i];
                series.Points.Add(new DataPoint(result.Time, result.BurningRate));
            }
            plotModel.Series.Add(series);

            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Title = "时间 t(s)" });
            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Title = "燃速 r(m/s)" });

            plotViewResults.Model = plotModel;
        }

        /// <summary>
        /// 绘制r-P曲线（燃速-压强）
        /// </summary>
        private void DrawRPCurve()
        {
            // 1. 检查是否有计算结果（避免空数据报错）
            if (_appDataContext?.CalcResults?.StepResults == null ||
                _appDataContext.CalcResults.StepResults.Count == 0)
            {
                // 无数据时显示提示
                chartRP.Model = new PlotModel { Title = "请先完成计算，再查看r-P曲线" };
                return;
            }

            // 2. 创建图表模型
            var plotModel = new PlotModel { Title = "燃速-压强（r-P）曲线" };

            // 3. 准备r-P数据系列
            var series = new LineSeries
            {
                Title = "r-P关系",
                MarkerType = MarkerType.Circle, // 显示数据点（方便观察离散点）
                MarkerSize = 4,
                MarkerFill = OxyColors.Blue,
                Color = OxyColors.DarkBlue, // 曲线颜色
                StrokeThickness = 2
            };

            // 4. 绑定数据（横轴=压强P，纵轴=燃速r）
            foreach (var step in _appDataContext.CalcResults.StepResults)
            {
                // 过滤无效数据（P或r为0/负数时不显示）
                if (step.Pressure > 0 && step.BurningRate > 0)
                {
                    series.Points.Add(new DataPoint(step.Pressure, step.BurningRate));
                }
            }
            plotModel.Series.Add(series);

            // 5. 设置坐标轴
            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "压强 P(Pa)",
                TitleFontSize = 12
            });
            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "燃速 r(m/s)",
                TitleFontSize = 12,
                AbsoluteMinimum = 0 // 燃速不能为负
            });

            // 6. 显示曲线（绑定到专用控件chartRP）
            chartRP.Model = plotModel;
        }

    }
}