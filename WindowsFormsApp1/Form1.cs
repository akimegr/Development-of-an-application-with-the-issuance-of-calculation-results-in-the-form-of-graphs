using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Text = "Лаб. раб N8 Ст.гр 10701320 ";

            this.textBox1.Width = 265;
            this.textBox1.Height = 100;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            
        }

        private void field_x_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void field_y_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (chart1.ChartAreas[0].AxisX.MajorGrid.Enabled == false || chart1.ChartAreas[0].AxisY.MajorGrid.Enabled == false)
            {
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            }
            else
            {
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

            try
            {
                chart1.Series[0].Points.Clear();
                double x = Double.Parse(field_x.Text);
                double h = Double.Parse(field_y.Text);
                string s = "";
                s += " Лаб.раб N8 Ст.гр 10701320 Акимов Е.С. \r\n";

                while (x <= int.Parse(textBox2.Text))
                {
                    double S = (Math.Pow(Math.Abs(x), 2) + 1) / 3;

                    s += " x:=" + x.ToString() + "\r\n";
                    s += " y:= " + S.ToString() + "\r\n";
                    this.chart1.Series[0].Points.AddXY(x, S);
                    x += h;

                }

                textBox1.Text = s;
            }
            catch (FormatException ex)
            {
                double x = 1;
                double y = 2;
                double z = 3;

                double S = Math.Pow((8 + Math.Pow(Math.Abs(x), 2) + 1), (1 / 3)) / (Math.Pow(x, 2) + Math.Pow(x, 2) + 2) - Math.Pow(Math.E, Math.Abs(x)) * (Math.Pow(Math.Pow(Math.Tan(x), 2) + 1, x));
                string s = "";
                s += " Лаб.раб N1 Ст.гр 10701320 Акимов Е.С. \r\n";
                s += " ОШИБКА!!! Значения по умолчнаию: \r\n";
                s += " x:=" + x.ToString() + "\r\n";
                s += " y:= " + y.ToString() + "\r\n";
                s += " z:= " + z.ToString() + "\r\n";
                s += " Результат U:= " + S.ToString() + "\r\n";
                textBox1.Text = s;
            }
        }
    }
}
