using System;
using System.Windows.Forms;
using MFP.DataLayer;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        private DBWrapper oDBWrapper;
        public Form3(DBWrapper oDBWrapper)
        {
            this.oDBWrapper = oDBWrapper;
            InitializeComponent();
            dataGridView1.DataSource = oDBWrapper.FillDataSet("SELECT * FROM МинимальныйОстаток() ORDER BY Количество_на_складе");
        }
    }
}
