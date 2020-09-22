using System;
using System.Windows.Forms;
using MFP.DataLayer;
using System.IO;


namespace WindowsFormsApplication1
{
   
    public partial class Form7 : Form
    {
        private DBWrapper oDBWrapper;
        public Form7(DBWrapper oDBWrapper)
        {
            this.oDBWrapper = oDBWrapper;
            InitializeComponent();
            dataGridView1.DataSource = oDBWrapper.FillDataSet("SELECT Поставка.Код_поставки, Поставка.Дата, Поставщик.Наименование FROM Поставка INNER JOIN Поставщик ON Поставка.Код_поставщика = Поставщик.Код_поставщика");
            comboBox1.DataSource = oDBWrapper.FillDataSet("Select * From Поставщик");
            comboBox1.DisplayMember = "Наименование";
            comboBox1.ValueMember = "Код_поставщика";
            //dataGridView2.DataSource = oDBWrapper.FillDataSet("Select * From СоставПоставки Where Код_поставки= "+ Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = oDBWrapper.FillDataSet("SELECT Поставка.Код_поставки, Поставка.Дата, Поставщик.Наименование FROM Поставка INNER JOIN Поставщик ON Поставка.Код_поставщика = Поставщик.Код_поставщика");
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = oDBWrapper.FillDataSet("Select * From ПоказатьТоварыПоПоставке(" + Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value)+")");

            label6.Text = oDBWrapper.FillDataSet("SELECT SUM(Количество*Цена_за_1шт) FROM ПоказатьТоварыПоПоставке("+ dataGridView1[0, dataGridView1.CurrentRow.Index].Value + ")").Rows[0][0].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               if(textBox1.Text=="" || textBox2.Text =="") throw new Exception("Введите даты");
                {
                    dataGridView1.DataSource = oDBWrapper.FillDataSet("SELECT Поставка.Код_поставки, Поставка.Дата, Поставщик.Наименование FROM Поставка INNER JOIN Поставщик ON Поставка.Код_поставщика = Поставщик.Код_поставщика Where Дата Between '" + textBox1.Text + "' AND '"+textBox2.Text+"'");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = oDBWrapper.FillDataSet("SELECT Поставка.Код_поставки, Поставка.Дата, Поставщик.Наименование FROM Поставка INNER JOIN Поставщик ON Поставка.Код_поставщика = Поставщик.Код_поставщика Where Поставка.Код_поставщика=" + Convert.ToInt32(comboBox1.SelectedValue.ToString()));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = oDBWrapper.FillDataSet("SELECT Поставка.Код_поставки, Поставка.Дата, Поставщик.Наименование FROM Поставка INNER JOIN Поставщик ON Поставка.Код_поставщика = Поставщик.Код_поставщика ORDER BY Код_поставки");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = oDBWrapper.FillDataSet("SELECT Поставка.Код_поставки, Поставка.Дата, Поставщик.Наименование FROM Поставка INNER JOIN Поставщик ON Поставка.Код_поставщика = Поставщик.Код_поставщика ORDER BY дата");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = oDBWrapper.FillDataSet("SELECT Поставка.Код_поставки, Поставка.Дата, Поставщик.Наименование FROM Поставка INNER JOIN Поставщик ON Поставка.Код_поставщика = Поставщик.Код_поставщика ORDER BY Поставщик.Код_поставщика");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "") throw new Exception("Введите даты!");
                TextWriter writer = new StreamWriter(@"D:\File.txt");
                writer.WriteLine("Отчет с "+textBox1.Text+" по "+ textBox2.Text);
                writer.WriteLine();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }
                    writer.WriteLine("");
                    writer.WriteLine("--------------------------------------------------------------------------------------");
                }
                writer.Close();
                MessageBox.Show("Экспортировано!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
