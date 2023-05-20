using Fitness;
using GYMForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace GYM
{

    public partial class MainForm : Form
    {

        LoginForm lg = new LoginForm();
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        bool b = true;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                menuStrip1.Dock = DockStyle.Left;
                b = false;
                toolStripMenuItem1.Image = Image.FromFile(@"D:\ITI-DotNet\Project C#\arrow-right.jpg");
            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
                toolStripMenuItem1.Image = Image.FromFile(@"D:\ITI-DotNet\Project C#\down-arrow.jpg");

            }

        }

        private void MainPage_Load(object sender, EventArgs e)
        {


        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraineeForm addtrainee = new TraineeForm();
            addtrainee.Show();
        }

        private void traineeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm trainnesearch = new SearchForm();
            trainnesearch.Show();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipment eq = new Equipment();
            eq.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lg.Show();
            Hide();
        }

        private void coutchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoachAddForm caf = new CoachAddForm();
            caf.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkerAddForm worker = new WorkerAddForm();
            worker.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            equipment_2 eqsearch = new equipment_2();
            eqsearch.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 eqDelete = new Form1();
            eqDelete.Show();
        }

        private void coachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoachSearchForm cf = new CoachSearchForm();
            cf.Show();
        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WorkerSearchForm ws = new WorkerSearchForm();
            ws.Show();
        }

        private void coachToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CoachForm cf = new CoachForm();
            cf.Show();
        }

        private void emplyeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkerForm wf = new WorkerForm();
            wf.Show();
        }

        private void traineeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteAndUpdate_Form dUPtra = new DeleteAndUpdate_Form();
            dUPtra.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
