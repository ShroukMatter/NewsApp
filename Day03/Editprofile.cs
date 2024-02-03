using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Day03.Models;

namespace Day03
{
    public partial class Editprofile : Form
    {
        string usrname;
        int userId;
        PaperContext DB;

        public Editprofile(int userId, string usrname)
        {
            InitializeComponent();
            this.usrname = usrname;
            this.userId = userId;
            DB = new PaperContext();
        }

        private void Editprofile_Load(object sender, EventArgs e)
        {
            userTxt.Text = usrname;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            Author author = DB.Authors.Where(n => n.Id == userId).SingleOrDefault();
            if (author.Password == oldpassTxt.Text)
            {
                author.Password = newpassTxt.Text;
                DB.SaveChanges();
                MessageBox.Show("Password Changed Successfully");

            }
            else
                MessageBox.Show("Old password not Valid");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile(userId,usrname);
            profile.ShowDialog();
            this.Close();
        }
    }
}
