namespace pryGerhauser
{
    partial class frmFinJuego
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
            label1 = new Label();
            btnYes = new Button();
            btnNo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(82, 46);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 0;
            label1.Text = "TRY AGAIN:";
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.Transparent;
            btnYes.FlatStyle = FlatStyle.Popup;
            btnYes.ForeColor = Color.Yellow;
            btnYes.Location = new Point(51, 96);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(60, 23);
            btnYes.TabIndex = 1;
            btnYes.Text = "YES";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.Transparent;
            btnNo.FlatStyle = FlatStyle.Popup;
            btnNo.ForeColor = Color.Yellow;
            btnNo.Location = new Point(139, 96);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(59, 23);
            btnNo.TabIndex = 2;
            btnNo.Text = "NO";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // frmFinJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(253, 171);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(label1);
            ForeColor = Color.Red;
            Name = "frmFinJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Over";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnYes;
        private Button btnNo;
    }
}