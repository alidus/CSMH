using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CSMH
{
    public partial class Form_disk : Form
    {
        private double a,b,c;
       private MainForm _f1;
        public Form_disk(MainForm form)
        {
            InitializeComponent();
             _f1 = form;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _f1.Show();
            this.Close();
        }

        private void textBox_disk_a_TextChanged(object sender, EventArgs e)
        {
            try
            {
               a = double.Parse(textBox_disk_a.Text);
                calculate_disk(true);
            }
            catch (Exception ex)
            {
                calculate_disk(false);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void calculate_disk(bool normal)
        {
            ProgramLogicName.ProgramLogic logic = new ProgramLogicName.ProgramLogic();
            double disk;
            double root1;
            double root2;
            int state;
            logic.FindDiskRoots(a, b, c, out disk, out state, out root1, out root2);
            if (normal)
            {
                switch (state)
                {
                    case 0:
                        textBox_disk_disk.Text = Math.Round(disk,4).ToString();
                        textBox_disk_root1.Text = "Корней нет";
                        textBox_disk_root2.Text = "Корней нет";
                        break;
                    case 1:
                        textBox_disk_disk.Text = Math.Round(disk, 4).ToString();
                        textBox_disk_root1.Text = Math.Round(root1, 4).ToString();
                        textBox_disk_root2.Text = "Второго корня нет";
                        break;
                    case 2:
                        textBox_disk_disk.Text = Math.Round(disk, 4).ToString();
                        textBox_disk_root1.Text = Math.Round(root1, 4).ToString();
                        textBox_disk_root2.Text = Math.Round(root2, 4).ToString();
                        break;
                }
            }
            else
            {
                textBox_disk_disk.Text = "Ошибка";
                textBox_disk_root1.Text = "Ошибка";
                textBox_disk_root2.Text = "Ошибка";
            }
        }
        private void textBox_disk_b_TextChanged(object sender, EventArgs e)
        {
            try
            {
                b = double.Parse(textBox_disk_b.Text);
                    calculate_disk(true);
            }
            catch (Exception ex)
            {
                calculate_disk(false);
            }
        }

        private void textBox_disk_c_TextChanged(object sender, EventArgs e)
        {
            try
            {
                c = double.Parse(textBox_disk_c.Text);
                calculate_disk(true);
            }
            catch (Exception ex)
            {
                calculate_disk(false);
            }
        }
    }
}
