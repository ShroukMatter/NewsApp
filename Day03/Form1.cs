using System.Security.Cryptography;
using Day03.Models;

namespace Day03
{
    public partial class Form1 : Form
    {
        PaperContext DB;
        public Form1()
        {
            InitializeComponent();
            DB = new PaperContext();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {


        }

        private void signUp_btn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "" || usernameTxt.Text == "" || passTxt.Text == "" || confirmPassTxt.Text == "")
            {
                MessageBox.Show("Please compelete your Info");
            }

            else
            {
                if (passTxt.Text != confirmPassTxt.Text)
                {
                    MessageBox.Show("Wrong Password");
                }
                else
                {
                    Author author = new Author()
                    {
                        Name = nameTxt.Text,
                        Username = usernameTxt.Text,
                        Password = passTxt.Text,
                        Joindate = DateTime.Now,
                    };

                    DB.Authors.Add(author);
                    DB.SaveChanges();

                    this.Hide();
                    Login logform = new Login();
                    logform.ShowDialog();
                    this.Close();
                }



            }








        }



        private void login_btn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
