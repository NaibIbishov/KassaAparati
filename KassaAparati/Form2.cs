using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KassaAparati
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //int i = dataGridView1.Rows.Add();

        //i = 0;
        //    dataGridView1.Rows[i].Cells[0].Value = 201;
        //    dataGridView1.Rows[i].Cells[1].Value = "Coca-Cola";
        //    dataGridView1.Rows[i].Cells[2].Value = "02.07.2023";
        //    dataGridView1.Rows[i].Cells[3].Value = "02.12.2023";
        //    dataGridView1.Rows[i].Cells[4].Value = "1,50 AZN";

        //    i = 1;
        //    dataGridView1.Rows[i].Cells[0].Value = 202;
        //    dataGridView1.Rows[i].Cells[1].Value = "DOritos";
        //    dataGridView1.Rows[i].Cells[2].Value = "02.07.2023";
        //    dataGridView1.Rows[i].Cells[3].Value = "02.10.2023";
        //    dataGridView1.Rows[i].Cells[4].Value = "1,80 AZN";

        //    i = 2;
        //    dataGridView1.Rows[i].Cells[0].Value = 203;
        //    dataGridView1.Rows[i].Cells[1].Value = "Pop-corn";
        //    dataGridView1.Rows[i].Cells[2].Value = "02.07.2023";
        //    dataGridView1.Rows[i].Cells[3].Value = "02.08.2023";
        //    dataGridView1.Rows[i].Cells[4].Value = "0,80 AZN";

        //    i = 3;
        //    dataGridView1.Rows[i].Cells[0].Value = 204;
        //    dataGridView1.Rows[i].Cells[1].Value = "Sirab";
        //    dataGridView1.Rows[i].Cells[2].Value = "02.07.2023";
        //    dataGridView1.Rows[i].Cells[3].Value = "10.01.2024";
        //    dataGridView1.Rows[i].Cells[4].Value = "1,00 AZN";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] Product = new string[6];
            Product[0] = "201";
            Product[1] = "Sirab";
            Product[2] = "02.07.2023";
            Product[3] = "10.10.2023";
            Product[4] = "1,20 AZN";
            string[] Product1 = new string[6];
            Product1[0] = "202";
            Product1[1] = "Coca-cola";
            Product1[2] = "02.07.2023";
            Product1[3] = "10.01.2024";
            Product1[4] = "1,00 AZN";
            string[] Product2 = new string[6];
            Product2[0] = "203";
            Product2[1] = "Efes";
            Product2[2] = "02.07.2023";
            Product2[3] = "11.12.2023";
            Product2[4] = "2,20 AZN";
            string[] Product3 = new string[6];
            Product3[0] = "204";
            Product3[1] = "Doritos";
            Product3[2] = "02.07.2023";
            Product3[3] = "10.01.2024";
            Product3[4] = "1,50 AZN";

            dataGridView1.Rows.Add(Product);
            dataGridView1.Rows.Add(Product1);
            dataGridView1.Rows.Add(Product2);
            dataGridView1.Rows.Add(Product3);
        }
    }
}
