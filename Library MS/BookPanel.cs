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
    public partial class BookPanel : UserControl
    {
        ManageSystem ms = new ManageSystem();
        public BookPanel()
        {
            InitializeComponent();
        }
        private void showRefresh()
        {
            
            DataTable tab = new DataTable();
            tab.Clear();
            MySqlDataAdapter adtr = new MySqlDataAdapter("SELECT * FROM books", ms.conn);
            adtr.Fill(tab);
            dgBook.DataSource = tab;
            
        }
        private void BookPanel_Load(object sender, EventArgs e)
        {
            
            showRefresh();
            dgBook.Columns[0].ReadOnly = true;
            dgBook.Columns[0].Visible = false;
            
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
                        if (ms.delBook(Convert.ToInt16(dgBook.CurrentRow.Cells[0].Value.ToString())) == true)
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

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showRefresh();
        }

        private void dgBook_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
         DialogResult dialogResult = MessageBox.Show("update?", "Oops!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (ms.dbCheck() == true)
                    {
                        if (ms.updateBook(Convert.ToInt16(dgBook.CurrentRow.Cells[0].Value),
                            dgBook.CurrentRow.Cells[1].Value.ToString(),
                            dgBook.CurrentRow.Cells[2].Value.ToString(),
                            dgBook.CurrentRow.Cells[3].Value.ToString(),
                            dgBook.CurrentRow.Cells[4].Value.ToString(),
                            dgBook.CurrentRow.Cells[5].Value.ToString(),
                            dgBook.CurrentRow.Cells[6].Value.ToString()) == true)
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
