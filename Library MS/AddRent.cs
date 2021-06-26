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
    public partial class AddRent : UserControl
    {
        public AddRent()
        {
            InitializeComponent();
        }
        ManageSystem ms = new ManageSystem();
        private void callUser()
        {
            cmbUser.Clear();
            MySqlCommand cmdI = new MySqlCommand("SELECT userNam,userIdNo FROM members");
            cmdI.Connection = ms.conn;
            cmdI.CommandType = CommandType.Text;

            MySqlDataReader drI;
            ms.conn.Open();
            drI = cmdI.ExecuteReader();
            while (drI.Read())
            {
                cmbUser.AddItem(drI["userIdNo"].ToString() + " / " + drI["userNam"].ToString());
            }
            ms.conn.Close();

            cmbUser.selectedIndex = 0;
            
        }
        private void callBook()
        {

            cmbBook.Clear();
            MySqlCommand cmdII = new MySqlCommand("SELECT bookTit FROM books");
            cmdII.Connection = ms.conn;
            cmdII.CommandType = CommandType.Text;

            MySqlDataReader drII;
            ms.conn.Open();
            drII = cmdII.ExecuteReader();
            while (drII.Read())
            {
                cmbBook.AddItem(drII["bookTit"].ToString());
            }
            ms.conn.Close();

            cmbBook.selectedIndex = 0;
            
        }

        private void AddRent_Load(object sender, EventArgs e)
        {
            callUser();
            callBook();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ms.dbCheck() == true)
                {
                    if (ms.addRent(cmbUser.selectedValue.ToString(), cmbBook.selectedValue.ToString(), dtDate.Value.ToShortDateString()))
                    { ms.msg1(); }
                    else { ms.msg0(); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            callUser();
            callBook();
        }
    }
}
