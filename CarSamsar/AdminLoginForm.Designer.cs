namespace CarSamsar
{
    partial class AdminLoginForm
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
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.employeesTab = new System.Windows.Forms.TabPage();
            this.removeButton = new System.Windows.Forms.Button();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cnpTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.carsTab = new System.Windows.Forms.TabPage();
            this.km_textbox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.remove_car = new System.Windows.Forms.Button();
            this.register_car = new System.Windows.Forms.Button();
            this.model_textbox = new System.Windows.Forms.TextBox();
            this.proprietari_textbox = new System.Windows.Forms.TextBox();
            this.an_textbox = new System.Windows.Forms.TextBox();
            this.pret_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.department_textbox = new System.Windows.Forms.TextBox();
            this.VIN_textbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.marca_textbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.employeesTab.SuspendLayout();
            this.carsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(133, 158);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(119, 20);
            this.usernameTextBox.TabIndex = 19;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(133, 200);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(119, 20);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Location = new System.Drawing.Point(133, 244);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(119, 20);
            this.firstnameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(133, 345);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(120, 26);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarSamsar.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(116, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.employeesTab);
            this.tabControl1.Controls.Add(this.carsTab);
            this.tabControl1.Location = new System.Drawing.Point(-1, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(598, 455);
            this.tabControl1.TabIndex = 8;
            // 
            // employeesTab
            // 
            this.employeesTab.Controls.Add(this.removeButton);
            this.employeesTab.Controls.Add(this.salaryTextBox);
            this.employeesTab.Controls.Add(this.addressTextBox);
            this.employeesTab.Controls.Add(this.cnpTextBox);
            this.employeesTab.Controls.Add(this.lastnameTextBox);
            this.employeesTab.Controls.Add(this.label7);
            this.employeesTab.Controls.Add(this.label6);
            this.employeesTab.Controls.Add(this.label5);
            this.employeesTab.Controls.Add(this.label4);
            this.employeesTab.Controls.Add(this.pictureBox1);
            this.employeesTab.Controls.Add(this.usernameTextBox);
            this.employeesTab.Controls.Add(this.registerButton);
            this.employeesTab.Controls.Add(this.passwordTextBox);
            this.employeesTab.Controls.Add(this.label3);
            this.employeesTab.Controls.Add(this.firstnameTextBox);
            this.employeesTab.Controls.Add(this.label2);
            this.employeesTab.Controls.Add(this.label1);
            this.employeesTab.Location = new System.Drawing.Point(4, 22);
            this.employeesTab.Name = "employeesTab";
            this.employeesTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.employeesTab.Size = new System.Drawing.Size(590, 429);
            this.employeesTab.TabIndex = 0;
            this.employeesTab.Text = "Employees";
            this.employeesTab.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(333, 345);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(120, 26);
            this.removeButton.TabIndex = 18;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(377, 240);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(117, 20);
            this.salaryTextBox.TabIndex = 17;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(377, 199);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(119, 20);
            this.addressTextBox.TabIndex = 16;
            // 
            // cnpTextBox
            // 
            this.cnpTextBox.Location = new System.Drawing.Point(377, 157);
            this.cnpTextBox.Name = "cnpTextBox";
            this.cnpTextBox.Size = new System.Drawing.Size(119, 20);
            this.cnpTextBox.TabIndex = 15;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Location = new System.Drawing.Point(133, 286);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(119, 20);
            this.lastnameTextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CNP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Last Name";
            // 
            // carsTab
            // 
            this.carsTab.Controls.Add(this.km_textbox);
            this.carsTab.Controls.Add(this.label15);
            this.carsTab.Controls.Add(this.remove_car);
            this.carsTab.Controls.Add(this.register_car);
            this.carsTab.Controls.Add(this.model_textbox);
            this.carsTab.Controls.Add(this.proprietari_textbox);
            this.carsTab.Controls.Add(this.an_textbox);
            this.carsTab.Controls.Add(this.pret_textbox);
            this.carsTab.Controls.Add(this.label8);
            this.carsTab.Controls.Add(this.label9);
            this.carsTab.Controls.Add(this.label10);
            this.carsTab.Controls.Add(this.label11);
            this.carsTab.Controls.Add(this.department_textbox);
            this.carsTab.Controls.Add(this.VIN_textbox);
            this.carsTab.Controls.Add(this.label12);
            this.carsTab.Controls.Add(this.marca_textbox);
            this.carsTab.Controls.Add(this.label13);
            this.carsTab.Controls.Add(this.label14);
            this.carsTab.Controls.Add(this.pictureBox2);
            this.carsTab.Location = new System.Drawing.Point(4, 22);
            this.carsTab.Name = "carsTab";
            this.carsTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.carsTab.Size = new System.Drawing.Size(590, 429);
            this.carsTab.TabIndex = 1;
            this.carsTab.Text = "Cars";
            this.carsTab.UseVisualStyleBackColor = true;
            // 
            // km_textbox
            // 
            this.km_textbox.Location = new System.Drawing.Point(379, 286);
            this.km_textbox.Name = "km_textbox";
            this.km_textbox.Size = new System.Drawing.Size(117, 20);
            this.km_textbox.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(283, 286);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "KM";
            // 
            // remove_car
            // 
            this.remove_car.Location = new System.Drawing.Point(334, 347);
            this.remove_car.Name = "remove_car";
            this.remove_car.Size = new System.Drawing.Size(120, 26);
            this.remove_car.TabIndex = 33;
            this.remove_car.Text = "Remove";
            this.remove_car.UseVisualStyleBackColor = true;
            // 
            // register_car
            // 
            this.register_car.Location = new System.Drawing.Point(134, 347);
            this.register_car.Name = "register_car";
            this.register_car.Size = new System.Drawing.Size(120, 26);
            this.register_car.TabIndex = 32;
            this.register_car.Text = "Register";
            this.register_car.UseVisualStyleBackColor = true;
            this.register_car.Click += new System.EventHandler(this.register_car_Click_1);
            // 
            // model_textbox
            // 
            this.model_textbox.Location = new System.Drawing.Point(379, 240);
            this.model_textbox.Name = "model_textbox";
            this.model_textbox.Size = new System.Drawing.Size(117, 20);
            this.model_textbox.TabIndex = 31;
            // 
            // proprietari_textbox
            // 
            this.proprietari_textbox.Location = new System.Drawing.Point(379, 200);
            this.proprietari_textbox.Name = "proprietari_textbox";
            this.proprietari_textbox.Size = new System.Drawing.Size(119, 20);
            this.proprietari_textbox.TabIndex = 30;
            // 
            // an_textbox
            // 
            this.an_textbox.Location = new System.Drawing.Point(379, 157);
            this.an_textbox.Name = "an_textbox";
            this.an_textbox.Size = new System.Drawing.Size(119, 20);
            this.an_textbox.TabIndex = 29;
            // 
            // pret_textbox
            // 
            this.pret_textbox.Location = new System.Drawing.Point(134, 287);
            this.pret_textbox.Name = "pret_textbox";
            this.pret_textbox.Size = new System.Drawing.Size(119, 20);
            this.pret_textbox.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Model";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Numar Proprietari";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(283, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "An Fabricatie";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Pret";
            // 
            // department_textbox
            // 
            this.department_textbox.Location = new System.Drawing.Point(134, 158);
            this.department_textbox.Name = "department_textbox";
            this.department_textbox.Size = new System.Drawing.Size(119, 20);
            this.department_textbox.TabIndex = 18;
            // 
            // VIN_textbox
            // 
            this.VIN_textbox.Location = new System.Drawing.Point(134, 201);
            this.VIN_textbox.Name = "VIN_textbox";
            this.VIN_textbox.Size = new System.Drawing.Size(119, 20);
            this.VIN_textbox.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Marca";
            // 
            // marca_textbox
            // 
            this.marca_textbox.Location = new System.Drawing.Point(134, 244);
            this.marca_textbox.Name = "marca_textbox";
            this.marca_textbox.Size = new System.Drawing.Size(119, 20);
            this.marca_textbox.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "VIN";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "ID departament";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarSamsar.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(116, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(365, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(597, 451);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.employeesTab.ResumeLayout(false);
            this.employeesTab.PerformLayout();
            this.carsTab.ResumeLayout(false);
            this.carsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage employeesTab;
        private System.Windows.Forms.TabPage carsTab;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cnpTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button remove_car;
        private System.Windows.Forms.Button register_car;
        private System.Windows.Forms.TextBox model_textbox;
        private System.Windows.Forms.TextBox proprietari_textbox;
        private System.Windows.Forms.TextBox an_textbox;
        private System.Windows.Forms.TextBox pret_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox department_textbox;
        private System.Windows.Forms.TextBox VIN_textbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox marca_textbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox km_textbox;
        private System.Windows.Forms.Label label15;
    }
}