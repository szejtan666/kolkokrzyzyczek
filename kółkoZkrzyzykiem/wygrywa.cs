﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kółkoZkrzyzykiem
{
    public partial class wygrywa : Form
    {
        public string Zwyciezca;
        private Form1 board;
        public wygrywa(Form1 b)
        {
            board = b;
            InitializeComponent();
        }

        private void PokaZwyciezce(object sender, EventArgs e)
        {
            zwyciezcaLabel.Text = "WYGRAŁ: " + Zwyciezca;
        }
    }
}