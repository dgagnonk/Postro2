using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Postro2
{
    public partial class frmInfo : Form
    {

        private Poster poster;
        public Poster _Poster { get { return poster; } }

        private string guid;


        // This constructor is used if a poster is being edited
        public frmInfo(string postertitle, Condition condition, string id, int count)
        {
            InitializeComponent();

            txtTitle.Text = postertitle;
            lstCondition.SelectedIndex = (int)condition;
            nudCount.Value = count;
            lblID.Text = "ID: " + id;
            guid = id;
        }

        // This constructor is used if it's a new poster being added
        public frmInfo()
        {
            InitializeComponent();

            guid = Guid.NewGuid().ToString();
            lblID.Text = "ID: " + guid;

            nudCount.Value = 1;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           
            if ((int)nudCount.Value <= 0)
            {
                var result = MessageBox.Show("Poster count is under or equal to zero. Are you sure you want to do this?", "Count", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (result != DialogResult.Yes) return;
            }

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                txtTitle.Text = "N/A";
            }

            if (lstCondition.SelectedIndex == -1)
            {
                lstCondition.SelectedIndex = 2;
            }

            poster = new Poster(txtTitle.Text, (Condition)lstCondition.SelectedIndex, guid, (int)nudCount.Value);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;   
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
            lstCondition.SelectedIndex = 2;
        }
    }
}
