
namespace KanbanBoard
{
    partial class KanbanTahtasi2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstToDo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstDoing = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstDone = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.lstToDo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 600);
            this.panel1.TabIndex = 0;
            // 
            // lstToDo
            // 
            this.lstToDo.FormattingEnabled = true;
            this.lstToDo.ItemHeight = 16;
            this.lstToDo.Location = new System.Drawing.Point(50, 75);
            this.lstToDo.Name = "lstToDo";
            this.lstToDo.Size = new System.Drawing.Size(250, 420);
            this.lstToDo.TabIndex = 3;
            this.lstToDo.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lstToDo.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            this.lstToDo.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lstToDo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(150, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ToDo";
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.Color.Beige;
            this.panel2.Controls.Add(this.lstDoing);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(350, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 600);
            this.panel2.TabIndex = 0;
            // 
            // lstDoing
            // 
            this.lstDoing.FormattingEnabled = true;
            this.lstDoing.ItemHeight = 16;
            this.lstDoing.Location = new System.Drawing.Point(50, 75);
            this.lstDoing.Name = "lstDoing";
            this.lstDoing.Size = new System.Drawing.Size(250, 420);
            this.lstDoing.TabIndex = 3;
            this.lstDoing.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lstDoing.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            this.lstDoing.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lstDoing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(150, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doing";
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.Controls.Add(this.lstDone);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(700, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 600);
            this.panel3.TabIndex = 0;
            // 
            // lstDone
            // 
            this.lstDone.FormattingEnabled = true;
            this.lstDone.ItemHeight = 16;
            this.lstDone.Location = new System.Drawing.Point(50, 75);
            this.lstDone.Name = "lstDone";
            this.lstDone.Size = new System.Drawing.Size(250, 420);
            this.lstDone.TabIndex = 3;
            this.lstDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lstDone.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            this.lstDone.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lstDone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(150, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Done";
            // 
            // KanbanTahtasi2
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
            this.Name = "KanbanTahtasi2";
            this.Text = "KanbanTahtasi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KanbanTahtasi2_FormClosing);
            this.Load += new System.EventHandler(this.KanbanTahtasi2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstToDo;
        private System.Windows.Forms.ListBox lstDoing;
        private System.Windows.Forms.ListBox lstDone;
    }
}