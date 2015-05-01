namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.angularTrackbar = new System.Windows.Forms.TrackBar();
            this.speedTrackbar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.decreaseAngularButton = new System.Windows.Forms.Button();
            this.increaseAngularButton = new System.Windows.Forms.Button();
            this.increaseSpeedButton = new System.Windows.Forms.Button();
            this.decreaseSpeedButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.enablePID = new System.Windows.Forms.CheckBox();
            this.enableMotors = new System.Windows.Forms.CheckBox();
            this.commSelect = new System.Windows.Forms.ComboBox();
            this.commSelectLabel = new System.Windows.Forms.Label();
            this.openPortButton = new System.Windows.Forms.Button();
            this.linPUpDown = new System.Windows.Forms.NumericUpDown();
            this.communicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linDUpDown = new System.Windows.Forms.NumericUpDown();
            this.linIUpDown = new System.Windows.Forms.NumericUpDown();
            this.angPUpDown = new System.Windows.Forms.NumericUpDown();
            this.angIUpDown = new System.Windows.Forms.NumericUpDown();
            this.angDUpDown = new System.Windows.Forms.NumericUpDown();
            this.LinearLabel = new System.Windows.Forms.Label();
            this.AngularLabel = new System.Windows.Forms.Label();
            this.PLabel = new System.Windows.Forms.Label();
            this.DLabel = new System.Windows.Forms.Label();
            this.ILabel = new System.Windows.Forms.Label();
            this.PIDProgramButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.angularTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linPUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.communicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linDUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linIUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angPUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angIUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angDUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // angularTrackbar
            // 
            this.angularTrackbar.Location = new System.Drawing.Point(141, 242);
            this.angularTrackbar.Maximum = 500;
            this.angularTrackbar.Minimum = -500;
            this.angularTrackbar.Name = "angularTrackbar";
            this.angularTrackbar.Size = new System.Drawing.Size(256, 45);
            this.angularTrackbar.TabIndex = 0;
            this.angularTrackbar.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // speedTrackbar
            // 
            this.speedTrackbar.Location = new System.Drawing.Point(1121, 218);
            this.speedTrackbar.Maximum = 500;
            this.speedTrackbar.Minimum = -500;
            this.speedTrackbar.Name = "speedTrackbar";
            this.speedTrackbar.Size = new System.Drawing.Size(114, 45);
            this.speedTrackbar.TabIndex = 1;
            this.speedTrackbar.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            this.speedTrackbar.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(670, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // decreaseAngularButton
            // 
            this.decreaseAngularButton.Location = new System.Drawing.Point(12, 227);
            this.decreaseAngularButton.Name = "decreaseAngularButton";
            this.decreaseAngularButton.Size = new System.Drawing.Size(123, 60);
            this.decreaseAngularButton.TabIndex = 9;
            this.decreaseAngularButton.Text = "button1";
            this.decreaseAngularButton.UseVisualStyleBackColor = true;
            this.decreaseAngularButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // increaseAngularButton
            // 
            this.increaseAngularButton.Location = new System.Drawing.Point(422, 227);
            this.increaseAngularButton.Name = "increaseAngularButton";
            this.increaseAngularButton.Size = new System.Drawing.Size(124, 60);
            this.increaseAngularButton.TabIndex = 10;
            this.increaseAngularButton.Text = "button2";
            this.increaseAngularButton.UseVisualStyleBackColor = true;
            this.increaseAngularButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // increaseSpeedButton
            // 
            this.increaseSpeedButton.Location = new System.Drawing.Point(1074, 104);
            this.increaseSpeedButton.Name = "increaseSpeedButton";
            this.increaseSpeedButton.Size = new System.Drawing.Size(124, 60);
            this.increaseSpeedButton.TabIndex = 11;
            this.increaseSpeedButton.Text = "button3";
            this.increaseSpeedButton.UseVisualStyleBackColor = true;
            this.increaseSpeedButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // decreaseSpeedButton
            // 
            this.decreaseSpeedButton.Location = new System.Drawing.Point(1074, 548);
            this.decreaseSpeedButton.Name = "decreaseSpeedButton";
            this.decreaseSpeedButton.Size = new System.Drawing.Size(124, 60);
            this.decreaseSpeedButton.TabIndex = 12;
            this.decreaseSpeedButton.Text = "button4";
            this.decreaseSpeedButton.UseVisualStyleBackColor = true;
            this.decreaseSpeedButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(740, 227);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 60);
            this.button5.TabIndex = 13;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // enablePID
            // 
            this.enablePID.AutoSize = true;
            this.enablePID.Location = new System.Drawing.Point(673, 548);
            this.enablePID.Name = "enablePID";
            this.enablePID.Size = new System.Drawing.Size(115, 17);
            this.enablePID.TabIndex = 14;
            this.enablePID.Text = "Enable PID control";
            this.enablePID.UseVisualStyleBackColor = true;
            this.enablePID.CheckedChanged += new System.EventHandler(this.enablePID_CheckedChanged);
            // 
            // enableMotors
            // 
            this.enableMotors.AutoSize = true;
            this.enableMotors.Location = new System.Drawing.Point(549, 548);
            this.enableMotors.Name = "enableMotors";
            this.enableMotors.Size = new System.Drawing.Size(94, 17);
            this.enableMotors.TabIndex = 15;
            this.enableMotors.Text = "Enable Motors";
            this.enableMotors.UseVisualStyleBackColor = true;
            this.enableMotors.CheckedChanged += new System.EventHandler(this.enableMotors_CheckedChanged);
            // 
            // commSelect
            // 
            this.commSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.commSelect.FormattingEnabled = true;
            this.commSelect.Location = new System.Drawing.Point(87, 546);
            this.commSelect.Name = "commSelect";
            this.commSelect.Size = new System.Drawing.Size(121, 21);
            this.commSelect.TabIndex = 16;
            // 
            // commSelectLabel
            // 
            this.commSelectLabel.AutoSize = true;
            this.commSelectLabel.Location = new System.Drawing.Point(84, 521);
            this.commSelectLabel.Name = "commSelectLabel";
            this.commSelectLabel.Size = new System.Drawing.Size(88, 13);
            this.commSelectLabel.TabIndex = 17;
            this.commSelectLabel.Text = "Select Serial Port";
            this.commSelectLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // openPortButton
            // 
            this.openPortButton.Location = new System.Drawing.Point(215, 543);
            this.openPortButton.Name = "openPortButton";
            this.openPortButton.Size = new System.Drawing.Size(75, 23);
            this.openPortButton.TabIndex = 18;
            this.openPortButton.Text = "Open Port";
            this.openPortButton.UseVisualStyleBackColor = true;
            this.openPortButton.Click += new System.EventHandler(this.openPortButton_Click);
            // 
            // linPUpDown
            // 
            this.linPUpDown.DecimalPlaces = 7;
            this.linPUpDown.Location = new System.Drawing.Point(531, 409);
            this.linPUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.linPUpDown.Name = "linPUpDown";
            this.linPUpDown.Size = new System.Drawing.Size(120, 20);
            this.linPUpDown.TabIndex = 19;
            // 
            // communicationBindingSource
            // 
            this.communicationBindingSource.DataSource = typeof(WindowsFormsApplication1.Communication);
            // 
            // linDUpDown
            // 
            this.linDUpDown.DecimalPlaces = 7;
            this.linDUpDown.Location = new System.Drawing.Point(531, 461);
            this.linDUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.linDUpDown.Name = "linDUpDown";
            this.linDUpDown.Size = new System.Drawing.Size(120, 20);
            this.linDUpDown.TabIndex = 20;
            // 
            // linIUpDown
            // 
            this.linIUpDown.DecimalPlaces = 7;
            this.linIUpDown.Location = new System.Drawing.Point(531, 435);
            this.linIUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.linIUpDown.Name = "linIUpDown";
            this.linIUpDown.Size = new System.Drawing.Size(120, 20);
            this.linIUpDown.TabIndex = 21;
            // 
            // angPUpDown
            // 
            this.angPUpDown.DecimalPlaces = 7;
            this.angPUpDown.Location = new System.Drawing.Point(668, 409);
            this.angPUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.angPUpDown.Name = "angPUpDown";
            this.angPUpDown.Size = new System.Drawing.Size(120, 20);
            this.angPUpDown.TabIndex = 22;
            // 
            // angIUpDown
            // 
            this.angIUpDown.DecimalPlaces = 7;
            this.angIUpDown.Location = new System.Drawing.Point(668, 435);
            this.angIUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.angIUpDown.Name = "angIUpDown";
            this.angIUpDown.Size = new System.Drawing.Size(120, 20);
            this.angIUpDown.TabIndex = 23;
            // 
            // angDUpDown
            // 
            this.angDUpDown.DecimalPlaces = 7;
            this.angDUpDown.Location = new System.Drawing.Point(668, 461);
            this.angDUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.angDUpDown.Name = "angDUpDown";
            this.angDUpDown.Size = new System.Drawing.Size(120, 20);
            this.angDUpDown.TabIndex = 24;
            // 
            // LinearLabel
            // 
            this.LinearLabel.AutoSize = true;
            this.LinearLabel.Location = new System.Drawing.Point(569, 393);
            this.LinearLabel.Name = "LinearLabel";
            this.LinearLabel.Size = new System.Drawing.Size(38, 13);
            this.LinearLabel.TabIndex = 25;
            this.LinearLabel.Text = "Speed";
            // 
            // AngularLabel
            // 
            this.AngularLabel.AutoSize = true;
            this.AngularLabel.Location = new System.Drawing.Point(701, 393);
            this.AngularLabel.Name = "AngularLabel";
            this.AngularLabel.Size = new System.Drawing.Size(43, 13);
            this.AngularLabel.TabIndex = 26;
            this.AngularLabel.Text = "Angular";
            // 
            // PLabel
            // 
            this.PLabel.AutoSize = true;
            this.PLabel.Location = new System.Drawing.Point(511, 411);
            this.PLabel.Name = "PLabel";
            this.PLabel.Size = new System.Drawing.Size(14, 13);
            this.PLabel.TabIndex = 27;
            this.PLabel.Text = "P";
            // 
            // DLabel
            // 
            this.DLabel.AutoSize = true;
            this.DLabel.Location = new System.Drawing.Point(511, 463);
            this.DLabel.Name = "DLabel";
            this.DLabel.Size = new System.Drawing.Size(15, 13);
            this.DLabel.TabIndex = 28;
            this.DLabel.Text = "D";
            // 
            // ILabel
            // 
            this.ILabel.AutoSize = true;
            this.ILabel.Location = new System.Drawing.Point(511, 437);
            this.ILabel.Name = "ILabel";
            this.ILabel.Size = new System.Drawing.Size(10, 13);
            this.ILabel.TabIndex = 29;
            this.ILabel.Text = "I";
            // 
            // PIDProgramButton
            // 
            this.PIDProgramButton.Location = new System.Drawing.Point(804, 432);
            this.PIDProgramButton.Name = "PIDProgramButton";
            this.PIDProgramButton.Size = new System.Drawing.Size(75, 23);
            this.PIDProgramButton.TabIndex = 30;
            this.PIDProgramButton.Text = "Program PID";
            this.PIDProgramButton.UseVisualStyleBackColor = true;
            this.PIDProgramButton.Click += new System.EventHandler(this.PIDProgramButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1502, 638);
            this.Controls.Add(this.PIDProgramButton);
            this.Controls.Add(this.ILabel);
            this.Controls.Add(this.DLabel);
            this.Controls.Add(this.PLabel);
            this.Controls.Add(this.AngularLabel);
            this.Controls.Add(this.LinearLabel);
            this.Controls.Add(this.angDUpDown);
            this.Controls.Add(this.angIUpDown);
            this.Controls.Add(this.angPUpDown);
            this.Controls.Add(this.linIUpDown);
            this.Controls.Add(this.linDUpDown);
            this.Controls.Add(this.linPUpDown);
            this.Controls.Add(this.openPortButton);
            this.Controls.Add(this.commSelectLabel);
            this.Controls.Add(this.commSelect);
            this.Controls.Add(this.enableMotors);
            this.Controls.Add(this.enablePID);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.decreaseSpeedButton);
            this.Controls.Add(this.increaseSpeedButton);
            this.Controls.Add(this.increaseAngularButton);
            this.Controls.Add(this.decreaseAngularButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.speedTrackbar);
            this.Controls.Add(this.angularTrackbar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.angularTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linPUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.communicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linDUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linIUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angPUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angIUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angDUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar angularTrackbar;
        private System.Windows.Forms.TrackBar speedTrackbar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button decreaseAngularButton;
        private System.Windows.Forms.Button increaseAngularButton;
        private System.Windows.Forms.Button increaseSpeedButton;
        private System.Windows.Forms.Button decreaseSpeedButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox enablePID;
        private System.Windows.Forms.CheckBox enableMotors;
        private System.Windows.Forms.ComboBox commSelect;
        private System.Windows.Forms.BindingSource communicationBindingSource;
        private System.Windows.Forms.Label commSelectLabel;
        private System.Windows.Forms.Button openPortButton;
        private System.Windows.Forms.NumericUpDown linPUpDown;
        private System.Windows.Forms.NumericUpDown linDUpDown;
        private System.Windows.Forms.NumericUpDown linIUpDown;
        private System.Windows.Forms.NumericUpDown angPUpDown;
        private System.Windows.Forms.NumericUpDown angIUpDown;
        private System.Windows.Forms.NumericUpDown angDUpDown;
        private System.Windows.Forms.Label LinearLabel;
        private System.Windows.Forms.Label AngularLabel;
        private System.Windows.Forms.Label PLabel;
        private System.Windows.Forms.Label DLabel;
        private System.Windows.Forms.Label ILabel;
        private System.Windows.Forms.Button PIDProgramButton;
    }
}

