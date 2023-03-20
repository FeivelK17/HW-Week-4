namespace HW_Week_4
{
    partial class Main_Form
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
            this.label_Name = new System.Windows.Forms.Label();
            this.label_FavArtist = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_FavArtist = new System.Windows.Forms.TextBox();
            this.checkBox_True1 = new System.Windows.Forms.CheckBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.button_NextForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(33, 44);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(82, 29);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name";
            // 
            // label_FavArtist
            // 
            this.label_FavArtist.AutoSize = true;
            this.label_FavArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FavArtist.Location = new System.Drawing.Point(35, 109);
            this.label_FavArtist.Name = "label_FavArtist";
            this.label_FavArtist.Size = new System.Drawing.Size(214, 29);
            this.label_FavArtist.TabIndex = 1;
            this.label_FavArtist.Text = "My Favorite Artist";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Name.Location = new System.Drawing.Point(344, 44);
            this.textBox_Name.Multiline = true;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(388, 29);
            this.textBox_Name.TabIndex = 2;
            // 
            // textBox_FavArtist
            // 
            this.textBox_FavArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FavArtist.Location = new System.Drawing.Point(344, 109);
            this.textBox_FavArtist.Multiline = true;
            this.textBox_FavArtist.Name = "textBox_FavArtist";
            this.textBox_FavArtist.Size = new System.Drawing.Size(388, 29);
            this.textBox_FavArtist.TabIndex = 3;
            // 
            // checkBox_True1
            // 
            this.checkBox_True1.AutoSize = true;
            this.checkBox_True1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_True1.Location = new System.Drawing.Point(40, 220);
            this.checkBox_True1.Name = "checkBox_True1";
            this.checkBox_True1.Size = new System.Drawing.Size(300, 24);
            this.checkBox_True1.TabIndex = 4;
            this.checkBox_True1.Text = "All of the content I put above is true!";
            this.checkBox_True1.UseVisualStyleBackColor = true;
            this.checkBox_True1.CheckedChanged += new System.EventHandler(this.checkBox_True1_CheckedChanged);
            // 
            // button_Submit
            // 
            this.button_Submit.Enabled = false;
            this.button_Submit.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Submit.Location = new System.Drawing.Point(132, 308);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(208, 68);
            this.button_Submit.TabIndex = 5;
            this.button_Submit.Text = "SUBMIT";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // button_NextForm
            // 
            this.button_NextForm.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NextForm.Location = new System.Drawing.Point(444, 308);
            this.button_NextForm.Name = "button_NextForm";
            this.button_NextForm.Size = new System.Drawing.Size(208, 68);
            this.button_NextForm.TabIndex = 6;
            this.button_NextForm.Text = "Open Next Form";
            this.button_NextForm.UseVisualStyleBackColor = true;
            this.button_NextForm.Click += new System.EventHandler(this.button_NextForm_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_NextForm);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.checkBox_True1);
            this.Controls.Add(this.textBox_FavArtist);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_FavArtist);
            this.Controls.Add(this.label_Name);
            this.Name = "Main_Form";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_FavArtist;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_FavArtist;
        private System.Windows.Forms.CheckBox checkBox_True1;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Button button_NextForm;
    }
}

