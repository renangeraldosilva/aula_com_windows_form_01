namespace WF4
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCriarPasta = new System.Windows.Forms.Button();
            this.lblPastaCriada = new System.Windows.Forms.Label();
            this.txtPastaCriada = new System.Windows.Forms.TextBox();
            this.btnDeletarPasta = new System.Windows.Forms.Button();
            this.lblApagarPasta = new System.Windows.Forms.Label();
            this.txtApagarPasta = new System.Windows.Forms.TextBox();
            this.lblOrigemArquivo = new System.Windows.Forms.Label();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.lblDestinoArquivo = new System.Windows.Forms.Label();
            this.txtArquivoDestino = new System.Windows.Forms.TextBox();
            this.btnMoverArquivo = new System.Windows.Forms.Button();
            this.lblArquivo = new System.Windows.Forms.Label();
            this.txtArquivoOrigem = new System.Windows.Forms.TextBox();
            this.btnCriarArquivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCriarPasta
            // 
            this.btnCriarPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPasta.Location = new System.Drawing.Point(456, 92);
            this.btnCriarPasta.Name = "btnCriarPasta";
            this.btnCriarPasta.Size = new System.Drawing.Size(78, 32);
            this.btnCriarPasta.TabIndex = 0;
            this.btnCriarPasta.Text = "Criar";
            this.btnCriarPasta.UseVisualStyleBackColor = true;
            this.btnCriarPasta.Click += new System.EventHandler(this.btnCriarPasta_Click);
            // 
            // lblPastaCriada
            // 
            this.lblPastaCriada.AutoSize = true;
            this.lblPastaCriada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastaCriada.Location = new System.Drawing.Point(92, 66);
            this.lblPastaCriada.Name = "lblPastaCriada";
            this.lblPastaCriada.Size = new System.Drawing.Size(269, 24);
            this.lblPastaCriada.TabIndex = 1;
            this.lblPastaCriada.Text = "Nome da Pasta a ser Criada";
            // 
            // txtPastaCriada
            // 
            this.txtPastaCriada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPastaCriada.Location = new System.Drawing.Point(96, 95);
            this.txtPastaCriada.Name = "txtPastaCriada";
            this.txtPastaCriada.Size = new System.Drawing.Size(301, 29);
            this.txtPastaCriada.TabIndex = 2;
            // 
            // btnDeletarPasta
            // 
            this.btnDeletarPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarPasta.Location = new System.Drawing.Point(456, 177);
            this.btnDeletarPasta.Name = "btnDeletarPasta";
            this.btnDeletarPasta.Size = new System.Drawing.Size(88, 32);
            this.btnDeletarPasta.TabIndex = 0;
            this.btnDeletarPasta.Text = "Deletar";
            this.btnDeletarPasta.UseVisualStyleBackColor = true;
            this.btnDeletarPasta.Click += new System.EventHandler(this.btnDeletarPasta_Click);
            // 
            // lblApagarPasta
            // 
            this.lblApagarPasta.AutoSize = true;
            this.lblApagarPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagarPasta.Location = new System.Drawing.Point(92, 150);
            this.lblApagarPasta.Name = "lblApagarPasta";
            this.lblApagarPasta.Size = new System.Drawing.Size(291, 24);
            this.lblApagarPasta.TabIndex = 1;
            this.lblApagarPasta.Text = "Nome da Pasta a ser Deletada";
            // 
            // txtApagarPasta
            // 
            this.txtApagarPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApagarPasta.Location = new System.Drawing.Point(96, 177);
            this.txtApagarPasta.Name = "txtApagarPasta";
            this.txtApagarPasta.Size = new System.Drawing.Size(301, 29);
            this.txtApagarPasta.TabIndex = 2;
            // 
            // lblOrigemArquivo
            // 
            this.lblOrigemArquivo.AutoSize = true;
            this.lblOrigemArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigemArquivo.Location = new System.Drawing.Point(92, 313);
            this.lblOrigemArquivo.Name = "lblOrigemArquivo";
            this.lblOrigemArquivo.Size = new System.Drawing.Size(245, 24);
            this.lblOrigemArquivo.TabIndex = 1;
            this.lblOrigemArquivo.Text = "Nome do Arquivo origem";
            // 
            // txtArquivo
            // 
            this.txtArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivo.Location = new System.Drawing.Point(96, 249);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(301, 29);
            this.txtArquivo.TabIndex = 2;
            // 
            // lblDestinoArquivo
            // 
            this.lblDestinoArquivo.AutoSize = true;
            this.lblDestinoArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinoArquivo.Location = new System.Drawing.Point(92, 385);
            this.lblDestinoArquivo.Name = "lblDestinoArquivo";
            this.lblDestinoArquivo.Size = new System.Drawing.Size(250, 24);
            this.lblDestinoArquivo.TabIndex = 1;
            this.lblDestinoArquivo.Text = "Nome do Arquivo Destino";
            // 
            // txtArquivoDestino
            // 
            this.txtArquivoDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivoDestino.Location = new System.Drawing.Point(96, 409);
            this.txtArquivoDestino.Name = "txtArquivoDestino";
            this.txtArquivoDestino.Size = new System.Drawing.Size(301, 29);
            this.txtArquivoDestino.TabIndex = 2;
            // 
            // btnMoverArquivo
            // 
            this.btnMoverArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoverArquivo.Location = new System.Drawing.Point(446, 365);
            this.btnMoverArquivo.Name = "btnMoverArquivo";
            this.btnMoverArquivo.Size = new System.Drawing.Size(78, 32);
            this.btnMoverArquivo.TabIndex = 0;
            this.btnMoverArquivo.Text = "Mover";
            this.btnMoverArquivo.UseVisualStyleBackColor = true;
            this.btnMoverArquivo.Click += new System.EventHandler(this.btnMoverArquivo_Click);
            // 
            // lblArquivo
            // 
            this.lblArquivo.AutoSize = true;
            this.lblArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArquivo.Location = new System.Drawing.Point(92, 222);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(159, 24);
            this.lblArquivo.TabIndex = 1;
            this.lblArquivo.Text = "Criar Arquivo txt";
            // 
            // txtArquivoOrigem
            // 
            this.txtArquivoOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivoOrigem.Location = new System.Drawing.Point(96, 340);
            this.txtArquivoOrigem.Name = "txtArquivoOrigem";
            this.txtArquivoOrigem.Size = new System.Drawing.Size(301, 29);
            this.txtArquivoOrigem.TabIndex = 2;
            // 
            // btnCriarArquivo
            // 
            this.btnCriarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarArquivo.Location = new System.Drawing.Point(446, 246);
            this.btnCriarArquivo.Name = "btnCriarArquivo";
            this.btnCriarArquivo.Size = new System.Drawing.Size(88, 32);
            this.btnCriarArquivo.TabIndex = 0;
            this.btnCriarArquivo.Text = "Criar";
            this.btnCriarArquivo.UseVisualStyleBackColor = true;
            this.btnCriarArquivo.Click += new System.EventHandler(this.btnCriarArquivo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 538);
            this.Controls.Add(this.txtArquivoOrigem);
            this.Controls.Add(this.txtArquivoDestino);
            this.Controls.Add(this.lblArquivo);
            this.Controls.Add(this.lblDestinoArquivo);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.lblOrigemArquivo);
            this.Controls.Add(this.btnMoverArquivo);
            this.Controls.Add(this.txtApagarPasta);
            this.Controls.Add(this.lblApagarPasta);
            this.Controls.Add(this.txtPastaCriada);
            this.Controls.Add(this.btnCriarArquivo);
            this.Controls.Add(this.btnDeletarPasta);
            this.Controls.Add(this.lblPastaCriada);
            this.Controls.Add(this.btnCriarPasta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarPasta;
        private System.Windows.Forms.Label lblPastaCriada;
        private System.Windows.Forms.TextBox txtPastaCriada;
        private System.Windows.Forms.Button btnDeletarPasta;
        private System.Windows.Forms.Label lblApagarPasta;
        private System.Windows.Forms.TextBox txtApagarPasta;
        private System.Windows.Forms.Label lblOrigemArquivo;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Label lblDestinoArquivo;
        private System.Windows.Forms.TextBox txtArquivoDestino;
        private System.Windows.Forms.Button btnMoverArquivo;
        private System.Windows.Forms.Label lblArquivo;
        private System.Windows.Forms.TextBox txtArquivoOrigem;
        private System.Windows.Forms.Button btnCriarArquivo;
    }
}

