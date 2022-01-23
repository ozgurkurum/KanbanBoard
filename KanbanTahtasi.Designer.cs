
namespace KanbanBoard
{
    partial class KanbanTahtasi
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKarakterSayisi = new System.Windows.Forms.Label();
            this.txtToDo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDoing = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDone = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblKarakterSayisi);
            this.panel1.Controls.Add(this.txtToDo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 600);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(160, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ToDo";
            // 
            // lblKarakterSayisi
            // 
            this.lblKarakterSayisi.AutoSize = true;
            this.lblKarakterSayisi.Location = new System.Drawing.Point(50, 525);
            this.lblKarakterSayisi.Name = "lblKarakterSayisi";
            this.lblKarakterSayisi.Size = new System.Drawing.Size(179, 17);
            this.lblKarakterSayisi.TabIndex = 1;
            this.lblKarakterSayisi.Text = "Kalan Karakter Sayısı : ";
            // 
            // txtToDo
            // 
            this.txtToDo.AllowDrop = true;
            this.txtToDo.ContextMenuStrip = this.contextMenuStrip1;
            this.txtToDo.Location = new System.Drawing.Point(50, 75);
            this.txtToDo.MaxLength = 140;
            this.txtToDo.Multiline = true;
            this.txtToDo.Name = "txtToDo";
            this.txtToDo.Size = new System.Drawing.Size(250, 440);
            this.txtToDo.TabIndex = 0;
            this.txtToDo.TextChanged += new System.EventHandler(this.txtToDo_TextChanged);
            this.txtToDo.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtToDo_DragDrop);
            this.txtToDo.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtToDo_DragEnter);
            this.txtToDo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtToDo_MouseDown);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.Color.Beige;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtDoing);
            this.panel2.Location = new System.Drawing.Point(350, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 600);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(160, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doing";
            // 
            // txtDoing
            // 
            this.txtDoing.AllowDrop = true;
            this.txtDoing.ContextMenuStrip = this.contextMenuStrip1;
            this.txtDoing.Location = new System.Drawing.Point(58, 75);
            this.txtDoing.MaxLength = 140;
            this.txtDoing.Multiline = true;
            this.txtDoing.Name = "txtDoing";
            this.txtDoing.ReadOnly = true;
            this.txtDoing.Size = new System.Drawing.Size(250, 440);
            this.txtDoing.TabIndex = 0;
            this.txtDoing.TextChanged += new System.EventHandler(this.txtDoing_TextChanged);
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtDone);
            this.panel3.Location = new System.Drawing.Point(700, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 600);
            this.panel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(160, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Done";
            // 
            // txtDone
            // 
            this.txtDone.AllowDrop = true;
            this.txtDone.ContextMenuStrip = this.contextMenuStrip1;
            this.txtDone.Location = new System.Drawing.Point(60, 75);
            this.txtDone.MaxLength = 140;
            this.txtDone.Multiline = true;
            this.txtDone.Name = "txtDone";
            this.txtDone.ReadOnly = true;
            this.txtDone.Size = new System.Drawing.Size(250, 440);
            this.txtDone.TabIndex = 0;
            this.txtDone.TextChanged += new System.EventHandler(this.txtDone_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopyalaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 26);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // KanbanTahtasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 601);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KanbanTahtasi";
            this.Text = "KanbanTahtasi";
            this.Load += new System.EventHandler(this.KanbanTahtasi_Load);
            this.MouseHover += new System.EventHandler(this.KanbanTahtasi_MouseHover);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtToDo;
        private System.Windows.Forms.Label lblKarakterSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDoing;
        private System.Windows.Forms.TextBox txtDone;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
    }
}