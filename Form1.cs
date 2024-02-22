using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA
{
    public partial class GPA : Form
    {
        public GPA()
        {
            InitializeComponent();
        }
    
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                textBox1.Text = "";
            }
            switch (comboBox1.Text) {
                case "1":
                    label5.Text = "20";
                    break;
                case "2":
                    label5.Text = "40";
                    break;
                case "3":
                    label5.Text = "60";
                    break;
                case "4":
                    label5.Text = "80";
                    break;
                case "5":
                    label5.Text = "100";
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] row = {textBox2.Text, comboBox1.Text, label6.Text, textBox1.Text, label5.Text,label10.Text};
            dataGridView1.Rows.Add(row);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int obt=0;
            if (textBox1.Text!="") {
                 obt = Convert.ToInt32(textBox1.Text); }
            switch (comboBox1.Text)
            {
                case "1":
                    if (obt>=16&&obt<=20)
                    {
                        label6.Text = "4.00";
                        label10.Text = "A";
                    }
                  else  if (obt == 15 )
                    {
                        label6.Text = "3.37";
                        label10.Text = "B";
                    }
                    else if (obt == 14)
                    {
                        label6.Text = "3.30";
                        label10.Text = "B";
                    }
                    else if (obt == 13)
                    {
                        label6.Text = "3.00";
                        label10.Text = "B";
                    }
                    else if (obt == 12)
                    {
                        label6.Text = "2.70";
                        label10.Text = "C";
                    }
                    else if (obt == 11)
                    {
                        label6.Text = "2.30";
                        label10.Text = "C";
                    }
                    else if (obt == 10)
                    {
                        label6.Text = "2.00";
                        label10.Text = "C";
                    }
                    else if (obt == 9)
                    {
                        label6.Text = "1.50";
                        label10.Text = "D";
                    }
                    else if (obt == 8)
                    {
                        label6.Text = "1.00";
                        label10.Text = "D";
                    }
                    else
                    {
                        label6.Text = "0.00";
                        label10.Text = "F";
                    }
                    break;
                case "2":
                    if (obt >= 32 && obt <= 40)
                    {
                        label6.Text = "8.00";
                        label10.Text = "A";
                    }
                    else if (obt == 31)
                    {
                        label6.Text = "7.60";
                        label10.Text = "B";
                    }
                    else if (obt == 30)
                    {
                        label6.Text = "7.40";
                        label10.Text = "B";
                    }
                    else if (obt == 29)
                    {
                        label6.Text = "7.00";
                        label10.Text = "B";
                    }
                    else if (obt == 28)
                    {
                        label6.Text = "6.60";
                        label10.Text = "B";
                    }
                    else if (obt == 27)
                    {
                        label6.Text = "6.40";
                        label10.Text = "B";
                    }
                    else if (obt == 26)
                    {
                        label6.Text = "6.00";
                        label10.Text = "B";
                    }
                    else if (obt == 25)
                    {
                        label6.Text = "5.60";
                        label10.Text = "C";
                    }
                    else if (obt == 24)
                    {
                        label6.Text = "5.50";
                        label10.Text = "C";
                    }
                    else if (obt == 23)
                    {
                        label6.Text = "5.00";
                        label10.Text = "C";
                    }
                    else if (obt == 22)
                    {
                        label6.Text = "4.60";
                        label10.Text = "C";
                    }
                    else if (obt == 21)
                    {
                        label6.Text = "4.40";
                        label10.Text = "C";
                    }
                    else if (obt == 20)
                    {
                        label6.Text = "4.00";
                        label10.Text = "C";
                    }
                    else if (obt == 19)
                    {
                        label6.Text = "3.60";
                        label10.Text = "D";
                    }
                    else if (obt == 18)
                    {
                        label6.Text = "3.00";
                        label10.Text = "D";
                    }
                    else if (obt == 17)
                    {
                        label6.Text = "2.60";
                        label10.Text = "D";
                    }
                    else if (obt == 16)
                    {
                        label6.Text = "2.00";
                        label10.Text = "D";
                    }
                    else 
                    {
                        label6.Text = "0.00";
                        label10.Text = "F";
                    }
                    break;
                case "3":
                    if (obt >= 48 && obt <= 60)
                    {
                        label6.Text = "12.00";
                        label10.Text = "A";
                    }
                    else if (obt == 47)
                    {
                        label6.Text = "11.70";
                        label10.Text = "B";
                    }
                    else if (obt == 46)
                    {
                        label6.Text = "11.40";
                        label10.Text = "B";
                    }
                    else if (obt == 45)
                    {
                        label6.Text = "11.10";
                        label10.Text = "B";
                    }
                    else if (obt == 44)
                    {
                        label6.Text = "10.50";
                        label10.Text = "B";
                    }
                    else if (obt == 43)
                    {
                        label6.Text = "10.20";
                        label10.Text = "B";
                    }
                    else if (obt == 42)
                    {
                        label6.Text = "9.90";
                        label10.Text = "B";
                    }
                    else if (obt == 41)
                    {
                        label6.Text = "9.60";
                        label10.Text = "B";
                    }
                    else if (obt == 40)
                    {
                        label6.Text = "9.30";
                        label10.Text = "B";
                    }
                    else if (obt == 39)
                    {
                        label6.Text = "9.00";
                        label10.Text = "C";
                    }
                    else if (obt == 38)
                    {
                        label6.Text = "8.70";
                        label10.Text = "C";
                    }
                    else if (obt == 37)
                    {
                        label6.Text = "8.40";
                        label10.Text = "C";
                    }
                    else if (obt == 36)
                    {
                        label6.Text = "8.10";
                        label10.Text = "C";
                    }
                    else if (obt == 35)
                    {
                        label6.Text = "7.50";
                        label10.Text = "C";
                    }
                    else if (obt == 34)
                    {
                        label6.Text = "7.20";
                        label10.Text = "C";
                    }
                    else if (obt == 33)
                    {
                        label6.Text = "6.90";
                        label10.Text = "C";
                    }
                    else if (obt == 32)
                    {
                        label6.Text = "6.60";
                        label10.Text = "C";
                    }
                    else if (obt == 31)
                    {
                        label6.Text = "6.30";
                        label10.Text = "C";
                    }
                    else if (obt == 30)
                    {
                        label6.Text = "6.00";
                        label10.Text = "C";
                    }
                    else if (obt == 29)
                    {
                        label6.Text = "5.40";
                        label10.Text = "D";
                    }
                    else if (obt == 28)
                    {
                        label6.Text = "5.10";
                        label10.Text = "D";
                    }
                    else if (obt == 27)
                    {
                        label6.Text = "4.50";
                        label10.Text = "D";
                    }
                    else if (obt == 26)
                    {
                        label6.Text = "3.90";
                        label10.Text = "D";
                    }
                    else if (obt == 25)
                    {
                        label6.Text = "3.60";
                        label10.Text = "D";
                    }
                    else if (obt == 24)
                    {
                        label6.Text = "3.00";
                        label10.Text = "D";
                    }
                    else
                    {
                        label6.Text = "0.00";
                        label10.Text = "F";
                    }
                    break;
                case "4":
                    if (obt >= 64 && obt <= 80)
                    {
                        label6.Text = "16.00";
                        label10.Text = "A";
                    }
                    else if (obt == 63)
                    {
                        label6.Text = "15.60";
                        label10.Text = "B";
                    }
                    else if (obt == 62)
                    {
                        label6.Text = "15.20";
                        label10.Text = "B";
                    }
                    else if (obt == 61)
                    {
                        label6.Text = "14.80";
                        label10.Text = "B";
                    }
                    else if (obt == 60)
                    {
                        label6.Text = "14.80";
                        label10.Text = "B";
                    }
                    else if (obt == 59)
                    {
                        label6.Text = "14.40";
                        label10.Text = "B";
                    }
                    else if (obt == 58)
                    {
                        label6.Text = "14.00";
                        label10.Text = "B";
                    }
                    else if (obt == 57)
                    {
                        label6.Text = "13.60";
                        label10.Text = "B";
                    }
                    else if (obt == 56)
                    {
                        label6.Text = "13.20";
                        label10.Text = "B";
                    }
                    else if (obt == 55)
                    {
                        label6.Text = "12.80";
                        label10.Text = "B";
                    }
                    else if (obt == 54)
                    {
                        label6.Text = "12.40";
                        label10.Text = "B";
                    }
                    else if (obt == 53)
                    {
                        label6.Text = "12.00";
                        label10.Text = "B";
                    }
                    else if (obt == 52)
                    {
                        label6.Text = "12.00";
                        label10.Text = "B";
                    }
                    else if (obt == 51)
                    {
                        label6.Text = "11.60";
                        label10.Text = "C";
                    }
                    else if (obt == 50)
                    {
                        label6.Text = "11.20";
                        label10.Text = "C";
                    }
                    else if (obt == 49)
                    {
                        label6.Text = "10.80";
                        label10.Text = "C";
                    }
                    else if (obt == 48)
                    {
                        label6.Text = "10.80";
                        label10.Text = "C";
                    }
                    else if (obt == 47)
                    {
                        label6.Text = "10.40";
                        label10.Text = "C";
                    }
                    else if (obt == 46)
                    {
                        label6.Text = "10.00";
                        label10.Text = "C";
                    }
                    else if (obt == 45)
                    {
                        label6.Text = "9.60";
                        label10.Text = "C";
                    }
                    else if (obt == 44)
                    {
                        label6.Text = "9.20";
                        label10.Text = "C";
                    }
                    else if (obt == 43)
                    {
                        label6.Text = "8.80";
                        label10.Text = "C";
                    }
                    else if (obt == 42)
                    {
                        label6.Text = "8.80";
                        label10.Text = "C";
                    }
                    else if (obt == 41)
                    {
                        label6.Text = "8.40";
                        label10.Text = "C";
                    }
                    else if (obt == 40)
                    {
                        label6.Text = "8.00";
                        label10.Text = "C";
                    }
                    else if (obt == 39)
                    {
                        label6.Text = "7.60";
                        label10.Text = "D";
                    }
                    else if (obt == 38)
                    {
                        label6.Text = "7.20";
                        label10.Text = "D";
                    }
                    else if (obt == 37)
                    {
                        label6.Text = "6.40";
                        label10.Text = "D";
                    }
                    else if (obt == 36)
                    {
                        label6.Text = "6.00";
                        label10.Text = "D";
                    }
                    else if (obt == 35)
                    {
                        label6.Text = "5.60";
                        label10.Text = "D";
                    }
                    else if (obt == 34)
                    {
                        label6.Text = "5.20";
                        label10.Text = "D";
                    }
                    else if (obt == 33)
                    {
                        label6.Text = "4.40";
                        label10.Text = "D";
                    }
                    else if (obt == 32)
                    {
                        label6.Text = "4.00";
                        label10.Text = "D";
                    }
                    else if (obt == 40)
                    {
                        label6.Text = "8.00";
                        label10.Text = "C";
                    }
                    else
                    {
                        label6.Text = "0.00";
                        label10.Text = "F";
                    }
                    break;
                case "5":
                    if (obt >= 80 && obt <= 100)
                    {
                        label6.Text = "20.00";
                        label10.Text = "A";
                    }
                    else if (obt == 79)
                    {
                        label6.Text = "19.50";
                        label10.Text = "B";
                    }
                    else if (obt == 78)
                    {
                        label6.Text = "19.50";
                        label10.Text = "B";
                    }
                    else if (obt == 77)
                    {
                        label6.Text = "19.00";
                        label10.Text = "B";
                    }
                    else if (obt == 76)
                    {
                        label6.Text = "18.50";
                        label10.Text = "B";
                    }
                    else if (obt == 75)
                    {
                        label6.Text = "18.50";
                        label10.Text = "B";
                    }
                    else if (obt == 74)
                    {
                        label6.Text = "18.00";
                        label10.Text = "B";
                    }
                    else if (obt == 73)
                    {
                        label6.Text = "17.50";
                        label10.Text = "B";
                    }
                    else if (obt == 72)
                    {
                        label6.Text = "17.50";
                        label10.Text = "B";
                    }
                    else if (obt == 71)
                    {
                        label6.Text = "17.00";
                        label10.Text = "B";
                    }
                    else if (obt == 70)
                    {
                        label6.Text = "16.50";
                        label10.Text = "B";
                    }
                    else if (obt == 69)
                    {
                        label6.Text = "16.50";
                        label10.Text = "B";
                    }
                    else if (obt == 68)
                    {
                        label6.Text = "16.00";
                        label10.Text = "B";
                    }
                    else if (obt == 67)
                    {
                        label6.Text = "15.50";
                        label10.Text = "B";
                    }
                    else if (obt == 66)
                    {
                        label6.Text = "15.50";
                        label10.Text = "B";
                    }
                    else if (obt == 65)
                    {
                        label6.Text = "15.00";
                        label10.Text = "B";
                    }
                    else if (obt == 64)
                    {
                        label6.Text = "14.50";
                        label10.Text = "C";
                    }
                    else if (obt == 63)
                    {
                        label6.Text = "14.50";
                        label10.Text = "C";
                    }
                    else if (obt == 62)
                    {
                        label6.Text = "14.00";
                        label10.Text = "C";
                    }
                    else if (obt == 61)
                    {
                        label6.Text = "13.50";
                        label10.Text = "C";
                    }
                    else if (obt == 60)
                    {
                        label6.Text = "13.50";
                        label10.Text = "C";
                    }
                    else if (obt == 59)
                    {
                        label6.Text = "13.00";
                        label10.Text = "C";
                    }
                    else if (obt == 58)
                    {
                        label6.Text = "12.50";
                        label10.Text = "C";
                    }
                    else if (obt == 57)
                    {
                        label6.Text = "12.50";
                        label10.Text = "C";
                    }
                    else if (obt == 56)
                    {
                        label6.Text = "12.00";
                        label10.Text = "C";
                    }
                    else if (obt == 55)
                    {
                        label6.Text = "11.50";
                        label10.Text = "C";
                    }
                    else if (obt == 54)
                    {
                        label6.Text = "11.50";
                        label10.Text = "C";
                    }
                    else if (obt == 53)
                    {
                        label6.Text = "11.00";
                        label10.Text = "C";
                    }
                    else if (obt == 52)
                    {
                        label6.Text = "10.50";
                        label10.Text = "C";
                    }
                    else if (obt == 51)
                    {
                        label6.Text = "10.50";
                        label10.Text = "C";
                    }
                    else if (obt == 50)
                    {
                        label6.Text = "10.00";
                        label10.Text = "C";
                    }
                    else if (obt == 49)
                    {
                        label6.Text = "9.50";
                        label10.Text = "D";
                    }
                    else if (obt == 48)
                    {
                        label6.Text = "9.00";
                        label10.Text = "D";
                    }
                    else if (obt == 47)
                    {
                        label6.Text = "8.50";
                        label10.Text = "D";
                    }
                    else if (obt == 46)
                    {
                        label6.Text = "8.00";
                        label10.Text = "C";
                    }
                    else if (obt == 45)
                    {
                        label6.Text = "7.50";
                        label10.Text = "C";
                    }
                    else if (obt == 44)
                    {
                        label6.Text = "7.00";
                        label10.Text = "D";
                    }
                    else if (obt == 43)
                    {
                        label6.Text = "6.50";
                        label10.Text = "D";
                    }
                    else if (obt == 42)
                    {
                        label6.Text = "6.00";
                        label10.Text = "D";
                    }
                    else if (obt == 41)
                    {
                        label6.Text = "5.50";
                        label10.Text = "D";
                    }
                    else if (obt == 40)
                    {
                        label6.Text = "5.00";
                        label10.Text = "D";
                    }
                    else
                    {
                        label6.Text = "0.00";
                        label10.Text = "F";
                    }
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = "";
            int crdhrs = 0;
            double Q_p = 0.0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                crdhrs += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                Q_p += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);

            }
            string leng = Convert.ToString(Q_p / crdhrs);
            int strleng = leng.Length;
            if (strleng > 4)
            {
                for (int i = 0; i < 4; i++)
                {

                    label8.Text += leng[i];
                }
            }
            else
            {
                label8.Text = Convert.ToString(Q_p / crdhrs);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Result Card",new Font("Arial",25,FontStyle.Bold),Brushes.Black,new PointF(315,10));
            e.Graphics.DrawString("Dear ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new PointF(0, 50));
            e.Graphics.DrawString(textBox3.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new PointF(100, 50));
            e.Graphics.DrawString("______________________________________________________________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Red, new PointF(0, 60));
            e.Graphics.DrawString("Subject |", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new PointF(0, 100));
            e.Graphics.DrawString("C.Hrs |", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new PointF(130, 100));
            e.Graphics.DrawString("Q.Poits |", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new PointF(260, 100));
            e.Graphics.DrawString("O.Marks |", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new PointF(390, 100));
            e.Graphics.DrawString("T.Marks |", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new PointF(520, 100));
            e.Graphics.DrawString("Grades |", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new PointF(650, 100));
            e.Graphics.DrawString("______________________________________________________________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Red, new PointF(0, 110));
            int Y_axis =150, X_axis= 0;
            for (int i=0;i<dataGridView1.Rows.Count-1;i++) {
                for (int j = 0; j < 6; j++) {
                    e.Graphics.DrawString(Convert.ToString(dataGridView1.Rows[i].Cells[j].Value), new Font("Arial", 20 ), Brushes.Black, new PointF(X_axis, Y_axis));
                    X_axis += 130;
                }
                Y_axis += 50;
                X_axis = 0;
            }
            e.Graphics.DrawString("______________________________________________________________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Red, new PointF(0, Y_axis+10));
            e.Graphics.DrawString("GPA", new Font("Arial", 20, FontStyle.Bold), Brushes.Red, new PointF(500, Y_axis + 50));
            e.Graphics.DrawString(label8.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Red, new PointF(600, Y_axis + 50));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
