
namespace pinnponn3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.titleButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.clearLabel = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.PR = new System.Windows.Forms.Label();
            this.Tama = new System.Windows.Forms.Label();
            this.EN = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.rightLabel = new System.Windows.Forms.Label();
            this.senlabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // titleButton
            // 
            this.titleButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.titleButton.Font = new System.Drawing.Font("Yu Gothic UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleButton.Location = new System.Drawing.Point(218, 242);
            this.titleButton.Name = "titleButton";
            this.titleButton.Size = new System.Drawing.Size(368, 137);
            this.titleButton.TabIndex = 0;
            this.titleButton.Text = "タイトルへ";
            this.titleButton.UseVisualStyleBackColor = false;
            this.titleButton.Visible = false;
            this.titleButton.Click += new System.EventHandler(this.titleButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.startButton.Font = new System.Drawing.Font("Yu Gothic UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(218, 242);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(368, 137);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "スタート！";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(305, 431);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(169, 15);
            this.copyrightLabel.TabIndex = 2;
            this.copyrightLabel.Text = "Copyright@ ２０２２　高橋涼";
            // 
            // clearLabel
            // 
            this.clearLabel.AutoSize = true;
            this.clearLabel.Font = new System.Drawing.Font("Yu Gothic UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearLabel.ForeColor = System.Drawing.Color.Crimson;
            this.clearLabel.Location = new System.Drawing.Point(233, 98);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(319, 106);
            this.clearLabel.TabIndex = 3;
            this.clearLabel.Text = "CLEAR!!";
            this.clearLabel.Visible = false;
            this.clearLabel.Click += new System.EventHandler(this.clearLabel_Click);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Yu Gothic UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameOverLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.gameOverLabel.Location = new System.Drawing.Point(179, 98);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(420, 106);
            this.gameOverLabel.TabIndex = 4;
            this.gameOverLabel.Text = "GameOver";
            this.gameOverLabel.Visible = false;
            this.gameOverLabel.Click += new System.EventHandler(this.gameOverLabel_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Yu Gothic UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(200, 98);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(386, 89);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "ピンポン2022";
            // 
            // PR
            // 
            this.PR.AutoSize = true;
            this.PR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PR.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PR.Location = new System.Drawing.Point(12, 142);
            this.PR.Name = "PR";
            this.PR.Size = new System.Drawing.Size(16, 135);
            this.PR.TabIndex = 6;
            this.PR.Text = "   \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // Tama
            // 
            this.Tama.AutoSize = true;
            this.Tama.BackColor = System.Drawing.Color.Gold;
            this.Tama.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tama.Location = new System.Drawing.Point(360, 196);
            this.Tama.Name = "Tama";
            this.Tama.Size = new System.Drawing.Size(38, 37);
            this.Tama.TabIndex = 7;
            this.Tama.Text = "   ";
            // 
            // EN
            // 
            this.EN.AutoSize = true;
            this.EN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EN.Location = new System.Drawing.Point(772, 142);
            this.EN.Name = "EN";
            this.EN.Size = new System.Drawing.Size(16, 135);
            this.EN.TabIndex = 8;
            this.EN.Text = "   \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Font = new System.Drawing.Font("Yu Gothic UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leftLabel.Location = new System.Drawing.Point(138, 9);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(74, 89);
            this.leftLabel.TabIndex = 9;
            this.leftLabel.Text = "0";
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.Font = new System.Drawing.Font("Yu Gothic UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rightLabel.Location = new System.Drawing.Point(579, 9);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(74, 89);
            this.rightLabel.TabIndex = 10;
            this.rightLabel.Text = "0";
            this.rightLabel.Click += new System.EventHandler(this.rightLabel_Click);
            // 
            // senlabel
            // 
            this.senlabel.AutoSize = true;
            this.senlabel.Font = new System.Drawing.Font("Yu Gothic UI", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.senlabel.Location = new System.Drawing.Point(326, -47);
            this.senlabel.Name = "senlabel";
            this.senlabel.Size = new System.Drawing.Size(129, 177);
            this.senlabel.TabIndex = 11;
            this.senlabel.Text = "-";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(527, 386);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(276, 72);
            this.timeLabel.TabIndex = 12;
            this.timeLabel.Text = "Time 1000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tama);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.rightLabel);
            this.Controls.Add(this.leftLabel);
            this.Controls.Add(this.EN);
            this.Controls.Add(this.PR);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleButton);
            this.Controls.Add(this.senlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button titleButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label clearLabel;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label PR;
        private System.Windows.Forms.Label Tama;
        private System.Windows.Forms.Label EN;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label senlabel;
        private System.Windows.Forms.Label timeLabel;
    }
}

