﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class AccountCreated : Form
    {
        public AccountCreated()
        {
            InitializeComponent();
        }

        public void SetLogText(string text)
        {
            log.Text = text;
        }

        private void log_Click(object sender, EventArgs e)
        {

        }
    }
}
