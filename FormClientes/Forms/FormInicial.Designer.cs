
namespace FormClientes.Forms
{
    partial class FormInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            this.tagSolutions = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casdastroRevisãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cnsultaServiçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.btnRevisao = new System.Windows.Forms.Button();
            this.btnServicos = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tagSolutions
            // 
            this.tagSolutions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tagSolutions.Cursor = System.Windows.Forms.Cursors.No;
            this.tagSolutions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagSolutions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tagSolutions.Location = new System.Drawing.Point(658, 488);
            this.tagSolutions.Name = "tagSolutions";
            this.tagSolutions.Size = new System.Drawing.Size(288, 43);
            this.tagSolutions.TabIndex = 16;
            this.tagSolutions.Text = "Oliveira New Solutions";
            this.tagSolutions.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.serviçosToolStripMenuItem,
            this.revisõesToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 30);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.cadastroClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // cadastroClienteToolStripMenuItem
            // 
            this.cadastroClienteToolStripMenuItem.Name = "cadastroClienteToolStripMenuItem";
            this.cadastroClienteToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.cadastroClienteToolStripMenuItem.Text = "Cadastro Cliente";
            this.cadastroClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastroClienteToolStripMenuItem_Click);
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviçoToolStripMenuItem,
            this.cadastroServiçoToolStripMenuItem});
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            // 
            // serviçoToolStripMenuItem
            // 
            this.serviçoToolStripMenuItem.Name = "serviçoToolStripMenuItem";
            this.serviçoToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.serviçoToolStripMenuItem.Text = "Serviço";
            this.serviçoToolStripMenuItem.Click += new System.EventHandler(this.serviçoToolStripMenuItem_Click);
            // 
            // cadastroServiçoToolStripMenuItem
            // 
            this.cadastroServiçoToolStripMenuItem.Name = "cadastroServiçoToolStripMenuItem";
            this.cadastroServiçoToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.cadastroServiçoToolStripMenuItem.Text = "Cadastro Serviço";
            this.cadastroServiçoToolStripMenuItem.Click += new System.EventHandler(this.cadastroServiçoToolStripMenuItem_Click);
            // 
            // revisõesToolStripMenuItem
            // 
            this.revisõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revisãoToolStripMenuItem,
            this.casdastroRevisãoToolStripMenuItem});
            this.revisõesToolStripMenuItem.Name = "revisõesToolStripMenuItem";
            this.revisõesToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.revisõesToolStripMenuItem.Text = "Revisões";
            // 
            // revisãoToolStripMenuItem
            // 
            this.revisãoToolStripMenuItem.Name = "revisãoToolStripMenuItem";
            this.revisãoToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.revisãoToolStripMenuItem.Text = "Revisão";
            this.revisãoToolStripMenuItem.Click += new System.EventHandler(this.revisãoToolStripMenuItem_Click);
            // 
            // casdastroRevisãoToolStripMenuItem
            // 
            this.casdastroRevisãoToolStripMenuItem.Name = "casdastroRevisãoToolStripMenuItem";
            this.casdastroRevisãoToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.casdastroRevisãoToolStripMenuItem.Text = "Casdastro Revisão";
            this.casdastroRevisãoToolStripMenuItem.Click += new System.EventHandler(this.casdastroRevisãoToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cnsultaServiçosToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(86, 26);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // cnsultaServiçosToolStripMenuItem
            // 
            this.cnsultaServiçosToolStripMenuItem.Name = "cnsultaServiçosToolStripMenuItem";
            this.cnsultaServiçosToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.cnsultaServiçosToolStripMenuItem.Text = "Consulta Serviços";
            this.cnsultaServiçosToolStripMenuItem.Click += new System.EventHandler(this.cnsultaServiçosToolStripMenuItem_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(790, 436);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(141, 46);
            this.BtnCancel.TabIndex = 14;
            this.BtnCancel.Text = "&Sair";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnRevisao
            // 
            this.btnRevisao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRevisao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRevisao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevisao.Image = global::FormClientes.Properties.Resources.Atendimento;
            this.btnRevisao.Location = new System.Drawing.Point(505, 53);
            this.btnRevisao.Name = "btnRevisao";
            this.btnRevisao.Size = new System.Drawing.Size(152, 151);
            this.btnRevisao.TabIndex = 20;
            this.btnRevisao.Text = "&Revisão";
            this.btnRevisao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRevisao.UseVisualStyleBackColor = false;
            this.btnRevisao.Click += new System.EventHandler(this.btnRevisao_Click);
            // 
            // btnServicos
            // 
            this.btnServicos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnServicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnServicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicos.Image = global::FormClientes.Properties.Resources.Config;
            this.btnServicos.Location = new System.Drawing.Point(274, 53);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(152, 151);
            this.btnServicos.TabIndex = 19;
            this.btnServicos.Text = "&Serviços";
            this.btnServicos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnServicos.UseVisualStyleBackColor = false;
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Image = global::FormClientes.Properties.Resources.Cliente;
            this.btnCliente.Location = new System.Drawing.Point(43, 53);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(152, 151);
            this.btnCliente.TabIndex = 18;
            this.btnCliente.Text = "&Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 45);
            this.label1.TabIndex = 21;
            this.label1.Text = "Your\'s Solutions ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 45);
            this.label2.TabIndex = 22;
            this.label2.Text = "are Created in here";
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(958, 541);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRevisao);
            this.Controls.Add(this.btnServicos);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.tagSolutions);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormInicial";
            this.Text = "Home_Menu";
            this.Load += new System.EventHandler(this.FormInicial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button tagSolutions;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casdastroRevisãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cnsultaServiçosToolStripMenuItem;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnServicos;
        private System.Windows.Forms.Button btnRevisao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}