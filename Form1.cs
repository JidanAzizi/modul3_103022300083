using System.Windows.Forms.VisualStyles;

namespace modul3_103022300083
{
    public partial class Form1 : Form
    {
        int A;
        int B;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nomor2 = btn2.Text;
            textBox1.Text += nomor2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String nomor3 = btn3.Text;
            textBox1.Text += nomor3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String nomor4 = btn4.Text;
            textBox1.Text += nomor4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String nomor5 = btn5.Text;
            textBox1.Text += nomor5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String nomor6 = btn6.Text;
            textBox1.Text += nomor6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String nomor7 = btn7.Text;
            textBox1.Text += nomor7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String nomor8 = btn8.Text;
            textBox1.Text += nomor8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String nomor9 = btn9.Text;
            textBox1.Text += nomor9;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            String nomor0 = btn0.Text;
            textBox1.Text += nomor0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            String nomor1 = btn1.Text;
            textBox1.Text += nomor1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String tambah = btnAdd.Text;
            //textBox1.Text += tambah;
            A = int.Parse(textBox1.Text);
            textBox1.Text = "";
            
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            //String hasil = btnResult.Text;
            //textBox1.Text += hasil;
            B = int.Parse(textBox1.Text);

            int hasil = A + B;
            String p = hasil.ToString();
            textBox1.Text = p;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
