namespace FigurasDDA
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graficos g = new Graficos();
        int x1, y1, x2, y2;
        Color color = Color.Black;

        private void btnNuevasC_Click(object sender, EventArgs e)
        {
            txtX1.Text = "";
            txtX2.Text = "";
            txtY1.Text = "";
            txtY2.Text = "";
        }
        private void btnColorLinea_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                color = colorDialog1.Color;
        }
        private void btnTrazarLinea_Click(object sender, EventArgs e)
        {
            this.Refresh();
            x1 = Convert.ToInt16(txtX1.Text);
            y1 = Convert.ToInt16(txtY1.Text);
            x2 = Convert.ToInt16(txtX2.Text);
            y2 = Convert.ToInt16(txtY2.Text);
            g.lineaDDA(x1, y1, x2, y2, pictureBox1, color);
        }
        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            this.Refresh();
            x1 = Convert.ToInt16(txtX1.Text);
            y1 = Convert.ToInt16(txtY1.Text);
            x2 = Convert.ToInt16(txtX2.Text);
            y2 = Convert.ToInt16(txtY2.Text);
            g.Triangulo(x1, y1, x2, y2, pictureBox1, color);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
