using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Library_MS
{
    public partial class RentPanel : UserControl
    {
        ManageSystem ms = new ManageSystem();
        public RentPanel()
        {
            InitializeComponent();
        }
        private void showRefresh()
        {

            DataTable tab = new DataTable();
            tab.Clear();
            MySqlDataAdapter adtr = new MySqlDataAdapter("SELECT * FROM rents", ms.conn);
            adtr.Fill(tab);
            dgRent.DataSource = tab;

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showRefresh();
        }

        private void RentPanel_Load(object sender, EventArgs e)
        {
            
            showRefresh();
            dgRent.Columns[0].ReadOnly = true;
            dgRent.Columns[0].Visible = false;

            if (Properties.Settings.Default.msg == false)
            {
                MessageBox.Show("double click the cell to update it. delete and refresh click for right.");
                Properties.Settings.Default.msg = true;
                Properties.Settings.Default.Save();
            }
          
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete?", "Oops!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                try
                {
                    if (ms.dbCheck() == true)
                    {
                        if (ms.delRent(Convert.ToInt16(dgRent.CurrentRow.Cells[0].Value.ToString())) == true)
                        {
                            ms.msg1();
                            showRefresh();
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
}
