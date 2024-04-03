namespace pryLUCASSAMPO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                using(Graphics objetoloco = this.CreateGraphics())
                {
                    objetoloco.FillEllipse(Brushes.Black, e.X, e.Y, 5, 5);
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}