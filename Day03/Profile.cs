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
    public partial class Profile : Form
    {
        bool allNewsChecked = false;
        int userId;
        string userName;
        PaperContext DB;
        public Profile(int userId, string userName)
        {
            InitializeComponent();
            DB = new PaperContext();
            this.userId = userId;
            this.userName = userName;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            catalog_cmbo.DataSource = DB.Catalogs.ToList();
            catalog_cmbo.ValueMember = "id";
            catalog_cmbo.DisplayMember = "name";
            profile_btn.Text = userName;

            try
            {
                news_dgv.DataSource = DB.news.Where(n => n.authorId == userId).Select(n => new { n.id, Author = n.author.Name, n.title, n.description, n.date, n.time, catalog = n.catalog.name }).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            add_btn.Enabled = true;
            update_btn.Enabled = false;
            delete_btn.Enabled = false;

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            News news = new News()
            {
                title = titleTxt.Text,
                description = descTxt.Text,
                authorId = userId,
                time = TimeOnly.FromDateTime(DateTime.Now),
                date = DateOnly.FromDateTime(DateTime.Now),
                catalogId = (int)catalog_cmbo.SelectedValue


            };

            DB.Add(news);
            DB.SaveChanges();
            news_dgv.DataSource = DB.news.Where(n => n.authorId == userId).Select(n => new { n.id, Author = n.author.Name, n.title, n.description, n.date, n.time, catalog = n.catalog.name }).ToList();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            News selectednews = DB.news.Where(n => n.id == id).SingleOrDefault();

            selectednews.title = titleTxt.Text;
            selectednews.description = descTxt.Text;
            selectednews.catalogId = (int)catalog_cmbo.SelectedValue;

            DB.SaveChanges();

            news_dgv.DataSource = DB.news.Where(n => n.authorId == userId).Select(n => new { n.id, Author = n.author.Name, n.title, n.description, n.date, n.time, catalog = n.catalog.name }).ToList();

            titleTxt.Text = descTxt.Text = "";
            add_btn.Enabled = true;
            update_btn.Enabled = false;
            delete_btn.Enabled = false;





        }

        private void news_dgv_DoubleClick(object sender, EventArgs e)
        {

        }
        int id;
        private void news_dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!allNewsChecked)
            {
                id = (int)news_dgv.SelectedRows[0].Cells[0].Value;

                News selectednews = DB.news.Where(n => n.id == id).SingleOrDefault();

                titleTxt.Text = selectednews.title;

                descTxt.Text = selectednews.description;

                catalog_cmbo.SelectedValue = selectednews.catalogId;

                add_btn.Enabled = false;
                update_btn.Enabled = true;
                delete_btn.Enabled = true;
            }

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            News selectednews = DB.news.Where(n => n.id == id).SingleOrDefault();

            DB.news.Remove(selectednews);
            DB.SaveChanges();
            news_dgv.DataSource = DB.news.Where(n => n.authorId == userId).Select(n => new { n.id, Author = n.author.Name, n.title, n.description, n.date, n.time, catalog = n.catalog.name }).ToList();

            add_btn.Enabled = true;
            update_btn.Enabled = false;
            delete_btn.Enabled = false;

            titleTxt.Text = descTxt.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showall_btn_Click(object sender, EventArgs e)
        {
            if (!allNewsChecked)
            {
                showall_btn.Text = "Show My News";
                news_dgv.DataSource = DB.news.Select(n => new { n.id, Author = n.author.Name, n.title, n.description, n.date, n.time, catalog = n.catalog.name }).ToList();



                allNewsChecked = true;
                add_btn.Enabled = false;

            }
            else
            {
                showall_btn.Text = "Show All News";


                news_dgv.DataSource = DB.news.Where(n => n.authorId == userId).Select(n => new { n.id, Author = n.author.Name, n.title, n.description, n.date, n.time, catalog = n.catalog.name }).ToList();

                allNewsChecked = false;

                add_btn.Enabled = true;



            }

        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Editprofile editprofile = new Editprofile(userId,userName);
            editprofile.ShowDialog();
            this.Close();
        }
    }
}
