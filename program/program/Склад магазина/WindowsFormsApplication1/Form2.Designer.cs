namespace WindowsFormsApplication1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(847, 376);
            this.dataGridView1.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Location = new System.Drawing.Point(16, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 48);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.Location = new System.Drawing.Point(120, 7);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 55);
            this.button6.TabIndex = 7;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.Location = new System.Drawing.Point(68, 10);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 49);
            this.button7.TabIndex = 8;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(867, 547);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(859, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Производители";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 26);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(859, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Поставщики";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 132);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(847, 376);
            this.dataGridView2.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(154, 56);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(282, 26);
            this.textBox5.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Номер телефона";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(287, 26);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Наименование";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(859, 514);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Типы Б-техники";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 132);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(847, 376);
            this.dataGridView3.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(48, 14);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(382, 26);
            this.textBox3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Тип";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Controls.Add(this.textBox4);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(859, 514);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Страны";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView4.Location = new System.Drawing.Point(3, 132);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView4.RowTemplate.Height = 28;
            this.dataGridView4.Size = new System.Drawing.Size(847, 376);
            this.dataGridView4.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(95, 14);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(342, 26);
            this.textBox4.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Название";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
    }
}