using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Graphics3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int x = 1, y = 1, yx = 0;
            if (checkBox1.Checked) x = -1;
            if (checkBox2.Checked) y = -1;
            if (checkBox3.Checked) yx = 1;
            e.Graphics.DrawLine(Pens.Green, pictureBox1.Width / 2, 0, pictureBox1.Width / 2, pictureBox1.Height);
            e.Graphics.DrawLine(Pens.Green, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);
            e.Graphics.DrawLine(Pens.Green, 0, pictureBox1.Height, pictureBox1.Width, 0);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            //e.Graphics.TranslateTransform(Convert.ToSingle(translationX.Value) + pictureBox1.Width / 2, Convert.ToSingle(translationY.Value) + pictureBox1.Height / 2); //возьмём центр picturebox за начало координат, чтобы все трансформы отсчитывались от центра, а не левого верхнего угла, и отодвинем на transform X, Y
            e.Graphics.ScaleTransform(Convert.ToSingle(scaleX.Value), Convert.ToSingle(scaleY.Value)); // применим scale transform
            //e.Graphics.TranslateTransform(Convert.ToSingle(rotationX.Value), Convert.ToSingle(rotationY.Value)); //отодвинем начало координат в точку rotation X, Y, чтобы вращать объект относительно её, а не центра
            //e.Graphics.RotateTransform(Convert.ToSingle(angle.Value)); //вращаем
            e.Graphics.TranslateTransform(-Convert.ToSingle(rotationX.Value), -Convert.ToSingle(rotationY.Value));//отодвинем начало координат обратно в центр picturebox
            Matrix matrix = new Matrix();
            float tx = x * (float)translationX.Value + pictureBox1.Width / 2 + (float)rotationX.Value;
            float ty = y * (float)translationY.Value + pictureBox1.Height / 2 + (float)rotationY.Value;
            matrix.Translate(tx + yx*(ty - tx), ty - yx*(tx - ty));
            matrix.Scale(x, y);
            matrix.RotateAt((float)angle.Value, new PointF((float)rotationX.Value, (float)rotationY.Value));
            matrix.Shear(Convert.ToSingle(shearX.Value), Convert.ToSingle(shearY.Value));
            e.Graphics.MultiplyTransform(matrix); //применим shear transform
            DrawImage(e); // нарисуем картинку на graphics с примененными трансформациями.
        }

        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down: //при нажатии стрелки вниз уменьшим scale. блок try catch здесь и ниже - чтобы нельзя было выйти за минимум/максимум полей ввода (например, чтобы scale не мог быть >100 или <0.001
                    try
                    {
                        scaleX.Value -= 0.1M;
                        scaleY.Value -= 0.1M;
                    }
                    catch { }
                    break;
                case Keys.Up: // стрелка вверх увеличивает scale
                    try
                    {
                        scaleX.Value += 0.1M;
                        scaleY.Value += 0.1M;
                    }
                    catch { }
                    break;
                case Keys.Left: // стрелка влево вращает против часовой
                    try { angle.Value -= 5; }
                    catch { }
                    break;
                case Keys.Right: // стрелка вправо вращает по часовой
                    try { angle.Value += 5; }
                    catch { }
                    break;
            }
        }

        private void DrawImage(PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Pen black = new Pen(Color.Black, 5);
            Point[] rectangle = new Point[] { new Point(-75, -50) , new Point(150, 100) };
            Point[] polygon = new Point[] { new Point(75, -100), new Point(150, 0), new Point(75, 100) };
            gr.DrawRectangle(black, new Rectangle(rectangle[0], new Size(rectangle[1])));
            gr.DrawPolygon(black, polygon);
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate(); // при изменении значения в полях слева перерисовать picturebox
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Focus(); // при наведении мыши на picturebox поля теряют фокус и не мешают работать макросам
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }
    }
}
