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
    public partial class Form4: Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblbairro_Click(object sender, EventArgs e)
        {

        }

        private void tbcep_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form3 _f3;
            _f3 = new Form3();
            _f3.Show();
            Hide();
        }

        private void passo1_Click(object sender, EventArgs e)
        {
            Form5 _f5;
            _f5 = new Form5();
            _f5.Show();
            Hide();
        }
    }
}
