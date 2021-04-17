namespace FigurasDDA
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
   public class Graficos
    {
        public void lineaDDA(int x1, int y1, int x2, int y2, PictureBox p1)
        {
            int dx, dy, longitud , k;
            float x_inc, y_inc, x, y;

            dx = x2 - x1;
            dy = y2 - y1;

            if (Math.Abs(dx) > Math.Abs(dy))
                longitud = Math.Abs(dx);
            else
                longitud = Math.Abs(dy);

            x_inc = (float)dx / longitud;
            y_inc = (float)dy / longitud;

            x = x1;
            y = y1;

            Bitmap bmp = new Bitmap(p1.ClientSize.Width,
            p1.ClientSize.Height);
            bmp.SetPixel((int)x, (int)y, Color.Gray);

            for (k = 1; k < longitud + 1; k++)
            {
                x = x + x_inc;
                y = y + y_inc;

                bmp.SetPixel((int)x, (int)y, Color.Gray);
            }
            Graphics g = p1.CreateGraphics();
            g.DrawImage(bmp, 0, 0, bmp.Width, bmp.Height);
        }

        public void lineaDDA(int x1, int y1, int x2, int y2, PictureBox p1, Color color)
        {
            int dx, dy, longitud, k;
            float x_inc, y_inc, x, y;

            dx = x2 - x1;
            dy = y2 - y1;

            if (Math.Abs(dx) > Math.Abs(dy))
                longitud = Math.Abs(dx);
            else
                longitud = Math.Abs(dy);

            x_inc = (float)dx / longitud;
            y_inc = (float)dy / longitud;

            x = x1;
            y = y1;

            Bitmap bmp = new Bitmap(p1.ClientSize.Width,
            p1.ClientSize.Height);
            bmp.SetPixel((int)x, (int)y, Color.Red);

            for (k = 1; k < longitud + 1; k++)
            {
                x = x + x_inc;
                y = y + y_inc;

                bmp.SetPixel((int)x, (int)y, color);
            }
            Graphics g = p1.CreateGraphics();
            g.DrawImage(bmp, 0, 0, bmp.Width, bmp.Height);
        }
    }
}
