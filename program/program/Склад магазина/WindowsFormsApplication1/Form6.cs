using System;
using System.Windows.Forms;
using MFP.DataLayer;

namespace WindowsFormsApplication1
{
    public partial class Form6 : Form
    {
        private DBWrapper oDBWrapper;
        public Form6(DBWrapper oDBWrapper)
        {
            InitializeComponent();
            this.oDBWrapper = oDBWrapper;
            dataGridView1.DataSource = oDBWrapper.FillDataSet("Select * From Модель_бытовой_техники");
            comboBox2.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Производитель");
            comboBox2.DisplayMember = "Наименование";
            comboBox2.ValueMember = "Код_производителя";

            comboBox1.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Тип_бытовой_техники");
            comboBox1.DisplayMember = "Наименование";
            comboBox1.ValueMember = "Код_типа";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            
                if (MessageBox.Show("Подтвердите удаление выбранной записи?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    oDBWrapper.InsertUpdateDelete("DELETE FROM[dbo].[Модель_бытовой_техники] WHERE Модель = '"+dataGridView1[0, dataGridView1.CurrentRow.Index].Value+"'");
                }
                dataGridView1.DataSource = oDBWrapper.FillDataSet("Select * From Модель_бытовой_техники");
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
           // MessageBox.Show(comboBox2.SelectedValue.ToString());
              //  oDBWrapper.InsertUpdateDelete("EXECUTE ДобавитьМодель '" + textBox1.Text + "','" + textBox2.Text + "'," + Convert.ToInt32(textBox3.Text) + ",'" + richTextBox1.Text + "','" + textBox4.Text + "'," + Convert.ToInt32(textBox5.Text) + ",'" + textBox6.Text + "'," + 0 + "," + Convert.ToInt32(comboBox2.SelectedValue.ToString()) + "," + Convert.ToInt32(comboBox1.SelectedValue.ToString()));
                  if (MessageBox.Show("Подтвердите добавление выбранной записи?", "Добавление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                  {
                      if (textBox1.Text == "") throw new Exception("Введите значения");
                      oDBWrapper.InsertUpdateDelete("EXECUTE ДобавитьМодель '" + textBox1.Text + "','" + textBox2.Text + "'," + Convert.ToInt32(textBox3.Text) + ",'" + richTextBox1.Text + "','" + textBox4.Text + "'," + Convert.ToInt32(textBox5.Text) + ",'" + textBox6.Text + "'," + 0 + "," + Convert.ToInt32(comboBox2.SelectedValue.ToString()) + "," + Convert.ToInt32(comboBox1.SelectedValue.ToString()));
                  }
                  dataGridView1.DataSource = oDBWrapper.FillDataSet("Select * From Модель_бытовой_техники");
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);
              }
            }
    }
}
