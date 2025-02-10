namespace sistema2
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonGerenciamentoCliente = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonCadastrarProduto = new System.Windows.Forms.Button();
            this.buttonAlterarProduto = new System.Windows.Forms.Button();
            this.buttonConsultarProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Principal";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cadastrar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGerenciamentoCliente
            // 
            this.buttonGerenciamentoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGerenciamentoCliente.Location = new System.Drawing.Point(23, 190);
            this.buttonGerenciamentoCliente.Name = "buttonGerenciamentoCliente";
            this.buttonGerenciamentoCliente.Size = new System.Drawing.Size(200, 55);
            this.buttonGerenciamentoCliente.TabIndex = 2;
            this.buttonGerenciamentoCliente.Text = "Gerenciamento Cliente";
            this.buttonGerenciamentoCliente.UseVisualStyleBackColor = true;
            this.buttonGerenciamentoCliente.Click += new System.EventHandler(this.buttonGerenciamentoCliente_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(23, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 63);
            this.button4.TabIndex = 4;
            this.button4.Text = "Alterar dados dos clientes";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(547, 377);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 61);
            this.button5.TabIndex = 5;
            this.button5.Text = "Fechar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrarProduto
            // 
            this.buttonCadastrarProduto.Location = new System.Drawing.Point(260, 84);
            this.buttonCadastrarProduto.Name = "buttonCadastrarProduto";
            this.buttonCadastrarProduto.Size = new System.Drawing.Size(186, 63);
            this.buttonCadastrarProduto.TabIndex = 6;
            this.buttonCadastrarProduto.Text = "Cadastrar Produto";
            this.buttonCadastrarProduto.UseVisualStyleBackColor = true;
            this.buttonCadastrarProduto.Click += new System.EventHandler(this.buttonCadastrarProduto_Click);
            // 
            // buttonAlterarProduto
            // 
            this.buttonAlterarProduto.Location = new System.Drawing.Point(260, 279);
            this.buttonAlterarProduto.Name = "buttonAlterarProduto";
            this.buttonAlterarProduto.Size = new System.Drawing.Size(186, 63);
            this.buttonAlterarProduto.TabIndex = 8;
            this.buttonAlterarProduto.Text = "Alterar Produto";
            this.buttonAlterarProduto.UseVisualStyleBackColor = true;
            // 
            // buttonConsultarProduto
            // 
            this.buttonConsultarProduto.Location = new System.Drawing.Point(260, 191);
            this.buttonConsultarProduto.Name = "buttonConsultarProduto";
            this.buttonConsultarProduto.Size = new System.Drawing.Size(186, 54);
            this.buttonConsultarProduto.TabIndex = 9;
            this.buttonConsultarProduto.Text = "Gerenciamento Carros";
            this.buttonConsultarProduto.UseVisualStyleBackColor = true;
            this.buttonConsultarProduto.Click += new System.EventHandler(this.buttonConsultarProduto_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonConsultarProduto);
            this.Controls.Add(this.buttonAlterarProduto);
            this.Controls.Add(this.buttonCadastrarProduto);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonGerenciamentoCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonGerenciamentoCliente;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonCadastrarProduto;
        private System.Windows.Forms.Button buttonAlterarProduto;
        private System.Windows.Forms.Button buttonConsultarProduto;
    }
}