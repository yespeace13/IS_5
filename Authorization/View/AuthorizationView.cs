﻿using IS_5.Controler;
using IS_5.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_5.View
{
    public partial class AuthorizationView : Form
    {
        private AuthorizationController _controller;
        public bool UserSuccessfullyAuthenticated { get; private set; }
        public AuthorizationView()
        {
            InitializeComponent();
            _controller = new AuthorizationController();
            OkButton.Click += new EventHandler(OkButton_Click);
            label4.Text = "";
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            var log = LogTextBox.Text;
            var pass = PassTextBox.Text;
            if(_controller.GetPrivilege(log, pass))
            {
                UserSuccessfullyAuthenticated = true;
                Close();
            }
            else
            {
                label4.Text = "Неправильный логин или/и пароль";
                label4.ForeColor = Color.Red;
            }
        }
    }
}
