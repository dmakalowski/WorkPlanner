namespace WorkPlanner
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        /// Comment added as a commit test.
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainCalendar = new MonthCalendar();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            LabelIntervalStart = new Label();
            LabelIntervalEnd = new Label();
            buttonAddIntervals = new Button();
            SuspendLayout();
            // 
            // MainCalendar
            // 
            MainCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainCalendar.BackColor = SystemColors.Window;
            MainCalendar.Font = new Font("Segoe UI", 25F);
            MainCalendar.Location = new Point(491, 18);
            MainCalendar.MaxSelectionCount = 1;
            MainCalendar.Name = "MainCalendar";
            MainCalendar.ScrollChange = 1;
            MainCalendar.ShowWeekNumbers = true;
            MainCalendar.TabIndex = 0;
            MainCalendar.DateSelected += MainCalendar_DateSelected;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(491, 207);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(50, 23);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(731, 207);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(51, 23);
            dateTimePicker2.TabIndex = 2;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // LabelIntervalStart
            // 
            LabelIntervalStart.AutoSize = true;
            LabelIntervalStart.Location = new Point(491, 189);
            LabelIntervalStart.Name = "LabelIntervalStart";
            LabelIntervalStart.Size = new Size(73, 15);
            LabelIntervalStart.TabIndex = 3;
            LabelIntervalStart.Text = "Interval Start";
            LabelIntervalStart.Click += label1_Click;
            // 
            // LabelIntervalEnd
            // 
            LabelIntervalEnd.AutoSize = true;
            LabelIntervalEnd.Location = new Point(713, 189);
            LabelIntervalEnd.Name = "LabelIntervalEnd";
            LabelIntervalEnd.Size = new Size(69, 15);
            LabelIntervalEnd.TabIndex = 4;
            LabelIntervalEnd.Text = "Interval End";
            LabelIntervalEnd.Click += label2_Click;
            // 
            // buttonAddIntervals
            // 
            buttonAddIntervals.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonAddIntervals.Location = new Point(547, 207);
            buttonAddIntervals.Name = "buttonAddIntervals";
            buttonAddIntervals.Size = new Size(178, 23);
            buttonAddIntervals.TabIndex = 5;
            buttonAddIntervals.Text = "Add Work Interval";
            buttonAddIntervals.UseVisualStyleBackColor = true;
            buttonAddIntervals.Click += buttonAddIntervals_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAddIntervals);
            Controls.Add(LabelIntervalEnd);
            Controls.Add(LabelIntervalStart);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(MainCalendar);
            Name = "FormMain";
            Text = "WorkPlanner";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar MainCalendar;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label LabelIntervalStart;
        private Label LabelIntervalEnd;
        private Button buttonAddIntervals;
    }
}
