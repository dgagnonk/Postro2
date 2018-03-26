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

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            string list = "";

            if (optFullList.Checked)
            {
                DbDataReader reader = await DatabaseManager.CommandWithReader("SELECT * FROM Posters ORDER BY PosterTitle;");
                while (await reader.ReadAsync())
                {
                    // 1: title -- 2: condition -- 3: count -- 4: ID     

                    list += reader.GetValue(0).ToString() + " -- [Count: " + reader.GetValue(2).ToString() + "]" + Environment.NewLine;

                }

                SaveFileDialog sfs = new SaveFileDialog();
                sfs.Filter = "Text files (*.txt)|*.txt";
                if (sfs.ShowDialog() == DialogResult.Cancel) return;

                File.WriteAllText(sfs.FileName, list);
            }
            else if (optAboveZero.Checked)
            {
                DbDataReader reader = await DatabaseManager.CommandWithReader("SELECT * FROM Posters WHERE Count > 0 ORDER BY PosterTitle;");
                while (await reader.ReadAsync())
                {
                    // 1: title -- 2: condition -- 3: count -- 4: ID     

                    list += reader.GetValue(0).ToString() + Environment.NewLine;

                }

                SaveFileDialog sfs = new SaveFileDialog();
                sfs.Filter = "Text files (*.txt)|*.txt";
                if (sfs.ShowDialog() == DialogResult.Cancel) return;

                File.WriteAllText(sfs.FileName, list);
            }
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
    }
}
