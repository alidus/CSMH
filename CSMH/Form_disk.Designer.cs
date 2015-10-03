namespace CSMH
{
    partial class Form_disk
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_go_to_mainform = new System.Windows.Forms.Button();
            this.textBox_disk_a = new System.Windows.Forms.TextBox();
            this.textBox_disk_b = new System.Windows.Forms.TextBox();
            this.textBox_disk_c = new System.Windows.Forms.TextBox();
            this.label_disk_a = new System.Windows.Forms.Label();
            this.label_disk_b = new System.Windows.Forms.Label();
            this.label_disk_c = new System.Windows.Forms.Label();
            this.textBox_disk_disk = new System.Windows.Forms.TextBox();
            this.label_disk_disk = new System.Windows.Forms.Label();
            this.textBox_disk_root1 = new System.Windows.Forms.TextBox();
            this.textBox_disk_root2 = new System.Windows.Forms.TextBox();
            this.label_disk_roo1 = new System.Windows.Forms.Label();
            this.label_disk_root2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_go_to_mainform
            // 
            this.button_go_to_mainform.Location = new System.Drawing.Point(12, 263);
            this.button_go_to_mainform.Name = "button_go_to_mainform";
            this.button_go_to_mainform.Size = new System.Drawing.Size(75, 23);
            this.button_go_to_mainform.TabIndex = 0;
            this.button_go_to_mainform.Text = "На главную";
            this.button_go_to_mainform.UseVisualStyleBackColor = true;
            this.button_go_to_mainform.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_disk_a
            // 
            this.textBox_disk_a.Location = new System.Drawing.Point(12, 45);
            this.textBox_disk_a.Name = "textBox_disk_a";
            this.textBox_disk_a.Size = new System.Drawing.Size(100, 20);
            this.textBox_disk_a.TabIndex = 1;
            this.textBox_disk_a.TextChanged += new System.EventHandler(this.textBox_disk_a_TextChanged);
            // 
            // textBox_disk_b
            // 
            this.textBox_disk_b.Location = new System.Drawing.Point(12, 84);
            this.textBox_disk_b.Name = "textBox_disk_b";
            this.textBox_disk_b.Size = new System.Drawing.Size(100, 20);
            this.textBox_disk_b.TabIndex = 2;
            this.textBox_disk_b.TextChanged += new System.EventHandler(this.textBox_disk_b_TextChanged);
            // 
            // textBox_disk_c
            // 
            this.textBox_disk_c.Location = new System.Drawing.Point(12, 123);
            this.textBox_disk_c.Name = "textBox_disk_c";
            this.textBox_disk_c.Size = new System.Drawing.Size(100, 20);
            this.textBox_disk_c.TabIndex = 3;
            this.textBox_disk_c.TextChanged += new System.EventHandler(this.textBox_disk_c_TextChanged);
            // 
            // label_disk_a
            // 
            this.label_disk_a.AutoSize = true;
            this.label_disk_a.Location = new System.Drawing.Point(9, 29);
            this.label_disk_a.Name = "label_disk_a";
            this.label_disk_a.Size = new System.Drawing.Size(108, 13);
            this.label_disk_a.TabIndex = 4;
            this.label_disk_a.Text = "Введите значение a";
            // 
            // label_disk_b
            // 
            this.label_disk_b.AutoSize = true;
            this.label_disk_b.Location = new System.Drawing.Point(9, 68);
            this.label_disk_b.Name = "label_disk_b";
            this.label_disk_b.Size = new System.Drawing.Size(108, 13);
            this.label_disk_b.TabIndex = 5;
            this.label_disk_b.Text = "Введите значение b";
            // 
            // label_disk_c
            // 
            this.label_disk_c.AutoSize = true;
            this.label_disk_c.Location = new System.Drawing.Point(9, 107);
            this.label_disk_c.Name = "label_disk_c";
            this.label_disk_c.Size = new System.Drawing.Size(108, 13);
            this.label_disk_c.TabIndex = 6;
            this.label_disk_c.Text = "Введите значение c";
            // 
            // textBox_disk_disk
            // 
            this.textBox_disk_disk.Location = new System.Drawing.Point(149, 84);
            this.textBox_disk_disk.Name = "textBox_disk_disk";
            this.textBox_disk_disk.Size = new System.Drawing.Size(100, 20);
            this.textBox_disk_disk.TabIndex = 7;
            // 
            // label_disk_disk
            // 
            this.label_disk_disk.AutoSize = true;
            this.label_disk_disk.Location = new System.Drawing.Point(156, 68);
            this.label_disk_disk.Name = "label_disk_disk";
            this.label_disk_disk.Size = new System.Drawing.Size(83, 13);
            this.label_disk_disk.TabIndex = 8;
            this.label_disk_disk.Text = "Дискриминант";
            // 
            // textBox_disk_root1
            // 
            this.textBox_disk_root1.Location = new System.Drawing.Point(301, 68);
            this.textBox_disk_root1.Name = "textBox_disk_root1";
            this.textBox_disk_root1.Size = new System.Drawing.Size(100, 20);
            this.textBox_disk_root1.TabIndex = 9;
            // 
            // textBox_disk_root2
            // 
            this.textBox_disk_root2.Location = new System.Drawing.Point(301, 107);
            this.textBox_disk_root2.Name = "textBox_disk_root2";
            this.textBox_disk_root2.Size = new System.Drawing.Size(100, 20);
            this.textBox_disk_root2.TabIndex = 10;
            // 
            // label_disk_roo1
            // 
            this.label_disk_roo1.AutoSize = true;
            this.label_disk_roo1.Location = new System.Drawing.Point(298, 52);
            this.label_disk_roo1.Name = "label_disk_roo1";
            this.label_disk_roo1.Size = new System.Drawing.Size(86, 13);
            this.label_disk_roo1.TabIndex = 11;
            this.label_disk_roo1.Text = "Первый корень";
            // 
            // label_disk_root2
            // 
            this.label_disk_root2.AutoSize = true;
            this.label_disk_root2.Location = new System.Drawing.Point(298, 91);
            this.label_disk_root2.Name = "label_disk_root2";
            this.label_disk_root2.Size = new System.Drawing.Size(82, 13);
            this.label_disk_root2.TabIndex = 12;
            this.label_disk_root2.Text = "Второй корень";
            this.label_disk_root2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_disk
            // 
            this.ClientSize = new System.Drawing.Size(446, 298);
            this.Controls.Add(this.label_disk_root2);
            this.Controls.Add(this.label_disk_roo1);
            this.Controls.Add(this.textBox_disk_root2);
            this.Controls.Add(this.textBox_disk_root1);
            this.Controls.Add(this.label_disk_disk);
            this.Controls.Add(this.textBox_disk_disk);
            this.Controls.Add(this.label_disk_c);
            this.Controls.Add(this.label_disk_b);
            this.Controls.Add(this.label_disk_a);
            this.Controls.Add(this.textBox_disk_c);
            this.Controls.Add(this.textBox_disk_b);
            this.Controls.Add(this.textBox_disk_a);
            this.Controls.Add(this.button_go_to_mainform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_disk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вычисление дискриминанта";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_go_to_mainform;
        private System.Windows.Forms.TextBox textBox_disk_a;
        private System.Windows.Forms.TextBox textBox_disk_b;
        private System.Windows.Forms.TextBox textBox_disk_c;
        private System.Windows.Forms.Label label_disk_a;
        private System.Windows.Forms.Label label_disk_b;
        private System.Windows.Forms.Label label_disk_c;
        private System.Windows.Forms.TextBox textBox_disk_disk;
        private System.Windows.Forms.Label label_disk_disk;
        private System.Windows.Forms.TextBox textBox_disk_root1;
        private System.Windows.Forms.TextBox textBox_disk_root2;
        private System.Windows.Forms.Label label_disk_roo1;
        private System.Windows.Forms.Label label_disk_root2;
    }
}
