namespace Зоомагазин
{
    partial class FormStorage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStorage));
            this.listViewStorage = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Provider = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Namee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxMk = new System.Windows.Forms.TextBox();
            this.labelMk = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelProvider = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxProvider = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewStorage
            // 
            this.listViewStorage.BackColor = System.Drawing.Color.MediumPurple;
            this.listViewStorage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewStorage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Provider,
            this.Namee,
            this.Type,
            this.Mk,
            this.Number,
            this.Price});
            this.listViewStorage.Cursor = System.Windows.Forms.Cursors.Help;
            this.listViewStorage.Font = new System.Drawing.Font("Digital-7 Mono", 9.749999F, System.Drawing.FontStyle.Bold);
            this.listViewStorage.FullRowSelect = true;
            this.listViewStorage.GridLines = true;
            this.listViewStorage.HideSelection = false;
            this.listViewStorage.Location = new System.Drawing.Point(387, 59);
            this.listViewStorage.Name = "listViewStorage";
            this.listViewStorage.Size = new System.Drawing.Size(789, 328);
            this.listViewStorage.TabIndex = 66;
            this.listViewStorage.UseCompatibleStateImageBehavior = false;
            this.listViewStorage.View = System.Windows.Forms.View.Details;
            this.listViewStorage.SelectedIndexChanged += new System.EventHandler(this.listViewStorage_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 33;
            // 
            // Provider
            // 
            this.Provider.Text = "Поставщик";
            this.Provider.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Provider.Width = 121;
            // 
            // Namee
            // 
            this.Namee.Text = "Наименование";
            this.Namee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Namee.Width = 162;
            // 
            // Type
            // 
            this.Type.Text = "Тип";
            this.Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Type.Width = 129;
            // 
            // Mk
            // 
            this.Mk.Text = "Серийный номер";
            this.Mk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mk.Width = 123;
            // 
            // Number
            // 
            this.Number.Text = "Количество";
            this.Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Number.Width = 101;
            // 
            // Price
            // 
            this.Price.Text = "Цена";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Width = 99;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.Silver;
            this.textBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrice.Font = new System.Drawing.Font("Dungeon", 18F);
            this.textBoxPrice.Location = new System.Drawing.Point(73, 462);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(257, 33);
            this.textBoxPrice.TabIndex = 65;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("Digital-7 Mono", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelPrice.Location = new System.Drawing.Point(69, 439);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(58, 20);
            this.labelPrice.TabIndex = 64;
            this.labelPrice.Text = "Цена:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.BackColor = System.Drawing.Color.Silver;
            this.textBoxNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumber.Font = new System.Drawing.Font("Dungeon", 18F);
            this.textBoxNumber.Location = new System.Drawing.Point(73, 386);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.textBoxNumber.Multiline = true;
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(257, 33);
            this.textBoxNumber.TabIndex = 63;
            this.textBoxNumber.TextChanged += new System.EventHandler(this.textBoxNumber_TextChanged);
            this.textBoxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumber_KeyPress);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber.Font = new System.Drawing.Font("Digital-7 Mono", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelNumber.Location = new System.Drawing.Point(69, 363);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(107, 20);
            this.labelNumber.TabIndex = 62;
            this.labelNumber.Text = "Количество:";
            // 
            // textBoxMk
            // 
            this.textBoxMk.BackColor = System.Drawing.Color.Silver;
            this.textBoxMk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMk.Font = new System.Drawing.Font("Dungeon", 18F);
            this.textBoxMk.Location = new System.Drawing.Point(73, 310);
            this.textBoxMk.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.textBoxMk.Multiline = true;
            this.textBoxMk.Name = "textBoxMk";
            this.textBoxMk.Size = new System.Drawing.Size(257, 33);
            this.textBoxMk.TabIndex = 61;
            this.textBoxMk.TextChanged += new System.EventHandler(this.textBoxMk_TextChanged);
            this.textBoxMk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMk_KeyPress);
            // 
            // labelMk
            // 
            this.labelMk.AutoSize = true;
            this.labelMk.BackColor = System.Drawing.Color.Transparent;
            this.labelMk.Font = new System.Drawing.Font("Digital-7 Mono", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelMk.Location = new System.Drawing.Point(69, 287);
            this.labelMk.Name = "labelMk";
            this.labelMk.Size = new System.Drawing.Size(150, 20);
            this.labelMk.TabIndex = 60;
            this.labelMk.Text = "Серийный номер:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.Color.Transparent;
            this.labelType.Font = new System.Drawing.Font("Digital-7 Mono", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelType.Location = new System.Drawing.Point(69, 211);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(47, 20);
            this.labelType.TabIndex = 58;
            this.labelType.Text = "Тип:";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Silver;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Dungeon", 18F);
            this.textBoxName.Location = new System.Drawing.Point(73, 158);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(257, 33);
            this.textBoxName.TabIndex = 57;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Digital-7 Mono", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(69, 135);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(129, 20);
            this.labelName.TabIndex = 56;
            this.labelName.Text = "Наименование:";
            // 
            // labelProvider
            // 
            this.labelProvider.AutoSize = true;
            this.labelProvider.BackColor = System.Drawing.Color.Transparent;
            this.labelProvider.Font = new System.Drawing.Font("Digital-7 Mono", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelProvider.Location = new System.Drawing.Point(69, 59);
            this.labelProvider.Name = "labelProvider";
            this.labelProvider.Size = new System.Drawing.Size(101, 20);
            this.labelProvider.TabIndex = 54;
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
            this.buttonDel.Font = new System.Drawing.Font("Digital-7 Mono", 20.25F, System.Drawing.FontStyle.Bold);
            this.buttonDel.Location = new System.Drawing.Point(877, 393);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(139, 82);
            this.buttonDel.TabIndex = 53;
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
            this.buttonEdit.Location = new System.Drawing.Point(732, 393);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(139, 82);
            this.buttonEdit.TabIndex = 52;
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
            this.buttonAdd.Location = new System.Drawing.Point(587, 393);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(139, 82);
            this.buttonAdd.TabIndex = 51;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxProvider
            // 
            this.comboBoxProvider.BackColor = System.Drawing.Color.Silver;
            this.comboBoxProvider.Cursor = System.Windows.Forms.Cursors.Cross;
            this.comboBoxProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProvider.Font = new System.Drawing.Font("Dungeon", 18F);
            this.comboBoxProvider.FormattingEnabled = true;
            this.comboBoxProvider.Location = new System.Drawing.Point(73, 82);
            this.comboBoxProvider.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.comboBoxProvider.Name = "comboBoxProvider";
            this.comboBoxProvider.Size = new System.Drawing.Size(257, 35);
            this.comboBoxProvider.TabIndex = 68;
            this.comboBoxProvider.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvider_SelectedIndexChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.BackColor = System.Drawing.Color.Silver;
            this.comboBoxType.Cursor = System.Windows.Forms.Cursors.Cross;
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.Font = new System.Drawing.Font("Dungeon", 18F);
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Корм",
            "Игрушки",
            "Поводки",
            "Медикаменты"});
            this.comboBoxType.Location = new System.Drawing.Point(73, 234);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(257, 35);
            this.comboBoxType.TabIndex = 69;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
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
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // FormStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Зоомагазин.Properties.Resources.Background2;
            this.ClientSize = new System.Drawing.Size(1232, 724);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxProvider);
            this.Controls.Add(this.listViewStorage);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.textBoxMk);
            this.Controls.Add(this.labelMk);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelProvider);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStorage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.FormStorage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewStorage;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Provider;
        private System.Windows.Forms.ColumnHeader Namee;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Mk;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxMk;
        private System.Windows.Forms.Label labelMk;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelProvider;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxProvider;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}