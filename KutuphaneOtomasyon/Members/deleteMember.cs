using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class deleteMember : Form
    {

        kutuphaneyeniEntities1 db = new kutuphaneyeniEntities1();

        public deleteMember()
        {
            InitializeComponent();
        }

        public void list()
        {

            var members = db.uyeler.ToList();
            dataGridView1.DataSource = members.ToList();
        }

        private void deleteMember_Load(object sender, EventArgs e)
        {
            list();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var member = db.uyeler.Where(x => x.uye_id == id).FirstOrDefault();

            db.uyeler.Remove(member);
            db.SaveChanges();
            list();
        }
    }
}
