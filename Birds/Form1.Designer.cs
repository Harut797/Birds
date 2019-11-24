namespace Birds
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.smile = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.stolba = new System.Windows.Forms.PictureBox();
            this.stolba2 = new System.Windows.Forms.PictureBox();
            this.randtime = new System.Windows.Forms.Timer(this.components);
            this.back1 = new System.Windows.Forms.PictureBox();
            this.back2 = new System.Windows.Forms.PictureBox();
            this.back3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.coins = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.coin2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.stolba5 = new System.Windows.Forms.PictureBox();
            this.stolba4 = new System.Windows.Forms.PictureBox();
            this.stolba6 = new System.Windows.Forms.PictureBox();
            this.stolba7 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.smile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stolba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stolba2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stolba5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stolba4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stolba6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stolba7)).BeginInit();
            this.SuspendLayout();
            // 
            // smile
            // 
            this.smile.BackColor = System.Drawing.Color.White;
            this.smile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("smile.BackgroundImage")));
            this.smile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.smile.InitialImage = ((System.Drawing.Image)(resources.GetObject("smile.InitialImage")));
            this.smile.Location = new System.Drawing.Point(168, 190);
            this.smile.Name = "smile";
            this.smile.Size = new System.Drawing.Size(47, 43);
            this.smile.TabIndex = 0;
            this.smile.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Click!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // stolba
            // 
            this.stolba.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stolba.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stolba.BackgroundImage")));
            this.stolba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stolba.Location = new System.Drawing.Point(543, 314);
            this.stolba.Name = "stolba";
            this.stolba.Size = new System.Drawing.Size(40, 167);
            this.stolba.TabIndex = 2;
            this.stolba.TabStop = false;
            // 
            // stolba2
            // 
            this.stolba2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stolba2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stolba2.BackgroundImage")));
            this.stolba2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stolba2.Image = ((System.Drawing.Image)(resources.GetObject("stolba2.Image")));
            this.stolba2.InitialImage = ((System.Drawing.Image)(resources.GetObject("stolba2.InitialImage")));
            this.stolba2.Location = new System.Drawing.Point(543, -16);
            this.stolba2.Name = "stolba2";
            this.stolba2.Size = new System.Drawing.Size(36, 169);
            this.stolba2.TabIndex = 3;
            this.stolba2.TabStop = false;
            // 
            // randtime
            // 
            this.randtime.Interval = 1000;
            this.randtime.Tick += new System.EventHandler(this.randtime_Tick);
            // 
            // back1
            // 
            this.back1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back1.BackgroundImage")));
            this.back1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back1.Location = new System.Drawing.Point(3, -2);
            this.back1.Name = "back1";
            this.back1.Size = new System.Drawing.Size(1705, 495);
            this.back1.TabIndex = 5;
            this.back1.TabStop = false;
            // 
            // back2
            // 
            this.back2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back2.BackgroundImage")));
            this.back2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back2.Location = new System.Drawing.Point(1078, -2);
            this.back2.Name = "back2";
            this.back2.Size = new System.Drawing.Size(648, 495);
            this.back2.TabIndex = 6;
            this.back2.TabStop = false;
            // 
            // back3
            // 
            this.back3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back3.BackgroundImage")));
            this.back3.Location = new System.Drawing.Point(543, -2);
            this.back3.Name = "back3";
            this.back3.Size = new System.Drawing.Size(648, 495);
            this.back3.TabIndex = 7;
            this.back3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Score";
            // 
            // coins
            // 
            this.coins.AutoSize = true;
            this.coins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coins.Location = new System.Drawing.Point(69, 9);
            this.coins.Name = "coins";
            this.coins.Size = new System.Drawing.Size(18, 20);
            this.coins.TabIndex = 9;
            this.coins.Text = "0";
            this.coins.Click += new System.EventHandler(this.coins_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Harut"});
            this.listBox1.Location = new System.Drawing.Point(3, 411);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(136, 82);
            this.listBox1.TabIndex = 10;
            // 
            // coin1
            // 
            this.coin1.BackColor = System.Drawing.Color.White;
            this.coin1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coin1.BackgroundImage")));
            this.coin1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coin1.Location = new System.Drawing.Point(337, 196);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(36, 37);
            this.coin1.TabIndex = 11;
            this.coin1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(732, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Coin";
            // 
            // coin2
            // 
            this.coin2.AutoSize = true;
            this.coin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coin2.Location = new System.Drawing.Point(779, 9);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(18, 20);
            this.coin2.TabIndex = 13;
            this.coin2.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(736, 458);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Store";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // stolba5
            // 
            this.stolba5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stolba5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stolba5.BackgroundImage")));
            this.stolba5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stolba5.Image = ((System.Drawing.Image)(resources.GetObject("stolba5.Image")));
            this.stolba5.InitialImage = ((System.Drawing.Image)(resources.GetObject("stolba5.InitialImage")));
            this.stolba5.Location = new System.Drawing.Point(765, -50);
            this.stolba5.Name = "stolba5";
            this.stolba5.Size = new System.Drawing.Size(36, 169);
            this.stolba5.TabIndex = 15;
            this.stolba5.TabStop = false;
            // 
            // stolba4
            // 
            this.stolba4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stolba4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stolba4.BackgroundImage")));
            this.stolba4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stolba4.Location = new System.Drawing.Point(765, 253);
            this.stolba4.Name = "stolba4";
            this.stolba4.Size = new System.Drawing.Size(40, 167);
            this.stolba4.TabIndex = 16;
            this.stolba4.TabStop = false;
            // 
            // stolba6
            // 
            this.stolba6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stolba6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stolba6.BackgroundImage")));
            this.stolba6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stolba6.Location = new System.Drawing.Point(1032, 314);
            this.stolba6.Name = "stolba6";
            this.stolba6.Size = new System.Drawing.Size(40, 167);
            this.stolba6.TabIndex = 17;
            this.stolba6.TabStop = false;
            // 
            // stolba7
            // 
            this.stolba7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stolba7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stolba7.BackgroundImage")));
            this.stolba7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stolba7.Image = ((System.Drawing.Image)(resources.GetObject("stolba7.Image")));
            this.stolba7.InitialImage = ((System.Drawing.Image)(resources.GetObject("stolba7.InitialImage")));
            this.stolba7.Location = new System.Drawing.Point(1032, -2);
            this.stolba7.Name = "stolba7";
            this.stolba7.Size = new System.Drawing.Size(36, 169);
            this.stolba7.TabIndex = 18;
            this.stolba7.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(168, 458);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "New Game";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 493);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.stolba7);
            this.Controls.Add(this.stolba6);
            this.Controls.Add(this.stolba4);
            this.Controls.Add(this.stolba5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.coins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.smile);
            this.Controls.Add(this.stolba2);
            this.Controls.Add(this.stolba);
            this.Controls.Add(this.back1);
            this.Controls.Add(this.back2);
            this.Controls.Add(this.back3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress_1);
            ((System.ComponentModel.ISupportInitialize)(this.smile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stolba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stolba2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stolba5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stolba4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stolba6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stolba7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox smile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox stolba;
        private System.Windows.Forms.PictureBox stolba2;
        private System.Windows.Forms.Timer randtime;
        private System.Windows.Forms.PictureBox back1;
        private System.Windows.Forms.PictureBox back2;
        private System.Windows.Forms.PictureBox back3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label coins;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label coin2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox stolba5;
        private System.Windows.Forms.PictureBox stolba4;
        private System.Windows.Forms.PictureBox stolba6;
        private System.Windows.Forms.PictureBox stolba7;
        public System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button button3;
    }
}

