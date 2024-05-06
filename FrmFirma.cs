using System.Windows.Forms;

namespace Pryfrima
{
    public partial class FrmFirma : Form
    {

        // Declara g como una variable de instancia de la clase
        Graphics g;
        Bitmap _bitmap;
        public FrmFirma()
        {
            InitializeComponent();

            // Inicializa el bitmap con el tamaño del PictureBox
            _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            // Crea un objeto Graphics a partir del Bitmap y limpia el fondo con Color.Transparent
            g = Graphics.FromImage(_bitmap);
            g.Clear(Color.Transparent);

            // Establece el color de fondo del PictureBox a transparente
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = _bitmap;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (chkAzul.Checked == true)
                {
                    g.FillEllipse(Brushes.Blue, e.X, e.Y, 5, 5);
                }
                else if (chkNegro.Checked == true)
                {
                    g.FillEllipse(Brushes.Black, e.X, e.Y, 5, 5);
                }
                else if (chkRojo.Checked == true)
                {
                    g.FillEllipse(Brushes.Red, e.X, e.Y, 5, 5);
                }
                else if (chkAmarillo.Checked == true)
                {
                    g.FillEllipse(Brushes.Yellow, e.X, e.Y, 5, 5);
                }
                pictureBox1.Invalidate(); // Esto hace que el PictureBox se redibuje
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            DateTime ahora = DateTime.Now;
            int dia = ahora.Day;
            int hora = ahora.Hour;
            int mes = ahora.Month;
            int minuto = ahora.Minute;
            int año = ahora.Year;
            string carpeta = "Firmas";
            if (Directory.Exists(carpeta))
            {
                _bitmap.Save("firmas/fecha(" + año + "." + mes + "." + dia + ")." + hora + "." + minuto + ".png", System.Drawing.Imaging.ImageFormat.Png);
                g.Clear(Color.Transparent);
            }
            else
            {
                Directory.CreateDirectory(carpeta);
                _bitmap.Save("firmas/fecha(" + año + "." + mes + "." + dia + ")." + hora + "." + minuto + ".png", System.Drawing.Imaging.ImageFormat.Png);
                g.Clear(Color.Transparent);
            }
            // Limpia el Bitmap con Color.Transparent
            g.Clear(Color.Transparent);

            // Actualiza el PictureBox
            pictureBox1.Image = _bitmap;
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            // Limpia el Bitmap con Color.Transparent
            g.Clear(Color.Transparent);

            // Actualiza el PictureBox
            pictureBox1.Image = _bitmap;
        }

        private void FrmFirma_Load(object sender, EventArgs e)
        {

        }
    }
}