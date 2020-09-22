using System;
using System.Windows.Forms;
using MFP.DataLayer;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private DBWrapper oDBWrapper;
        public Form1()
        {
            InitializeComponent();
            oDBWrapper = new DBWrapper(@"DESKTOP-Q3DJI2M\SQLEXPRESS", "СкладМагазина");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "") throw new Exception("Введите модель");
                dataGridView1.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Инфо_Модель('"+textBox1.Text+"')");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "") throw new Exception("Введите серийный номер");
                dataGridView1.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Инфо_СерНомер('" + textBox1.Text + "')");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(oDBWrapper);
            f2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3(oDBWrapper);
            f3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(oDBWrapper);
            f5.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(oDBWrapper);
            f7.Show();
        }
    }
}
