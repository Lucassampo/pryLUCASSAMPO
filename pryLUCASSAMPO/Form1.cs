namespace pryLUCASSAMPO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            archivoImagen = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }
        public Bitmap archivoImagen;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string fechaDia = "", fechaHora = "", fechaMes = "", fechaAño = "", fechaMinutos = "", fechaHoy = "";
            fechaDia = DateTime.Now.Day.ToString();
            fechaHora = DateTime.Now.Hour.ToString();
            fechaMes = DateTime.Now.Month.ToString();
            fechaAño = DateTime.Now.Year.ToString();
            fechaMinutos = DateTime.Now.Minute.ToString();
            fechaHoy = fechaAño + "." + fechaMes + "." + fechaDia + "" + fechaHora + "." + fechaMinutos;
            archivoImagen.Save(@"../../../" + "Firma/" + fechaHoy + ".jpg");
            MessageBox.Show("Guardado");
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.Location.ToString();
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics g = Graphics.FromImage(archivoImagen))
                {
                    g.FillEllipse(Brushes.Black, e.X, e.Y, 5, 5);
                }
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(archivoImagen, Point.Empty);
        }
    }
}