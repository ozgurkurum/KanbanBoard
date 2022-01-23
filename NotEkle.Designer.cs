
namespace KanbanBoard
{
    partial class NotEkle
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
            this.txtNotEkle = new System.Windows.Forms.TextBox();
            this.btnNotEkle = new System.Windows.Forms.Button();
            this.lblKalanKarakterSayisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNotEkle
            // 
            this.txtNotEkle.Location = new System.Drawing.Point(91, 98);
            this.txtNotEkle.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotEkle.MaxLength = 140;
            this.txtNotEkle.Multiline = true;
            this.txtNotEkle.Name = "txtNotEkle";
            this.txtNotEkle.Size = new System.Drawing.Size(246, 268);
            this.txtNotEkle.TabIndex = 1;
            this.txtNotEkle.TextChanged += new System.EventHandler(this.txtNotEkle_TextChanged);
            // 
            // btnNotEkle
            // 
            this.btnNotEkle.Location = new System.Drawing.Point(91, 374);
            this.btnNotEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnNotEkle.Name = "btnNotEkle";
            this.btnNotEkle.Size = new System.Drawing.Size(112, 28);
            this.btnNotEkle.TabIndex = 2;
            this.btnNotEkle.Text = "Not Ekle";
            this.btnNotEkle.UseVisualStyleBackColor = true;
            this.btnNotEkle.Click += new System.EventHandler(this.btnNotEkle_Click);
            // 
            // lblKalanKarakterSayisi
            // 
            this.lblKalanKarakterSayisi.AutoSize = true;
            this.lblKalanKarakterSayisi.Location = new System.Drawing.Point(88, 77);
            this.lblKalanKarakterSayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKalanKarakterSayisi.Name = "lblKalanKarakterSayisi";
            this.lblKalanKarakterSayisi.Size = new System.Drawing.Size(179, 17);
            this.lblKalanKarakterSayisi.TabIndex = 3;
            this.lblKalanKarakterSayisi.Text = "Kalan Karakter Sayısı : ";
            // 
            // NotEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(441, 466);
            this.Controls.Add(this.lblKalanKarakterSayisi);
            this.Controls.Add(this.btnNotEkle);
            this.Controls.Add(this.txtNotEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NotEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNotEkle;
        private System.Windows.Forms.Button btnNotEkle;
        private System.Windows.Forms.Label lblKalanKarakterSayisi;
    }
}