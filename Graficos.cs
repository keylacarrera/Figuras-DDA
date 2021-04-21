//CLASE CONTENEDORA DEL METODO PARA DIBUJAR LA LINEA DDA
//TENEMOS 2 SOBRECARGAS, UNA PARA DIBUJAR LA LINEA NORMAL
//Y OTRA PARA DIBUJAR LA LINEA CON COLOR.

namespace FigurasDDA
{
    //IMPORTAMOS LAS LIBRERIAS A OCUPAR
    using System;
    using System.Drawing;
    using System.Windows.Forms;
   public class Graficos
    {
        //SOBRECARGA DE LINEA NORMAL
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
        //SOBRECARGA DE LINEA ON COLOR:
        //Este metodo es llamado al hacer click al boton 'Trazar linea', pues nos genera 
        //solamente una linea.
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
              
        public void TrianguloDDA(int x1, int y1, int x2, int y2, PictureBox p1, Color color)
        {
            #region DDA para linea 1
           
            int dx, dy, longitud, k, h, x3, y3;
            float x_inc, y_inc, x, y;
            
            dx = x2 - x1;
            dy = y2 - y1;
          
            h = Convert.ToInt32((x2-x1) * 0.75);
            x3 = dx / 2;
            y3 =y1 -h;
                    
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
            #endregion

            // repetir para linea 2

            #region DDA para linea 2
            dx = x3 - x2;
            dy = y3 - y2;
           
            if (Math.Abs(dx) > Math.Abs(dy))
                longitud = Math.Abs(dx);
            else
                longitud = Math.Abs(dy);

            x_inc = (float)dx / longitud;
            y_inc = (float)dy / longitud;

            x = x2;
            y = y2;

            Bitmap bmp2 = new Bitmap(p1.ClientSize.Width,
            p1.ClientSize.Height);
            bmp2.SetPixel((int)x, (int)y, Color.Red);

            for (k = 1; k < longitud + 1; k++)
            {
                x = x + x_inc;
                y = y + y_inc;

                bmp2.SetPixel((int)x, (int)y, color);
            }
            Graphics g2 = p1.CreateGraphics();
            g2.DrawImage(bmp2, 0, 0, bmp2.Width, bmp2.Height);
            #endregion

            // repetir para linea 3

            #region DDA para linea 3
            dx = x1 - x3;
            dy = y1 - y3;

            if (Math.Abs(dx) > Math.Abs(dy))
                longitud = Math.Abs(dx);
            else
                longitud = Math.Abs(dy);

            x_inc = (float)dx / longitud;
            y_inc = (float)dy / longitud;

            x = x3;
            y = y3;

            Bitmap bmp3 = new Bitmap(p1.ClientSize.Width,
            p1.ClientSize.Height);
            bmp3.SetPixel((int)x, (int)y, Color.Red);

            for (k = 1; k < longitud + 1; k++)
            {
                x = x + x_inc;
                y = y + y_inc;

                bmp3.SetPixel((int)x, (int)y, color);
            }
            Graphics g3 = p1.CreateGraphics();
            g3.DrawImage(bmp3, 0, 0, bmp3.Width, bmp3.Height);
            #endregion
        }
        public void CuadradoDDA(int x1, int y1, int x2, int y2, PictureBox p1, Color color)
        {   
            #region DDA para linea 1
          
            int dx, dy, longitud, k, d, x3, y3, x4, y4;
            float x_inc, y_inc, x, y;
            
            dx = x2 - x1;
            dy = y2 - y1;
           
            d = x2-x1;
            x3 = x2;
            y3 = y2 - d;
            x4 = x1;
            y4 = y1 - d;

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
            #endregion

            // repetir para linea 2

            #region DDA para linea 2
            dx = x3 - x2;
            dy = y3 - y2;

            if (Math.Abs(dx) > Math.Abs(dy))
                longitud = Math.Abs(dx);
            else
                longitud = Math.Abs(dy);

            x_inc = (float)dx / longitud;
            y_inc = (float)dy / longitud;

            x = x2;
            y = y2;

            Bitmap bmp2 = new Bitmap(p1.ClientSize.Width,
            p1.ClientSize.Height);
            bmp2.SetPixel((int)x, (int)y, Color.Red);

            for (k = 1; k < longitud + 1; k++)
            {
                x = x + x_inc;
                y = y + y_inc;

                bmp2.SetPixel((int)x, (int)y, color);
            }
            Graphics g2 = p1.CreateGraphics();
            g2.DrawImage(bmp2, 0, 0, bmp2.Width, bmp2.Height);
            #endregion

            // repetir para linea 3

            #region DDA para linea 3
            dx = x4 - x3;
            dy = y4 - y3;

            if (Math.Abs(dx) > Math.Abs(dy))
                longitud = Math.Abs(dx);
            else
                longitud = Math.Abs(dy);

            x_inc = (float)dx / longitud;
            y_inc = (float)dy / longitud;

            x = x3;
            y = y3;

            Bitmap bmp3 = new Bitmap(p1.ClientSize.Width,
            p1.ClientSize.Height);
            bmp3.SetPixel((int)x, (int)y, Color.Red);

            for (k = 1; k < longitud + 1; k++)
            {
                x = x + x_inc;
                y = y + y_inc;

                bmp3.SetPixel((int)x, (int)y, color);
            }
            Graphics g3 = p1.CreateGraphics();
            g3.DrawImage(bmp3, 0, 0, bmp3.Width, bmp3.Height);
            #endregion

            // repetir para linea 4

            #region DDA para linea 4
            dx = x4 - x1;
            dy = y4 - y1;

            if (Math.Abs(dx) > Math.Abs(dy))
                longitud = Math.Abs(dx);
            else
                longitud = Math.Abs(dy);

            x_inc = (float)dx / longitud;
            y_inc = (float)dy / longitud;

            x = x1;
            y = y1;

            Bitmap bmp4 = new Bitmap(p1.ClientSize.Width,
            p1.ClientSize.Height);
            bmp4.SetPixel((int)x, (int)y, Color.Red);

            for (k = 1; k < longitud + 1; k++)
            {
                x = x + x_inc;
                y = y + y_inc;

                bmp4.SetPixel((int)x, (int)y, color);
            }
            Graphics g4 = p1.CreateGraphics();
            g4.DrawImage(bmp4, 0, 0, bmp4.Width, bmp4.Height);
            #endregion
        }
        public void TrapecioDDA(int x1, int y1, int x2, int y2, PictureBox p1, Color color)
        {
            #region DDA para linea 1
           
            int dx, dy, longitud, k, d, x3, y3, x4, y4;
            float x_inc, y_inc, x, y;
            
            dx = x2 - x1;
            dy = y2 - y1;
            
            d = x2 - x1;
            x3 = Convert.ToInt32(x2 - d * 0.1);
            y3 = Convert.ToInt32(y2 - d * 0.7);
            x4 = Convert.ToInt32(x1 + d *0.1);
            y4 = Convert.ToInt32(y1 - d * 0.7); 
         
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
            #endregion

            // repetir para linea 2

            #region DDA para linea 2
            dx = x3 - x2;
            dy = y3 - y2;

            if (Math.Abs(dx) > Math.Abs(dy))
                longitud = Math.Abs(dx);
            else
                longitud = Math.Abs(dy);

            x_inc = (float)dx / longitud;
            y_inc = (float)dy / longitud;

            x = x2;
            y = y2;

            Bitmap bmp2 = new Bitmap(p1.ClientSize.Width,
            p1.ClientSize.Height);
            bmp2.SetPixel((int)x, (int)y, Color.Red);

            for (k = 1; k < longitud + 1; k++)
            {
                x = x + x_inc;
                y = y + y_inc;

                bmp2.SetPixel((int)x, (int)y, color);
            }
            Graphics g2 = p1.CreateGraphics();
            g2.DrawImage(bmp2, 0, 0, bmp2.Width, bmp2.Height);
            #endregion

            // repetir para linea 3

            #region DDA para linea 3
            dx = x4 - x3;
            dy = y4 - y3;

            if (Math.Abs(dx) > Math.Abs(dy))
                longitud = Math.Abs(dx);
            else
                longitud = Math.Abs(dy);

            x_inc = (float)dx / longitud;
            y_inc = (float)dy / longitud;

            x = x3;
            y = y3;

            Bitmap bmp3 = new Bitmap(p1.ClientSize.Width,
            p1.ClientSize.Height);
            bmp3.SetPixel((int)x, (int)y, Color.Red);

            for (k = 1; k < longitud + 1; k++)
            {
                x = x + x_inc;
                y = y + y_inc;

                bmp3.SetPixel((int)x, (int)y, color);
            }
            Graphics g3 = p1.CreateGraphics();
            g3.DrawImage(bmp3, 0, 0, bmp3.Width, bmp3.Height);
            #endregion

            // repetir para linea 4

            #region DDA para linea 4
            dx = x4 - x1;
            dy = y4 - y1;

            if (Math.Abs(dx) > Math.Abs(dy))
                longitud = Math.Abs(dx);
            else
                longitud = Math.Abs(dy);

            x_inc = (float)dx / longitud;
            y_inc = (float)dy / longitud;

            x = x1;
            y = y1;

            Bitmap bmp4 = new Bitmap(p1.ClientSize.Width,
            p1.ClientSize.Height);
            bmp4.SetPixel((int)x, (int)y, Color.Red);

            for (k = 1; k < longitud + 1; k++)
            {
                x = x + x_inc;
                y = y + y_inc;

                bmp4.SetPixel((int)x, (int)y, color);
            }
            Graphics g4 = p1.CreateGraphics();
            g4.DrawImage(bmp4, 0, 0, bmp4.Width, bmp4.Height);
            #endregion
        }

    }
}
