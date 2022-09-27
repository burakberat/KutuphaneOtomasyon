using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class Form1 : Form
    {
        kutuphaneyeniEntities1 db = new kutuphaneyeniEntities1();



        public Form1()
        {
            InitializeComponent();
        }

        private void userLogin_Click(object sender, EventArgs e)
        {
            string username = userText.Text;
            string password = passwordText.Text;

            var staff = db.personeller.Where(x => x.personel_kullaniciAd.Equals(username)&& x.personel_sifre.Equals(password)).FirstOrDefault();

            if (staff == null)
            {
                MessageBox.Show("Giriş hatalı.");
            }
            else
            {
                MessageBox.Show("Giriş başarılı.");
                operation operationForm = new operation();
                operationForm.Show();
                this.Hide();
            }

        }
    }
}
