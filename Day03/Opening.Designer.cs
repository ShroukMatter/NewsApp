namespace Day03
{
    partial class Opening
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
            createacc_btn = new Button();
            haveacc_btn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // createacc_btn
            // 
            createacc_btn.BackColor = Color.Black;
            createacc_btn.FlatAppearance.BorderColor = Color.White;
            createacc_btn.FlatAppearance.BorderSize = 0;
            createacc_btn.FlatStyle = FlatStyle.Flat;
            createacc_btn.Font = new Font("Comic Sans MS", 12F);
            createacc_btn.ForeColor = Color.White;
            createacc_btn.ImageAlign = ContentAlignment.MiddleLeft;
            createacc_btn.Location = new Point(149, 309);
            createacc_btn.Name = "createacc_btn";
            createacc_btn.Size = new Size(200, 37);
            createacc_btn.TabIndex = 0;
            createacc_btn.Text = "Create Account";
            createacc_btn.UseVisualStyleBackColor = false;
            createacc_btn.Click += createacc_btn_Click;
            // 
            // haveacc_btn
            // 
            haveacc_btn.BackColor = Color.Black;
            haveacc_btn.FlatAppearance.BorderColor = Color.White;
            haveacc_btn.FlatAppearance.BorderSize = 0;
            haveacc_btn.FlatStyle = FlatStyle.Flat;
            haveacc_btn.Font = new Font("Comic Sans MS", 12F);
            haveacc_btn.ForeColor = Color.White;
            haveacc_btn.Location = new Point(385, 309);
            haveacc_btn.Name = "haveacc_btn";
            haveacc_btn.Size = new Size(227, 37);
            haveacc_btn.TabIndex = 1;
            haveacc_btn.Text = "Already have Account ?";
            haveacc_btn.UseVisualStyleBackColor = false;
            haveacc_btn.Click += haveacc_btn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(710, 0);
            button1.Name = "button1";
            button1.Size = new Size(69, 41);
            button1.TabIndex = 3;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Opening
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(776, 590);
            Controls.Add(button1);
            Controls.Add(haveacc_btn);
            Controls.Add(createacc_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Opening";
            Text = "Opening";
            Load += Opening_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button createacc_btn;
        private Button haveacc_btn;
        private Button button1;
    }
}