using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace Library_MS
{
    public partial class AddUser : UserControl
    {
        public AddUser()
        {
            InitializeComponent();
        }
        ManageSystem ms = new ManageSystem();
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ms.dbCheck() == true)
                {
                    if (ms.addMember(txtName.Text, txtId.Text, txtPhone.Text, txtMail.Text, txtAdres.Text) == true)
                    {
                        ms.msg1();
                        txtName.Text = "";
                        txtId.Text = "";
                        txtPhone.Text = "";
                        txtMail.Text = "";
                        txtAdres.Text = "";
                    }
                    else
                    {
                        ms.msg0();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}