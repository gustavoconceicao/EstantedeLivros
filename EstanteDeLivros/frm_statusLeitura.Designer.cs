namespace EstanteDeLivros
{
    partial class frm_statusLeitura
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
            this.pic_thumb = new System.Windows.Forms.PictureBox();
            this.lbl_nomeLivro = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_thumb)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_thumb
            // 
            this.pic_thumb.Location = new System.Drawing.Point(12, 12);
            this.pic_thumb.Name = "pic_thumb";
            this.pic_thumb.Size = new System.Drawing.Size(168, 226);
            this.pic_thumb.TabIndex = 0;
            this.pic_thumb.TabStop = false;
            // 
            // lbl_nomeLivro
            // 
            this.lbl_nomeLivro.AutoSize = true;
            this.lbl_nomeLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeLivro.Location = new System.Drawing.Point(50, 251);
            this.lbl_nomeLivro.Name = "lbl_nomeLivro";
            this.lbl_nomeLivro.Size = new System.Drawing.Size(70, 25);
            this.lbl_nomeLivro.TabIndex = 1;
            this.lbl_nomeLivro.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ja li";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 64);
            this.button2.TabIndex = 3;
            this.button2.Text = "Planejo Ler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_statusLeitura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 299);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_nomeLivro);
            this.Controls.Add(this.pic_thumb);
            this.Name = "frm_statusLeitura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_statusLeitura";
            this.Load += new System.EventHandler(this.frm_statusLeitura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_thumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_thumb;
        private System.Windows.Forms.Label lbl_nomeLivro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}