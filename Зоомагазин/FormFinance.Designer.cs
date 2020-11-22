
namespace Зоомагазин
{
    partial class FormFinance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinance));
            this.listViewFinance = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Term = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Profit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.labelTerm = new System.Windows.Forms.Label();
            this.comboBoxTerm = new System.Windows.Forms.ComboBox();
            this.labelReceived = new System.Windows.Forms.Label();
            this.labelSpent = new System.Windows.Forms.Label();
            this.textBoxReceived = new System.Windows.Forms.TextBox();
            this.textBoxSpent = new System.Windows.Forms.TextBox();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.labelData = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewFinance
            // 
            this.listViewFinance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFinance.BackColor = System.Drawing.Color.MediumPurple;
            this.listViewFinance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewFinance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Term,
            this.Data,
            this.Profit});
            this.listViewFinance.Cursor = System.Windows.Forms.Cursors.Help;
            this.listViewFinance.Font = new System.Drawing.Font("Digital-7 Mono", 9.749999F, System.Drawing.FontStyle.Bold);
            this.listViewFinance.FullRowSelect = true;
            this.listViewFinance.GridLines = true;
            this.listViewFinance.HideSelection = false;
            this.listViewFinance.Location = new System.Drawing.Point(387, 59);
            this.listViewFinance.Name = "listViewFinance";
            this.listViewFinance.Size = new System.Drawing.Size(789, 328);
            this.listViewFinance.TabIndex = 0;
            this.listViewFinance.UseCompatibleStateImageBehavior = false;
            this.listViewFinance.View = System.Windows.Forms.View.Details;
            this.listViewFinance.SelectedIndexChanged += new System.EventHandler(this.listViewFinance_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 52;
            // 
            // Data
            // 
            this.Data.DisplayIndex = 1;
            this.Data.Text = "Дата";
            this.Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Data.Width = 160;
            // 
            // Term
            // 
            this.Term.DisplayIndex = 2;
            this.Term.Text = "Срок";
            this.Term.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Term.Width = 157;
            // 
            // Profit
            // 
            this.Profit.Text = "Прибыль";
            this.Profit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Profit.Width = 402;
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
            this.buttonAdd.Location = new System.Drawing.Point(562, 393);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(139, 82);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
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
            this.buttonEdit.Location = new System.Drawing.Point(707, 393);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(139, 82);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
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
            this.buttonDel.Location = new System.Drawing.Point(852, 393);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(139, 82);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // labelTerm
            // 
            this.labelTerm.AutoSize = true;
            this.labelTerm.BackColor = System.Drawing.Color.Transparent;
            this.labelTerm.Font = new System.Drawing.Font("Digital-7 Mono", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelTerm.Location = new System.Drawing.Point(69, 59);
            this.labelTerm.Name = "labelTerm";
            this.labelTerm.Size = new System.Drawing.Size(55, 20);
            this.labelTerm.TabIndex = 4;
            this.labelTerm.Text = "Срок:";
            // 
            // comboBoxTerm
            // 
            this.comboBoxTerm.BackColor = System.Drawing.Color.Silver;
            this.comboBoxTerm.Cursor = System.Windows.Forms.Cursors.Cross;
            this.comboBoxTerm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTerm.Font = new System.Drawing.Font("Dungeon", 18F);
            this.comboBoxTerm.FormattingEnabled = true;
            this.comboBoxTerm.Items.AddRange(new object[] {
            "День",
            "Неделя",
            "Месяц",
            "Год"});
            this.comboBoxTerm.Location = new System.Drawing.Point(73, 82);
            this.comboBoxTerm.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.comboBoxTerm.Name = "comboBoxTerm";
            this.comboBoxTerm.Size = new System.Drawing.Size(257, 35);
            this.comboBoxTerm.TabIndex = 5;
            // 
            // labelReceived
            // 
            this.labelReceived.AutoSize = true;
            this.labelReceived.BackColor = System.Drawing.Color.Transparent;
            this.labelReceived.Font = new System.Drawing.Font("Digital-7 Mono", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelReceived.Location = new System.Drawing.Point(69, 215);
            this.labelReceived.Name = "labelReceived";
            this.labelReceived.Size = new System.Drawing.Size(92, 20);
            this.labelReceived.TabIndex = 6;
            this.labelReceived.Text = "Получено:";
            // 
            // labelSpent
            // 
            this.labelSpent.AutoSize = true;
            this.labelSpent.BackColor = System.Drawing.Color.Transparent;
            this.labelSpent.Font = new System.Drawing.Font("Digital-7 Mono", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelSpent.Location = new System.Drawing.Point(69, 291);
            this.labelSpent.Name = "labelSpent";
            this.labelSpent.Size = new System.Drawing.Size(101, 20);
            this.labelSpent.TabIndex = 7;
            this.labelSpent.Text = "Потрачено:";
            // 
            // textBoxReceived
            // 
            this.textBoxReceived.BackColor = System.Drawing.Color.Silver;
            this.textBoxReceived.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxReceived.Font = new System.Drawing.Font("Dungeon", 18F);
            this.textBoxReceived.Location = new System.Drawing.Point(73, 238);
            this.textBoxReceived.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.textBoxReceived.Multiline = true;
            this.textBoxReceived.Name = "textBoxReceived";
            this.textBoxReceived.Size = new System.Drawing.Size(257, 33);
            this.textBoxReceived.TabIndex = 8;
            this.textBoxReceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxReceived_KeyPress);
            // 
            // textBoxSpent
            // 
            this.textBoxSpent.BackColor = System.Drawing.Color.Silver;
            this.textBoxSpent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSpent.Font = new System.Drawing.Font("Dungeon", 18F);
            this.textBoxSpent.Location = new System.Drawing.Point(73, 314);
            this.textBoxSpent.Multiline = true;
            this.textBoxSpent.Name = "textBoxSpent";
            this.textBoxSpent.Size = new System.Drawing.Size(257, 33);
            this.textBoxSpent.TabIndex = 9;
            this.textBoxSpent.TextChanged += new System.EventHandler(this.textBoxSpent_TextChanged_1);
            this.textBoxSpent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSpent_KeyPress);
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dateTimePickerData.Font = new System.Drawing.Font("Dungeon", 18F);
            this.dateTimePickerData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerData.Location = new System.Drawing.Point(73, 160);
            this.dateTimePickerData.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(257, 35);
            this.dateTimePickerData.TabIndex = 10;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.BackColor = System.Drawing.Color.Transparent;
            this.labelData.Font = new System.Drawing.Font("Digital-7 Mono", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelData.Location = new System.Drawing.Point(69, 137);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(57, 20);
            this.labelData.TabIndex = 11;
            this.labelData.Text = "Дата:";
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
            // FormFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Зоомагазин.Properties.Resources.Background2;
            this.ClientSize = new System.Drawing.Size(1232, 724);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.textBoxSpent);
            this.Controls.Add(this.textBoxReceived);
            this.Controls.Add(this.labelSpent);
            this.Controls.Add(this.labelReceived);
            this.Controls.Add(this.comboBoxTerm);
            this.Controls.Add(this.labelTerm);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewFinance);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFinance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Финансы";
            this.Load += new System.EventHandler(this.FormFinance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewFinance;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label labelTerm;
        private System.Windows.Forms.ComboBox comboBoxTerm;
        private System.Windows.Forms.Label labelReceived;
        private System.Windows.Forms.Label labelSpent;
        private System.Windows.Forms.TextBox textBoxReceived;
        private System.Windows.Forms.TextBox textBoxSpent;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Term;
        private System.Windows.Forms.ColumnHeader Profit;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}