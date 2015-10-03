using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMH
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (mainTextBox.Created) { mainTextBox.Text = "Выберите из числа доступных операций необходимую и введите сооветствующую цифру:\n1) Вычисление дискриминанта\n2) Посчитать определитель матрицы\n3) Операции с векторами"; };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_disk form2 = new Form_disk(this);
            form2.Show();
            this.Hide();
        }
    }
}
