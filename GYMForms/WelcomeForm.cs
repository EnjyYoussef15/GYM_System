using GYM;

namespace GYMForms
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            Hide();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CoachAddForm cf = new CoachAddForm();
            cf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CoachForm sf = new CoachForm();
            sf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CoachSearchForm cf = new CoachSearchForm();
            cf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WorkerAddForm cf = new WorkerAddForm();
            cf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            WorkerForm sf = new WorkerForm();
            sf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            WorkerSearchForm workerSearchForm = new WorkerSearchForm();
            workerSearchForm.Show();
        }
    }
}