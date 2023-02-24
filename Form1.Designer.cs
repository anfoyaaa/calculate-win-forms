namespace calculate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonclose = new System.Windows.Forms.PictureBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonTOCHKA = new System.Windows.Forms.Button();
            this.ButtonZero = new System.Windows.Forms.Button();
            this.buttonseven = new System.Windows.Forms.Button();
            this.buttoneight = new System.Windows.Forms.Button();
            this.buttonnine = new System.Windows.Forms.Button();
            this.buttonfive = new System.Windows.Forms.Button();
            this.buttonsix = new System.Windows.Forms.Button();
            this.buttonfour = new System.Windows.Forms.Button();
            this.buttonthree = new System.Windows.Forms.Button();
            this.buttontwo = new System.Windows.Forms.Button();
            this.buttonone = new System.Windows.Forms.Button();
            this.buttonravno = new System.Windows.Forms.Button();
            this.buttonmin = new System.Windows.Forms.Button();
            this.buttonplu = new System.Windows.Forms.Button();
            this.buttonx = new System.Windows.Forms.Button();
            this.buttondel = new System.Windows.Forms.Button();
            this.buttonstepen = new System.Windows.Forms.Button();
            this.buttonc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonclose)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.buttonclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 34);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::calculate.Properties.Resources._1643985559_49_phonoteka_org_p_oranzhevii_fon_gorizontalnii_60;
            this.pictureBox2.Location = new System.Drawing.Point(313, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 22);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // buttonclose
            // 
            this.buttonclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonclose.Image = global::calculate.Properties.Resources.красный_плоский_прямоугольник_для_предпосылки_пастельного_красного_145287398;
            this.buttonclose.Location = new System.Drawing.Point(357, 6);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(31, 22);
            this.buttonclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonclose.TabIndex = 0;
            this.buttonclose.TabStop = false;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox.Location = new System.Drawing.Point(0, 34);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(400, 47);
            this.TextBox.TabIndex = 1;
            this.TextBox.Text = "0";
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Controls.Add(this.buttonTOCHKA);
            this.panel2.Controls.Add(this.ButtonZero);
            this.panel2.Controls.Add(this.buttonseven);
            this.panel2.Controls.Add(this.buttoneight);
            this.panel2.Controls.Add(this.buttonnine);
            this.panel2.Controls.Add(this.buttonfive);
            this.panel2.Controls.Add(this.buttonsix);
            this.panel2.Controls.Add(this.buttonfour);
            this.panel2.Controls.Add(this.buttonthree);
            this.panel2.Controls.Add(this.buttontwo);
            this.panel2.Controls.Add(this.buttonone);
            this.panel2.Controls.Add(this.buttonravno);
            this.panel2.Controls.Add(this.buttonmin);
            this.panel2.Controls.Add(this.buttonplu);
            this.panel2.Controls.Add(this.buttonx);
            this.panel2.Controls.Add(this.buttondel);
            this.panel2.Controls.Add(this.buttonstepen);
            this.panel2.Controls.Add(this.buttonc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Old English Text MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 521);
            this.panel2.TabIndex = 2;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buttonTOCHKA
            // 
            this.buttonTOCHKA.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonTOCHKA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTOCHKA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTOCHKA.Location = new System.Drawing.Point(202, 244);
            this.buttonTOCHKA.Name = "buttonTOCHKA";
            this.buttonTOCHKA.Size = new System.Drawing.Size(87, 40);
            this.buttonTOCHKA.TabIndex = 17;
            this.buttonTOCHKA.Text = ",\r\n\r\n";
            this.buttonTOCHKA.UseVisualStyleBackColor = false;
            this.buttonTOCHKA.Click += new System.EventHandler(this.buttonTOCHKA_Click);
            // 
            // ButtonZero
            // 
            this.ButtonZero.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ButtonZero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonZero.Location = new System.Drawing.Point(3, 244);
            this.ButtonZero.Name = "ButtonZero";
            this.ButtonZero.Size = new System.Drawing.Size(178, 40);
            this.ButtonZero.TabIndex = 16;
            this.ButtonZero.Text = "0";
            this.ButtonZero.UseVisualStyleBackColor = false;
            this.ButtonZero.Click += new System.EventHandler(this.buttonTOCHKA_Click);
            // 
            // buttonseven
            // 
            this.buttonseven.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonseven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonseven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonseven.Location = new System.Drawing.Point(0, 180);
            this.buttonseven.Name = "buttonseven";
            this.buttonseven.Size = new System.Drawing.Size(87, 40);
            this.buttonseven.TabIndex = 15;
            this.buttonseven.Text = "7";
            this.buttonseven.UseVisualStyleBackColor = false;
            this.buttonseven.Click += new System.EventHandler(this.buttonTOCHKA_Click);
            // 
            // buttoneight
            // 
            this.buttoneight.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttoneight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoneight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttoneight.Location = new System.Drawing.Point(103, 180);
            this.buttoneight.Name = "buttoneight";
            this.buttoneight.Size = new System.Drawing.Size(87, 40);
            this.buttoneight.TabIndex = 14;
            this.buttoneight.Text = "8";
            this.buttoneight.UseVisualStyleBackColor = false;
            this.buttoneight.Click += new System.EventHandler(this.buttonTOCHKA_Click);
            // 
            // buttonnine
            // 
            this.buttonnine.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonnine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonnine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonnine.Location = new System.Drawing.Point(202, 180);
            this.buttonnine.Name = "buttonnine";
            this.buttonnine.Size = new System.Drawing.Size(87, 40);
            this.buttonnine.TabIndex = 13;
            this.buttonnine.Text = "9";
            this.buttonnine.UseVisualStyleBackColor = false;
            this.buttonnine.Click += new System.EventHandler(this.buttonTOCHKA_Click);
            // 
            // buttonfive
            // 
            this.buttonfive.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonfive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonfive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonfive.Location = new System.Drawing.Point(103, 117);
            this.buttonfive.Name = "buttonfive";
            this.buttonfive.Size = new System.Drawing.Size(87, 40);
            this.buttonfive.TabIndex = 12;
            this.buttonfive.Text = "5";
            this.buttonfive.UseVisualStyleBackColor = false;
            this.buttonfive.Click += new System.EventHandler(this.buttonTOCHKA_Click);
            // 
            // buttonsix
            // 
            this.buttonsix.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonsix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonsix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonsix.Location = new System.Drawing.Point(202, 117);
            this.buttonsix.Name = "buttonsix";
            this.buttonsix.Size = new System.Drawing.Size(87, 40);
            this.buttonsix.TabIndex = 11;
            this.buttonsix.Text = "6";
            this.buttonsix.UseVisualStyleBackColor = false;
            this.buttonsix.Click += new System.EventHandler(this.buttonTOCHKA_Click);
            // 
            // buttonfour
            // 
            this.buttonfour.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonfour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonfour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonfour.Location = new System.Drawing.Point(0, 116);
            this.buttonfour.Name = "buttonfour";
            this.buttonfour.Size = new System.Drawing.Size(87, 40);
            this.buttonfour.TabIndex = 10;
            this.buttonfour.Text = "4";
            this.buttonfour.UseVisualStyleBackColor = false;
            this.buttonfour.Click += new System.EventHandler(this.buttonTOCHKA_Click);
            // 
            // buttonthree
            // 
            this.buttonthree.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonthree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonthree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonthree.Location = new System.Drawing.Point(202, 62);
            this.buttonthree.Name = "buttonthree";
            this.buttonthree.Size = new System.Drawing.Size(87, 40);
            this.buttonthree.TabIndex = 9;
            this.buttonthree.Text = "3";
            this.buttonthree.UseVisualStyleBackColor = false;
            this.buttonthree.Click += new System.EventHandler(this.buttonTOCHKA_Click);
            // 
            // buttontwo
            // 
            this.buttontwo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttontwo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttontwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttontwo.Location = new System.Drawing.Point(103, 62);
            this.buttontwo.Name = "buttontwo";
            this.buttontwo.Size = new System.Drawing.Size(87, 40);
            this.buttontwo.TabIndex = 8;
            this.buttontwo.Text = "2";
            this.buttontwo.UseVisualStyleBackColor = false;
            this.buttontwo.Click += new System.EventHandler(this.buttonTOCHKA_Click);
            // 
            // buttonone
            // 
            this.buttonone.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonone.Location = new System.Drawing.Point(0, 62);
            this.buttonone.Name = "buttonone";
            this.buttonone.Size = new System.Drawing.Size(87, 40);
            this.buttonone.TabIndex = 7;
            this.buttonone.Text = "1";
            this.buttonone.UseVisualStyleBackColor = false;
            this.buttonone.Click += new System.EventHandler(this.buttonTOCHKA_Click);
            // 
            // buttonravno
            // 
            this.buttonravno.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonravno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonravno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonravno.Location = new System.Drawing.Point(313, 180);
            this.buttonravno.Name = "buttonravno";
            this.buttonravno.Size = new System.Drawing.Size(75, 104);
            this.buttonravno.TabIndex = 6;
            this.buttonravno.Text = "=";
            this.buttonravno.UseVisualStyleBackColor = false;
            this.buttonravno.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonmin
            // 
            this.buttonmin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonmin.Location = new System.Drawing.Point(313, 116);
            this.buttonmin.Name = "buttonmin";
            this.buttonmin.Size = new System.Drawing.Size(75, 41);
            this.buttonmin.TabIndex = 5;
            this.buttonmin.Text = "-";
            this.buttonmin.UseVisualStyleBackColor = false;
            this.buttonmin.Click += new System.EventHandler(this.Form1_Click);
            // 
            // buttonplu
            // 
            this.buttonplu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonplu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonplu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonplu.Location = new System.Drawing.Point(313, 62);
            this.buttonplu.Name = "buttonplu";
            this.buttonplu.Size = new System.Drawing.Size(75, 35);
            this.buttonplu.TabIndex = 4;
            this.buttonplu.Text = "+";
            this.buttonplu.UseVisualStyleBackColor = false;
            this.buttonplu.Click += new System.EventHandler(this.Form1_Click);
            // 
            // buttonx
            // 
            this.buttonx.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonx.Location = new System.Drawing.Point(313, 13);
            this.buttonx.Name = "buttonx";
            this.buttonx.Size = new System.Drawing.Size(62, 33);
            this.buttonx.TabIndex = 3;
            this.buttonx.Text = "X";
            this.buttonx.UseVisualStyleBackColor = false;
            this.buttonx.Click += new System.EventHandler(this.Form1_Click);
            // 
            // buttondel
            // 
            this.buttondel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttondel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttondel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttondel.Location = new System.Drawing.Point(216, 14);
            this.buttondel.Name = "buttondel";
            this.buttondel.Size = new System.Drawing.Size(60, 32);
            this.buttondel.TabIndex = 2;
            this.buttondel.Text = "/";
            this.buttondel.UseVisualStyleBackColor = false;
            this.buttondel.Click += new System.EventHandler(this.Form1_Click);
            // 
            // buttonstepen
            // 
            this.buttonstepen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonstepen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonstepen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonstepen.Location = new System.Drawing.Point(117, 14);
            this.buttonstepen.Name = "buttonstepen";
            this.buttonstepen.Size = new System.Drawing.Size(55, 30);
            this.buttonstepen.TabIndex = 1;
            this.buttonstepen.Text = "*2";
            this.buttonstepen.UseVisualStyleBackColor = false;
            this.buttonstepen.Click += new System.EventHandler(this.Form1_Click);
            // 
            // buttonc
            // 
            this.buttonc.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonc.Location = new System.Drawing.Point(12, 14);
            this.buttonc.Name = "buttonc";
            this.buttonc.Size = new System.Drawing.Size(57, 33);
            this.buttonc.TabIndex = 0;
            this.buttonc.Text = "C";
            this.buttonc.UseVisualStyleBackColor = false;
            this.buttonc.Click += new System.EventHandler(this.buttonc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonclose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonmin;
        private System.Windows.Forms.Button buttonplu;
        private System.Windows.Forms.Button buttonx;
        private System.Windows.Forms.Button buttondel;
        private System.Windows.Forms.Button buttonstepen;
        private System.Windows.Forms.Button buttonc;
        private System.Windows.Forms.Button buttonseven;
        private System.Windows.Forms.Button buttoneight;
        private System.Windows.Forms.Button buttonnine;
        private System.Windows.Forms.Button buttonfive;
        private System.Windows.Forms.Button buttonsix;
        private System.Windows.Forms.Button buttonfour;
        private System.Windows.Forms.Button buttonthree;
        private System.Windows.Forms.Button buttontwo;
        private System.Windows.Forms.Button buttonone;
        private System.Windows.Forms.Button buttonravno;
        private System.Windows.Forms.Button buttonTOCHKA;
        private System.Windows.Forms.Button ButtonZero;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox buttonclose;
    }
}

