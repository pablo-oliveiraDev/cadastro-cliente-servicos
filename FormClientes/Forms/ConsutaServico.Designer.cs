
namespace FormClientes.Forms
{
    partial class ConsultaServico
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
            this.textDataServico = new System.Windows.Forms.TextBox();
            this.textNomeCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tagSolutions = new System.Windows.Forms.Button();
            this.dataGridViewConsulta = new System.Windows.Forms.DataGridView();
            this.dataGridViewConsulta2 = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta2)).BeginInit();
            this.SuspendLayout();
            // 
            // textDataServico
            // 
            this.textDataServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDataServico.Location = new System.Drawing.Point(371, 36);
            this.textDataServico.Name = "textDataServico";
            this.textDataServico.Size = new System.Drawing.Size(152, 30);
            this.textDataServico.TabIndex = 2;
            // 
            // textNomeCliente
            // 
            this.textNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeCliente.Location = new System.Drawing.Point(109, 36);
            this.textNomeCliente.Name = "textNomeCliente";
            this.textNomeCliente.Size = new System.Drawing.Size(152, 30);
            this.textNomeCliente.TabIndex = 3;
            this.textNomeCliente.TextChanged += new System.EventHandler(this.textNomeCliente_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(32, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cliente :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(310, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data :";
            // 
            // tagSolutions
            // 
            this.tagSolutions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tagSolutions.Cursor = System.Windows.Forms.Cursors.No;
            this.tagSolutions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagSolutions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tagSolutions.Location = new System.Drawing.Point(697, 405);
            this.tagSolutions.Name = "tagSolutions";
            this.tagSolutions.Size = new System.Drawing.Size(288, 43);
            this.tagSolutions.TabIndex = 22;
            this.tagSolutions.Text = "Oliveira New Solutions";
            this.tagSolutions.UseVisualStyleBackColor = false;
            // 
            // dataGridViewConsulta
            // 
            this.dataGridViewConsulta.AllowUserToAddRows = false;
            this.dataGridViewConsulta.AllowUserToDeleteRows = false;
            this.dataGridViewConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsulta.Location = new System.Drawing.Point(36, 92);
            this.dataGridViewConsulta.Name = "dataGridViewConsulta";
            this.dataGridViewConsulta.ReadOnly = true;
            this.dataGridViewConsulta.RowHeadersWidth = 51;
            this.dataGridViewConsulta.RowTemplate.Height = 24;
            this.dataGridViewConsulta.Size = new System.Drawing.Size(883, 272);
            this.dataGridViewConsulta.TabIndex = 23;
            this.dataGridViewConsulta.Visible = false;
            // 
            // dataGridViewConsulta2
            // 
            this.dataGridViewConsulta2.AllowUserToAddRows = false;
            this.dataGridViewConsulta2.AllowUserToDeleteRows = false;
            this.dataGridViewConsulta2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsulta2.Location = new System.Drawing.Point(36, 92);
            this.dataGridViewConsulta2.Name = "dataGridViewConsulta2";
            this.dataGridViewConsulta2.ReadOnly = true;
            this.dataGridViewConsulta2.RowHeadersWidth = 51;
            this.dataGridViewConsulta2.RowTemplate.Height = 24;
            this.dataGridViewConsulta2.Size = new System.Drawing.Size(883, 272);
            this.dataGridViewConsulta2.TabIndex = 24;
            this.dataGridViewConsulta2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConsulta2_CellContentClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(582, 32);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(142, 44);
            this.btnPesquisar.TabIndex = 25;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(749, 32);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(142, 44);
            this.btnImprimir.TabIndex = 26;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDialog2
            // 
            this.printDialog2.UseEXDialog = true;
            // 
            // ConsultaServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dataGridViewConsulta2);
            this.Controls.Add(this.dataGridViewConsulta);
            this.Controls.Add(this.tagSolutions);
            this.Controls.Add(this.textNomeCliente);
            this.Controls.Add(this.textDataServico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "ConsultaServico";
            this.Text = "ConsultaServico";
            this.Load += new System.EventHandler(this.CadRevisao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textDataServico;
        private System.Windows.Forms.TextBox textNomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button tagSolutions;
        private System.Windows.Forms.DataGridView dataGridViewConsulta;
        private System.Windows.Forms.DataGridView dataGridViewConsulta2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog2;
    }
}