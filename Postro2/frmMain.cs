using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace Postro2
{
    public partial class frmMain : Form
    {
        /*
         * List generation cleaner (1)
         * Auto email send (3)
         * Holds (2)
         * Pricing (for special edition posters and stuff) (3)
         * Online database
         * Bug: quality doesn't update when editing poster (combobox should read existing poster's quality) (1)
         * Add sell to client list and button on main screen (3)
         * Update server
         */


        /* TODO:
         * Pricing on edit window
         * Be able to add holds
         */

        DataSet dataset;
        string databasename = "posters.sqlite";
        bool connected = false;

        string exmessage = "";

        public frmMain()
        {
            InitializeComponent();

            dataset = new DataSet("posters");

            try
            {
                DatabaseManager.Connect(databasename);
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Connection error: Click for details.";
                exmessage = ex.Message;
                connected = false;
                return;
            }

            connected = true;

            lblStatus.ForeColor = Color.Green;
            lblStatus.Text = "Connected to database";

            DatabaseManager.Command("CREATE TABLE IF NOT EXISTS Posters (PosterTitle VARCHAR(255), Condition VARCHAR(70), Count INT, ID VARCHAR(255), Holds INT, Price INT);");

            dgvData.SelectionChanged += DgvData_SelectionChanged;
            txtSearch.GotFocus += TxtSearch_GotFocus;

            DisplayAllRows();
        }

        private void TxtSearch_GotFocus(object sender, EventArgs e)
        {
            if (txtSearch.Focused) return;
            else txtSearch.SelectAll();
        }

        private void DgvData_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvData.SelectedCells.Count > 0)
            {
                int rowindex = dgvData.SelectedCells[0].RowIndex;
                dgvData.Rows[rowindex].Selected = true;
            }
        }

        private async void DisplayAllRows()
        {
            dgvData.Rows.Clear();
            DbDataReader reader = await DatabaseManager.CommandWithReader("SELECT * FROM Posters ORDER BY PosterTitle ASC");
            while (await reader.ReadAsync())
            {
                // 1: title -- 2: condition -- 3: count -- 4: ID -- 5: Holds -- 6: Price        
                dgvData.Rows.Add(new object[] { reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), int.Parse(reader.GetValue(5).ToString()) / 100f });
            }
        }

        private async void DisplayAllRows(string searchterm)
        {
            dgvData.Rows.Clear();
            DbDataReader reader = await DatabaseManager.CommandWithReader(string.Format("SELECT * FROM Posters WHERE PosterTitle LIKE '%{0}%'", searchterm));
            while (await reader.ReadAsync())
            {
                // 1: title -- 2: condition -- 3: count -- 4: ID -- 5: Holds -- 6: Price        
                dgvData.Rows.Add(new object[] { reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), int.Parse(reader.GetValue(5).ToString()) / 100f });
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                frmInfo infoWindow = new frmInfo();

                var result = infoWindow.ShowDialog();
                Poster poster = infoWindow._Poster;

                if ((poster = infoWindow._Poster) == null && result != DialogResult.OK) return;

                DatabaseManager.AddPosterToDB(poster);

                DisplayAllRows();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayAllRows();
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            int idcellindex = dgvData.SelectedRows[0].Cells.Count - 1; // ID is in the last column, so the cell is just the cell count in the row minus 1
            string selectedid = dgvData.SelectedRows[0].Cells[idcellindex].Value.ToString();

            string selectedtitle = dgvData.SelectedRows[0].Cells[0].Value.ToString(); // poster title is always col 1

            var result = MessageBox.Show("Are you sure you want to delete \"" + selectedtitle + "\"? This cannot be undone.", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            DatabaseManager.Command(string.Format("DELETE FROM Posters WHERE ID='{0}'", selectedid));

            DisplayAllRows();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DisplayAllRows(txtSearch.Text);


        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            DisplayAllRows();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text)) DisplayAllRows();
        }

        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            // data row: title, condition, count, id, holds, price

            if (dgvData.SelectedRows.Count > 0)
            {
                string title = dgvData.SelectedCells[0].Value.ToString();
                string id = dgvData.SelectedCells[3].Value.ToString();
                string condition = dgvData.SelectedCells[1].Value.ToString();
                int count = int.Parse(dgvData.SelectedCells[2].Value.ToString());
                double price = double.Parse(dgvData.SelectedCells[5].Value.ToString());

                Console.WriteLine(title);
                Console.WriteLine(condition);
                Console.WriteLine(count.ToString());
                Console.WriteLine(id);


                frmInfo info = new Postro2.frmInfo(title, Poster.StringToCondition(condition), id, count, price);

                if (info.ShowDialog() != DialogResult.OK) return;
                Poster poster = info._Poster;

                Console.WriteLine(poster.ToString());

                // PosterTitle, Condition, Count, ID, Holds, Price
                DatabaseManager.Command(string.Format("UPDATE Posters SET PosterTitle=\"{0}\", Condition=\"{1}\", Count={2}, Price={4} WHERE ID=\"{3}\";",
                                                        poster.Title, Poster.ConditionToString(poster.PosterCondition), poster.Count, poster.ID, (poster.Pricing * 100)));

                DisplayAllRows();

            }
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(exmessage)) return;

            MessageBox.Show(exmessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lnkIcons8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Free license requires link
            System.Diagnostics.Process.Start("https://icons8.com/android-L");
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            frmAdvanced adv = new frmAdvanced();
            adv.Show();
        }
    }
}
