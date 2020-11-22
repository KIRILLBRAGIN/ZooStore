namespace Зоомагазин
{
    partial class FormProvider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProvider));
            this.listViewProvider = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxAddress_Home = new System.Windows.Forms.TextBox();
            this.labelAddress_Home = new System.Windows.Forms.Label();
            this.textBoxAddress_Street = new System.Windows.Forms.TextBox();
            this.labelAddress_Street = new System.Windows.Forms.Label();
            this.textBoxAddress_City = new System.Windows.Forms.TextBox();
            this.labelAddress_City = new System.Windows.Forms.Label();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewProvider
            // 
            this.listViewProvider.BackColor = System.Drawing.Color.MediumPurple;
            this.listViewProvider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewProvider.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.NameCompany,
            this.Address,
            this.Phone,
            this.Email});
            this.listViewProvider.Cursor = System.Windows.Forms.Cursors.Help;
            this.listViewProvider.Font = new System.Drawing.Font("Digital-7 Mono", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewProvider.FullRowSelect = true;
            this.listViewProvider.GridLines = true;
            this.listViewProvider.HideSelection = false;
            this.listViewProvider.Location = new System.Drawing.Point(387, 59);
            this.listViewProvider.Name = "listViewProvider";
            this.listViewProvider.Size = new System.Drawing.Size(789, 328);
            this.listViewProvider.TabIndex = 32;
            this.listViewProvider.UseCompatibleStateImageBehavior = false;
            this.listViewProvider.View = System.Windows.Forms.View.Details;
            this.listViewProvider.SelectedIndexChanged += new System.EventHandler(this.listViewProvider_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 42;
            // 
            // NameCompany
            // 
            this.NameCompany.Text = "Название компании";
            this.NameCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameCompany.Width = 127;
            // 
            // Address
            // 
            this.Address.Text = "Адрес";
            this.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Address.Width = 214;
            // 
            // Phone
            // 
            this.Phone.Text = "Телефон";
            this.Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Phone.Width = 190;
            // 
            // Email
            // 
            this.Email.Text = "Почта";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Width = 207;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.Silver;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEmail.Font = new System.Drawing.Font("Dungeon", 18F);
            this.textBoxEmail.Location = new System.Drawing.Point(73, 462);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(257, 33);
            this.textBoxEmail.TabIndex = 31;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Digital-7 Mono", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelEmail.Location = new System.Drawing.Point(69, 439);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(65, 20);
            this.labelEmail.TabIndex = 30;
            this.labelEmail.Text = "Почта:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.Color.Silver;
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPhone.Font = new System.Drawing.Font("Dungeon", 18F);
            this.textBoxPhone.Location = new System.Drawing.Point(73, 386);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.textBoxPhone.Multiline = true;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(257, 33);
            this.textBoxPhone.TabIndex = 29;
            this.textBoxPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPhone_KeyDown);
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Digital-7 Mono", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelPhone.Location = new System.Drawing.Point(69, 363);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(76, 20);
            this.labelPhone.TabIndex = 28;
            this.labelPhone.Text = "Телефон";
            // 
            // textBoxAddress_Home
            // 
            this.textBoxAddress_Home.BackColor = System.Drawing.Color.Silver;
            this.textBoxAddress_Home.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddress_Home.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAddress_Home.Font = new System.Drawing.Font("Dungeon", 18F);
            this.textBoxAddress_Home.Location = new System.Drawing.Point(73, 310);
            this.textBoxAddress_Home.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.textBoxAddress_Home.Multiline = true;
            this.textBoxAddress_Home.Name = "textBoxAddress_Home";
            this.textBoxAddress_Home.Size = new System.Drawing.Size(257, 33);
            this.textBoxAddress_Home.TabIndex = 27;
            // 
            // labelAddress_Home
            // 
            this.labelAddress_Home.AutoSize = true;
            this.labelAddress_Home.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress_Home.Font = new System.Drawing.Font("Digital-7 Mono", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelAddress_Home.Location = new System.Drawing.Point(69, 287);
            this.labelAddress_Home.Name = "labelAddress_Home";
            this.labelAddress_Home.Size = new System.Drawing.Size(114, 20);
            this.labelAddress_Home.TabIndex = 26;
            this.labelAddress_Home.Text = "Номер дома:";
            // 
            // textBoxAddress_Street
            // 
            this.textBoxAddress_Street.BackColor = System.Drawing.Color.Silver;
            this.textBoxAddress_Street.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddress_Street.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAddress_Street.Font = new System.Drawing.Font("Dungeon", 18F);
            this.textBoxAddress_Street.Location = new System.Drawing.Point(73, 234);
            this.textBoxAddress_Street.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.textBoxAddress_Street.Multiline = true;
            this.textBoxAddress_Street.Name = "textBoxAddress_Street";
            this.textBoxAddress_Street.Size = new System.Drawing.Size(257, 33);
            this.textBoxAddress_Street.TabIndex = 25;
            // 
            // labelAddress_Street
            // 
            this.labelAddress_Street.AutoSize = true;
            this.labelAddress_Street.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress_Street.Font = new System.Drawing.Font("Digital-7 Mono", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelAddress_Street.Location = new System.Drawing.Point(69, 211);
            this.labelAddress_Street.Name = "labelAddress_Street";
            this.labelAddress_Street.Size = new System.Drawing.Size(65, 20);
            this.labelAddress_Street.TabIndex = 24;
            this.labelAddress_Street.Text = "Улица:";
            // 
            // textBoxAddress_City
            // 
            this.textBoxAddress_City.BackColor = System.Drawing.Color.Silver;
            this.textBoxAddress_City.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddress_City.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAddress_City.Font = new System.Drawing.Font("Dungeon", 18F);
            this.textBoxAddress_City.Location = new System.Drawing.Point(73, 158);
            this.textBoxAddress_City.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.textBoxAddress_City.Multiline = true;
            this.textBoxAddress_City.Name = "textBoxAddress_City";
            this.textBoxAddress_City.Size = new System.Drawing.Size(257, 33);
            this.textBoxAddress_City.TabIndex = 23;
            // 
            // labelAddress_City
            // 
            this.labelAddress_City.AutoSize = true;
            this.labelAddress_City.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress_City.Font = new System.Drawing.Font("Digital-7 Mono", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelAddress_City.Location = new System.Drawing.Point(69, 135);
            this.labelAddress_City.Name = "labelAddress_City";
            this.labelAddress_City.Size = new System.Drawing.Size(64, 20);
            this.labelAddress_City.TabIndex = 22;
            this.labelAddress_City.Text = "Город:";
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.BackColor = System.Drawing.Color.Silver;
            this.textBoxCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCompanyName.Font = new System.Drawing.Font("Dungeon", 18F);
            this.textBoxCompanyName.Location = new System.Drawing.Point(73, 82);
            this.textBoxCompanyName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.textBoxCompanyName.Multiline = true;
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(257, 33);
            this.textBoxCompanyName.TabIndex = 21;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.labelCompanyName.Font = new System.Drawing.Font("Digital-7 Mono", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelCompanyName.Location = new System.Drawing.Point(69, 59);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(173, 20);
            this.labelCompanyName.TabIndex = 20;
            this.labelCompanyName.Text = "Название компании:";
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(215)))));
            this.buttonDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(215)))));
            this.buttonDel.FlatAppearance.BorderSize = 2;
            this.buttonDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(162)))), ((int)(((byte)(253)))));
            this.buttonDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(162)))), ((int)(((byte)(253)))));
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Digital-7 Mono", 20.25F, System.Drawing.FontStyle.Bold);
            this.buttonDel.Location = new System.Drawing.Point(856, 393);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(139, 82);
            this.buttonDel.TabIndex = 19;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(215)))));
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(215)))));
            this.buttonEdit.FlatAppearance.BorderSize = 2;
            this.buttonEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(162)))), ((int)(((byte)(253)))));
            this.buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(162)))), ((int)(((byte)(253)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Digital-7 Mono", 20.25F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.Location = new System.Drawing.Point(711, 393);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(139, 82);
            this.buttonEdit.TabIndex = 18;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(215)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(215)))));
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(162)))), ((int)(((byte)(253)))));
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(162)))), ((int)(((byte)(253)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Digital-7 Mono", 20.25F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.Location = new System.Drawing.Point(566, 393);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(139, 82);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Зоомагазин.Properties.Resources.minilogo;
            this.pictureBox1.Location = new System.Drawing.Point(880, 637);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // FormProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Зоомагазин.Properties.Resources.Background2;
            this.ClientSize = new System.Drawing.Size(1232, 724);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewProvider);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxAddress_Home);
            this.Controls.Add(this.labelAddress_Home);
            this.Controls.Add(this.textBoxAddress_Street);
            this.Controls.Add(this.labelAddress_Street);
            this.Controls.Add(this.textBoxAddress_City);
            this.Controls.Add(this.labelAddress_City);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(387, 59);
            this.Name = "FormProvider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставщики";
            this.Load += new System.EventHandler(this.FormProvider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewProvider;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader NameCompany;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxAddress_Home;
        private System.Windows.Forms.Label labelAddress_Home;
        private System.Windows.Forms.TextBox textBoxAddress_Street;
        private System.Windows.Forms.Label labelAddress_Street;
        private System.Windows.Forms.TextBox textBoxAddress_City;
        private System.Windows.Forms.Label labelAddress_City;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}