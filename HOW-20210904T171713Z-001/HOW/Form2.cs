﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passo1_Click(object sender, EventArgs e)
        {
            string tam;

            tam = checkedListBox1.Text;

            MessageBox.Show("tamanho:" + tam);
        }
    }
}