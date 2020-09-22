using System;
using System.Windows.Forms;
using MFP.DataLayer;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        private DBWrapper oDBWrapper;
        private int countModels;
        private int countCode;
        private int[] Codes;
        public Form5(DBWrapper oDBWrapper)
        {
            InitializeComponent();
            this.oDBWrapper = oDBWrapper;
            comboBox1.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Поставщик");
            comboBox1.DisplayMember = "Наименование";
            comboBox1.ValueMember = "Код_поставщика";

            comboBox2.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Модель_бытовой_техники");
            comboBox2.DisplayMember = "Модель";
            comboBox2.ValueMember = "Модель";

            comboBox3.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Модель_бытовой_техники");
            comboBox3.DisplayMember = "Модель";
            comboBox3.ValueMember = "Модель";

            dataGridView1.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Поставка");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboBox1.SelectedValue.ToString() != "")
                {
                    if (MessageBox.Show("Подтвердите добавления выбранной записи?", "Добавление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                        oDBWrapper.InsertUpdateDelete("EXEC ДобавитьПоставку "  + id);
                        comboBox1.Enabled = false;
                        textBox1.Enabled = true;
                        comboBox2.Enabled = true;
                        //textBox2.Enabled = true;
                        button1.Enabled = true;
                        button3.Enabled = false;

                        dataGridView1.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Поставка");
                    }
                }
                else throw new Exception("Введите значения");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.SelectedValue.ToString() == "" || textBox1.Text == "") throw new Exception("Введите значения");
                if (MessageBox.Show("Подтвердите добавления выбранной записи?", "Добавление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    oDBWrapper.InsertUpdateDelete("EXEC ДобавитьСоставПоставки '" + comboBox2.SelectedValue.ToString() + "','" + textBox1.Text + "'");
                   // oDBWrapper.InsertUpdateDelete("EXEC ДобавитьКоличествоТовара '" + comboBox2.SelectedValue.ToString() + "'," + Convert.ToInt32(textBox2.Text + ""));
                }
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
                if (textBox3.Text == "" || comboBox3.SelectedValue.ToString() == "") throw new Exception("Введите значения");
                if (MessageBox.Show("Подтвердите добавления выбранной записи?", "Добавление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    oDBWrapper.InsertUpdateDelete("EXEC ДобавитьТовар '" + textBox3.Text + "','" + comboBox3.SelectedValue.ToString() + "'," + dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
                    oDBWrapper.InsertUpdateDelete("EXEC ДобавитьКоличествоТовара '" + comboBox2.SelectedValue.ToString() + "'," + 1);
                }
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(oDBWrapper);
            f6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox2.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Модель_бытовой_техники");
            comboBox2.DisplayMember = "Модель";
            comboBox2.ValueMember = "Модель";
        }
    }
}
