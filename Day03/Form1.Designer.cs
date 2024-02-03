namespace Day03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameTxt = new TextBox();
            passTxt = new TextBox();
            confirmPassTxt = new TextBox();
            signUp_btn = new Button();
            nameTxt = new TextBox();
            name_lbl = new Label();
            username_lbl = new Label();
            pass_lbl = new Label();
            cnfrmPass_lbl = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(374, 159);
            usernameTxt.Margin = new Padding(4);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(249, 34);
            usernameTxt.TabIndex = 0;
            // 
            // passTxt
            // 
            passTxt.Location = new Point(374, 239);
            passTxt.Margin = new Padding(4);
            passTxt.Name = "passTxt";
            passTxt.PasswordChar = '*';
            passTxt.Size = new Size(249, 34);
            passTxt.TabIndex = 1;
            passTxt.TextChanged += textBox2_TextChanged;
            // 
            // confirmPassTxt
            // 
            confirmPassTxt.Location = new Point(374, 334);
            confirmPassTxt.Margin = new Padding(4);
            confirmPassTxt.Name = "confirmPassTxt";
            confirmPassTxt.PasswordChar = '*';
            confirmPassTxt.Size = new Size(249, 34);
            confirmPassTxt.TabIndex = 2;
            // 
            // signUp_btn
            // 
            signUp_btn.BackColor = Color.Black;
            signUp_btn.FlatAppearance.BorderSize = 0;
            signUp_btn.FlatStyle = FlatStyle.Flat;
            signUp_btn.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signUp_btn.ForeColor = Color.White;
            signUp_btn.Location = new Point(282, 470);
            signUp_btn.Margin = new Padding(4);
            signUp_btn.Name = "signUp_btn";
            signUp_btn.Size = new Size(200, 44);
            signUp_btn.TabIndex = 3;
            signUp_btn.Text = "Sign up";
            signUp_btn.UseVisualStyleBackColor = false;
            signUp_btn.Click += signUp_btn_Click;
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(374, 64);
            nameTxt.Margin = new Padding(4);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(249, 34);
            nameTxt.TabIndex = 4;
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.Font = new Font("Comic Sans MS", 12F);
            name_lbl.Location = new Point(165, 70);
            name_lbl.Margin = new Padding(4, 0, 4, 0);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(64, 28);
            name_lbl.TabIndex = 5;
            name_lbl.Text = "Name";
            // 
            // username_lbl
            // 
            username_lbl.AutoSize = true;
            username_lbl.Font = new Font("Comic Sans MS", 12F);
            username_lbl.Location = new Point(165, 159);
            username_lbl.Margin = new Padding(4, 0, 4, 0);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(104, 28);
            username_lbl.TabIndex = 6;
            username_lbl.Text = "Username";
            // 
            // pass_lbl
            // 
            pass_lbl.AutoSize = true;
            pass_lbl.Font = new Font("Comic Sans MS", 12F);
            pass_lbl.Location = new Point(165, 243);
            pass_lbl.Margin = new Padding(4, 0, 4, 0);
            pass_lbl.Name = "pass_lbl";
            pass_lbl.Size = new Size(99, 28);
            pass_lbl.TabIndex = 7;
            pass_lbl.Text = "Password";
            // 
            // cnfrmPass_lbl
            // 
            cnfrmPass_lbl.AutoSize = true;
            cnfrmPass_lbl.Font = new Font("Comic Sans MS", 12F);
            cnfrmPass_lbl.Location = new Point(165, 340);
            cnfrmPass_lbl.Margin = new Padding(4, 0, 4, 0);
            cnfrmPass_lbl.Name = "cnfrmPass_lbl";
            cnfrmPass_lbl.Size = new Size(179, 28);
            cnfrmPass_lbl.TabIndex = 8;
            cnfrmPass_lbl.Text = "Confirm Password";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(713, -2);
            button1.Name = "button1";
            button1.Size = new Size(69, 41);
            button1.TabIndex = 9;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(776, 590);
            Controls.Add(button1);
            Controls.Add(cnfrmPass_lbl);
            Controls.Add(pass_lbl);
            Controls.Add(username_lbl);
            Controls.Add(name_lbl);
            Controls.Add(nameTxt);
            Controls.Add(signUp_btn);
            Controls.Add(confirmPassTxt);
            Controls.Add(passTxt);
            Controls.Add(usernameTxt);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTxt;
        private TextBox passTxt;
        private TextBox confirmPassTxt;
        private Button signUp_btn;
        private TextBox nameTxt;
        private Label name_lbl;
        private Label username_lbl;
        private Label pass_lbl;
        private Label cnfrmPass_lbl;
        private Button button1;
    }
}
