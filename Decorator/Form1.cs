using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kuća = "";
            StambeniObjekt stambeniobjekt = null;

            foreach (var item in listBox1.SelectedItems)
            {
                kuća += item;
            }

            switch (kuća)
            {
                case "obična kuća + bazen":
                    stambeniobjekt = new Bazen(new ObičnaKuća());
                    break;
                case "obična kuća + garaža":
                    stambeniobjekt = new Garaža(new ObičnaKuća());
                    break;
                case "obična kuća + dvorište":
                    stambeniobjekt = new Dvorište(new ObičnaKuća());
                    break;
                case "obična kuća + bazen + garaža":
                    stambeniobjekt = new Garaža(new Bazen(new ObičnaKuća()));
                    break;
                case "obična kuća + dvorište + bazen":
                    stambeniobjekt = new Bazen(new Dvorište(new ObičnaKuća()));
                    break;
                case "obična kuća + dvorište + garaža":
                    stambeniobjekt = new Garaža(new Dvorište(new ObičnaKuća()));
                    break;
                case "obična kuća + dvorište + bazen + garaža":
                    stambeniobjekt = new Garaža(new Bazen(new Dvorište(new ObičnaKuća())));
                    break;
                default:
                    ClearDrawingContext(this);
                    NapraviObičuKuću();
                    return;
            }

            ClearDrawingContext(this);
            NapraviStambeniObjekt(stambeniobjekt.GetTipObjekta());
        }

        public void NapraviStambeniObjekt(string kuća)
        {
            switch (kuća)
            {
                case "obična kuća + bazen":
                    DodajBazen();
                    break;
                case "obična kuća + garaža":
                    DodajGaražu();
                    break;
                case "obična kuća + dvorište":
                    DodajDvorište();
                    break;
                case "obična kuća + bazen + garaža":
                    DodajGaražu();
                    DodajBazen();
                    break;
                case "obična kuća + dvorište + garaža":
                    DodajDvorište();
                    DodajGaražu();
                    break;
                case "obična kuća + dvorište + bazen":
                    DodajDvorište();
                    DodajBazen();
                    break;
                case "obična kuća + dvorište + bazen + garaža":
                    DodajDvorište();
                    DodajBazen();
                    DodajGaražu();
                    break;
                default:
                    break;
            }

            NapraviObičuKuću();

            //graphics.Dispose();
            //myBrush.Dispose();
        }

        public void NapraviObičuKuću()
        {
            System.Drawing.Graphics graphics = this.CreateGraphics();

            graphics.DrawRectangle(System.Drawing.Pens.Black, new System.Drawing.Rectangle(200, 200, 100, 100));
            graphics.DrawLine(System.Drawing.Pens.Black, new Point(200, 200), new Point(250, 175));
            graphics.DrawLine(System.Drawing.Pens.Black, new Point(250, 175), new Point(300, 200));
            graphics.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.OrangeRed), new System.Drawing.Rectangle(200, 200, 100, 100));
            graphics.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Khaki), new System.Drawing.Rectangle(215, 215, 30, 30));
            graphics.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), new System.Drawing.Rectangle(255, 255, 30, 45));
        }

        public void DodajDvorište()
        {
            System.Drawing.Graphics graphics = this.CreateGraphics();

            graphics.DrawRectangle(System.Drawing.Pens.Black, new System.Drawing.Rectangle(120, 70, 600, 50));
            graphics.DrawLine(System.Drawing.Pens.Black, new Point(120, 70), new Point(120, 350));
            graphics.DrawLine(System.Drawing.Pens.Black, new Point(720, 350), new Point(720, 120));
            graphics.DrawRectangle(System.Drawing.Pens.Black, new System.Drawing.Rectangle(120, 350, 600, 50));
            graphics.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.SaddleBrown), new System.Drawing.Rectangle(120, 70, 600, 50));
            graphics.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.SaddleBrown), new System.Drawing.Rectangle(120, 350, 600, 50));
            graphics.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.LawnGreen), new System.Drawing.Rectangle(120, 120, 600, 230));
        }

        public void DodajBazen()
        {
            System.Drawing.Graphics graphics = this.CreateGraphics();
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);

            graphics.DrawRectangle(System.Drawing.Pens.Black, new System.Drawing.Rectangle(350, 200, 120, 70));
            graphics.FillRectangle(myBrush, new System.Drawing.Rectangle(350, 200, 120, 70));
        }

        public void DodajGaražu()
        {
            System.Drawing.Graphics graphics = this.CreateGraphics();

            graphics.DrawRectangle(System.Drawing.Pens.Black, new System.Drawing.Rectangle(500, 200, 100, 70));
            graphics.DrawLine(System.Drawing.Pens.Black, new Point(500, 200), new Point(550, 180));
            graphics.DrawLine(System.Drawing.Pens.Black, new Point(550, 180), new Point(600, 200));
            graphics.DrawRectangle(System.Drawing.Pens.Black, new System.Drawing.Rectangle(525, 240, 50, 30));
            graphics.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.OrangeRed), new System.Drawing.Rectangle(500, 200, 100, 70));
            graphics.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Khaki), new System.Drawing.Rectangle(525, 240, 50, 30));
        }

        public void ClearDrawingContext(Form1 form1)
        {
            System.Drawing.Graphics graphics = this.CreateGraphics();
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            
            graphics.FillRectangle(myBrush, form1.ClientRectangle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearDrawingContext(this);
        }
    }
}
