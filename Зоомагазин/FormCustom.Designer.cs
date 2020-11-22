namespace Зоомагазин
{
    partial class FormCustom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustom));
            this.comboBoxTypeProduct = new System.Windows.Forms.ComboBox();
            this.comboBoxProvider = new System.Windows.Forms.ComboBox();
            this.listViewCustoms = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Provider = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Namee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxNumberProduct = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxMkProduct = new System.Windows.Forms.TextBox();
            this.labelMk = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxNameProduct = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelProvider = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerCustom = new System.Windows.Forms.DateTimePicker();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTypeProduct
            // 
            this.comboBoxTypeProduct.BackColor = System.Drawing.Color.Silver;
            this.comboBoxTypeProduct.Cursor = System.Windows.Forms.Cursors.Cross;
            this.comboBoxTypeProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTypeProduct.Font = new System.Drawing.Font("Dungeon", 18F);
            this.comboBoxTypeProduct.FormattingEnabled = true;
            this.comboBoxTypeProduct.Items.AddRange(new object[] {
            "Корм",
            "Игрушки",
            "Поводки",
            "Медикаменты"});
            this.comboBoxTypeProduct.Location = new System.Drawing.Point(73, 237);
            this.comboBoxTypeProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 20);
            this.comboBoxTypeProduct.Name = "comboBoxTypeProduct";
            this.comboBoxTypeProduct.Size = new System.Drawing.Size(257, 35);
            this.comboBoxTypeProduct.TabIndex = 86;
            // 
            // comboBoxProvider
            // 
            this.comboBoxProvider.BackColor = System.Drawing.Color.Silver;
            this.comboBoxProvider.Cursor = System.Windows.Forms.Cursors.Cross;
            this.comboBoxProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProvider.Font = new System.Drawing.Font("Dungeon", 18F);
            this.comboBoxProvider.FormattingEnabled = true;
            this.comboBoxProvider.Location = new System.Drawing.Point(73, 83);
            this.comboBoxProvider.Margin = new System.Windows.Forms.Padding(5, 4, 5, 20);
            this.comboBoxProvider.Name = "comboBoxProvider";
            this.comboBoxProvider.Size = new System.Drawing.Size(257, 35);
            this.comboBoxProvider.TabIndex = 85;
            // 
            // listViewCustoms
            // 
            this.listViewCustoms.BackColor = System.Drawing.Color.MediumPurple;
            this.listViewCustoms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewCustoms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Provider,
            this.Namee,
            this.Type,
            this.Mk,
            this.Number,
            this.Price,
            this.Date,
            this.Status});
            this.listViewCustoms.Cursor = System.Windows.Forms.Cursors.Help;
            this.listViewCustoms.Font = new System.Drawing.Font("Digital-7 Mono", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCustoms.FullRowSelect = true;
            this.listViewCustoms.GridLines = true;
            this.listViewCustoms.HideSelection = false;
            this.listViewCustoms.Location = new System.Drawing.Point(387, 59);
            this.listViewCustoms.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listViewCustoms.Name = "listViewCustoms";
            this.listViewCustoms.Size = new System.Drawing.Size(789, 328);
            this.listViewCustoms.TabIndex = 83;
            this.listViewCustoms.UseCompatibleStateImageBehavior = false;
            this.listViewCustoms.View = System.Windows.Forms.View.Details;
            this.listViewCustoms.SelectedIndexChanged += new System.EventHandler(this.listViewCustoms_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 31;
            // 
            // Provider
            // 
            this.Provider.Text = "Поставщик";
            this.Provider.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Provider.Width = 89;
            // 
            // Namee
            // 
            this.Namee.Text = "Наименование";
            this.Namee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Namee.Width = 119;
            // 
            // Type
            // 
            this.Type.Text = "Тип";
            this.Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Type.Width = 88;
            // 
            // Mk
            // 
            this.Mk.Text = "Серийный номер";
            this.Mk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mk.Width = 111;
            // 
            // Number
            // 
            this.Number.Text = "Количество";
            this.Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Number.Width = 83;
            // 
            // Price
            // 
            this.Price.Text = "Цена";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Width = 69;
            // 
            // Date
            // 
            this.Date.Text = "Дата";
            this.Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date.Width = 85;
            // 
            // Status
            // 
            this.Status.Text = "Статус заказа";
            this.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Status.Width = 105;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.Silver;
            this.textBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrice.Font = new System.Drawing.Font("Dungeon", 18F);
            this.textBoxPrice.Location = new System.Drawing.Point(73, 468);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 20);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(257, 33);
            this.textBoxPrice.TabIndex = 82;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Location = new System.Drawing.Point(69, 444);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(58, 20);
            this.labelPrice.TabIndex = 81;
            this.labelPrice.Text = "Цена:";
            // 
            // textBoxNumberProduct
            // 
            this.textBoxNumberProduct.BackColor = System.Drawing.Color.Silver;
            this.textBoxNumberProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumberProduct.Font = new System.Drawing.Font("Dungeon", 18F);
            this.textBoxNumberProduct.Location = new System.Drawing.Point(73, 391);
            this.textBoxNumberProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 20);
            this.textBoxNumberProduct.Multiline = true;
            this.textBoxNumberProduct.Name = "textBoxNumberProduct";
            this.textBoxNumberProduct.Size = new System.Drawing.Size(257, 33);
            this.textBoxNumberProduct.TabIndex = 80;
            this.textBoxNumberProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberProduct_KeyPress);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber.Location = new System.Drawing.Point(69, 367);
            this.labelNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(107, 20);
            this.labelNumber.TabIndex = 79;
            this.labelNumber.Text = "Количество:";
            // 
            // textBoxMkProduct
            // 
            this.textBoxMkProduct.BackColor = System.Drawing.Color.Silver;
            this.textBoxMkProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMkProduct.Font = new System.Drawing.Font("Dungeon", 18F);
            this.textBoxMkProduct.Location = new System.Drawing.Point(73, 314);
            this.textBoxMkProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 20);
            this.textBoxMkProduct.Multiline = true;
            this.textBoxMkProduct.Name = "textBoxMkProduct";
            this.textBoxMkProduct.Size = new System.Drawing.Size(257, 33);
            this.textBoxMkProduct.TabIndex = 78;
            this.textBoxMkProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMkProduct_KeyPress);
            // 
            // labelMk
            // 
            this.labelMk.AutoSize = true;
            this.labelMk.BackColor = System.Drawing.Color.Transparent;
            this.labelMk.Location = new System.Drawing.Point(69, 290);
            this.labelMk.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMk.Name = "labelMk";
            this.labelMk.Size = new System.Drawing.Size(150, 20);
            this.labelMk.TabIndex = 77;
            this.labelMk.Text = "Серийный номер:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.Color.Transparent;
            this.labelType.Location = new System.Drawing.Point(69, 213);
            this.labelType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(47, 20);
            this.labelType.TabIndex = 76;
            this.labelType.Text = "Тип:";
            // 
            // textBoxNameProduct
            // 
            this.textBoxNameProduct.BackColor = System.Drawing.Color.Silver;
            this.textBoxNameProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNameProduct.Font = new System.Drawing.Font("Dungeon", 18F);
            this.textBoxNameProduct.Location = new System.Drawing.Point(73, 160);
            this.textBoxNameProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 20);
            this.textBoxNameProduct.Multiline = true;
            this.textBoxNameProduct.Name = "textBoxNameProduct";
            this.textBoxNameProduct.Size = new System.Drawing.Size(257, 33);
            this.textBoxNameProduct.TabIndex = 75;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Location = new System.Drawing.Point(69, 136);
            this.labelName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(129, 20);
            this.labelName.TabIndex = 74;
            this.labelName.Text = "Наименование:";
            // 
            // labelProvider
            // 
            this.labelProvider.AutoSize = true;
            this.labelProvider.BackColor = System.Drawing.Color.Transparent;
            this.labelProvider.Location = new System.Drawing.Point(69, 59);
            this.labelProvider.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelProvider.Name = "labelProvider";
            this.labelProvider.Size = new System.Drawing.Size(101, 20);
            this.labelProvider.TabIndex = 73;
            this.labelProvider.Text = "Поставщик:";
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
            this.buttonDel.Font = new System.Drawing.Font("Digital-7 Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.Location = new System.Drawing.Point(856, 395);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(139, 82);
            this.buttonDel.TabIndex = 72;
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
            this.buttonEdit.Font = new System.Drawing.Font("Digital-7 Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(707, 395);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(139, 82);
            this.buttonEdit.TabIndex = 71;
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
            this.buttonAdd.Font = new System.Drawing.Font("Digital-7 Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(558, 395);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(139, 82);
            this.buttonAdd.TabIndex = 70;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Location = new System.Drawing.Point(69, 521);
            this.labelDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(57, 20);
            this.labelDate.TabIndex = 87;
            this.labelDate.Text = "Дата:";
            this.labelDate.Click += new System.EventHandler(this.labelDate_Click);
            // 
            // dateTimePickerCustom
            // 
            this.dateTimePickerCustom.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.dateTimePickerCustom.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dateTimePickerCustom.Font = new System.Drawing.Font("Dungeon", 18F);
            this.dateTimePickerCustom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCustom.Location = new System.Drawing.Point(73, 545);
            this.dateTimePickerCustom.Margin = new System.Windows.Forms.Padding(5, 4, 5, 20);
            this.dateTimePickerCustom.Name = "dateTimePickerCustom";
            this.dateTimePickerCustom.Size = new System.Drawing.Size(257, 35);
            this.dateTimePickerCustom.TabIndex = 89;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.Color.Silver;
            this.comboBoxStatus.Cursor = System.Windows.Forms.Cursors.Cross;
            this.comboBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxStatus.Font = new System.Drawing.Font("Dungeon", 18F);
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Заказ формируется",
            "Отправка заказа",
            "Заказ отправлен",
            "Доставлено"});
            this.comboBoxStatus.Location = new System.Drawing.Point(73, 620);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 20);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(257, 35);
            this.comboBoxStatus.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(69, 596);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 90;
            this.label1.Text = "Статус заказа:";
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
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // FormCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Зоомагазин.Properties.Resources.Background2;
            this.ClientSize = new System.Drawing.Size(1232, 724);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerCustom);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.comboBoxTypeProduct);
            this.Controls.Add(this.comboBoxProvider);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewCustoms);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxNumberProduct);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.textBoxMkProduct);
            this.Controls.Add(this.labelMk);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxNameProduct);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelProvider);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Digital-7 Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormCustom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.sssss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTypeProduct;
        private System.Windows.Forms.ComboBox comboBoxProvider;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewCustoms;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Provider;
        private System.Windows.Forms.ColumnHeader Namee;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Mk;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxNumberProduct;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxMkProduct;
        private System.Windows.Forms.Label labelMk;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxNameProduct;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelProvider;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerCustom;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Status;
    }
}