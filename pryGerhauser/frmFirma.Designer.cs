namespace pryGerhauser
{
    partial class frmFirma
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
            picFirma = new PictureBox();
            btnGuardar = new Button();
            btnBorrar = new Button();
            ((System.ComponentModel.ISupportInitialize)picFirma).BeginInit();
            SuspendLayout();
            // 
            // picFirma
            // 
            picFirma.Dock = DockStyle.Bottom;
            picFirma.Location = new Point(0, 65);
            picFirma.Name = "picFirma";
            picFirma.Size = new Size(826, 403);
            picFirma.TabIndex = 0;
            picFirma.TabStop = false;
            picFirma.MouseDown += picFirma_MouseDown;
            picFirma.MouseMove += picFirma_MouseMove;
            picFirma.MouseUp += picFirma_MouseUp;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(60, 12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(164, 12);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 2;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // frmFirma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 468);
            Controls.Add(btnBorrar);
            Controls.Add(btnGuardar);
            Controls.Add(picFirma);
            Name = "frmFirma";
            Text = "frmFirma";
            ((System.ComponentModel.ISupportInitialize)picFirma).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picFirma;
        private Button btnGuardar;
        private Button btnBorrar;
    }
}