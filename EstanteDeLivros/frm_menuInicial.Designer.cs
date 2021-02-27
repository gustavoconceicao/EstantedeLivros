namespace EstanteDeLivros
{
    partial class frm_menuInicial
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
            this.btn_estante = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_estante
            // 
            this.btn_estante.Location = new System.Drawing.Point(52, 130);
            this.btn_estante.Name = "btn_estante";
            this.btn_estante.Size = new System.Drawing.Size(130, 56);
            this.btn_estante.TabIndex = 0;
            this.btn_estante.Text = "Mostrar Estante";
            this.btn_estante.UseVisualStyleBackColor = true;
            this.btn_estante.Click += new System.EventHandler(this.btn_estante_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(52, 68);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(130, 56);
            this.btn_pesquisar.TabIndex = 0;
            this.btn_pesquisar.Text = "Pesquisar Livros";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(52, 6);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(130, 56);
            this.btn_cadastrar.TabIndex = 1;
            this.btn_cadastrar.Text = "Cadastro";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Visible = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 199);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.btn_estante);
            this.Name = "menuInicial";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu inicial";
            this.Load += new System.EventHandler(this.menuInicial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_estante;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_cadastrar;
    }
}