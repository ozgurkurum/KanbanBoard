using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanBoard
{
    public partial class KanbanTahtasi2 : Form
    {
        //private readonly NotEkle _gelenNotlar;
        List<string> jsonList = new List<string>();

        public KanbanTahtasi2(string text)
        {
            InitializeComponent();
            //_gelenNotlar = gelenNotlar;
            //lstToDo.Items.Add(_gelenNotlar.gorevlerListesi);
            lstToDo.AllowDrop = true;
            lstDoing.AllowDrop = true;
            lstDone.AllowDrop = true;

            //string json = File.ReadAllText("kanbanTahtasiVeri.json");
            //jsonList = JsonConvert.DeserializeObject<List<string>>(json); ;
        }
        private void KanbanTahtasi2_Load(object sender, EventArgs e)
        {
            //NotEkle n = new NotEkle();
            //foreach (var item in n.gidenListe)
            //{
            //    lstToDo.Items.Add(item);
            //}
            lstToDo.Items.Add(NotEkle.gidenText);
        }

        private void listBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
                e.Effect = DragDropEffects.Move;
        }

        private void listBox_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
                e.Effect = DragDropEffects.All;
        }

        ListBox dragLst;
        ListBox dropLst;
        int Listbox_Index = 0;

        private void listBox_MouseDown(object sender, MouseEventArgs e)
        {
            dragLst = sender as ListBox;
            Point unknownLocation = new Point(e.X, e.Y);
            Listbox_Index = dragLst.IndexFromPoint(unknownLocation);
            if (Listbox_Index == -1)
                return;
            if (e.Button == MouseButtons.Left)
                dragLst.DoDragDrop(dragLst.Items[Listbox_Index].ToString(), DragDropEffects.All);
        }

        private void listBox_DragDrop(object sender, DragEventArgs e)
        {
            dropLst = sender as ListBox;
            dropLst.Items.Add(dragLst.Items[Listbox_Index]);
            dragLst.Items.Remove(dragLst.Items[Listbox_Index]);
        }

        private void KanbanTahtasi2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //string json = JsonConvert.SerializeObject(jsonList);
            //File.WriteAllText("kanbanTahtasiVeri.json", json);
        }
    }
}
