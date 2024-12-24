namespace arjun_hafizd_meiansyah
{
    public partial class Form1 : Form //definisi kelas form1.
                                      //menunjukan bahwa definisi kelas tersebut bisa dibagi beberapa file.
    {
        decimal bil1; //ini adalah deklarasi dua variabel bertipe decimal 
        decimal bil2;
        int opr; //digunakan untuk menyimpan operasi matematika
        Boolean opr_selesai = false; //variabel bolean yang digunakan untuk menandai apakah operasi matematika sudah selesai

        public Form1()
        {
            InitializeComponent(); //inisialisasi GUI
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "2";
            }
            else
            {
                txtDisplay1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "3";
            }
            else
            {
                txtDisplay1.Text += "3";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "5";
            }
            else
            {
                txtDisplay1.Text += "5";
            }

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "4";
            }
            else
            {
                txtDisplay1.Text += "4";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "7";
            }
            else
            {
                txtDisplay1.Text += "7";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtDisplay1.Text);
            txtDisplay2.Text = "÷";
            txtDisplay1.Text = " ";
            opr = 2;
            opr_selesai = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "o")
            {
                txtDisplay1.Text = "9";
            }
            else
            {
                txtDisplay1.Text += "9";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "1";
            }
            else
            {
                txtDisplay1.Text += "1";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "5";
            }
            else
            {
                txtDisplay1.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "6";
            }
            else
            {
                txtDisplay1.Text += "6";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "8";
            }
            else
            {
                txtDisplay1.Text += "8";
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtDisplay1.Text);
            txtDisplay2.Text = "+";
            txtDisplay1.Text = " ";
            opr = 4;
            opr_selesai = true;
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtDisplay1.Text);
            txtDisplay2.Text = "-";
            txtDisplay1.Text = " ";
            opr = 2;
            opr_selesai = true;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "0";
            }
            else
            {
                txtDisplay1.Text += "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay1.Text = "0";
            bil1 = 0;
            bil2 = 0;
            txtDisplay2.Text = " ";
        }

        private void btnKoma_Click(object sender, EventArgs e)
        {
             if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = ",";
            }
            else
            {
                txtDisplay1.Text += ",";
            }

        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtDisplay1.Text);
            txtDisplay2.Text = "x";
            txtDisplay1.Text = " ";
            opr = 1;
            opr_selesai = true;
        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            if (opr_selesai == true)
                bil2 = Convert.ToDecimal(txtDisplay1.Text);
            {
                switch (opr)
                {
                    case 1:
                        txtDisplay1.Text = Convert.ToString(bil1 * bil2);
                        break;
                    case 2:
                        txtDisplay1.Text = Convert.ToString(bil1 / bil2);
                        break;
                    case 3:
                        txtDisplay1.Text = Convert.ToString(bil1 - bil2);
                        break;
                    case 4:
                        txtDisplay1.Text = Convert.ToString(bil1 + bil2);
                        break;

                }
                opr_selesai = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDisplay1_TextChanged(object sender, EventArgs e)
        {
`
        }
    }
}
