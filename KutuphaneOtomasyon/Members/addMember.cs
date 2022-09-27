using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon.Members
{

    

    public partial class addMember : Form
    {
        kutuphaneyeniEntities1 db = new kutuphaneyeniEntities1();

        public addMember()
        {
            InitializeComponent();
        }

        public void list()
        {
            
            var members = db.uyeler.ToList();
            dataGridView1.DataSource = members.ToList();
        }

        private void addMember_Load(object sender, EventArgs e)
        {
            list();
        }

        private void save_Click(object sender, EventArgs e)
        {
            uyeler uyeler = new uyeler();
            uyeler.uye_ad = nametxt.Text;
            uyeler.uye_soyad = surnametxt.Text;
            uyeler.uye_tc = ıdtxt.Text;
            uyeler.uye_tel = numtxt.Text;
            uyeler.uye_mail = mailtxt.Text;

            if (radioMan.Checked == true)
            {
                uyeler.uye_cinsiyet = "E";
            }
            else if (radioWoman.Checked == true)
            {
                uyeler.uye_cinsiyet = "K";
            }
            else
            {
                MessageBox.Show("Please enter the gender!!");
            }

            db.uyeler.Add(uyeler);
            db.SaveChanges();
            list();
        }
    }
}
