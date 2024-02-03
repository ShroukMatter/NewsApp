namespace Day03
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            titleTxt = new TextBox();
            title_lbl = new Label();
            desc_lbl = new Label();
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            descTxt = new RichTextBox();
            catalog_cmbo = new ComboBox();
            news_dgv = new DataGridView();
            add_btn = new Button();
            update_btn = new Button();
            delete_btn = new Button();
            button1 = new Button();
            showall_btn = new Button();
            profile_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)news_dgv).BeginInit();
            SuspendLayout();
            // 
            // titleTxt
            // 
            titleTxt.Location = new Point(178, 125);
            titleTxt.Name = "titleTxt";
            titleTxt.Size = new Size(226, 27);
            titleTxt.TabIndex = 0;
            // 
            // title_lbl
            // 
            title_lbl.AutoSize = true;
            title_lbl.Font = new Font("Comic Sans MS", 12F);
            title_lbl.Location = new Point(12, 122);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(56, 28);
            title_lbl.TabIndex = 5;
            title_lbl.Text = "Title";
            // 
            // desc_lbl
            // 
            desc_lbl.AutoSize = true;
            desc_lbl.Font = new Font("Comic Sans MS", 12F);
            desc_lbl.Location = new Point(12, 191);
            desc_lbl.Name = "desc_lbl";
            desc_lbl.Size = new Size(119, 28);
            desc_lbl.TabIndex = 6;
            desc_lbl.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F);
            label3.Location = new Point(12, 68);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 7;
            label3.Text = "Catalog";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // descTxt
            // 
            descTxt.Location = new Point(178, 191);
            descTxt.Name = "descTxt";
            descTxt.Size = new Size(226, 83);
            descTxt.TabIndex = 11;
            descTxt.Text = "";
            // 
            // catalog_cmbo
            // 
            catalog_cmbo.FormattingEnabled = true;
            catalog_cmbo.Location = new Point(178, 71);
            catalog_cmbo.Name = "catalog_cmbo";
            catalog_cmbo.Size = new Size(226, 28);
            catalog_cmbo.TabIndex = 12;
            // 
            // news_dgv
            // 
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            news_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            news_dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            news_dgv.BackgroundColor = Color.White;
            news_dgv.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            news_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            news_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            news_dgv.Location = new Point(6, 290);
            news_dgv.Name = "news_dgv";
            news_dgv.RowHeadersWidth = 51;
            news_dgv.Size = new Size(938, 239);
            news_dgv.TabIndex = 13;
            news_dgv.RowHeaderMouseDoubleClick += news_dgv_RowHeaderMouseDoubleClick;
            news_dgv.DoubleClick += news_dgv_DoubleClick;
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.Black;
            add_btn.FlatAppearance.BorderSize = 0;
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.Font = new Font("Comic Sans MS", 12F);
            add_btn.ForeColor = Color.White;
            add_btn.Location = new Point(597, 125);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(200, 37);
            add_btn.TabIndex = 14;
            add_btn.Text = "Add News";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // update_btn
            // 
            update_btn.BackColor = Color.Black;
            update_btn.FlatAppearance.BorderSize = 0;
            update_btn.FlatStyle = FlatStyle.Flat;
            update_btn.Font = new Font("Comic Sans MS", 12F);
            update_btn.ForeColor = Color.White;
            update_btn.Location = new Point(597, 182);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(200, 37);
            update_btn.TabIndex = 15;
            update_btn.Text = "update News";
            update_btn.UseVisualStyleBackColor = false;
            update_btn.Click += update_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.Black;
            delete_btn.FlatAppearance.BorderSize = 0;
            delete_btn.FlatStyle = FlatStyle.Flat;
            delete_btn.Font = new Font("Comic Sans MS", 12F);
            delete_btn.ForeColor = Color.White;
            delete_btn.Location = new Point(597, 237);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(200, 37);
            delete_btn.TabIndex = 16;
            delete_btn.Text = "Delete News";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(875, 0);
            button1.Name = "button1";
            button1.Size = new Size(69, 41);
            button1.TabIndex = 17;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // showall_btn
            // 
            showall_btn.BackColor = Color.Black;
            showall_btn.FlatAppearance.BorderSize = 0;
            showall_btn.FlatStyle = FlatStyle.Flat;
            showall_btn.Font = new Font("Comic Sans MS", 12F);
            showall_btn.ForeColor = Color.White;
            showall_btn.Location = new Point(597, 64);
            showall_btn.Name = "showall_btn";
            showall_btn.Size = new Size(200, 37);
            showall_btn.TabIndex = 18;
            showall_btn.Text = "Show All News";
            showall_btn.UseVisualStyleBackColor = false;
            showall_btn.Click += showall_btn_Click;
            // 
            // profile_btn
            // 
            profile_btn.BackColor = Color.Black;
            profile_btn.FlatAppearance.BorderSize = 0;
            profile_btn.FlatStyle = FlatStyle.Flat;
            profile_btn.Font = new Font("Comic Sans MS", 12F);
            profile_btn.ForeColor = Color.White;
            profile_btn.Location = new Point(-3, 0);
            profile_btn.Name = "profile_btn";
            profile_btn.Size = new Size(196, 41);
            profile_btn.TabIndex = 19;
            profile_btn.Text = "Profile";
            profile_btn.UseVisualStyleBackColor = false;
            profile_btn.Click += profile_btn_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(944, 530);
            Controls.Add(profile_btn);
            Controls.Add(showall_btn);
            Controls.Add(button1);
            Controls.Add(delete_btn);
            Controls.Add(update_btn);
            Controls.Add(add_btn);
            Controls.Add(news_dgv);
            Controls.Add(catalog_cmbo);
            Controls.Add(descTxt);
            Controls.Add(label3);
            Controls.Add(desc_lbl);
            Controls.Add(title_lbl);
            Controls.Add(titleTxt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            ((System.ComponentModel.ISupportInitialize)news_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleTxt;
        private TextBox textBox2;
        private Label title_lbl;
        private Label desc_lbl;
        private Label label3;
        private ContextMenuStrip contextMenuStrip1;
        private RichTextBox descTxt;
        private ComboBox catalog_cmbo;
        private DataGridView news_dgv;
        private Button add_btn;
        private Button update_btn;
        private Button delete_btn;
        private Button button1;
        private Button showall_btn;
        private Button profile_btn;
    }
}