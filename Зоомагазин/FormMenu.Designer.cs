namespace Зоомагазин
{
    partial class FormMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.OpenCustom = new System.Windows.Forms.Button();
            this.OpenStorage = new System.Windows.Forms.Button();
            this.OpenProvider = new System.Windows.Forms.Button();
            this.OpenFinance = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenCustom
            // 
            this.OpenCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(215)))));
            this.OpenCustom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenCustom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(215)))));
            this.OpenCustom.FlatAppearance.BorderSize = 2;
            this.OpenCustom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(162)))), ((int)(((byte)(253)))));
            this.OpenCustom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(162)))), ((int)(((byte)(253)))));
            this.OpenCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenCustom.ForeColor = System.Drawing.Color.SlateBlue;
            this.OpenCustom.Location = new System.Drawing.Point(106, 143);
            this.OpenCustom.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.OpenCustom.Name = "OpenCustom";
            this.OpenCustom.Size = new System.Drawing.Size(213, 68);
            this.OpenCustom.TabIndex = 6;
            this.OpenCustom.Text = "Заказы";
            this.OpenCustom.UseVisualStyleBackColor = false;
            this.OpenCustom.Click += new System.EventHandler(this.OpenCustom_Click);
            // 
            // OpenStorage
            // 
            this.OpenStorage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(215)))));
            this.OpenStorage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(215)))));
            this.OpenStorage.FlatAppearance.BorderSize = 2;
            this.OpenStorage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(162)))), ((int)(((byte)(253)))));
            this.OpenStorage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(162)))), ((int)(((byte)(253)))));
            this.OpenStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenStorage.ForeColor = System.Drawing.Color.SlateBlue;
            this.OpenStorage.Location = new System.Drawing.Point(106, 229);
            this.OpenStorage.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.OpenStorage.Name = "OpenStorage";
            this.OpenStorage.Size = new System.Drawing.Size(213, 68);
            this.OpenStorage.TabIndex = 5;
            this.OpenStorage.Text = "Склад";
            this.OpenStorage.UseVisualStyleBackColor = false;
            this.OpenStorage.Click += new System.EventHandler(this.OpenStorage_Click);
            // 
            // OpenProvider
            // 
            this.OpenProvider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(215)))));
            this.OpenProvider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenProvider.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(215)))));
            this.OpenProvider.FlatAppearance.BorderSize = 2;
            this.OpenProvider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(162)))), ((int)(((byte)(253)))));
            this.OpenProvider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(162)))), ((int)(((byte)(253)))));
            this.OpenProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenProvider.Font = new System.Drawing.Font("Digital-7 Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenProvider.ForeColor = System.Drawing.Color.SlateBlue;
            this.OpenProvider.Location = new System.Drawing.Point(106, 57);
            this.OpenProvider.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.OpenProvider.Name = "OpenProvider";
            this.OpenProvider.Size = new System.Drawing.Size(213, 68);
            this.OpenProvider.TabIndex = 4;
            this.OpenProvider.Text = "Поставщики";
            this.OpenProvider.UseVisualStyleBackColor = false;
            this.OpenProvider.Click += new System.EventHandler(this.OpenProvider_Click);
            // 
            // OpenFinance
            // 
            this.OpenFinance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(215)))));
            this.OpenFinance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(215)))));
            this.OpenFinance.FlatAppearance.BorderSize = 2;
            this.OpenFinance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(162)))), ((int)(((byte)(253)))));
            this.OpenFinance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(162)))), ((int)(((byte)(253)))));
            this.OpenFinance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFinance.ForeColor = System.Drawing.Color.SlateBlue;
            this.OpenFinance.Location = new System.Drawing.Point(106, 315);
            this.OpenFinance.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.OpenFinance.Name = "OpenFinance";
            this.OpenFinance.Size = new System.Drawing.Size(213, 68);
            this.OpenFinance.TabIndex = 9;
            this.OpenFinance.Text = "Финансы";
            this.OpenFinance.UseVisualStyleBackColor = false;
            this.OpenFinance.Click += new System.EventHandler(this.OpenFinance_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Зоомагазин.Properties.Resources.зверьё;
            this.pictureBox1.Location = new System.Drawing.Point(589, 157);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Зоомагазин.Properties.Resources.logo1;
            this.pictureBox2.Location = new System.Drawing.Point(347, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(395, 305);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.WaitOnLoad = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Зоомагазин.Properties.Resources.Background2;
            this.ClientSize = new System.Drawing.Size(970, 453);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.OpenFinance);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OpenCustom);
            this.Controls.Add(this.OpenStorage);
            this.Controls.Add(this.OpenProvider);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Digital-7 Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(986, 492);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button OpenCustom;
        private System.Windows.Forms.Button OpenStorage;
        private System.Windows.Forms.Button OpenProvider;
        private System.Windows.Forms.Button OpenFinance;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

