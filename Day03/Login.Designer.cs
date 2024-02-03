namespace Day03
{
    partial class Login
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
            login_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            nameTxt = new TextBox();
            passTxt = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.Black;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Comic Sans MS", 12F);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(260, 356);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(200, 37);
            login_btn.TabIndex = 4;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F);
            label1.Location = new Point(195, 230);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 3;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F);
            label2.Location = new Point(208, 150);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(366, 150);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(200, 27);
            nameTxt.TabIndex = 5;
            // 
            // passTxt
            // 
            passTxt.Location = new Point(366, 230);
            passTxt.Name = "passTxt";
            passTxt.PasswordChar = '*';
            passTxt.Size = new Size(200, 27);
            passTxt.TabIndex = 6;
            passTxt.TextChanged += passTxt_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(694, -1);
            button1.Name = "button1";
            button1.Size = new Size(69, 41);
            button1.TabIndex = 7;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(758, 543);
            Controls.Add(button1);
            Controls.Add(passTxt);
            Controls.Add(nameTxt);
            Controls.Add(login_btn);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "App";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button login_btn;
        private Label label1;
        private Label label2;
        private TextBox nameTxt;
        private TextBox passTxt;
        private Button button1;
    }
}