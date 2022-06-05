using System.Media;

namespace BestOil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (var item in Benzin)
            {
                comboBox1.Items.Add(item);
            }
            comboBox1.SelectedIndex = 0;
            comboBox1.Select();
        }

        public List<string> Benzin = new()
        {
            "A-92", "A-95", "A-98", "Diesel", "LPG"
        };

        public List<float> Cost = new()
        {
            1.0f, 1.6f, 1.9f, 0.8f, 0.65f
        };

        public List<float> MenuPrice = new()
        {
            2.0f, 4.5f, 3.2f, 1.3f
        };
        public float Total1 { get; set; } = 0;
        public float Total2 { get; set; } = 0;
        public float Total3 { get; set; } = 0;
        public float Total4 { get; set; } = 0;
        public float TotalCafe { get; set; } = 0;
        public float TotalGasoline { get; set; }

        public float Total { get; set; }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBoxQiymet.Text = Cost[comboBox1.SelectedIndex].ToString();
            textBoxLitr.Text = "0";
            textBoxMebleg.Text = "0";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMebleg.Text = "0";
            textBoxLitr.Select();
            if (radioButton2.Checked)
            {
                textBoxLitr.ReadOnly = false; textBoxMebleg.ReadOnly = true;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxLitr.Text = "0";
            textBoxMebleg.Select();
            if (radioButton1.Checked)
            {
                textBoxMebleg.ReadOnly = false; textBoxLitr.ReadOnly = true;
            }
        }

        private void textBoxLitr_TextChanged(object sender, EventArgs e)
        {
            textBoxLitr.Select();
            if (string.IsNullOrWhiteSpace(textBoxLitr.Text))
            {
                textBoxLitr.Text = "0";
            }
            stationUmumiQiymet.Text = (float.Parse(textBoxLitr.Text) * float.Parse(textBoxQiymet.Text)).ToString();
            TotalGasoline = float.Parse(stationUmumiQiymet.Text);
        }

        private void textBoxMebleg_TextChanged(object sender, EventArgs e)
        {
            textBoxMebleg.Select();
            if (string.IsNullOrWhiteSpace(textBoxMebleg.Text))
            {
                textBoxMebleg.Text = "0";
            }
            stationUmumiQiymet.Text = textBoxMebleg.Text;
            textBoxLitr.Text = (float.Parse(textBoxMebleg.Text) / float.Parse(textBoxQiymet.Text)).ToString();
            TotalGasoline = float.Parse(stationUmumiQiymet.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var s = sender as CheckBox;
            if (s?.Checked == true)
            {
                if (s.TabIndex == 1)
                {
                    textBox5.Enabled = true;
                    textBox5.Text = "1";
                    textBox5.Select();
                }
                else if (s.TabIndex == 2)
                {
                    textBox7.Enabled = true;
                    textBox7.Text = "1";
                    textBox7.Select();
                }
                else if (s.TabIndex == 3)
                {
                    textBox1.Enabled = true;
                    textBox1.Text = "1";
                    textBox1.Select();
                }
                else if (s.TabIndex == 4)
                {
                    textBox3.Enabled = true;
                    textBox3.Text = "1";
                    textBox3.Select();
                }
            }
            else if (s.Checked == false)
            {
                if (s.TabIndex == 1)
                {
                    textBox5.Enabled = false;
                    textBox5.Text = "0";
                }
                else if (s.TabIndex == 2)
                {
                    textBox7.Enabled = false;
                    textBox7.Text = "0";
                }
                else if (s.TabIndex == 3)
                {
                    textBox1.Enabled = false;
                    textBox1.Text = "0";
                }
                else if (s.TabIndex == 4)
                {
                    textBox3.Enabled = false;
                    textBox3.Text = "0";
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            float a = 0;
            Total1 = 0;
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                textBox5.Text = "0";                
            }
            var count = float.Parse(textBox5.Text);
            
            var pay = count * MenuPrice[0];
            if (count == 0)
            {
                pay = 0;
                Total1=0;
            }
            a += pay;
            cafe_umumiQiymet.Text = a.ToString();
            Total1 += a;
            float f = Total1 + Total2 + Total3 + Total4;
            cafe_umumiQiymet.Text = f.ToString();
            TotalCafe = float.Parse(cafe_umumiQiymet.Text);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            float a = 0;
            Total2 = 0;
            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                textBox7.Text = "0";
            }
            var count = float.Parse(textBox7.Text);

            var pay = count * MenuPrice[1];
            if (count == 0)
            {
                pay = 0;
                Total2 = 0;
            }
            a += pay;
            
            Total2 += a;
            float f = Total1 + Total2 + Total3 +Total4;
            cafe_umumiQiymet.Text = f.ToString();
            TotalCafe = float.Parse(cafe_umumiQiymet.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float a = 0;
            Total3 = 0;
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "0";
            }
            var count = float.Parse(textBox1.Text);

            var pay = count * MenuPrice[2];
            if (count == 0)
            {
                pay = 0;
                Total3 = 0;
            }
            a += pay;

            Total3 += a;
            float f = Total1 + Total2 + Total3 +Total4;
            cafe_umumiQiymet.Text = f.ToString();
            TotalCafe = float.Parse(cafe_umumiQiymet.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            float a = 0;
            Total4 = 0;
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.Text = "0";
            }
            var count = float.Parse(textBox3.Text);

            var pay = count * MenuPrice[3];
            if (count == 0)
            {
                pay = 0;
                Total4 = 0;
            }
            a += pay;

            Total4 += a;
            float f = Total1 + Total2 + Total3 + Total4;
            cafe_umumiQiymet.Text = f.ToString();
            TotalCafe = float.Parse(cafe_umumiQiymet.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Total = TotalCafe + TotalGasoline;
            lbl_umumiQiymet.Text = Total.ToString();
            var sp = new SoundPlayer("audio.wav");
            sp.PlaySync();
            
        }
    }

}