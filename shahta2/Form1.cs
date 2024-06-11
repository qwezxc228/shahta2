namespace shahta2
{
    public partial class Form1 : Form
    {
        FormMine formIM;
        Mine IronMine;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            IronMine = new();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            formIM = new();
            formIM.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            IronMine.Tick();
            if (formIM != null)
            {
                formIM.Show(IronMine.Ore, IronMine.Worker);
            }
        }
    }
}
