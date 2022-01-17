namespace MediaBazaarProjectKSAsolutions
{
    partial class RadForm1
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
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint1 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint2 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint3 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint4 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint5 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.WinControls.UI.LineSeries lineSeries2 = new Telerik.WinControls.UI.LineSeries();
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
            this.radChartView1.BackColor = System.Drawing.Color.Yellow;
            this.radChartView1.Location = new System.Drawing.Point(22, 36);
            this.radChartView1.Name = "radChartView1";
            categoricalDataPoint1.Category = "A";
            categoricalDataPoint1.Label = 60D;
            categoricalDataPoint1.Value = 60D;
            categoricalDataPoint2.Category = "B";
            categoricalDataPoint2.Label = 14D;
            categoricalDataPoint2.Value = 14D;
            categoricalDataPoint3.Category = "C";
            categoricalDataPoint3.Label = 54D;
            categoricalDataPoint3.Value = 54D;
            categoricalDataPoint4.Category = "D";
            categoricalDataPoint4.Label = 52D;
            categoricalDataPoint4.Value = 52D;
            categoricalDataPoint5.Category = "E";
            categoricalDataPoint5.Label = 90D;
            categoricalDataPoint5.Value = 90D;
            lineSeries1.DataPoints.AddRange(new Telerik.Charting.DataPoint[] {
            categoricalDataPoint1,
            categoricalDataPoint2,
            categoricalDataPoint3,
            categoricalDataPoint4,
            categoricalDataPoint5});
            lineSeries1.HorizontalAxis = categoricalAxis1;
            lineSeries1.LabelAngle = 90D;
            lineSeries1.LabelDistanceToPoint = 15D;
            lineSeries1.Spline = true;
            lineSeries1.VerticalAxis = linearAxis1;
            categoricalDataPoint6.Category = "A";
            categoricalDataPoint6.Label = 67D;
            categoricalDataPoint6.Value = 67D;
            categoricalDataPoint7.Category = "B";
            categoricalDataPoint7.Label = 63D;
            categoricalDataPoint7.Value = 63D;
            categoricalDataPoint8.Category = "C";
            categoricalDataPoint8.Label = 66D;
            categoricalDataPoint8.Value = 66D;
            categoricalDataPoint9.Category = "D";
            categoricalDataPoint9.Label = 46D;
            categoricalDataPoint9.Value = 46D;
            categoricalDataPoint10.Category = "E";
            categoricalDataPoint10.Label = 90D;
            categoricalDataPoint10.Value = 90D;
            lineSeries2.DataPoints.AddRange(new Telerik.Charting.DataPoint[] {
            categoricalDataPoint6,
            categoricalDataPoint7,
            categoricalDataPoint8,
            categoricalDataPoint9,
            categoricalDataPoint10});
            lineSeries2.HorizontalAxis = categoricalAxis1;
            lineSeries2.LabelAngle = 90D;
            lineSeries2.LabelDistanceToPoint = 15D;
            lineSeries2.LegendTitle = null;
            lineSeries2.Spline = true;
            lineSeries2.VerticalAxis = linearAxis1;
            this.radChartView1.Series.AddRange(new Telerik.WinControls.UI.ChartSeries[] {
            lineSeries1,
            lineSeries2});
            this.radChartView1.ShowGrid = false;
            this.radChartView1.Size = new System.Drawing.Size(480, 320);
            this.radChartView1.TabIndex = 0;
            // 
            // RadForm1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 645);
            this.Controls.Add(this.radChartView1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChartView radChartView1;
    }
}
