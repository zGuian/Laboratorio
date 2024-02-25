namespace Lab_PresentationDesktop.FormularioViews
{
    partial class Frm_Principal
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
            mnu_Principal = new MenuStrip();
            mnuStrip_tecnico = new ToolStripMenuItem();
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            removerToolStripMenuItem = new ToolStripMenuItem();
            mnuStrip_registro = new ToolStripMenuItem();
            mnuStrip_equipamentos = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            mnu_Principal.SuspendLayout();
            SuspendLayout();
            // 
            // mnu_Principal
            // 
            mnu_Principal.Items.AddRange(new ToolStripItem[] { mnuStrip_tecnico, mnuStrip_equipamentos, mnuStrip_registro });
            mnu_Principal.Location = new Point(0, 0);
            mnu_Principal.Name = "mnu_Principal";
            mnu_Principal.Size = new Size(1055, 24);
            mnu_Principal.TabIndex = 0;
            mnu_Principal.Text = "menuStrip1";
            // 
            // mnuStrip_tecnico
            // 
            mnuStrip_tecnico.DropDownItems.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem, removerToolStripMenuItem });
            mnuStrip_tecnico.Name = "mnuStrip_tecnico";
            mnuStrip_tecnico.Size = new Size(59, 20);
            mnuStrip_tecnico.Text = "Tecnico";
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.Size = new Size(180, 22);
            adicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // removerToolStripMenuItem
            // 
            removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            removerToolStripMenuItem.Size = new Size(180, 22);
            removerToolStripMenuItem.Text = "Remover";
            // 
            // mnuStrip_registro
            // 
            mnuStrip_registro.Name = "mnuStrip_registro";
            mnuStrip_registro.Size = new Size(62, 20);
            mnuStrip_registro.Text = "Registro";
            mnuStrip_registro.Click += MnuStrip_registro_Click;
            // 
            // mnuStrip_equipamentos
            // 
            mnuStrip_equipamentos.DropDownItems.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem });
            mnuStrip_equipamentos.Name = "mnuStrip_equipamentos";
            mnuStrip_equipamentos.Size = new Size(95, 20);
            mnuStrip_equipamentos.Text = "Equipamentos";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(180, 22);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // Frm_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 511);
            Controls.Add(mnu_Principal);
            IsMdiContainer = true;
            MainMenuStrip = mnu_Principal;
            Name = "Frm_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Principal";
            mnu_Principal.ResumeLayout(false);
            mnu_Principal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnu_Principal;
        private ToolStripMenuItem mnuStrip_tecnico;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem removerToolStripMenuItem;
        private ToolStripMenuItem mnuStrip_equipamentos;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem mnuStrip_registro;
    }
}