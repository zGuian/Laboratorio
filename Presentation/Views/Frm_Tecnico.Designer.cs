namespace Presentation.Views
{
    partial class Frm_Tecnico
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
            Btn_Carregar = new Button();
            lbl_Conectar = new Label();
            SuspendLayout();
            // 
            // Btn_Carregar
            // 
            Btn_Carregar.Location = new Point(137, 101);
            Btn_Carregar.Name = "Btn_Carregar";
            Btn_Carregar.Size = new Size(75, 23);
            Btn_Carregar.TabIndex = 0;
            Btn_Carregar.Text = "button1";
            Btn_Carregar.UseVisualStyleBackColor = true;
            Btn_Carregar.Click += Btn_Carregar_Click;
            // 
            // lbl_Conectar
            // 
            lbl_Conectar.AutoSize = true;
            lbl_Conectar.Location = new Point(140, 48);
            lbl_Conectar.Name = "lbl_Conectar";
            lbl_Conectar.Size = new Size(38, 15);
            lbl_Conectar.TabIndex = 1;
            lbl_Conectar.Text = "label1";
            // 
            // Frm_Tecnico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Conectar);
            Controls.Add(Btn_Carregar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "Frm_Tecnico";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Frm_Tecnico";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Carregar;
        private Label lbl_Conectar;
    }
}