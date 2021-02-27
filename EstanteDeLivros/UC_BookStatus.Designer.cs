namespace EstanteDeLivros
{
    partial class UC_BookStatus
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic_thumb = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_thumb)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_thumb
            // 
            this.pic_thumb.Location = new System.Drawing.Point(12, 3);
            this.pic_thumb.Name = "pic_thumb";
            this.pic_thumb.Size = new System.Drawing.Size(154, 198);
            this.pic_thumb.TabIndex = 0;
            this.pic_thumb.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(9, 214);
            this.lbl_title.MaximumSize = new System.Drawing.Size(150, 150);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(45, 16);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "label1";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(55, 251);
            this.lbl_status.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(41, 15);
            this.lbl_status.TabIndex = 2;
            this.lbl_status.Text = "label2";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_BookStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pic_thumb);
            this.Name = "UC_BookStatus";
            this.Size = new System.Drawing.Size(179, 286);
            this.Load += new System.EventHandler(this.UC_BookStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_thumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_thumb;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_status;
    }
}
