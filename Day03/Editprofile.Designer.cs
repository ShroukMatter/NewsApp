namespace Day03
{
    partial class Editprofile
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
            userTxt = new TextBox();
            oldpassTxt = new TextBox();
            usrname_lbl = new Label();
            oldpass_btn = new Label();
            label1 = new Label();
            newpassTxt = new TextBox();
            edit_btn = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // userTxt
            // 
            userTxt.Location = new Point(362, 105);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(201, 27);
            userTxt.TabIndex = 0;
            // 
            // oldpassTxt
            // 
            oldpassTxt.Location = new Point(362, 166);
            oldpassTxt.Name = "oldpassTxt";
            oldpassTxt.Size = new Size(201, 27);
            oldpassTxt.TabIndex = 1;
            // 
            // usrname_lbl
            // 
            usrname_lbl.AutoSize = true;
            usrname_lbl.Font = new Font("Comic Sans MS", 12F);
            usrname_lbl.Location = new Point(177, 104);
            usrname_lbl.Name = "usrname_lbl";
            usrname_lbl.Size = new Size(152, 28);
            usrname_lbl.TabIndex = 2;
            usrname_lbl.Text = " New username";
            // 
            // oldpass_btn
            // 
            oldpass_btn.AutoSize = true;
            oldpass_btn.Font = new Font("Comic Sans MS", 12F);
            oldpass_btn.Location = new Point(177, 166);
            oldpass_btn.Name = "oldpass_btn";
            oldpass_btn.Size = new Size(139, 28);
            oldpass_btn.TabIndex = 3;
            oldpass_btn.Text = "Old password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F);
            label1.Location = new Point(177, 221);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 4;
            label1.Text = "New password";
            // 
            // newpassTxt
            // 
            newpassTxt.Location = new Point(362, 224);
            newpassTxt.Name = "newpassTxt";
            newpassTxt.Size = new Size(201, 27);
            newpassTxt.TabIndex = 5;
            // 
            // edit_btn
            // 
            edit_btn.BackColor = Color.Black;
            edit_btn.FlatAppearance.BorderSize = 0;
            edit_btn.FlatStyle = FlatStyle.Flat;
            edit_btn.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            edit_btn.ForeColor = Color.White;
            edit_btn.Location = new Point(292, 329);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(168, 44);
            edit_btn.TabIndex = 6;
            edit_btn.Text = "Edit Profile";
            edit_btn.UseVisualStyleBackColor = false;
            edit_btn.Click += edit_btn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(689, -3);
            button1.Name = "button1";
            button1.Size = new Size(69, 41);
            button1.TabIndex = 18;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Comic Sans MS", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(-2, -17);
            button2.Name = "button2";
            button2.Size = new Size(73, 55);
            button2.TabIndex = 19;
            button2.Text = "⬅️";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Editprofile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(756, 451);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(edit_btn);
            Controls.Add(newpassTxt);
            Controls.Add(label1);
            Controls.Add(oldpass_btn);
            Controls.Add(usrname_lbl);
            Controls.Add(oldpassTxt);
            Controls.Add(userTxt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Editprofile";
            Text = "Editprofile";
            Load += Editprofile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userTxt;
        private TextBox oldpassTxt;
        private Label usrname_lbl;
        private Label oldpass_btn;
        private Label label1;
        private TextBox newpassTxt;
        private Button edit_btn;
        private Button button1;
        private Button button2;
    }
}