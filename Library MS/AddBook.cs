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
    public partial class AddBook : UserControl
    {
        public AddBook()
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
                    if (ms.addBook(txtTitle.Text, txtAuthor.Text, txtDesc.Text, txtDate.Text, txtLen.Text, txtLan.Text) == true)
                    {
                        ms.msg1();
                        txtTitle.Text = "";
                        txtAuthor.Text = "";
                        txtDesc.Text = "";
                        txtDate.Text = "";
                        txtLen.Text = "";
                        txtLan.Text = "";
                        
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

        private void AddBook_Load(object sender, EventArgs e)
        {

        }
    }
}
