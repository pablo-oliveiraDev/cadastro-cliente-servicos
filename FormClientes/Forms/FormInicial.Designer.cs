﻿
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(335, 429);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(141, 46);
            this.BtnCancel.TabIndex = 14;
            this.BtnCancel.Text = "&Sair";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCadastrar.Location = new System.Drawing.Point(124, 429);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(141, 46);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
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
            this.menuStrip1.Size = new System.Drawing.Size(958, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.cadastroClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // cadastroClienteToolStripMenuItem
            // 
            this.cadastroClienteToolStripMenuItem.Name = "cadastroClienteToolStripMenuItem";
            this.cadastroClienteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cadastroClienteToolStripMenuItem.Text = "Cadastro Cliente";
            this.cadastroClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastroClienteToolStripMenuItem_Click);
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviçoToolStripMenuItem,
            this.cadastroServiçoToolStripMenuItem});
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            // 
            // serviçoToolStripMenuItem
            // 
            this.serviçoToolStripMenuItem.Name = "serviçoToolStripMenuItem";
            this.serviçoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.serviçoToolStripMenuItem.Text = "Serviço";
            this.serviçoToolStripMenuItem.Click += new System.EventHandler(this.serviçoToolStripMenuItem_Click);
            // 
            // cadastroServiçoToolStripMenuItem
            // 
            this.cadastroServiçoToolStripMenuItem.Name = "cadastroServiçoToolStripMenuItem";
            this.cadastroServiçoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cadastroServiçoToolStripMenuItem.Text = "Cadastro Serviço";
            this.cadastroServiçoToolStripMenuItem.Click += new System.EventHandler(this.cadastroServiçoToolStripMenuItem_Click);
            // 
            // revisõesToolStripMenuItem
            // 
            this.revisõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revisãoToolStripMenuItem,
            this.casdastroRevisãoToolStripMenuItem});
            this.revisõesToolStripMenuItem.Name = "revisõesToolStripMenuItem";
            this.revisõesToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.revisõesToolStripMenuItem.Text = "Revisões";
            // 
            // revisãoToolStripMenuItem
            // 
            this.revisãoToolStripMenuItem.Name = "revisãoToolStripMenuItem";
            this.revisãoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.revisãoToolStripMenuItem.Text = "Revisão";
            this.revisãoToolStripMenuItem.Click += new System.EventHandler(this.revisãoToolStripMenuItem_Click);
            // 
            // casdastroRevisãoToolStripMenuItem
            // 
            this.casdastroRevisãoToolStripMenuItem.Name = "casdastroRevisãoToolStripMenuItem";
            this.casdastroRevisãoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.casdastroRevisãoToolStripMenuItem.Text = "Casdastro Revisão";
            this.casdastroRevisãoToolStripMenuItem.Click += new System.EventHandler(this.casdastroRevisãoToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cnsultaServiçosToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // cnsultaServiçosToolStripMenuItem
            // 
            this.cnsultaServiçosToolStripMenuItem.Name = "cnsultaServiçosToolStripMenuItem";
            this.cnsultaServiçosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cnsultaServiçosToolStripMenuItem.Text = "Cnsulta Serviços";
            this.cnsultaServiçosToolStripMenuItem.Click += new System.EventHandler(this.cnsultaServiçosToolStripMenuItem_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(958, 541);
            this.Controls.Add(this.tagSolutions);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormInicial";
            this.Text = "NovoCliente";
            this.Load += new System.EventHandler(this.FormInicial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button btnCadastrar;
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
    }
}