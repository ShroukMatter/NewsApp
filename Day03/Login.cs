﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Day03.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Day03
{
    public partial class Login : Form
    {
        PaperContext DB;

        public Login()
        {
            InitializeComponent();
            DB = new PaperContext();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private void login_btn_Click(object sender, EventArgs e)
        {

            if (nameTxt.Text == "" || passTxt.Text == "")
            {
                MessageBox.Show("Some Ifno missing , Pls Enter Full data");
            }

            else
            {
                bool found = false;
                foreach (var auth in DB.Authors.ToList())
                {
                    if (auth.Username == nameTxt.Text && auth.Password == passTxt.Text)
                    {
                        this.Hide();
                        Profile form = new Profile(auth.Id, nameTxt.Text);
                        form.ShowDialog();
                        this.Close();
                        found = true;
                        return;
                    }

                };
                if (!found)
                {
                    MessageBox.Show("Invalid Username or Password");

                }
            }
        }

        private void passTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
