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
    public partial class UserPanel : UserControl
    {
        ManageSystem ms = new ManageSystem();
        public UserPanel()
        {
            InitializeComponent();
        }
        private void showRefresh()
        {
           
            DataTable tab = new DataTable();
            tab.Clear();
            MySqlDataAdapter adtr = new MySqlDataAdapter("SELECT * FROM members", ms.conn);
            adtr.Fill(tab);
            dgUser.DataSource = tab;

        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            showRefresh();
            dgUser.Columns[0].ReadOnly = true;
            dgUser.Columns[0].Visible = false;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showRefresh();

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
                        if (ms.delMember(Convert.ToInt16(dgUser.CurrentRow.Cells[0].Value.ToString())) == true)
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

        private void dgUser_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("update?", "Oops!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (ms.dbCheck() == true)
                    {
                        if (ms.updateMember(Convert.ToInt16(dgUser.CurrentRow.Cells[0].Value),
                            dgUser.CurrentRow.Cells[1].Value.ToString(),
                            dgUser.CurrentRow.Cells[2].Value.ToString(),
                            dgUser.CurrentRow.Cells[3].Value.ToString(),
                            dgUser.CurrentRow.Cells[4].Value.ToString(),
                            dgUser.CurrentRow.Cells[5].Value.ToString()) == true)
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
