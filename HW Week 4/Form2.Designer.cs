namespace HW_Week_4
{
    partial class Second_Form
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
            this.label_BackColor = new System.Windows.Forms.Label();
            this.label_TxtColor = new System.Windows.Forms.Label();
            this.panel_Atas = new System.Windows.Forms.Panel();
            this.panel_Bawah = new System.Windows.Forms.Panel();
            this.radioButton_Red1 = new System.Windows.Forms.RadioButton();
            this.radioButton_Blue1 = new System.Windows.Forms.RadioButton();
            this.radioButton_Orange1 = new System.Windows.Forms.RadioButton();
            this.radioButton_Green1 = new System.Windows.Forms.RadioButton();
            this.radioButton_Purple1 = new System.Windows.Forms.RadioButton();
            this.radioButton_Red2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Green2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Black2 = new System.Windows.Forms.RadioButton();
            this.button_Magic = new System.Windows.Forms.Button();
            this.label_Hasil = new System.Windows.Forms.Label();
            this.checkBox_True2 = new System.Windows.Forms.CheckBox();
            this.checkBox_Agree2 = new System.Windows.Forms.CheckBox();
            this.panel_Atas.SuspendLayout();
            this.panel_Bawah.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_BackColor
            // 
            this.label_BackColor.AutoSize = true;
            this.label_BackColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BackColor.Location = new System.Drawing.Point(37, 46);
            this.label_BackColor.Name = "label_BackColor";
            this.label_BackColor.Size = new System.Drawing.Size(326, 22);
            this.label_BackColor.TabIndex = 0;
            this.label_BackColor.Text = "Pick your favorite background color";
            // 
            // label_TxtColor
            // 
            this.label_TxtColor.AutoSize = true;
            this.label_TxtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TxtColor.Location = new System.Drawing.Point(40, 220);
            this.label_TxtColor.Name = "label_TxtColor";
            this.label_TxtColor.Size = new System.Drawing.Size(137, 22);
            this.label_TxtColor.TabIndex = 1;
            this.label_TxtColor.Text = "Pick text color";
            // 
            // panel_Atas
            // 
            this.panel_Atas.Controls.Add(this.radioButton_Purple1);
            this.panel_Atas.Controls.Add(this.radioButton_Green1);
            this.panel_Atas.Controls.Add(this.radioButton_Orange1);
            this.panel_Atas.Controls.Add(this.radioButton_Blue1);
            this.panel_Atas.Controls.Add(this.radioButton_Red1);
            this.panel_Atas.Location = new System.Drawing.Point(41, 94);
            this.panel_Atas.Name = "panel_Atas";
            this.panel_Atas.Size = new System.Drawing.Size(200, 100);
            this.panel_Atas.TabIndex = 2;
            // 
            // panel_Bawah
            // 
            this.panel_Bawah.Controls.Add(this.radioButton_Black2);
            this.panel_Bawah.Controls.Add(this.radioButton_Green2);
            this.panel_Bawah.Controls.Add(this.radioButton_Red2);
            this.panel_Bawah.Location = new System.Drawing.Point(44, 273);
            this.panel_Bawah.Name = "panel_Bawah";
            this.panel_Bawah.Size = new System.Drawing.Size(200, 100);
            this.panel_Bawah.TabIndex = 3;
            // 
            // radioButton_Red1
            // 
            this.radioButton_Red1.AutoSize = true;
            this.radioButton_Red1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Red1.ForeColor = System.Drawing.Color.Red;
            this.radioButton_Red1.Location = new System.Drawing.Point(0, 0);
            this.radioButton_Red1.Name = "radioButton_Red1";
            this.radioButton_Red1.Size = new System.Drawing.Size(61, 22);
            this.radioButton_Red1.TabIndex = 0;
            this.radioButton_Red1.TabStop = true;
            this.radioButton_Red1.Text = "RED";
            this.radioButton_Red1.UseVisualStyleBackColor = true;
            // 
            // radioButton_Blue1
            // 
            this.radioButton_Blue1.AutoSize = true;
            this.radioButton_Blue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Blue1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.radioButton_Blue1.Location = new System.Drawing.Point(0, 40);
            this.radioButton_Blue1.Name = "radioButton_Blue1";
            this.radioButton_Blue1.Size = new System.Drawing.Size(68, 22);
            this.radioButton_Blue1.TabIndex = 1;
            this.radioButton_Blue1.TabStop = true;
            this.radioButton_Blue1.Text = "BLUE";
            this.radioButton_Blue1.UseVisualStyleBackColor = true;
            // 
            // radioButton_Orange1
            // 
            this.radioButton_Orange1.AutoSize = true;
            this.radioButton_Orange1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Orange1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radioButton_Orange1.Location = new System.Drawing.Point(0, 78);
            this.radioButton_Orange1.Name = "radioButton_Orange1";
            this.radioButton_Orange1.Size = new System.Drawing.Size(94, 22);
            this.radioButton_Orange1.TabIndex = 2;
            this.radioButton_Orange1.TabStop = true;
            this.radioButton_Orange1.Text = "ORANGE";
            this.radioButton_Orange1.UseVisualStyleBackColor = true;
            // 
            // radioButton_Green1
            // 
            this.radioButton_Green1.AutoSize = true;
            this.radioButton_Green1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Green1.ForeColor = System.Drawing.Color.LimeGreen;
            this.radioButton_Green1.Location = new System.Drawing.Point(113, 0);
            this.radioButton_Green1.Name = "radioButton_Green1";
            this.radioButton_Green1.Size = new System.Drawing.Size(83, 22);
            this.radioButton_Green1.TabIndex = 3;
            this.radioButton_Green1.TabStop = true;
            this.radioButton_Green1.Text = "GREEN";
            this.radioButton_Green1.UseVisualStyleBackColor = true;
            // 
            // radioButton_Purple1
            // 
            this.radioButton_Purple1.AutoSize = true;
            this.radioButton_Purple1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Purple1.ForeColor = System.Drawing.Color.BlueViolet;
            this.radioButton_Purple1.Location = new System.Drawing.Point(113, 42);
            this.radioButton_Purple1.Name = "radioButton_Purple1";
            this.radioButton_Purple1.Size = new System.Drawing.Size(89, 22);
            this.radioButton_Purple1.TabIndex = 4;
            this.radioButton_Purple1.TabStop = true;
            this.radioButton_Purple1.Text = "PURPLE";
            this.radioButton_Purple1.UseVisualStyleBackColor = true;
            // 
            // radioButton_Red2
            // 
            this.radioButton_Red2.AutoSize = true;
            this.radioButton_Red2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Red2.ForeColor = System.Drawing.Color.Red;
            this.radioButton_Red2.Location = new System.Drawing.Point(0, 0);
            this.radioButton_Red2.Name = "radioButton_Red2";
            this.radioButton_Red2.Size = new System.Drawing.Size(61, 22);
            this.radioButton_Red2.TabIndex = 5;
            this.radioButton_Red2.TabStop = true;
            this.radioButton_Red2.Text = "RED";
            this.radioButton_Red2.UseVisualStyleBackColor = true;
            // 
            // radioButton_Green2
            // 
            this.radioButton_Green2.AutoSize = true;
            this.radioButton_Green2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Green2.ForeColor = System.Drawing.Color.LimeGreen;
            this.radioButton_Green2.Location = new System.Drawing.Point(0, 39);
            this.radioButton_Green2.Name = "radioButton_Green2";
            this.radioButton_Green2.Size = new System.Drawing.Size(83, 22);
            this.radioButton_Green2.TabIndex = 5;
            this.radioButton_Green2.TabStop = true;
            this.radioButton_Green2.Text = "GREEN";
            this.radioButton_Green2.UseVisualStyleBackColor = true;
            // 
            // radioButton_Black2
            // 
            this.radioButton_Black2.AutoSize = true;
            this.radioButton_Black2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Black2.ForeColor = System.Drawing.Color.Black;
            this.radioButton_Black2.Location = new System.Drawing.Point(122, 0);
            this.radioButton_Black2.Name = "radioButton_Black2";
            this.radioButton_Black2.Size = new System.Drawing.Size(77, 22);
            this.radioButton_Black2.TabIndex = 6;
            this.radioButton_Black2.TabStop = true;
            this.radioButton_Black2.Text = "BLACK";
            this.radioButton_Black2.UseVisualStyleBackColor = true;
            // 
            // button_Magic
            // 
            this.button_Magic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_Magic.Enabled = false;
            this.button_Magic.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Magic.ForeColor = System.Drawing.Color.White;
            this.button_Magic.Location = new System.Drawing.Point(440, 287);
            this.button_Magic.Name = "button_Magic";
            this.button_Magic.Size = new System.Drawing.Size(208, 68);
            this.button_Magic.TabIndex = 6;
            this.button_Magic.Text = "MAGIC :)";
            this.button_Magic.UseVisualStyleBackColor = false;
            this.button_Magic.Click += new System.EventHandler(this.button_Magic_Click);
            // 
            // label_Hasil
            // 
            this.label_Hasil.AutoSize = true;
            this.label_Hasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Hasil.Location = new System.Drawing.Point(353, 220);
            this.label_Hasil.Name = "label_Hasil";
            this.label_Hasil.Size = new System.Drawing.Size(390, 22);
            this.label_Hasil.TabIndex = 7;
            this.label_Hasil.Text = "Hi, my name is _ and my favorite artist is _";
            // 
            // checkBox_True2
            // 
            this.checkBox_True2.AutoSize = true;
            this.checkBox_True2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_True2.Location = new System.Drawing.Point(348, 134);
            this.checkBox_True2.Name = "checkBox_True2";
            this.checkBox_True2.Size = new System.Drawing.Size(288, 24);
            this.checkBox_True2.TabIndex = 8;
            this.checkBox_True2.Text = "All the choice I pick above are true";
            this.checkBox_True2.UseVisualStyleBackColor = true;
            this.checkBox_True2.CheckedChanged += new System.EventHandler(this.checkBox_True2_CheckedChanged);
            // 
            // checkBox_Agree2
            // 
            this.checkBox_Agree2.AutoSize = true;
            this.checkBox_Agree2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Agree2.Location = new System.Drawing.Point(348, 92);
            this.checkBox_Agree2.Name = "checkBox_Agree2";
            this.checkBox_Agree2.Size = new System.Drawing.Size(287, 24);
            this.checkBox_Agree2.TabIndex = 9;
            this.checkBox_Agree2.Text = "I agree to the Terms of Agreement";
            this.checkBox_Agree2.UseVisualStyleBackColor = true;
            this.checkBox_Agree2.CheckedChanged += new System.EventHandler(this.checkBox_Agree2_CheckedChanged);
            // 
            // Second_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox_Agree2);
            this.Controls.Add(this.checkBox_True2);
            this.Controls.Add(this.label_Hasil);
            this.Controls.Add(this.button_Magic);
            this.Controls.Add(this.panel_Bawah);
            this.Controls.Add(this.panel_Atas);
            this.Controls.Add(this.label_TxtColor);
            this.Controls.Add(this.label_BackColor);
            this.Name = "Second_Form";
            this.Text = "Second Form";
            this.panel_Atas.ResumeLayout(false);
            this.panel_Atas.PerformLayout();
            this.panel_Bawah.ResumeLayout(false);
            this.panel_Bawah.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_BackColor;
        private System.Windows.Forms.Label label_TxtColor;
        private System.Windows.Forms.Panel panel_Atas;
        private System.Windows.Forms.RadioButton radioButton_Purple1;
        private System.Windows.Forms.RadioButton radioButton_Green1;
        private System.Windows.Forms.RadioButton radioButton_Orange1;
        private System.Windows.Forms.RadioButton radioButton_Blue1;
        private System.Windows.Forms.RadioButton radioButton_Red1;
        private System.Windows.Forms.Panel panel_Bawah;
        private System.Windows.Forms.RadioButton radioButton_Black2;
        private System.Windows.Forms.RadioButton radioButton_Green2;
        private System.Windows.Forms.RadioButton radioButton_Red2;
        private System.Windows.Forms.Button button_Magic;
        private System.Windows.Forms.Label label_Hasil;
        private System.Windows.Forms.CheckBox checkBox_True2;
        private System.Windows.Forms.CheckBox checkBox_Agree2;
    }
}