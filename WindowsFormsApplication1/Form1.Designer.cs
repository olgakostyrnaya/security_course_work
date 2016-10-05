namespace WindowsFormsApplication1
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnAttemptsNumber = new System.Windows.Forms.Button();
            this.btnTestLength = new System.Windows.Forms.Button();
            this.btnClearPBox3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGeneralKey = new System.Windows.Forms.Button();
            this.lblTest1 = new System.Windows.Forms.Label();
            this.lblTest2 = new System.Windows.Forms.Label();
            this.btnTest1PMinus = new System.Windows.Forms.Button();
            this.btnTest1Plus = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTest2Minus = new System.Windows.Forms.Button();
            this.btnTest2Plus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 309);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Save to file";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(122, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 249);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove_1);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(22, 39);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(157, 125);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(211, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(242, 249);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(470, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(242, 249);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // btnAttemptsNumber
            // 
            this.btnAttemptsNumber.Location = new System.Drawing.Point(211, 310);
            this.btnAttemptsNumber.Name = "btnAttemptsNumber";
            this.btnAttemptsNumber.Size = new System.Drawing.Size(245, 23);
            this.btnAttemptsNumber.TabIndex = 16;
            this.btnAttemptsNumber.Text = "Test \"Number of attempts\"";
            this.btnAttemptsNumber.UseVisualStyleBackColor = true;
            this.btnAttemptsNumber.Click += new System.EventHandler(this.btnAttemptsNumber_Click);
            // 
            // btnTestLength
            // 
            this.btnTestLength.Location = new System.Drawing.Point(467, 310);
            this.btnTestLength.Name = "btnTestLength";
            this.btnTestLength.Size = new System.Drawing.Size(123, 22);
            this.btnTestLength.TabIndex = 17;
            this.btnTestLength.Text = "Test \"Key Length\"";
            this.btnTestLength.UseVisualStyleBackColor = true;
            this.btnTestLength.Click += new System.EventHandler(this.btnTestLength_Click);
            // 
            // btnClearPBox3
            // 
            this.btnClearPBox3.Location = new System.Drawing.Point(599, 309);
            this.btnClearPBox3.Name = "btnClearPBox3";
            this.btnClearPBox3.Size = new System.Drawing.Size(116, 23);
            this.btnClearPBox3.TabIndex = 18;
            this.btnClearPBox3.Text = "Clear";
            this.btnClearPBox3.UseVisualStyleBackColor = true;
            this.btnClearPBox3.Click += new System.EventHandler(this.btnClearPBox3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "label3";
            // 
            // btnGeneralKey
            // 
            this.btnGeneralKey.Location = new System.Drawing.Point(12, 279);
            this.btnGeneralKey.Name = "btnGeneralKey";
            this.btnGeneralKey.Size = new System.Drawing.Size(185, 23);
            this.btnGeneralKey.TabIndex = 20;
            this.btnGeneralKey.Text = "Create key";
            this.btnGeneralKey.UseVisualStyleBackColor = true;
            this.btnGeneralKey.Click += new System.EventHandler(this.btnGeneralKey_Click);
            // 
            // lblTest1
            // 
            this.lblTest1.AutoSize = true;
            this.lblTest1.Location = new System.Drawing.Point(397, 282);
            this.lblTest1.Name = "lblTest1";
            this.lblTest1.Size = new System.Drawing.Size(13, 13);
            this.lblTest1.TabIndex = 21;
            this.lblTest1.Text = "5";
            // 
            // lblTest2
            // 
            this.lblTest2.AutoSize = true;
            this.lblTest2.Location = new System.Drawing.Point(648, 282);
            this.lblTest2.Name = "lblTest2";
            this.lblTest2.Size = new System.Drawing.Size(13, 13);
            this.lblTest2.TabIndex = 22;
            this.lblTest2.Text = "3";
            // 
            // btnTest1PMinus
            // 
            this.btnTest1PMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTest1PMinus.Location = new System.Drawing.Point(352, 276);
            this.btnTest1PMinus.Name = "btnTest1PMinus";
            this.btnTest1PMinus.Size = new System.Drawing.Size(30, 23);
            this.btnTest1PMinus.TabIndex = 23;
            this.btnTest1PMinus.Text = "-";
            this.btnTest1PMinus.UseVisualStyleBackColor = true;
            this.btnTest1PMinus.Click += new System.EventHandler(this.btnTest1PMinus_Click);
            // 
            // btnTest1Plus
            // 
            this.btnTest1Plus.Location = new System.Drawing.Point(423, 277);
            this.btnTest1Plus.Name = "btnTest1Plus";
            this.btnTest1Plus.Size = new System.Drawing.Size(33, 23);
            this.btnTest1Plus.TabIndex = 24;
            this.btnTest1Plus.Text = "+";
            this.btnTest1Plus.UseVisualStyleBackColor = true;
            this.btnTest1Plus.Click += new System.EventHandler(this.btnTest1Plus_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Количество попыток : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Количество попыток : ";
            // 
            // btnTest2Minus
            // 
            this.btnTest2Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTest2Minus.Location = new System.Drawing.Point(596, 277);
            this.btnTest2Minus.Name = "btnTest2Minus";
            this.btnTest2Minus.Size = new System.Drawing.Size(29, 23);
            this.btnTest2Minus.TabIndex = 27;
            this.btnTest2Minus.Text = "-";
            this.btnTest2Minus.UseVisualStyleBackColor = true;
            this.btnTest2Minus.Click += new System.EventHandler(this.btnTest2Minus_Click);
            // 
            // btnTest2Plus
            // 
            this.btnTest2Plus.Location = new System.Drawing.Point(688, 277);
            this.btnTest2Plus.Name = "btnTest2Plus";
            this.btnTest2Plus.Size = new System.Drawing.Size(27, 23);
            this.btnTest2Plus.TabIndex = 28;
            this.btnTest2Plus.Text = "+";
            this.btnTest2Plus.UseVisualStyleBackColor = true;
            this.btnTest2Plus.Click += new System.EventHandler(this.btnTest2Plus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 390);
            this.Controls.Add(this.btnTest2Plus);
            this.Controls.Add(this.btnTest2Minus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTest1Plus);
            this.Controls.Add(this.btnTest1PMinus);
            this.Controls.Add(this.lblTest2);
            this.Controls.Add(this.lblTest1);
            this.Controls.Add(this.btnGeneralKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClearPBox3);
            this.Controls.Add(this.btnTestLength);
            this.Controls.Add(this.btnAttemptsNumber);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "Form1";
            this.Text = "Pattern Key";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnAttemptsNumber;
        private System.Windows.Forms.Button btnTestLength;
        private System.Windows.Forms.Button btnClearPBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGeneralKey;
        private System.Windows.Forms.Label lblTest1;
        private System.Windows.Forms.Label lblTest2;
        private System.Windows.Forms.Button btnTest1PMinus;
        private System.Windows.Forms.Button btnTest1Plus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTest2Minus;
        private System.Windows.Forms.Button btnTest2Plus;
    }
}

