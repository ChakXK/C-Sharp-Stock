namespace WindowsFormsApplication1
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TabControl tab;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            tab = new System.Windows.Forms.TabControl();
            tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            tab.Controls.Add(this.tabPage1);
            tab.Controls.Add(this.tabPage2);
            tab.Location = new System.Drawing.Point(5, 2);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new System.Drawing.Size(972, 630);
            tab.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(964, 597);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Оформить поставку";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Info;
            this.button5.Location = new System.Drawing.Point(735, 247);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(208, 36);
            this.button5.TabIndex = 21;
            this.button5.Text = "Добавить модель";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(667, 251);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 36);
            this.button4.TabIndex = 20;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Цена";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(269, 335);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Location = new System.Drawing.Point(264, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(465, 36);
            this.button3.TabIndex = 17;
            this.button3.Text = "Оформить поставку";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(269, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(465, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Оформить накладную";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Модель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Поставщик";
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(269, 256);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(380, 28);
            this.comboBox2.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(264, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(380, 28);
            this.comboBox1.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(964, 597);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить накладные на товары";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Модель";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(530, 266);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(380, 28);
            this.comboBox3.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(954, 170);
            this.dataGridView1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(445, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(465, 36);
            this.button2.TabIndex = 15;
            this.button2.Text = "Оформить накладную";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Серийный номер продукта";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(588, 209);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(322, 26);
            this.textBox3.TabIndex = 13;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(tab);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление поставки";
            tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}