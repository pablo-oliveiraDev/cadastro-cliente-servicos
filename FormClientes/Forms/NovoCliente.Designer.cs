
namespace FormClientes.Forms
{
    partial class NovoCliente
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
            this.textDataEntrada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.tagSolutions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textDataEntrada
            // 
            this.textDataEntrada.Location = new System.Drawing.Point(135, 126);
            this.textDataEntrada.Name = "textDataEntrada";
            this.textDataEntrada.Size = new System.Drawing.Size(352, 22);
            this.textDataEntrada.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Data Entrada: ";
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(135, 86);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(352, 22);
            this.textEndereco.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Endereço: ";
            // 
            // TextNome
            // 
            this.TextNome.Location = new System.Drawing.Point(135, 48);
            this.TextNome.Name = "TextNome";
            this.TextNome.Size = new System.Drawing.Size(352, 22);
            this.TextNome.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome: ";
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.Location = new System.Drawing.Point(346, 177);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(141, 46);
            this.BtnCancel.TabIndex = 14;
            this.BtnCancel.Text = "&Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Location = new System.Drawing.Point(135, 177);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(141, 46);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // tagSolutions
            // 
            this.tagSolutions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tagSolutions.Cursor = System.Windows.Forms.Cursors.No;
            this.tagSolutions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagSolutions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tagSolutions.Location = new System.Drawing.Point(199, 243);
            this.tagSolutions.Name = "tagSolutions";
            this.tagSolutions.Size = new System.Drawing.Size(288, 43);
            this.tagSolutions.TabIndex = 16;
            this.tagSolutions.Text = "Oliveira New Solutions";
            this.tagSolutions.UseVisualStyleBackColor = false;
            // 
            // NovoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(571, 288);
            this.Controls.Add(this.tagSolutions);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.textDataEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextNome);
            this.Controls.Add(this.label1);
            this.Name = "NovoCliente";
            this.Text = "NovoCliente";
            this.Load += new System.EventHandler(this.NovoCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDataEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button tagSolutions;
    }
}