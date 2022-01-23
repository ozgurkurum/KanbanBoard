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
    public partial class NotEkle : Form
    {
        public NotEkle()
        {
            InitializeComponent();
           

        }
        //public List<string> gorevlerListesi { get; set; }
        KanbanTahtasi2 frmKanban = new KanbanTahtasi2(gidenText);
        MDIParent1 frmMdi = new MDIParent1();
        public static string gidenText;
        //public IEnumerable<string> gidenListe { get; set; }
        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            gidenText = txtNotEkle.Text;
            //gidenListe.ToList().Add(gidenText);
            frmMdi.FormGetir(frmKanban);
            frmMdi.Show();
            //List<string> gorevlerListesi = new List<string>();
            //gorevlerListesi.Add(txtNotEkle.Text);
            //this.gorevlerListesi = gorevlerListesi;
        }

        private void txtNotEkle_TextChanged(object sender, EventArgs e)
        {
            int karakterSiniri = txtNotEkle.TextLength;
            lblKalanKarakterSayisi.Text = "Kalan Karakter Sayısı : " + (txtNotEkle.MaxLength - txtNotEkle.TextLength).ToString();
            if (karakterSiniri == 140)
            {
                MessageBox.Show("Max karakter sayısına ulaştınız");
            }
        }
    }
}
