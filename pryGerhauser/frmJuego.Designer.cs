namespace pryGerhauser
{
    partial class frmJuego
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
            components = new System.ComponentModel.Container();
            timerDisparo = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            lblPoints = new Label();
            label2 = new Label();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            label4 = new Label();
            lblLevel = new Label();
            label5 = new Label();
            lblPlayer = new Label();
            SuspendLayout();
            // 
            // timerDisparo
            // 
            timerDisparo.Interval = 25;
            timerDisparo.Tick += timerDisparo_Tick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "SCORE:";
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.BackColor = Color.Black;
            lblPoints.ForeColor = Color.Yellow;
            lblPoints.Location = new Point(12, 44);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(13, 15);
            lblPoints.TabIndex = 1;
            lblPoints.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(144, 29);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "HIGH SCORE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(144, 44);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 3;
            label3.Text = "0";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(264, 29);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(123, 15);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(264, 9);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 5;
            label4.Text = "LEVEL:";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.BackColor = Color.Black;
            lblLevel.ForeColor = Color.Yellow;
            lblLevel.Location = new Point(311, 9);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(13, 15);
            lblLevel.TabIndex = 6;
            lblLevel.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.ForeColor = Color.Yellow;
            label5.Location = new Point(13, 9);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 7;
            label5.Text = "PLAYER:";
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.BackColor = Color.Black;
            lblPlayer.ForeColor = Color.Yellow;
            lblPlayer.Location = new Point(60, 9);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(12, 15);
            lblPlayer.TabIndex = 8;
            lblPlayer.Text = "-";
            // 
            // frmJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(398, 507);
            Controls.Add(lblPlayer);
            Controls.Add(label5);
            Controls.Add(lblLevel);
            Controls.Add(label4);
            Controls.Add(progressBar1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblPoints);
            Controls.Add(label1);
            Name = "frmJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmJuego";
            KeyDown += frmJuego_KeyDown_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timerDisparo;
        private Label label1;
        public Label lblPoints;
        private Label label2;
        public Label label3;
        private ProgressBar progressBar1;
        private Label label4;
        public Label lblLevel;
        private Label label5;
        public Label lblPlayer;
    }
}