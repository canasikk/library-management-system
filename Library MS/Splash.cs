using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_MS
{
    public partial class Splash : Form
    {
        int x = 1;
        ManageSystem ms = new ManageSystem();
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            Mutex Mtx = new Mutex(false, "SINGLE_INSTANCE_APP_MUTEX");
            if (Mtx.WaitOne(0, false) == false)
            {
                Mtx.Close();
                Mtx = null;
                Application.Exit();

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (x <= 3)
            {
                timer1.Stop();
                if (Properties.Settings.Default.dbBool == false)
                {
                    DBSettings dbSet = new DBSettings();
                    dbSet.Show();
                    this.Hide();

                }
                else
                {
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                }
            }
            else {

                x++;
                timer1.Stop();
            }
        }

        private void dBCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ms.dbCheck() == true)
            {
                MessageBox.Show("Connected");
            }
            else {
                MessageBox.Show("Failed");
            }
        }

        private void netCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Net.Sockets.TcpClient cl = new System.Net.Sockets.TcpClient("www.google.com.tr", 80);
                cl.Close();
                MessageBox.Show("Connection Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
