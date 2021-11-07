using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOW
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void passo1_Click(object sender, EventArgs e)
        {
            Form4 _f4;
            _f4 = new Form4();
            _f4.Show();
            Hide();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            Form2 _f2;
            _f2 = new Form2();
            _f2.Show();
            Hide();
        }
    }
}
