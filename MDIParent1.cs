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
    public partial class MDIParent1 : Form
    {
        Form frm = new Form();


        public MDIParent1()
        {
            InitializeComponent();
            //todoForm.Location = new Point(0, 0);
            //doingForm.Location = new Point(550,200 );
            //doneForm.Location = new Point(0, (this.Height + doingForm.Height));
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            //ToDo todoForm = new ToDo();
            //Doing doingForm = new Doing();
            //Done doneForm = new Done();

            //FormGetir(todoForm, 0, 0);
            //FormGetir(doingForm, 400, 0);
            //FormGetir(doneForm, 800, 0);
        }

        public void FormGetir(Form frm)
        {
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }


        private void kanbanTahtasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KanbanTahtasi frmKanban = new KanbanTahtasi();
            FormGetir(frmKanban);
        }

        private void notEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotEkle frmNotEkle = new NotEkle();
            FormGetir(frmNotEkle);
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //private void OpenFile(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        //    openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        //    if (openFileDialog.ShowDialog(this) == DialogResult.OK)
        //    {
        //        string FileName = openFileDialog.FileName;
        //    }
        //}

        //private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        //    saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        //    if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
        //    {
        //        string FileName = saveFileDialog.FileName;
        //    }
        //}
    }
}
