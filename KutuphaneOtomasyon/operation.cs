using KutuphaneOtomasyon.Members;
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
    public partial class operation : Form
    {
        public operation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (addbtn.Visible == false)
            {
                addbtn.Visible = true;
                updatebtn.Visible = true;
                deletebtn.Visible = true;
            }
            else
            {
                addbtn.Visible = false;
                updatebtn.Visible = false;
                deletebtn.Visible = false;
            }

            membersList membersform = new membersList();
            membersform.MdiParent = this;
            membersform.Show();

        }

        private void operation_Load(object sender, EventArgs e)
        {
            addbtn.Visible = false;
            updatebtn.Visible = false;
            deletebtn.Visible = false;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            addMember addMember = new addMember();
            addMember.MdiParent = this;
            addMember.Show();

            
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            deleteMember deleteMember = new deleteMember();
            deleteMember.MdiParent = this;
            deleteMember.Show();
        }
    }
}
