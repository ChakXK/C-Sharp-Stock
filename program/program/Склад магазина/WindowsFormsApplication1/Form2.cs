using System;
using System.Windows.Forms;
using MFP.DataLayer;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        private DBWrapper oDBWrapper;
        public Form2(DBWrapper oDBWrapper)
        {
            this.oDBWrapper = oDBWrapper;
            InitializeComponent();
            dataGridView1.DataSource = oDBWrapper.FillDataSet("SELECT Производитель.Наименование, Страна.Название FROM Страна INNER JOIN Производитель ON dbo.Страна.Код_страны = dbo.Производитель.Код_страны");
            dataGridView2.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Поставщик");
            dataGridView3.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Тип_бытовой_техники");
            dataGridView4.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Страна");

        }

        //DELETE
        private void button6_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                try
                {
                    if (MessageBox.Show("Подтвердите удаление выбранной записи?", "Изменение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        oDBWrapper.InsertUpdateDelete("EXEC УдалитьПроизводителя " + dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
                        dataGridView1.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Производитель");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (tabControl1.SelectedIndex == 1)
            {
                try
                {
                        if (MessageBox.Show("Подтвердите удаление выбранной записи?", "Изменение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            oDBWrapper.InsertUpdateDelete("EXEC УдалитьПоставщика " + dataGridView2[0, dataGridView2.CurrentRow.Index].Value);
                            dataGridView2.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Поставщик");
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (tabControl1.SelectedIndex == 2)
            {
                try
                {
                    if (MessageBox.Show("Подтвердите удаление выбранной записи?", "Изменение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        oDBWrapper.InsertUpdateDelete("EXEC УдалитьТип " + dataGridView3[0, dataGridView3.CurrentRow.Index].Value);
                        dataGridView3.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Тип_бытовой_техники");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (tabControl1.SelectedIndex == 3)
            {
                try
                {
                    if (MessageBox.Show("Подтвердите удаление выбранной записи?", "Изменение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        oDBWrapper.InsertUpdateDelete("EXEC УдалитьСтрану " + dataGridView4[0, dataGridView4.CurrentRow.Index].Value);
                        dataGridView4.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Страна"); ;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //CHANGE
        private void button5_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                try
                {
                    if (textBox1.Text == "") throw new Exception("Введите наименования");
                    if (MessageBox.Show("Подтвердите изменение выбранной записи?", "Изменение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        oDBWrapper.InsertUpdateDelete("EXEC ИзменитьПроизводителя " + dataGridView1[0, dataGridView1.CurrentRow.Index].Value+",'"+textBox1.Text+"'");
                        dataGridView1.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Производитель");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (tabControl1.SelectedIndex == 1)
            {
                try
                {
                    if (textBox2.Text == "" || textBox5.Text == "") throw new Exception("Введите значение");
                    if (textBox2.Text != "") 
                    if (MessageBox.Show("Подтвердите изменение наименование выбранной записи?", "Изменение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        oDBWrapper.InsertUpdateDelete("EXEC ИзменитьрПоставщика " + dataGridView2[0, dataGridView2.CurrentRow.Index].Value + ",'" + textBox2.Text + "'");
                        dataGridView2.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Поставщик");
                    }
                    if (textBox5.Text != "")
                        if (MessageBox.Show("Подтвердите изменение номера телефона выбранной записи?", "Изменение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            oDBWrapper.InsertUpdateDelete("EXEC ИзменитьНомерПоставщика " + dataGridView2[0, dataGridView2.CurrentRow.Index].Value + ",'" + textBox5.Text + "'");
                            dataGridView2.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Поставщик");
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (tabControl1.SelectedIndex == 2)
            {
                try
                {
                    if (textBox3.Text == "") throw new Exception("Введите наименования");
                    if (MessageBox.Show("Подтвердите изменение выбранной записи?", "Изменение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        oDBWrapper.InsertUpdateDelete("EXEC ИзменитьТип " + dataGridView3[0, dataGridView3.CurrentRow.Index].Value + ",'" + textBox3.Text + "'");
                        dataGridView3.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Тип_бытовой_техники");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (tabControl1.SelectedIndex == 3)
            {
                try
                {
                    if (textBox4.Text == "") throw new Exception("Введите название");
                    if (MessageBox.Show("Подтвердите изменение выбранной записи?", "Изменение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        oDBWrapper.InsertUpdateDelete("EXEC ИзменитьСтрану " + dataGridView4[0, dataGridView4.CurrentRow.Index].Value + ",'" + textBox4.Text+"'");
                        dataGridView4.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Страна"); ;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //ADD
        private void button7_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                try
                {
                    if (textBox1.Text == "") throw new Exception("Введите наименования");
                    if (MessageBox.Show("Подтвердите добавление новой записи?", "Добавление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        oDBWrapper.InsertUpdateDelete("EXEC ДобавитьПроизводителя '" + textBox1.Text + "'," + 6);
                        dataGridView1.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Производитель");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (tabControl1.SelectedIndex == 1)
            {
                try
                {
                    if (textBox2.Text == "") throw new Exception("Введите наименования");
                    if (textBox5.Text == "") throw new Exception("Введите номер телефона");
                    if (MessageBox.Show("Подтвердите добавление новой записи?", "Добавление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        oDBWrapper.InsertUpdateDelete("EXEC ДобавитьПоставщика '" + textBox2.Text + "','" + textBox5.Text+"'");
                        dataGridView2.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Поставщик");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (tabControl1.SelectedIndex == 2)
            {
                try
                {
                    if (textBox3.Text == "") throw new Exception("Введите наименования");
                    if (MessageBox.Show("Подтвердите добавление новой записи?", "Добавление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        oDBWrapper.InsertUpdateDelete("EXEC ДобавитьТип '" + textBox3.Text+"'");
                        dataGridView3.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Тип_бытовой_техники");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (tabControl1.SelectedIndex == 3)
            {
                try
                {
                    if (textBox4.Text == "") throw new Exception("Введите название");
                    if (MessageBox.Show("Подтвердите добавление новой записи?", "Добавление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        oDBWrapper.InsertUpdateDelete("EXEC ДобавитьСтрану '" + textBox4.Text+"'");
                        dataGridView4.DataSource = oDBWrapper.FillDataSet("SELECT * FROM Страна"); ;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
