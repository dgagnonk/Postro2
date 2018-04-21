using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Common;

namespace Postro2
{
    public partial class frmAdvanced : Form
    {
        public frmAdvanced()
        {
            InitializeComponent();
        }

        private void lnkDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This option will delete the database file, clearing all data. Postro2 will need to be restarted.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lnkDump_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This option will dump the contents of the database into a readable text file. The text file will open in your default text editor immediately after dumping is complete. This is a non-destructive process and can be performed safely.", "Dump", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete the database file? All data will be lost. This action is irreversable.", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (result != DialogResult.Yes) return;

            try
            {
                File.Delete(DatabaseManager.DatabaseFilename);
                MessageBox.Show("Database deleted successfully. Closing Postro.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete database file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private string AssembleQueryColString(List<string> columns)
        {
            string ret = columns[0];
            if (columns.Count >= 2)
            {
                for (int i = 1; i < columns.Count; i++)
                {
                    ret += (", " + columns[i]);
                }
            }

            return ret;
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            bool _continue = false;

            foreach(Control c in gbInclude.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked) _continue = true;
                }
            }

            if (!_continue)
            {
                MessageBox.Show("At least 1 field must be included to generate a list.", "Include", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string list = "";
            string query = "";
            List<string> queryColumns = new List<string>();

            if (optFullList.Checked) query = "SELECT [QUERYCOLS] FROM Posters ORDER BY PosterTitle;";
            else if(optAboveZero.Checked) query = "SELECT [QUERYCOLS] FROM Posters WHERE Count > 0 ORDER BY PosterTitle;";

            if (chkTitle.Checked) queryColumns.Add("PosterTitle");
            if (chkCondition.Checked) queryColumns.Add("Condition");
            if (chkCount.Checked) queryColumns.Add("Count");
            if (chkID.Checked) queryColumns.Add("ID");
            if (chkHolds.Checked) queryColumns.Add("Holds");
            if (chkPrice.Checked) queryColumns.Add("Price");

            string finalQueryColumns = AssembleQueryColString(queryColumns);
            query = query.Replace("[QUERYCOLS]", finalQueryColumns);

            DbDataReader reader = await DatabaseManager.CommandWithReader(query);

            while(await reader.ReadAsync())
            {              
                int counter = 0;
                foreach(string col in queryColumns)
                {
                    list += (col + ": " + reader.GetValue(counter) + Environment.NewLine);
                    counter++;
                }

                list += "------------------------------------------" + Environment.NewLine;
            }

            SaveFileDialog sfs = new SaveFileDialog();
            sfs.Filter = "Text files (*.txt)|*.txt";
            if (sfs.ShowDialog() == DialogResult.Cancel) return;

            File.WriteAllText(sfs.FileName, list);

        }

        private async void btnDump_Click(object sender, EventArgs e)
        {
            string list = "";

            DbDataReader reader = await DatabaseManager.CommandWithReader("SELECT * FROM Posters WHERE Count > 0 ORDER BY PosterTitle;");
            while (await reader.ReadAsync())
            {
                // 1: title -- 2: condition -- 3: count -- 4: ID     

                list += string.Format("[Title: \"{0}\" - Condition: {1} - Count: {2} - ID: {3}]{4}", reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), Environment.NewLine);

            }

            SaveFileDialog sfs = new SaveFileDialog();
            sfs.Filter = "Text files (*.txt)|*.txt";
            if (sfs.ShowDialog() == DialogResult.Cancel) return;

            File.WriteAllText(sfs.FileName, list);
        }

        private void lnkConsole_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new frmDevConsole()).Show();
        }
    }
}
