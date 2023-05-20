using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM
{
    public partial class NewMemberForm : Form
    {
        public NewMemberForm()
        {
            InitializeComponent();
        }

        private void btnTraineeReset_Click(object sender, EventArgs e)
        {
            txtTraineeID.Text = "";
            txtTraineeName.Text = "";
            txtTraineeAge.Text = "";
            txtTraineeClass.Text = "";
            txtTraineePhone.Text = "";
            txtTraineeSubscriptionFee.Text = "";
            txtDurationUpDown.Value = 0;
        }
    }
}
