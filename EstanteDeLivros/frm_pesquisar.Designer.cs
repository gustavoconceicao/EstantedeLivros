namespace EstanteDeLivros
{
    partial class frm_pesquisar
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
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txtbox_input = new System.Windows.Forms.TextBox();
            this.lbl_footer = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_listar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_input_ator = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(159, 108);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(182, 53);
            this.btn_pesquisar.TabIndex = 0;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(32, 24);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(110, 13);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Qual o Titulo do livro?";
            // 
            // txtbox_input
            // 
            this.txtbox_input.Location = new System.Drawing.Point(159, 21);
            this.txtbox_input.Name = "txtbox_input";
            this.txtbox_input.Size = new System.Drawing.Size(260, 20);
            this.txtbox_input.TabIndex = 2;
            // 
            // lbl_footer
            // 
            this.lbl_footer.AutoSize = true;
            this.lbl_footer.Location = new System.Drawing.Point(183, 185);
            this.lbl_footer.Name = "lbl_footer";
            this.lbl_footer.Size = new System.Drawing.Size(122, 13);
            this.lbl_footer.TabIndex = 3;
            this.lbl_footer.Text = "Resultados encontrados";
            this.lbl_footer.Visible = false;
            this.lbl_footer.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(183, 218);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(0, 13);
            this.lbl_resultado.TabIndex = 4;
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(232, 212);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(90, 25);
            this.btn_listar.TabIndex = 5;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Visible = false;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Qual o autor do livro?";
            // 
            // txt_input_ator
            // 
            this.txt_input_ator.Location = new System.Drawing.Point(159, 65);
            this.txt_input_ator.Name = "txt_input_ator";
            this.txt_input_ator.Size = new System.Drawing.Size(260, 20);
            this.txt_input_ator.TabIndex = 7;
            // 
            // frm_pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 249);
            this.Controls.Add(this.txt_input_ator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_footer);
            this.Controls.Add(this.txtbox_input);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_pesquisar);
            this.Name = "frm_pesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquise seu livro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox txtbox_input;
        private System.Windows.Forms.Label lbl_footer;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_input_ator;
    }
}

