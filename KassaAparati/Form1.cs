using KassaAparati.Entity;

namespace KassaAparati
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Product pro = new Product();
        int a = 1;
        int b = 1;
        int c = 1;
        int d = 1;
        decimal r1;
        decimal r2;
        decimal r3;
        decimal r4;
        decimal Result = 0.0M;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            object[] obj = { pro.ProductId = 201, pro.Name = "Sirab", pro.Number = a, pro.Price = 1.20M * a };
            object[] obj1 = { pro.ProductId = 202, pro.Name = "Coca-cola", pro.Number = b, pro.Price = 1.00M * b };
            object[] obj2 = { pro.ProductId = 203, pro.Name = "Efes", pro.Number = c, pro.Price = 2.20M * c };
            object[] obj3 = { pro.ProductId = 204, pro.Name = "Doritos", pro.Number = d, pro.Price = 1.50M * d };
            if (textBox1.Text == "201")
            {
                a++;

                if (a > 1)
                {
                    dataGridView1.Rows.Clear();
                }
                dataGridView1.Rows.Add(obj);
                
            }
            else if (textBox1.Text == "202")
            {
                b++;

                if (b > 1)
                {
                    dataGridView1.Rows.Clear();
                }
                
                dataGridView1.Rows.Add(obj1);

            }
            else if (textBox1.Text == "203")
            {
                c++;

                if (c > 1)
                {
                    dataGridView1.Rows.Clear();
                }
                
                dataGridView1.Rows.Add(obj2);
            }
            else if (textBox1.Text == "204")
            {
                d++;

                if (d > 1)
                {
                    dataGridView1.Rows.Clear();
                }
                
                dataGridView1.Rows.Add(obj3);
            }
            else if (textBox1.Text == string.Empty)
            {

                dataGridView1.Rows.Clear();

                dataGridView1.Rows.Add(obj);

                dataGridView1.Rows.Add(obj1);

                dataGridView1.Rows.Add(obj2);

                dataGridView1.Rows.Add(obj3);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a--;
            b--;
            c--;
            d--;
            button2_Click(sender, e);
            if (dataGridView1.Rows[0].Cells[3].Value != string.Empty)
            {
                r1 = Convert.ToDecimal(dataGridView1.Rows[0].Cells[3].Value);
            }
            else if (dataGridView1.Rows[1].Cells[3].Value != string.Empty)
            {
                r2 = Convert.ToDecimal(dataGridView1.Rows[1].Cells[3].Value);
            }
            else if (dataGridView1.Rows[2].Cells[3].Value != string.Empty)
            {
                r3 = Convert.ToDecimal(dataGridView1.Rows[2].Cells[3].Value);
            }
            else if (dataGridView1.Rows[3].Cells[3].Value != string.Empty)
            {
                r4 = Convert.ToDecimal(dataGridView1.Rows[3].Cells[3].Value);
            }
            Result = r1 + r2 + r3 + r4;
            label5.Text = Result.ToString();
        }
    }
}