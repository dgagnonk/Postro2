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

        private Condition condition;


        // This constructor is used if a poster is being edited
        public frmInfo(string postertitle, Condition condition, string id, int count)
        {
            InitializeComponent();

            txtTitle.Text = postertitle;

            this.condition = condition;
            lstCondition.SelectedIndex = (int)condition;

            txtPricing.LostFocus += TxtPricing_LostFocus;

            nudCount.Value = count;
            lblID.Text = "ID: " + id;
            guid = id;
        }

        //DOESN'T WORK
        private void TxtPricing_LostFocus(object sender, EventArgs e)
        {
            double value;
            if (Double.TryParse(txtPricing.Text, out value))
                txtPricing.Text = string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            else
                txtPricing.Text = string.Empty;
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

            poster = new Poster(txtTitle.Text, (Condition)lstCondition.SelectedIndex, guid, (int)nudCount.Value, 0, Convert.ToDouble(txtPricing.Text));
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;   
        }
    }
}
