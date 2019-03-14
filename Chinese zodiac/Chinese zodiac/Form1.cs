using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinese_zodiac
{
   // enum elements { wood, fire, earth, gold, water };
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            button1.Enabled = false;
            //    enum elements { wood, fire, earth, gold, water };
            textBox1.MaxLength = 5;
            textBox1.Focus();
    }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(textBox1.Text);
            int i ;
            int reminder;
            if (checkBox2.Checked == true)
            {
                i = ((Math.Abs(year) + 2) / 60 );
                reminder = ((Math.Abs(year)+ 2) - (60 * i));
                i = 60 - reminder;


                // uncomment to test result  label2.Text = reminder.ToString();
                label2.Visible = true;
                RsultToLabel(reminder);
            }
            else if (checkBox1.Checked == true)
            {
                i = (year - 3) / 60;
                reminder = (year - 3) - (60 * i);

              // uncomment to test result  label2.Text = reminder.ToString();
                label2.Visible = true;
                RsultToLabel(reminder);

            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // 0, 0-4 is a bug , ad\bc choise and textbox click is a bug,
            

            if ( textBox1.Text.Length > 0 ) 
                
            {
               // try textBox1.Text.Convert.ToInt32();

                label1.Visible = false;
                if ((checkBox2.Checked == true) && (checkBox1.Checked == true))
                {
                    button1.Enabled = false;
                }
                else if ((checkBox2.Checked == false) && (checkBox1.Checked == false))
                {
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                }
            }

            else
            {
                button1.Enabled = false;
                label1.Visible = true;
            }
            
        }

        

       

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Checked = false;
            }
            
            if ((textBox1.Text.Length > 0) && (checkBox2.Checked == true) && (checkBox1.Checked == false))
            {
                button1.Enabled = true;
                label5.Visible = false;
            }
            else if ((textBox1.Text.Length > 0) && (checkBox1.Checked == true) && (checkBox2.Checked == false))
            {
                button1.Enabled = true;
                label5.Visible = false;
            }
          
            else
            {
                button1.Enabled = false;
            }
            if ((checkBox1.Checked) || (checkBox2.Checked))
            {
                label5.Visible = false;
            }
            else
            {
                label5.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox2.Checked = false;
            }

            if ((textBox1.Text.Length > 0) && (checkBox1.Checked == true) && (checkBox2.Checked == false))
            {
                button1.Enabled = true;
                
            }
            else if ((textBox1.Text.Length > 0) && (checkBox2.Checked == true) && (checkBox1.Checked == false))
            {
                button1.Enabled = true;
                
            }
            
            else
            {
                button1.Enabled = false;
            }
            if ((checkBox1.Checked) || (checkBox2.Checked))
            {
                label5.Visible = false;
            }
            else
            {
                label5.Visible = true;
            }
        }
        // results list to display
        private void RsultToLabel(int reminder)
        {
            switch (reminder)
            {
                case 1:
                    label2.Text = "甲 Yang Wood	子 Rat";
                    break;
                case 2:
                    label2.Text = "乙 Yin Wood 丑 Ox";
                    break;
                case 3:
                    label2.Text = "丙 Yang Fire 寅 Tiger";
                    break;
                case 4:
                    label2.Text = "丁 Yin Fire 卯 Rabbit";
                    break;
                case 5:
                    label2.Text = "戊 Yang Earth 辰 Dragon";
                    break;
                case 6:
                    label2.Text = "己 Yin Earth	巳 Snake";
                    break;
                case 7:
                    label2.Text = "庚 Yang Metal 午 Horse";
                    break;
                case 8:
                    label2.Text = "辛 Yin Metal 未 Goat";
                    break;
                case 9:
                    label2.Text = "壬 Yang Water 申 Monkey";
                    break;
                case 10:
                    label2.Text = "癸 Yin Water 酉 Rooster";
                    break;

                case 11:
                    label2.Text = "甲 Yang Wood 戌 Dog";
                    break;
                case 12:
                    label2.Text = "乙 Yin Wood 亥 Pig";
                    break;
                case 13:
                    label2.Text = "丙 Yang Fire 子 Rat";
                    break;
                case 14:
                    label2.Text = "丁 Yin Fire 丑 Ox";
                    break;
                case 15:
                    label2.Text = "戊 Yang Earth 寅 Tiger";
                    break;
                case 16:
                    label2.Text = "己 Yin Earth 卯 Rabbit";
                    break;
                case 17:
                    label2.Text = "庚 Yang Metal 辰 Dragon";
                    break;
                case 18:
                    label2.Text = "辛 Yin Metal 巳 Snake";
                    break;
                case 19:
                    label2.Text = "壬 Yang Water 午 Horse";
                    break;
                case 20:
                    label2.Text = "癸 Yin Water 未 Goat";
                    break;

                case 21:
                    label2.Text = "甲 Yang Wood 申 Monkey";
                    break;
                case 22:
                    label2.Text = "乙 Yin Wood 酉 Rooster";
                    break;
                case 23:
                    label2.Text = "丙 Yang Fire 戌 Dog";
                    break;
                case 24:
                    label2.Text = "丁 Yin Fire 亥 Pig";
                    break;
                case 25:
                    label2.Text = "戊 Yang Earth 子 Rat";
                    break;
                case 26:
                    label2.Text = "己 Yin Earth 丑 Ox";
                    break;
                case 27:
                    label2.Text = "庚 Yang Metal 寅 Tiger";
                    break;
                case 28:
                    label2.Text = "辛 Yin Metal 卯 Rabbit";
                    break;
                case 29:
                    label2.Text = "壬 Yang Water 辰 Dragon";
                    break;
                case 30:
                    label2.Text = "癸 Yin Water 巳 Snake";
                    break;

                case 31:
                    label2.Text = "甲 Yang Wood 午 Horse";
                    break;
                case 32:
                    label2.Text = "乙 Yin Wood 未 Goat";
                    break;
                case 33:
                    label2.Text = "丙 Yang Fire 申 Monkey";
                    break;
                case 34:
                    label2.Text = "丁 Yin Fire 酉 Rooster";
                    break;
                case 35:
                    label2.Text = "戊 Yang Earth 戌 Dog";
                    break;
                case 36:
                    label2.Text = "己 Yin Earth 亥 Pig";
                    break;
                case 37:
                    label2.Text = "庚 Yang Metal 子 Rat";
                    break;
                case 38:
                    label2.Text = "辛 Yin Metal 丑 Ox";
                    break;
                case 39:
                    label2.Text = "壬 Yang Water 寅 Tiger";
                    break;
                case 40:
                    label2.Text = "癸 Yin Water 卯 Rabbit";
                    break;

                case 41:
                    label2.Text = "甲 Yang Wood 辰 Dragon";
                    break;
                case 42:
                    label2.Text = "乙 Yin Wood 巳 Snake";
                    break;
                case 43:
                    label2.Text = "丙 Yang Fire 午 Horse";
                    break;
                case 44:
                    label2.Text = "丁 Yin Fire 未 Goat";
                    break;
                case 45:
                    label2.Text = "戊 Yang Earth 申 Monkey";
                    break;
                case 46:
                    label2.Text = "己 Yin Earth 酉 Rooster";
                    break;
                case 47:
                    label2.Text = "庚 Yang Metal 戌 Dog";
                    break;
                case 48:
                    label2.Text = "辛 Yin Metal 亥 Pig";
                    break;
                case 49:
                    label2.Text = "壬 Yang Water	子 Rat";
                    break;
                case 50:
                    label2.Text = "癸 Yin Water 丑 Ox";
                    break;

                case 51:
                    label2.Text = "甲 Yang Wood 寅 Tiger";
                    break;
                case 52:
                    label2.Text = "乙 Yin Wood 卯 Rabbit";
                    break;
                case 53:
                    label2.Text = "丙 Yang Fire 辰 Dragon";
                    break;
                case 54:
                    label2.Text = "丁 Yin Fire 巳 Snake";
                    break;
                case 55:
                    label2.Text = "戊 Yang Earth 午 Horse";
                    break;
                case 56:
                    label2.Text = "己 Yin Earth 未 Goat";
                    break;
                case 57:
                    label2.Text = "庚 Yang Metal 申 Monkey";
                    break;
                case 58:
                    label2.Text = "辛 Yin Metal 酉 Rooster";
                    break;
                case 59:
                    label2.Text = "壬 Yang Water 戌 Dog";
                    break;
                case 60:
                    label2.Text = "癸 Yin Water 亥 Pig";
                    break;
                default: 
                    break;
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                button1.PerformClick();

            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}
