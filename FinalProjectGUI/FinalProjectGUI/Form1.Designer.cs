namespace FinalProjectGUI
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
            this.tempLabel = new System.Windows.Forms.Label();
            this.lightLabel = new System.Windows.Forms.Label();
            this.rhLabel = new System.Windows.Forms.Label();
            this.weatherTypeLabel = new System.Windows.Forms.Label();
            this.lightTextbox = new System.Windows.Forms.TextBox();
            this.tempTextbox = new System.Windows.Forms.TextBox();
            this.rhTextbox = new System.Windows.Forms.TextBox();
            this.weatherTypeTextbox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialButton = new System.Windows.Forms.Button();
            this.autoButton = new System.Windows.Forms.Button();
            this.sunnyButton = new System.Windows.Forms.Button();
            this.cloudyButton = new System.Windows.Forms.Button();
            this.rainyButton = new System.Windows.Forms.Button();
            this.snowyButton = new System.Windows.Forms.Button();
            this.stormyButton = new System.Windows.Forms.Button();
            this.modeLabel = new System.Windows.Forms.Label();
            this.modeTextbox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flagLabel = new System.Windows.Forms.Label();
            this.flagTextbox = new System.Windows.Forms.TextBox();
            this.timerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Location = new System.Drawing.Point(379, 43);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(67, 13);
            this.tempLabel.TabIndex = 0;
            this.tempLabel.Text = "Temperature";
            // 
            // lightLabel
            // 
            this.lightLabel.AutoSize = true;
            this.lightLabel.Location = new System.Drawing.Point(379, 9);
            this.lightLabel.Name = "lightLabel";
            this.lightLabel.Size = new System.Drawing.Size(30, 13);
            this.lightLabel.TabIndex = 1;
            this.lightLabel.Text = "Light";
            // 
            // rhLabel
            // 
            this.rhLabel.AutoSize = true;
            this.rhLabel.Location = new System.Drawing.Point(379, 80);
            this.rhLabel.Name = "rhLabel";
            this.rhLabel.Size = new System.Drawing.Size(23, 13);
            this.rhLabel.TabIndex = 2;
            this.rhLabel.Text = "RH";
            // 
            // weatherTypeLabel
            // 
            this.weatherTypeLabel.AutoSize = true;
            this.weatherTypeLabel.Location = new System.Drawing.Point(379, 114);
            this.weatherTypeLabel.Name = "weatherTypeLabel";
            this.weatherTypeLabel.Size = new System.Drawing.Size(75, 13);
            this.weatherTypeLabel.TabIndex = 3;
            this.weatherTypeLabel.Text = "Weather Type";
            // 
            // lightTextbox
            // 
            this.lightTextbox.Location = new System.Drawing.Point(471, 9);
            this.lightTextbox.Name = "lightTextbox";
            this.lightTextbox.Size = new System.Drawing.Size(100, 20);
            this.lightTextbox.TabIndex = 4;
            // 
            // tempTextbox
            // 
            this.tempTextbox.Location = new System.Drawing.Point(471, 43);
            this.tempTextbox.Name = "tempTextbox";
            this.tempTextbox.Size = new System.Drawing.Size(100, 20);
            this.tempTextbox.TabIndex = 5;
            // 
            // rhTextbox
            // 
            this.rhTextbox.Location = new System.Drawing.Point(471, 80);
            this.rhTextbox.Name = "rhTextbox";
            this.rhTextbox.Size = new System.Drawing.Size(100, 20);
            this.rhTextbox.TabIndex = 6;
            // 
            // weatherTypeTextbox
            // 
            this.weatherTypeTextbox.Location = new System.Drawing.Point(471, 114);
            this.weatherTypeTextbox.Name = "weatherTypeTextbox";
            this.weatherTypeTextbox.Size = new System.Drawing.Size(100, 20);
            this.weatherTypeTextbox.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // serialButton
            // 
            this.serialButton.Location = new System.Drawing.Point(139, 12);
            this.serialButton.Name = "serialButton";
            this.serialButton.Size = new System.Drawing.Size(107, 23);
            this.serialButton.TabIndex = 9;
            this.serialButton.Text = "Connect Serial";
            this.serialButton.UseVisualStyleBackColor = true;
            this.serialButton.Click += new System.EventHandler(this.serialButton_Click);
            // 
            // autoButton
            // 
            this.autoButton.Location = new System.Drawing.Point(379, 143);
            this.autoButton.Name = "autoButton";
            this.autoButton.Size = new System.Drawing.Size(75, 23);
            this.autoButton.TabIndex = 10;
            this.autoButton.Text = "Auto";
            this.autoButton.UseVisualStyleBackColor = true;
            this.autoButton.Click += new System.EventHandler(this.autoButton_Click);
            // 
            // sunnyButton
            // 
            this.sunnyButton.Location = new System.Drawing.Point(12, 114);
            this.sunnyButton.Name = "sunnyButton";
            this.sunnyButton.Size = new System.Drawing.Size(75, 23);
            this.sunnyButton.TabIndex = 11;
            this.sunnyButton.Text = "Sunny";
            this.sunnyButton.UseVisualStyleBackColor = true;
            this.sunnyButton.Click += new System.EventHandler(this.sunnyButton_Click);
            // 
            // cloudyButton
            // 
            this.cloudyButton.Location = new System.Drawing.Point(12, 143);
            this.cloudyButton.Name = "cloudyButton";
            this.cloudyButton.Size = new System.Drawing.Size(75, 23);
            this.cloudyButton.TabIndex = 12;
            this.cloudyButton.Text = "Cloudy";
            this.cloudyButton.UseVisualStyleBackColor = true;
            this.cloudyButton.Click += new System.EventHandler(this.cloudyButton_Click);
            // 
            // rainyButton
            // 
            this.rainyButton.Location = new System.Drawing.Point(12, 172);
            this.rainyButton.Name = "rainyButton";
            this.rainyButton.Size = new System.Drawing.Size(75, 23);
            this.rainyButton.TabIndex = 13;
            this.rainyButton.Text = "Rainy";
            this.rainyButton.UseVisualStyleBackColor = true;
            this.rainyButton.Click += new System.EventHandler(this.rainyButton_Click);
            // 
            // snowyButton
            // 
            this.snowyButton.Location = new System.Drawing.Point(12, 201);
            this.snowyButton.Name = "snowyButton";
            this.snowyButton.Size = new System.Drawing.Size(75, 23);
            this.snowyButton.TabIndex = 14;
            this.snowyButton.Text = "Snowy";
            this.snowyButton.UseVisualStyleBackColor = true;
            this.snowyButton.Click += new System.EventHandler(this.snowyButton_Click);
            // 
            // stormyButton
            // 
            this.stormyButton.Location = new System.Drawing.Point(12, 230);
            this.stormyButton.Name = "stormyButton";
            this.stormyButton.Size = new System.Drawing.Size(75, 23);
            this.stormyButton.TabIndex = 15;
            this.stormyButton.Text = "Stormy";
            this.stormyButton.UseVisualStyleBackColor = true;
            this.stormyButton.Click += new System.EventHandler(this.stormyButton_Click);
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new System.Drawing.Point(12, 87);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(34, 13);
            this.modeLabel.TabIndex = 16;
            this.modeLabel.Text = "Mode";
            // 
            // modeTextbox
            // 
            this.modeTextbox.Location = new System.Drawing.Point(52, 84);
            this.modeTextbox.Name = "modeTextbox";
            this.modeTextbox.Size = new System.Drawing.Size(100, 20);
            this.modeTextbox.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flagLabel
            // 
            this.flagLabel.AutoSize = true;
            this.flagLabel.Location = new System.Drawing.Point(595, 9);
            this.flagLabel.Name = "flagLabel";
            this.flagLabel.Size = new System.Drawing.Size(27, 13);
            this.flagLabel.TabIndex = 18;
            this.flagLabel.Text = "Flag";
            // 
            // flagTextbox
            // 
            this.flagTextbox.Location = new System.Drawing.Point(628, 6);
            this.flagTextbox.Name = "flagTextbox";
            this.flagTextbox.Size = new System.Drawing.Size(100, 20);
            this.flagTextbox.TabIndex = 19;
            // 
            // timerButton
            // 
            this.timerButton.Location = new System.Drawing.Point(271, 12);
            this.timerButton.Name = "timerButton";
            this.timerButton.Size = new System.Drawing.Size(75, 23);
            this.timerButton.TabIndex = 88;
            this.timerButton.Text = "start Timer";
            this.timerButton.UseVisualStyleBackColor = true;
            this.timerButton.Click += new System.EventHandler(this.timerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timerButton);
            this.Controls.Add(this.flagTextbox);
            this.Controls.Add(this.flagLabel);
            this.Controls.Add(this.modeTextbox);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.stormyButton);
            this.Controls.Add(this.snowyButton);
            this.Controls.Add(this.rainyButton);
            this.Controls.Add(this.cloudyButton);
            this.Controls.Add(this.sunnyButton);
            this.Controls.Add(this.autoButton);
            this.Controls.Add(this.serialButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.weatherTypeTextbox);
            this.Controls.Add(this.rhTextbox);
            this.Controls.Add(this.tempTextbox);
            this.Controls.Add(this.lightTextbox);
            this.Controls.Add(this.weatherTypeLabel);
            this.Controls.Add(this.rhLabel);
            this.Controls.Add(this.lightLabel);
            this.Controls.Add(this.tempLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label lightLabel;
        private System.Windows.Forms.Label rhLabel;
        private System.Windows.Forms.Label weatherTypeLabel;
        private System.Windows.Forms.TextBox lightTextbox;
        private System.Windows.Forms.TextBox tempTextbox;
        private System.Windows.Forms.TextBox rhTextbox;
        private System.Windows.Forms.TextBox weatherTypeTextbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button serialButton;
        private System.Windows.Forms.Button autoButton;
        private System.Windows.Forms.Button sunnyButton;
        private System.Windows.Forms.Button cloudyButton;
        private System.Windows.Forms.Button rainyButton;
        private System.Windows.Forms.Button snowyButton;
        private System.Windows.Forms.Button stormyButton;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.TextBox modeTextbox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label flagLabel;
        private System.Windows.Forms.TextBox flagTextbox;
        private System.Windows.Forms.Button timerButton;
    }
}

