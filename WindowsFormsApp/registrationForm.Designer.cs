namespace WindowsFormsApp
{
    partial class registrationForm
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
            this.name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.branch = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.input_name = new System.Windows.Forms.TextBox();
            this.input_paswword = new System.Windows.Forms.TextBox();
            this.input_branch = new System.Windows.Forms.ComboBox();
            this.radio_male = new System.Windows.Forms.RadioButton();
            this.radio_female = new System.Windows.Forms.RadioButton();
            this.register = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(125, 46);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(64, 25);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(125, 92);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(98, 25);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.label2_Click);
            // 
            // branch
            // 
            this.branch.AutoSize = true;
            this.branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch.Location = new System.Drawing.Point(125, 137);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(74, 25);
            this.branch.TabIndex = 2;
            this.branch.Text = "Branch";
            this.branch.Click += new System.EventHandler(this.branch_Click);
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(125, 177);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(46, 25);
            this.city.TabIndex = 3;
            this.city.Text = "City";
            this.city.Click += new System.EventHandler(this.city_Click);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(125, 294);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(77, 25);
            this.gender.TabIndex = 4;
            this.gender.Text = "Gender";
            this.gender.Click += new System.EventHandler(this.gender_Click);
            // 
            // input_name
            // 
            this.input_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_name.Location = new System.Drawing.Point(303, 51);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(163, 23);
            this.input_name.TabIndex = 5;
            this.input_name.TextChanged += new System.EventHandler(this.input_name_TextChanged);
            // 
            // input_paswword
            // 
            this.input_paswword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_paswword.Location = new System.Drawing.Point(303, 97);
            this.input_paswword.Name = "input_paswword";
            this.input_paswword.PasswordChar = '*';
            this.input_paswword.Size = new System.Drawing.Size(163, 23);
            this.input_paswword.TabIndex = 6;
            this.input_paswword.TextChanged += new System.EventHandler(this.input_paswword_TextChanged);
            // 
            // input_branch
            // 
            this.input_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_branch.FormattingEnabled = true;
            this.input_branch.Items.AddRange(new object[] {
            "CE",
            "IT",
            "Civil",
            "CS",
            "CyberSecurity"});
            this.input_branch.Location = new System.Drawing.Point(303, 137);
            this.input_branch.Name = "input_branch";
            this.input_branch.Size = new System.Drawing.Size(163, 24);
            this.input_branch.TabIndex = 7;
            this.input_branch.SelectedIndexChanged += new System.EventHandler(this.input_branch_SelectedIndexChanged);
            // 
            // radio_male
            // 
            this.radio_male.AutoSize = true;
            this.radio_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_male.Location = new System.Drawing.Point(303, 295);
            this.radio_male.Name = "radio_male";
            this.radio_male.Size = new System.Drawing.Size(61, 24);
            this.radio_male.TabIndex = 9;
            this.radio_male.TabStop = true;
            this.radio_male.Text = "Male";
            this.radio_male.UseVisualStyleBackColor = true;
            this.radio_male.CheckedChanged += new System.EventHandler(this.radio_male_CheckedChanged);
            // 
            // radio_female
            // 
            this.radio_female.AutoSize = true;
            this.radio_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_female.Location = new System.Drawing.Point(386, 296);
            this.radio_female.Name = "radio_female";
            this.radio_female.Size = new System.Drawing.Size(80, 24);
            this.radio_female.TabIndex = 10;
            this.radio_female.TabStop = true;
            this.radio_female.Text = "Female";
            this.radio_female.UseVisualStyleBackColor = true;
            this.radio_female.CheckedChanged += new System.EventHandler(this.radio_female_CheckedChanged);
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.Location = new System.Drawing.Point(347, 383);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(119, 37);
            this.register.TabIndex = 11;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Rajkot",
            "Surat",
            "Morbi",
            "Ahemdabad",
            "Junagadh"});
            this.listBox1.Location = new System.Drawing.Point(303, 177);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(163, 84);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // registrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.register);
            this.Controls.Add(this.radio_female);
            this.Controls.Add(this.radio_male);
            this.Controls.Add(this.input_branch);
            this.Controls.Add(this.input_paswword);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.city);
            this.Controls.Add(this.branch);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Name = "registrationForm";
            this.Text = "Nsm";
            this.Load += new System.EventHandler(this.registrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label branch;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.TextBox input_paswword;
        private System.Windows.Forms.ComboBox input_branch;
        private System.Windows.Forms.RadioButton radio_male;
        private System.Windows.Forms.RadioButton radio_female;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.ListBox listBox1;
    }
}