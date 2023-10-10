namespace Activity_2
{
    public partial class Form1 : Form
    {
        float distance, waitinghrs, taxiservicecharge, additionalcharge, waitingcharges, discount;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void shownametxt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name;
            name = this.txt1.Text;                                 this textbox s Text
            this.shownametxt1.Text = name;




            distance = Convert.ToInt32(this.txt2.Text);
            waitinghrs = Convert.ToInt32(this.txt3.Text);
            taxiservicecharge = 75;
            additionalcharge = 50;

            if (distance > 20)
            {
                waitingcharges = waitinghrs * 200;
                taxiservicecharge = 1500 + (additionalcharge * (distance - 20)) + waitingcharges;
                this.textBox4.Text = waitingcharges.ToString();
            }
            else
            {
                waitingcharges = waitinghrs * 200;
                taxiservicecharge = (taxiservicecharge * distance) + waitingcharges;
                this.textBox6.Text = taxiservicecharge.ToString();
                this.textBox4.Text = waitingcharges.ToString();
            }


            if (this.comboBox1.SelectedIndex == 0)
            {
                discount = taxiservicecharge * 1 / 100;
                taxiservicecharge = taxiservicecharge - discount;
                this.textBox5.Text = discount.ToString();
                this.textBox6.Text = taxiservicecharge.ToString();
                if (this.radioButton1.Checked == true)
                {
                    this.discountshowtxt.Text = "1% Discount Added For our Regular Customer Mr." + name;
                }
                else if (this.radioButton2.Checked == true)
                {
                    this.discountshowtxt.Text = "1% Discount Added For our Regular Customer Mrs." + name;
                }

            }
            else if (this.comboBox1.SelectedIndex == 1)
            {
                discount = taxiservicecharge * 5 / 100;
                taxiservicecharge = taxiservicecharge - discount;
                this.textBox5.Text = discount.ToString();
                this.textBox6.Text = taxiservicecharge.ToString();
                if (this.radioButton1.Checked == true)
                {
                    this.discountshowtxt.Text = "5% Discount Added For our Loyal Customer Mr." + name;
                }
                else if (this.radioButton2.Checked == true)
                {
                    this.discountshowtxt.Text = "5% Discount Added For our Loyal Customer Mrs." + name;
                }

            }
            else if (this.comboBox1.SelectedIndex == 2)
            {
                discount = taxiservicecharge * 10 / 100;
                taxiservicecharge = taxiservicecharge - discount;
                this.textBox5.Text = discount.ToString();
                this.textBox6.Text = taxiservicecharge.ToString();
                if (this.radioButton1.Checked == true)
                {
                    this.discountshowtxt.Text = "10% Discount Added For our Member Mr." + name;
                }
                else if (this.radioButton2.Checked == true)
                {
                    this.discountshowtxt.Text = "10% Discount Added For our Member Mrs." + name;
                }

            }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}