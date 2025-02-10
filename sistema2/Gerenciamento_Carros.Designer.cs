namespace sistema2
{
    partial class Gerenciamento_Carros
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
            this.dataGridViewGerenciamentoCarros = new System.Windows.Forms.DataGridView();
            this.buttonPesquisaCarros = new System.Windows.Forms.Button();
            this.buttonRemoverCarros = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGerenciamentoCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGerenciamentoCarros
            // 
            this.dataGridViewGerenciamentoCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGerenciamentoCarros.Location = new System.Drawing.Point(66, 78);
            this.dataGridViewGerenciamentoCarros.Name = "dataGridViewGerenciamentoCarros";
            this.dataGridViewGerenciamentoCarros.Size = new System.Drawing.Size(707, 298);
            this.dataGridViewGerenciamentoCarros.TabIndex = 0;
            // 
            // buttonPesquisaCarros
            // 
            this.buttonPesquisaCarros.Location = new System.Drawing.Point(492, 8);
            this.buttonPesquisaCarros.Name = "buttonPesquisaCarros";
            this.buttonPesquisaCarros.Size = new System.Drawing.Size(92, 43);
            this.buttonPesquisaCarros.TabIndex = 1;
            this.buttonPesquisaCarros.Text = "Pesquisar Carros ";
            this.buttonPesquisaCarros.UseVisualStyleBackColor = true;
            this.buttonPesquisaCarros.Click += new System.EventHandler(this.buttonPesquisaCarros_Click);
            // 
            // buttonRemoverCarros
            // 
            this.buttonRemoverCarros.Location = new System.Drawing.Point(590, 8);
            this.buttonRemoverCarros.Name = "buttonRemoverCarros";
            this.buttonRemoverCarros.Size = new System.Drawing.Size(90, 43);
            this.buttonRemoverCarros.TabIndex = 2;
            this.buttonRemoverCarros.Text = "Remover Carros";
            this.buttonRemoverCarros.UseVisualStyleBackColor = true;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(686, 8);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(87, 43);
            this.buttonFechar.TabIndex = 3;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gerenciamento de carros";
            // 
            // Gerenciamento_Carros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonRemoverCarros);
            this.Controls.Add(this.buttonPesquisaCarros);
            this.Controls.Add(this.dataGridViewGerenciamentoCarros);
            this.Name = "Gerenciamento_Carros";
            this.Text = "Gerenciamento_Carros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGerenciamentoCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGerenciamentoCarros;
        private System.Windows.Forms.Button buttonPesquisaCarros;
        private System.Windows.Forms.Button buttonRemoverCarros;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Label label1;
    }
}