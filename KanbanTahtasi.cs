using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanBoard
{
    public partial class KanbanTahtasi : Form
    {
        public KanbanTahtasi()
        {
            InitializeComponent();
            //ControlExtension.Draggable(txtNotEkle, true);
        }

        private void KanbanTahtasi_MouseHover(object sender, EventArgs e)
        {
            //txtNotEkle.BringToFront();
            //panel2.SendToBack();
            //panel3.SendToBack();
        }

        private void txtToDo_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
            tb.DoDragDrop(tb.Text, DragDropEffects.Copy);
        }

        private void txtToDo_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
            TextBox tb = (TextBox)sender;
            tb.Text = "";
        }

        private void txtToDo_DragEnterCopy(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
            TextBox tb = (TextBox)sender;
        }

        private void txtToDo_DragDrop(object sender, DragEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = (string)e.Data.GetData(DataFormats.Text);
            
        }

        private void txtToDo_TextChanged(object sender, EventArgs e)
        {
            KarakterSayisi(txtToDo.TextLength, txtToDo.MaxLength);
        }

        private void KarakterSayisi(int textLength,int maxLength)
        {
            int karakterSiniri = textLength;
            lblKarakterSayisi.Text = "Kalan Karakter Sayısı : " + (maxLength - textLength).ToString();
            if (karakterSiniri == 140)
            {
                MessageBox.Show("Max karakter sayısına ulaştınız");
            }
        }

        private void KanbanTahtasi_Load(object sender, EventArgs e)
        {
            txtDoing.DragEnter += new DragEventHandler(txtToDo_DragEnter);
            txtDoing.MouseDown += new MouseEventHandler(txtToDo_MouseDown);
            txtDoing.DragDrop += new DragEventHandler(txtToDo_DragDrop);

            txtDone.DragEnter += new DragEventHandler(txtToDo_DragEnter);
            txtDone.MouseDown += new MouseEventHandler(txtToDo_MouseDown);
            txtDone.DragDrop += new DragEventHandler(txtToDo_DragDrop);
        }

        private void txtDoing_TextChanged(object sender, EventArgs e)
        {
            KarakterSayisi(txtDoing.TextLength, txtDoing.MaxLength);
            if (!string.IsNullOrEmpty(txtDoing.Text))
            {
                txtDoing.ReadOnly = false;
            }
            else
            {
                txtDoing.ReadOnly = true;
            }
        }

        private void txtDone_TextChanged(object sender, EventArgs e)
        {
            KarakterSayisi(txtDone.TextLength, txtDone.MaxLength);
            if (!string.IsNullOrEmpty(txtDone.Text))
            {
                txtDone.ReadOnly = false;
            }
            else
            {
                txtDone.ReadOnly = true;
            }
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDoing.DragEnter += new DragEventHandler(txtToDo_DragEnterCopy);
            txtDoing.MouseDown += new MouseEventHandler(txtToDo_MouseDown);
            txtDoing.DragDrop += new DragEventHandler(txtToDo_DragDrop);

            txtDone.DragEnter += new DragEventHandler(txtToDo_DragEnterCopy);
            txtDone.MouseDown += new MouseEventHandler(txtToDo_MouseDown);
            txtDone.DragDrop += new DragEventHandler(txtToDo_DragDrop);

        }
    }
}
