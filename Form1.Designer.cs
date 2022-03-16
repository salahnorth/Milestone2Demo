namespace Milestone2Demo
{
    partial class Demo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CusIDText = new System.Windows.Forms.TextBox();
            this.FnameText = new System.Windows.Forms.TextBox();
            this.LNameText = new System.Windows.Forms.TextBox();
            this.PhoneNumberText = new System.Windows.Forms.TextBox();
            this.BranchID = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Street_Add1 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.Province = new System.Windows.Forms.Label();
            this.Street_Add2 = new System.Windows.Forms.Label();
            this.Postal_Code = new System.Windows.Forms.Label();
            this.Phone_Num = new System.Windows.Forms.Label();
            this.BranchIDtext = new System.Windows.Forms.TextBox();
            this.Citytext = new System.Windows.Forms.TextBox();
            this.Street_Add2text = new System.Windows.Forms.TextBox();
            this.Street_Add1text = new System.Windows.Forms.TextBox();
            this.Provincetext = new System.Windows.Forms.TextBox();
            this.PostalCodetext = new System.Windows.Forms.TextBox();
            this.Phone_Numtext = new System.Windows.Forms.TextBox();
            this.Descriptiontext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(200, 344);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 178);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.resetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = "|";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "search Branch ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "search Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "search Street Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "search Phone number";
            // 
            // CusIDText
            // 
            this.CusIDText.Location = new System.Drawing.Point(157, 271);
            this.CusIDText.Name = "CusIDText";
            this.CusIDText.Size = new System.Drawing.Size(100, 20);
            this.CusIDText.TabIndex = 6;
            this.CusIDText.TextChanged += new System.EventHandler(this.CusIDText_TextChanged);
            // 
            // FnameText
            // 
            this.FnameText.Location = new System.Drawing.Point(157, 307);
            this.FnameText.Name = "FnameText";
            this.FnameText.Size = new System.Drawing.Size(100, 20);
            this.FnameText.TabIndex = 7;
            this.FnameText.TextChanged += new System.EventHandler(this.FnameText_TextChanged);
            // 
            // LNameText
            // 
            this.LNameText.Location = new System.Drawing.Point(433, 271);
            this.LNameText.Name = "LNameText";
            this.LNameText.Size = new System.Drawing.Size(100, 20);
            this.LNameText.TabIndex = 8;
            this.LNameText.TextChanged += new System.EventHandler(this.LNameText_TextChanged);
            // 
            // PhoneNumberText
            // 
            this.PhoneNumberText.Location = new System.Drawing.Point(433, 310);
            this.PhoneNumberText.Name = "PhoneNumberText";
            this.PhoneNumberText.Size = new System.Drawing.Size(100, 20);
            this.PhoneNumberText.TabIndex = 9;
            this.PhoneNumberText.TextChanged += new System.EventHandler(this.PhoneNumberText_TextChanged);
            // 
            // BranchID
            // 
            this.BranchID.AutoSize = true;
            this.BranchID.Location = new System.Drawing.Point(82, 94);
            this.BranchID.Name = "BranchID";
            this.BranchID.Size = new System.Drawing.Size(58, 13);
            this.BranchID.TabIndex = 10;
            this.BranchID.Text = "Branch_ID";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(297, 94);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(60, 13);
            this.Description.TabIndex = 11;
            this.Description.Text = "Description";
            // 
            // Street_Add1
            // 
            this.Street_Add1.AutoSize = true;
            this.Street_Add1.Location = new System.Drawing.Point(551, 94);
            this.Street_Add1.Name = "Street_Add1";
            this.Street_Add1.Size = new System.Drawing.Size(85, 13);
            this.Street_Add1.TabIndex = 12;
            this.Street_Add1.Text = "Street Address 1";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(316, 158);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(24, 13);
            this.City.TabIndex = 13;
            this.City.Text = "City";
            // 
            // Province
            // 
            this.Province.AutoSize = true;
            this.Province.Location = new System.Drawing.Point(561, 154);
            this.Province.Name = "Province";
            this.Province.Size = new System.Drawing.Size(49, 13);
            this.Province.TabIndex = 14;
            this.Province.Text = "Province";
            // 
            // Street_Add2
            // 
            this.Street_Add2.AutoSize = true;
            this.Street_Add2.Location = new System.Drawing.Point(61, 154);
            this.Street_Add2.Name = "Street_Add2";
            this.Street_Add2.Size = new System.Drawing.Size(85, 13);
            this.Street_Add2.TabIndex = 15;
            this.Street_Add2.Text = "Street Address 2";
            // 
            // Postal_Code
            // 
            this.Postal_Code.AutoSize = true;
            this.Postal_Code.Location = new System.Drawing.Point(73, 202);
            this.Postal_Code.Name = "Postal_Code";
            this.Postal_Code.Size = new System.Drawing.Size(64, 13);
            this.Postal_Code.TabIndex = 16;
            this.Postal_Code.Text = "Postal Code";
            // 
            // Phone_Num
            // 
            this.Phone_Num.AutoSize = true;
            this.Phone_Num.Location = new System.Drawing.Point(296, 202);
            this.Phone_Num.Name = "Phone_Num";
            this.Phone_Num.Size = new System.Drawing.Size(78, 13);
            this.Phone_Num.TabIndex = 17;
            this.Phone_Num.Text = "Phone Number";
            // 
            // BranchIDtext
            // 
            this.BranchIDtext.Location = new System.Drawing.Point(146, 91);
            this.BranchIDtext.Name = "BranchIDtext";
            this.BranchIDtext.Size = new System.Drawing.Size(100, 20);
            this.BranchIDtext.TabIndex = 18;
            // 
            // Citytext
            // 
            this.Citytext.Location = new System.Drawing.Point(380, 151);
            this.Citytext.Name = "Citytext";
            this.Citytext.Size = new System.Drawing.Size(100, 20);
            this.Citytext.TabIndex = 19;
            // 
            // Street_Add2text
            // 
            this.Street_Add2text.Location = new System.Drawing.Point(146, 151);
            this.Street_Add2text.Name = "Street_Add2text";
            this.Street_Add2text.Size = new System.Drawing.Size(100, 20);
            this.Street_Add2text.TabIndex = 20;
            // 
            // Street_Add1text
            // 
            this.Street_Add1text.Location = new System.Drawing.Point(648, 91);
            this.Street_Add1text.Name = "Street_Add1text";
            this.Street_Add1text.Size = new System.Drawing.Size(100, 20);
            this.Street_Add1text.TabIndex = 21;
            // 
            // Provincetext
            // 
            this.Provincetext.Location = new System.Drawing.Point(648, 151);
            this.Provincetext.Name = "Provincetext";
            this.Provincetext.Size = new System.Drawing.Size(100, 20);
            this.Provincetext.TabIndex = 22;
            // 
            // PostalCodetext
            // 
            this.PostalCodetext.Location = new System.Drawing.Point(146, 199);
            this.PostalCodetext.Name = "PostalCodetext";
            this.PostalCodetext.Size = new System.Drawing.Size(100, 20);
            this.PostalCodetext.TabIndex = 25;
            // 
            // Phone_Numtext
            // 
            this.Phone_Numtext.Location = new System.Drawing.Point(380, 196);
            this.Phone_Numtext.Name = "Phone_Numtext";
            this.Phone_Numtext.Size = new System.Drawing.Size(100, 20);
            this.Phone_Numtext.TabIndex = 26;
            // 
            // Descriptiontext
            // 
            this.Descriptiontext.Location = new System.Drawing.Point(380, 91);
            this.Descriptiontext.Name = "Descriptiontext";
            this.Descriptiontext.Size = new System.Drawing.Size(100, 20);
            this.Descriptiontext.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(719, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(719, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 516);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Descriptiontext);
            this.Controls.Add(this.Phone_Numtext);
            this.Controls.Add(this.PostalCodetext);
            this.Controls.Add(this.Provincetext);
            this.Controls.Add(this.Street_Add1text);
            this.Controls.Add(this.Street_Add2text);
            this.Controls.Add(this.Citytext);
            this.Controls.Add(this.BranchIDtext);
            this.Controls.Add(this.Phone_Num);
            this.Controls.Add(this.Postal_Code);
            this.Controls.Add(this.Street_Add2);
            this.Controls.Add(this.Province);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Street_Add1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.BranchID);
            this.Controls.Add(this.PhoneNumberText);
            this.Controls.Add(this.LNameText);
            this.Controls.Add(this.FnameText);
            this.Controls.Add(this.CusIDText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Demo";
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.Demo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CusIDText;
        private System.Windows.Forms.TextBox FnameText;
        private System.Windows.Forms.TextBox LNameText;
        private System.Windows.Forms.TextBox PhoneNumberText;
        private System.Windows.Forms.Label BranchID;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Street_Add1;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label Province;
        private System.Windows.Forms.Label Street_Add2;
        private System.Windows.Forms.Label Postal_Code;
        private System.Windows.Forms.Label Phone_Num;
        private System.Windows.Forms.TextBox BranchIDtext;
        private System.Windows.Forms.TextBox Citytext;
        private System.Windows.Forms.TextBox Street_Add2text;
        private System.Windows.Forms.TextBox Street_Add1text;
        private System.Windows.Forms.TextBox Provincetext;
        private System.Windows.Forms.TextBox PostalCodetext;
        private System.Windows.Forms.TextBox Phone_Numtext;
        private System.Windows.Forms.TextBox Descriptiontext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

