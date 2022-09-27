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
    public partial class membersList : Form
    {
        public membersList()
        {
            InitializeComponent();
        }

        public void list()
        {
            kutuphaneyeniEntities1 db = new kutuphaneyeniEntities1();
            var members = db.uyeler.ToList();
            dataGridView1.DataSource = members.ToList();
        }

        private void membersList_Load(object sender, EventArgs e)
        {
            list();
        }
    }
}
