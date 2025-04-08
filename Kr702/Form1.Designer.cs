namespace Kr702
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            таблицяToolStripMenuItem = new ToolStripMenuItem();
            записиToolStripMenuItem = new ToolStripMenuItem();
            додатиToolStripMenuItem = new ToolStripMenuItem();
            видалитиToolStripMenuItem = new ToolStripMenuItem();
            редагуватиToolStripMenuItem = new ToolStripMenuItem();
            запитиToolStripMenuItem = new ToolStripMenuItem();
            звітиToolStripMenuItem = new ToolStripMenuItem();
            налаштуванняToolStripMenuItem = new ToolStripMenuItem();
            панельІнструментівToolStripMenuItem = new ToolStripMenuItem();
            довідкаToolStripMenuItem = new ToolStripMenuItem();
            проПрограмуToolStripMenuItem = new ToolStripMenuItem();
            проАвтораToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            statusStrip1 = new StatusStrip();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            textBox4 = new TextBox();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { таблицяToolStripMenuItem, записиToolStripMenuItem, запитиToolStripMenuItem, звітиToolStripMenuItem, налаштуванняToolStripMenuItem, довідкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(888, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // таблицяToolStripMenuItem
            // 
            таблицяToolStripMenuItem.Name = "таблицяToolStripMenuItem";
            таблицяToolStripMenuItem.Size = new Size(65, 20);
            таблицяToolStripMenuItem.Text = "Таблиця";
            // 
            // записиToolStripMenuItem
            // 
            записиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { додатиToolStripMenuItem, видалитиToolStripMenuItem, редагуватиToolStripMenuItem });
            записиToolStripMenuItem.Name = "записиToolStripMenuItem";
            записиToolStripMenuItem.Size = new Size(59, 20);
            записиToolStripMenuItem.Text = "Записи";
            // 
            // додатиToolStripMenuItem
            // 
            додатиToolStripMenuItem.Name = "додатиToolStripMenuItem";
            додатиToolStripMenuItem.Size = new Size(134, 22);
            додатиToolStripMenuItem.Text = "Додати";
            додатиToolStripMenuItem.Click += button2_Click;
            // 
            // видалитиToolStripMenuItem
            // 
            видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            видалитиToolStripMenuItem.Size = new Size(134, 22);
            видалитиToolStripMenuItem.Text = "Видалити";
            видалитиToolStripMenuItem.Click += button1_Click;
            // 
            // редагуватиToolStripMenuItem
            // 
            редагуватиToolStripMenuItem.Name = "редагуватиToolStripMenuItem";
            редагуватиToolStripMenuItem.Size = new Size(134, 22);
            редагуватиToolStripMenuItem.Text = "Редагувати";
            // 
            // запитиToolStripMenuItem
            // 
            запитиToolStripMenuItem.Name = "запитиToolStripMenuItem";
            запитиToolStripMenuItem.Size = new Size(58, 20);
            запитиToolStripMenuItem.Text = "Запити";
            // 
            // звітиToolStripMenuItem
            // 
            звітиToolStripMenuItem.Name = "звітиToolStripMenuItem";
            звітиToolStripMenuItem.Size = new Size(47, 20);
            звітиToolStripMenuItem.Text = "Звіти";
            // 
            // налаштуванняToolStripMenuItem
            // 
            налаштуванняToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { панельІнструментівToolStripMenuItem });
            налаштуванняToolStripMenuItem.Name = "налаштуванняToolStripMenuItem";
            налаштуванняToolStripMenuItem.Size = new Size(101, 20);
            налаштуванняToolStripMenuItem.Text = "Налаштування";
            // 
            // панельІнструментівToolStripMenuItem
            // 
            панельІнструментівToolStripMenuItem.Checked = true;
            панельІнструментівToolStripMenuItem.CheckOnClick = true;
            панельІнструментівToolStripMenuItem.CheckState = CheckState.Checked;
            панельІнструментівToolStripMenuItem.Name = "панельІнструментівToolStripMenuItem";
            панельІнструментівToolStripMenuItem.Size = new Size(188, 22);
            панельІнструментівToolStripMenuItem.Text = "Панель інструментів";
            панельІнструментівToolStripMenuItem.Click += панельІнструментівToolStripMenuItem_Click;
            // 
            // довідкаToolStripMenuItem
            // 
            довідкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { проПрограмуToolStripMenuItem, проАвтораToolStripMenuItem });
            довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            довідкаToolStripMenuItem.Size = new Size(61, 20);
            довідкаToolStripMenuItem.Text = "Довідка";
            // 
            // проПрограмуToolStripMenuItem
            // 
            проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            проПрограмуToolStripMenuItem.Size = new Size(154, 22);
            проПрограмуToolStripMenuItem.Text = "Про програму";
            проПрограмуToolStripMenuItem.Click += проПрограмуToolStripMenuItem_Click;
            // 
            // проАвтораToolStripMenuItem
            // 
            проАвтораToolStripMenuItem.Name = "проАвтораToolStripMenuItem";
            проАвтораToolStripMenuItem.Size = new Size(154, 22);
            проАвтораToolStripMenuItem.Text = "Про автора";
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 54);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(290, 15);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Додати";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(380, 15);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Видалити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 571);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(888, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(139, 81);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(749, 442);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(741, 414);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Таблиця";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(819, 425);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(741, 414);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Доадати";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(741, 414);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Редагувати";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(741, 414);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Звіти";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(57, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(57, 163);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 23);
            textBox3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(57, 211);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 129);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(88, 364);
            button3.Name = "button3";
            button3.Size = new Size(121, 23);
            button3.TabIndex = 4;
            button3.Text = "Завантажити...";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(278, 46);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(440, 294);
            textBox4.TabIndex = 5;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F);
            button4.Location = new Point(401, 346);
            button4.Name = "button4";
            button4.Size = new Size(257, 36);
            button4.TabIndex = 6;
            button4.Text = "Зберегти запис";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 44);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 7;
            label1.Text = "Прізвище";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 95);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 8;
            label2.Text = "Група";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 145);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 9;
            label3.Text = "С. бал";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 195);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 10;
            label4.Text = "Фото";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(281, 29);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 11;
            label5.Text = "Характеристика";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 593);
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Кр ПрограмуванняСистема класний керівни";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem таблицяToolStripMenuItem;
        private ToolStripMenuItem записиToolStripMenuItem;
        private ToolStripMenuItem додатиToolStripMenuItem;
        private ToolStripMenuItem видалитиToolStripMenuItem;
        private ToolStripMenuItem редагуватиToolStripMenuItem;
        private ToolStripMenuItem запитиToolStripMenuItem;
        private ToolStripMenuItem звітиToolStripMenuItem;
        private ToolStripMenuItem налаштуванняToolStripMenuItem;
        private ToolStripMenuItem довідкаToolStripMenuItem;
        private Panel panel1;
        private StatusStrip statusStrip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private ToolStripMenuItem панельІнструментівToolStripMenuItem;
        private Button button1;
        private ToolStripMenuItem проПрограмуToolStripMenuItem;
        private ToolStripMenuItem проАвтораToolStripMenuItem;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button4;
        private TextBox textBox4;
        private Button button3;
        private PictureBox pictureBox1;
    }
}
