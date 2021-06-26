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
    public partial class DBSettings : Form
    {
        public DBSettings()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.server = txtServer.Text;
            Properties.Settings.Default.database = txtDatabase.Text;
            Properties.Settings.Default.userid = txtUid.Text;
            Properties.Settings.Default.password = txtPw.Text;
            Properties.Settings.Default.dbBool = true;
            Properties.Settings.Default.Save();

            Main main = new Main();
            main.Show();
            this.Hide();

        }

        private void btnExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void DBSettings_Load(object sender, EventArgs e)
        {
            txtServer.Text= Properties.Settings.Default.server;
            txtDatabase.Text= Properties.Settings.Default.database;
            txtUid.Text=Properties.Settings.Default.userid ;
            txtPw.Text = Properties.Settings.Default.password;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Properties.Settings.Default.server = null;
            Properties.Settings.Default.database = null;
            Properties.Settings.Default.userid = null;
            Properties.Settings.Default.password = null;
            Properties.Settings.Default.dbBool = false;
            Properties.Settings.Default.msg = false;
            Properties.Settings.Default.Save();
            Application.Exit();
        }
    }
}
