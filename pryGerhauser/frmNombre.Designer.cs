namespace pryGerhauser
{
    partial class frmNombre
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
            btnOk = new Button();
            txtName = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.Transparent;
            btnOk.FlatStyle = FlatStyle.Popup;
            btnOk.ForeColor = Color.Yellow;
            btnOk.Location = new Point(129, 129);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(114, 23);
            btnOk.TabIndex = 9;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // txtName
            // 
            txtName.BackColor = Color.Black;
            txtName.ForeColor = Color.Gold;
            txtName.Location = new Point(129, 87);
            txtName.Name = "txtName";
            txtName.Size = new Size(114, 23);
            txtName.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(129, 46);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 7;
            label2.Text = "PLAYER NAME:";
            // 
            // frmNombre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            ClientSize = new Size(366, 198);
            Controls.Add(btnOk);
            Controls.Add(txtName);
            Controls.Add(label2);
            Name = "frmNombre";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnOk;
        private TextBox txtName;
        private Label label2;
    }
}