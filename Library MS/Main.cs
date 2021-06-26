using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_MS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        ManageSystem ms = new ManageSystem();

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 200 && panel1.Height == 522)
            {
                panel1.Size = new Size(50, 522);
                btnMenu.Location = new Point(6, 11);
                linkLabel2.Visible = false;
            }
            else
            {
                panel1.Size = new Size(200, 522);
                btnMenu.Location = new Point(151, 11);
                linkLabel2.Visible = true;
            }

            
        }

        private void btnRentList_Click(object sender, EventArgs e)
        {
            rentPanel1.Visible = true;
            rentPanel1.BringToFront();
            rentPanel1.Invalidate();
            rentPanel1.Refresh();
            bookPanel1.Visible = false;
            userPanel1.Visible = false;
            addRent1.Visible = false;
            addBook1.Visible = false;
            addUser1.Visible = false;

        }

        private void btnBookList_Click(object sender, EventArgs e)
        {
            rentPanel1.Visible = false;
            bookPanel1.Visible = true;
            bookPanel1.BringToFront();
            bookPanel1.Refresh();
            userPanel1.Visible = false;
            addRent1.Visible = false;
            addBook1.Visible = false;
            addUser1.Visible = false;
            addUser1.Visible = false;
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            rentPanel1.Visible = false;
            bookPanel1.Visible = false;
            userPanel1.Visible = true;
            userPanel1.BringToFront();
            addRent1.Visible = false;
            addBook1.Visible = false;
            addUser1.Visible = false;
        }

        private void btnAddRent_Click(object sender, EventArgs e)
        {
            rentPanel1.Visible = false;
            bookPanel1.Visible = false;
            userPanel1.Visible = false;
            addRent1.Visible = true;
            addRent1.BringToFront();
            addBook1.Visible = false;
            addUser1.Visible = false;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            rentPanel1.Visible = false;
            bookPanel1.Visible = false;
            userPanel1.Visible = false;
            addRent1.Visible = false;
            addBook1.Visible = true;
            addBook1.BringToFront();
            addUser1.Visible = false;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            rentPanel1.Visible = false;
            bookPanel1.Visible = false;
            userPanel1.Visible = false;
            addRent1.Visible = false;
            addBook1.Visible = false;
            addUser1.BringToFront();
            addUser1.Visible = true;
        }

        private void btnDb_Click(object sender, EventArgs e)
        {
            DBSettings dbs = new DBSettings();
            dbs.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/canasikk");
        }

      
         

       
    }
}
