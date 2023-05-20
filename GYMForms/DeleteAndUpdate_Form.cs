using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness
{
    public partial class DeleteAndUpdate_Form : Form
    {
        public DeleteAndUpdate_Form()
        {
            InitializeComponent();
            grdTraineeUpdate.AutoGenerateColumns = true;
            grdTraineeUpdate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDeleteAndUpdate_Update_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteAndUpdate_Reset_Click(object sender, EventArgs e)
        {
            txtDeleteAndUpdateClass.Text = "";
            txtDeleteAndUpdateDurationUpDown.TabIndex = 0;
            txtDeleteAndUpdateAge.Text = "";
            txtDeleteAndUpdateID.Text = "";
            txtDeleteAndUpdateName.Text = "";
            txtDeleteAndUpdatePhone.Text = "";
            txtDeleteAndUpdateSubFee.Text = "";
        }

        private void btnDeleteAndUpdate_Back_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void lblTraineeClass_Click(object sender, EventArgs e)
        {

        }
    }
}
