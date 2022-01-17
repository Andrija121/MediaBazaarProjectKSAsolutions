namespace MediaBazaarProjectKSAsolutions.Forms
{
    partial class RadFormStatistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CategoricalAxis categoricalAxis1 = new Telerik.WinControls.UI.CategoricalAxis();
            Telerik.WinControls.UI.LinearAxis linearAxis1 = new Telerik.WinControls.UI.LinearAxis();
            Telerik.WinControls.UI.LineSeries lineSeries1 = new Telerik.WinControls.UI.LineSeries();
            Telerik.WinControls.UI.LineSeries lineSeries2 = new Telerik.WinControls.UI.LineSeries();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint1 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint2 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint3 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint4 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint5 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.WinControls.UI.SteplineSeries steplineSeries1 = new Telerik.WinControls.UI.SteplineSeries();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint6 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint7 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint8 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint9 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint10 = new Telerik.Charting.CategoricalDataPoint();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radChartView1
            // 
            this.radChartView1.AreaDesign = cartesianArea1;
            categoricalAxis1.IsPrimary = true;
            categoricalAxis1.LabelRotationAngle = 300D;
            categoricalAxis1.Title = "";
            linearAxis1.AxisType = Telerik.Charting.AxisType.Second;
            linearAxis1.IsPrimary = true;
            linearAxis1.LabelRotationAngle = 300D;
            linearAxis1.MajorStep = 10D;
            linearAxis1.TickOrigin = null;
            linearAxis1.Title = "";
            this.radChartView1.Axes.AddRange(new Telerik.WinControls.UI.Axis[] {
            categoricalAxis1,
            linearAxis1});
            this.radChartView1.Location = new System.Drawing.Point(112, 125);
            this.radChartView1.Name = "radChartView1";
            lineSeries1.HorizontalAxis = categoricalAxis1;
            lineSeries1.LabelAngle = 90D;
            lineSeries1.LabelDistanceToPoint = 15D;
            lineSeries1.LegendTitle = "Males";
            lineSeries1.Spline = true;
            lineSeries1.ValueMember = "";
            lineSeries1.VerticalAxis = linearAxis1;
            categoricalDataPoint1.Category = "A";
            categoricalDataPoint1.Label = 40D;
            categoricalDataPoint1.Value = 40D;
            categoricalDataPoint2.Category = "B";
            categoricalDataPoint2.Label = 39D;
            categoricalDataPoint2.Value = 39D;
            categoricalDataPoint3.Category = "C";
            categoricalDataPoint3.Label = 50D;
            categoricalDataPoint3.Value = 50D;
            categoricalDataPoint4.Category = "D";
            categoricalDataPoint4.Label = 90D;
            categoricalDataPoint4.Value = 90D;
            categoricalDataPoint5.Category = "E";
            categoricalDataPoint5.Label = 64D;
            categoricalDataPoint5.Value = 64D;
            lineSeries2.DataPoints.AddRange(new Telerik.Charting.DataPoint[] {
            categoricalDataPoint1,
            categoricalDataPoint2,
            categoricalDataPoint3,
            categoricalDataPoint4,
            categoricalDataPoint5});
            lineSeries2.HorizontalAxis = categoricalAxis1;
            lineSeries2.LabelAngle = 90D;
            lineSeries2.LabelDistanceToPoint = 15D;
            lineSeries2.LegendTitle = "Females";
            lineSeries2.Spline = true;
            lineSeries2.VerticalAxis = linearAxis1;
            categoricalDataPoint6.Category = "A";
            categoricalDataPoint6.Label = 10D;
            categoricalDataPoint6.Value = 10D;
            categoricalDataPoint7.Category = "B";
            categoricalDataPoint7.Label = 20D;
            categoricalDataPoint7.Value = 20D;
            categoricalDataPoint8.Category = "D";
            categoricalDataPoint8.Label = 30D;
            categoricalDataPoint8.Value = 30D;
            categoricalDataPoint9.Category = "C";
            categoricalDataPoint9.Label = 40D;
            categoricalDataPoint9.Value = 40D;
            categoricalDataPoint10.Category = "E";
            categoricalDataPoint10.Label = 50D;
            categoricalDataPoint10.Value = 50D;
            steplineSeries1.DataPoints.AddRange(new Telerik.Charting.DataPoint[] {
            categoricalDataPoint6,
            categoricalDataPoint7,
            categoricalDataPoint8,
            categoricalDataPoint9,
            categoricalDataPoint10});
            steplineSeries1.HorizontalAxis = categoricalAxis1;
            steplineSeries1.LabelAngle = 90D;
            steplineSeries1.LabelDistanceToPoint = 15D;
            steplineSeries1.LegendTitle = "Others";
            steplineSeries1.VerticalAxis = linearAxis1;
            this.radChartView1.Series.AddRange(new Telerik.WinControls.UI.ChartSeries[] {
            lineSeries1,
            lineSeries2,
            steplineSeries1});
            this.radChartView1.ShowGrid = false;
            this.radChartView1.ShowLegend = true;
            this.radChartView1.ShowTitle = true;
            this.radChartView1.Size = new System.Drawing.Size(480, 320);
            this.radChartView1.TabIndex = 0;
            // 
            // RadFormStatistics
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 519);
            this.Controls.Add(this.radChartView1);
            this.Name = "RadFormStatistics";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RadFormStatistics";
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChartView radChartView1;
    }
}
