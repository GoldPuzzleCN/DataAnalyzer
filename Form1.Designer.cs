namespace DataAnalyzer_Oceanparadise
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPageRawData = new TabPage();
            splitContainerRaw = new SplitContainer();
            plotViewRaw = new OxyPlot.WindowsForms.PlotView();
            dgvRawData = new DataGridView();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblTimeStepInfo = new Label();
            label3 = new Label();
            tabPageResults = new TabPage();
            splitContainerResults = new SplitContainer();
            plotViewResults = new OxyPlot.WindowsForms.PlotView();
            dgvResults = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCalculate = new Button();
            lblInitialArea = new Label();
            tabPage1 = new TabPage();
            splitResults = new SplitContainer();
            chartRP = new OxyPlot.WindowsForms.PlotView();
            btnImport = new Button();
            lblTimeRange = new Label();
            lblDataCount = new Label();
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            txtRho = new TextBox();
            lblRho = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            lblCPrime = new Label();
            txtCPrime = new TextBox();
            lblAt = new Label();
            lblD = new Label();
            lblH = new Label();
            txtAt = new TextBox();
            txtD = new TextBox();
            txtH = new TextBox();
            txtT = new TextBox();
            lblT = new Label();
            tabControl1.SuspendLayout();
            tabPageRawData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerRaw).BeginInit();
            splitContainerRaw.Panel1.SuspendLayout();
            splitContainerRaw.Panel2.SuspendLayout();
            splitContainerRaw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRawData).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            tabPageResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerResults).BeginInit();
            splitContainerResults.Panel1.SuspendLayout();
            splitContainerResults.Panel2.SuspendLayout();
            splitContainerResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitResults).BeginInit();
            splitResults.Panel1.SuspendLayout();
            splitResults.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageRawData);
            tabControl1.Controls.Add(tabPageResults);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(0, 3);
            tabControl1.Margin = new Padding(0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(0, 0);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1315, 785);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 3;
            // 
            // tabPageRawData
            // 
            tabPageRawData.Controls.Add(splitContainerRaw);
            tabPageRawData.Controls.Add(flowLayoutPanel2);
            tabPageRawData.Controls.Add(label3);
            tabPageRawData.Cursor = Cursors.IBeam;
            tabPageRawData.Location = new Point(4, 33);
            tabPageRawData.Margin = new Padding(4);
            tabPageRawData.Name = "tabPageRawData";
            tabPageRawData.Padding = new Padding(4);
            tabPageRawData.Size = new Size(1307, 748);
            tabPageRawData.TabIndex = 0;
            tabPageRawData.Text = "原始 P-t 数据";
            tabPageRawData.UseVisualStyleBackColor = true;
            // 
            // splitContainerRaw
            // 
            splitContainerRaw.Dock = DockStyle.Fill;
            splitContainerRaw.Location = new Point(4, 4);
            splitContainerRaw.Name = "splitContainerRaw";
            splitContainerRaw.Orientation = Orientation.Horizontal;
            // 
            // splitContainerRaw.Panel1
            // 
            splitContainerRaw.Panel1.Controls.Add(plotViewRaw);
            // 
            // splitContainerRaw.Panel2
            // 
            splitContainerRaw.Panel2.Controls.Add(dgvRawData);
            splitContainerRaw.Size = new Size(1299, 716);
            splitContainerRaw.SplitterDistance = 348;
            splitContainerRaw.TabIndex = 4;
            // 
            // plotViewRaw
            // 
            plotViewRaw.Dock = DockStyle.Fill;
            plotViewRaw.Location = new Point(0, 0);
            plotViewRaw.Name = "plotViewRaw";
            plotViewRaw.PanCursor = Cursors.Hand;
            plotViewRaw.Size = new Size(1299, 348);
            plotViewRaw.TabIndex = 0;
            plotViewRaw.Text = "plotView1";
            plotViewRaw.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewRaw.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewRaw.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // dgvRawData
            // 
            dgvRawData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRawData.Dock = DockStyle.Fill;
            dgvRawData.Location = new Point(0, 0);
            dgvRawData.Margin = new Padding(4);
            dgvRawData.Name = "dgvRawData";
            dgvRawData.RowHeadersWidth = 62;
            dgvRawData.RowTemplate.Height = 30;
            dgvRawData.Size = new Size(1299, 364);
            dgvRawData.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(lblTimeStepInfo);
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.Location = new Point(4, 720);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1299, 24);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // lblTimeStepInfo
            // 
            lblTimeStepInfo.AutoSize = true;
            lblTimeStepInfo.Location = new Point(4, 0);
            lblTimeStepInfo.Margin = new Padding(4, 0, 4, 0);
            lblTimeStepInfo.Name = "lblTimeStepInfo";
            lblTimeStepInfo.Size = new Size(118, 24);
            lblTimeStepInfo.TabIndex = 2;
            lblTimeStepInfo.Text = "等待数据导入";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 4);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 24);
            label3.TabIndex = 0;
            // 
            // tabPageResults
            // 
            tabPageResults.BackgroundImageLayout = ImageLayout.Center;
            tabPageResults.Controls.Add(splitContainerResults);
            tabPageResults.Controls.Add(flowLayoutPanel1);
            tabPageResults.Location = new Point(4, 33);
            tabPageResults.Name = "tabPageResults";
            tabPageResults.Size = new Size(1307, 748);
            tabPageResults.TabIndex = 1;
            tabPageResults.Text = "计算结果";
            tabPageResults.UseVisualStyleBackColor = true;
            // 
            // splitContainerResults
            // 
            splitContainerResults.Dock = DockStyle.Fill;
            splitContainerResults.Location = new Point(0, 40);
            splitContainerResults.Name = "splitContainerResults";
            splitContainerResults.Orientation = Orientation.Horizontal;
            // 
            // splitContainerResults.Panel1
            // 
            splitContainerResults.Panel1.Controls.Add(plotViewResults);
            // 
            // splitContainerResults.Panel2
            // 
            splitContainerResults.Panel2.Controls.Add(dgvResults);
            splitContainerResults.Size = new Size(1307, 708);
            splitContainerResults.SplitterDistance = 348;
            splitContainerResults.TabIndex = 4;
            // 
            // plotViewResults
            // 
            plotViewResults.Dock = DockStyle.Fill;
            plotViewResults.Location = new Point(0, 0);
            plotViewResults.Name = "plotViewResults";
            plotViewResults.PanCursor = Cursors.Hand;
            plotViewResults.Size = new Size(1307, 348);
            plotViewResults.TabIndex = 0;
            plotViewResults.Text = "plotView1";
            plotViewResults.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewResults.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewResults.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // dgvResults
            // 
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Dock = DockStyle.Fill;
            dgvResults.Location = new Point(0, 0);
            dgvResults.Name = "dgvResults";
            dgvResults.RowHeadersWidth = 62;
            dgvResults.Size = new Size(1307, 356);
            dgvResults.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnCalculate);
            flowLayoutPanel1.Controls.Add(lblInitialArea);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1307, 40);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Anchor = AnchorStyles.None;
            btnCalculate.Location = new Point(3, 3);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "计算燃速";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click_1;
            // 
            // lblInitialArea
            // 
            lblInitialArea.Anchor = AnchorStyles.None;
            lblInitialArea.AutoSize = true;
            lblInitialArea.Location = new Point(121, 8);
            lblInitialArea.Name = "lblInitialArea";
            lblInitialArea.Size = new Size(136, 24);
            lblInitialArea.TabIndex = 1;
            lblInitialArea.Text = "初始燃面面积：";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitResults);
            tabPage1.Location = new Point(4, 33);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1307, 748);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "r-P曲线";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitResults
            // 
            splitResults.Dock = DockStyle.Fill;
            splitResults.Location = new Point(3, 3);
            splitResults.Name = "splitResults";
            splitResults.Orientation = Orientation.Horizontal;
            // 
            // splitResults.Panel1
            // 
            splitResults.Panel1.Controls.Add(chartRP);
            splitResults.Size = new Size(1301, 742);
            splitResults.SplitterDistance = 348;
            splitResults.TabIndex = 0;
            // 
            // chartRP
            // 
            chartRP.Dock = DockStyle.Fill;
            chartRP.Location = new Point(0, 0);
            chartRP.Name = "chartRP";
            chartRP.PanCursor = Cursors.Hand;
            chartRP.Size = new Size(1301, 348);
            chartRP.TabIndex = 0;
            chartRP.Text = "plotView1";
            chartRP.ZoomHorizontalCursor = Cursors.SizeWE;
            chartRP.ZoomRectangleCursor = Cursors.SizeNWSE;
            chartRP.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(0, 3);
            btnImport.Margin = new Padding(4);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(166, 35);
            btnImport.TabIndex = 0;
            btnImport.Text = "导入 P-t 数据";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // lblTimeRange
            // 
            lblTimeRange.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTimeRange.AutoSize = true;
            lblTimeRange.Location = new Point(429, 11);
            lblTimeRange.Margin = new Padding(0);
            lblTimeRange.Name = "lblTimeRange";
            lblTimeRange.Size = new Size(190, 24);
            lblTimeRange.TabIndex = 2;
            lblTimeRange.Text = "时间范围：未导入数据";
            // 
            // lblDataCount
            // 
            lblDataCount.AutoSize = true;
            lblDataCount.Location = new Point(174, 9);
            lblDataCount.Margin = new Padding(4, 0, 4, 0);
            lblDataCount.Name = "lblDataCount";
            lblDataCount.Size = new Size(100, 24);
            lblDataCount.TabIndex = 1;
            lblDataCount.Text = "数据条数：";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(btnImport);
            panel1.Controls.Add(lblTimeRange);
            panel1.Controls.Add(lblDataCount);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1619, 42);
            panel1.TabIndex = 5;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 42);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lblT);
            splitContainer1.Panel1.Controls.Add(txtT);
            splitContainer1.Panel1.Controls.Add(txtH);
            splitContainer1.Panel1.Controls.Add(txtD);
            splitContainer1.Panel1.Controls.Add(txtAt);
            splitContainer1.Panel1.Controls.Add(lblH);
            splitContainer1.Panel1.Controls.Add(lblD);
            splitContainer1.Panel1.Controls.Add(lblAt);
            splitContainer1.Panel1.Controls.Add(txtCPrime);
            splitContainer1.Panel1.Controls.Add(lblCPrime);
            splitContainer1.Panel1.Controls.Add(txtRho);
            splitContainer1.Panel1.Controls.Add(lblRho);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(textBox2);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(textBox3);
            splitContainer1.Panel1.Controls.Add(label4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Size = new Size(1619, 788);
            splitContainer1.SplitterDistance = 300;
            splitContainer1.TabIndex = 6;
            // 
            // txtRho
            // 
            txtRho.Location = new Point(12, 67);
            txtRho.Name = "txtRho";
            txtRho.Size = new Size(274, 30);
            txtRho.TabIndex = 6;
            // 
            // lblRho
            // 
            lblRho.AutoSize = true;
            lblRho.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblRho.Location = new Point(12, 36);
            lblRho.Name = "lblRho";
            lblRho.Size = new Size(195, 28);
            lblRho.TabIndex = 0;
            lblRho.Text = "燃料密度ρ (kg/m³):";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 30);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(195, 28);
            label1.TabIndex = 0;
            label1.Text = "燃料密度ρ (kg/m³):";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 30);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(195, 28);
            label2.TabIndex = 0;
            label2.Text = "燃料密度ρ (kg/m³):";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 67);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(223, 30);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(12, 36);
            label4.Name = "label4";
            label4.Size = new Size(195, 28);
            label4.TabIndex = 0;
            label4.Text = "燃料密度ρ (kg/m³):";
            // 
            // lblCPrime
            // 
            lblCPrime.AutoSize = true;
            lblCPrime.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblCPrime.Location = new Point(12, 100);
            lblCPrime.Name = "lblCPrime";
            lblCPrime.Size = new Size(180, 28);
            lblCPrime.TabIndex = 7;
            lblCPrime.Text = "特征速度C (m/s):`";
            // 
            // txtCPrime
            // 
            txtCPrime.Location = new Point(12, 131);
            txtCPrime.Name = "txtCPrime";
            txtCPrime.Size = new Size(274, 30);
            txtCPrime.TabIndex = 8;
            // 
            // lblAt
            // 
            lblAt.AutoSize = true;
            lblAt.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblAt.Location = new Point(12, 164);
            lblAt.Name = "lblAt";
            lblAt.Size = new Size(172, 28);
            lblAt.TabIndex = 9;
            lblAt.Text = "喷喉面积At (m²):";
            // 
            // lblD
            // 
            lblD.AutoSize = true;
            lblD.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblD.Location = new Point(12, 228);
            lblD.Name = "lblD";
            lblD.Size = new Size(199, 28);
            lblD.TabIndex = 10;
            lblD.Text = "初始内孔直径D (m):\t";
            // 
            // lblH
            // 
            lblH.AutoSize = true;
            lblH.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblH.Location = new Point(12, 292);
            lblH.Name = "lblH";
            lblH.Size = new Size(154, 28);
            lblH.TabIndex = 11;
            lblH.Text = "药柱长度h (m):\t";
            // 
            // txtAt
            // 
            txtAt.Location = new Point(12, 195);
            txtAt.Name = "txtAt";
            txtAt.Size = new Size(274, 30);
            txtAt.TabIndex = 12;
            // 
            // txtD
            // 
            txtD.Location = new Point(12, 259);
            txtD.Name = "txtD";
            txtD.Size = new Size(274, 30);
            txtD.TabIndex = 13;
            // 
            // txtH
            // 
            txtH.Location = new Point(12, 323);
            txtH.Name = "txtH";
            txtH.Size = new Size(274, 30);
            txtH.TabIndex = 14;
            // 
            // txtT
            // 
            txtT.Location = new Point(12, 387);
            txtT.Name = "txtT";
            txtT.Size = new Size(274, 30);
            txtT.TabIndex = 15;
            txtT.Text = "自动识别";
            // 
            // lblT
            // 
            lblT.AutoSize = true;
            lblT.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblT.Location = new Point(13, 356);
            lblT.Name = "lblT";
            lblT.Size = new Size(143, 28);
            lblT.TabIndex = 16;
            lblT.Text = "时间步长T (s):\t";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1619, 830);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPageRawData.ResumeLayout(false);
            tabPageRawData.PerformLayout();
            splitContainerRaw.Panel1.ResumeLayout(false);
            splitContainerRaw.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerRaw).EndInit();
            splitContainerRaw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRawData).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            tabPageResults.ResumeLayout(false);
            splitContainerResults.Panel1.ResumeLayout(false);
            splitContainerResults.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerResults).EndInit();
            splitContainerResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tabPage1.ResumeLayout(false);
            splitResults.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitResults).EndInit();
            splitResults.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRawData;
        private System.Windows.Forms.Label lblTimeStepInfo;
        private System.Windows.Forms.Label label3;
        private TabPage tabPageResults;
        private Label lblInitialArea;
        private Button btnCalculate;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnImport;
        private Label lblTimeRange;
        private Label lblDataCount;
        private Panel panel1;
        private SplitContainer splitContainerRaw;
        private DataGridView dgvRawData;
        private OxyPlot.WindowsForms.PlotView plotViewRaw;
        private SplitContainer splitContainerResults;
        private DataGridView dgvResults;
        private OxyPlot.WindowsForms.PlotView plotViewResults;
        private TabPage tabPage1;
        private SplitContainer splitResults;
        private OxyPlot.WindowsForms.PlotView chartRP;
        private SplitContainer splitContainer1;
        private TextBox txtRho;
        private Label lblRho;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label4;
        private Label lblT;
        private TextBox txtT;
        private TextBox txtH;
        private TextBox txtD;
        private TextBox txtAt;
        private Label lblH;
        private Label lblD;
        private Label lblAt;
        private TextBox txtCPrime;
        private Label lblCPrime;
    }
}