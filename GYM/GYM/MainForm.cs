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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        bool b = true;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                menuStrip1.Dock = DockStyle.Left;
                b = false;
                toolStripMenuItem1.Image = Image.FromFile(@"D:\Corses\iTi\00. Project C#\GYM\Imgs\arrow-right.png");
            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
                toolStripMenuItem1.Image = Image.FromFile(@"D:\Corses\iTi\00. Project C#\GYM\Imgs\down-arrow.png");

            }

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            

        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMemberForm NM = new NewMemberForm();
            NM.Show();
        }

        private void traineeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Show();
            SearchTraineeForm searchTraineeForm = new SearchTraineeForm();
            searchTraineeForm.Show();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquipmentForm equipmentForm = new EquipmentForm();  
            equipmentForm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
