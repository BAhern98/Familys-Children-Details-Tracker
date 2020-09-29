namespace Dave_Menu
{
    partial class listBirthdays
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
            this.btnBack = new System.Windows.Forms.Button();
            this.listViewBirthdays = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.btnBack.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnBack.Location = new System.Drawing.Point(229, 479);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(163, 44);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // listViewBirthdays
            // 
            this.listViewBirthdays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.listViewBirthdays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewBirthdays.Font = new System.Drawing.Font("Franklin Gothic Book", 9F);
            this.listViewBirthdays.GridLines = true;
            this.listViewBirthdays.Location = new System.Drawing.Point(86, 12);
            this.listViewBirthdays.Name = "listViewBirthdays";
            this.listViewBirthdays.Size = new System.Drawing.Size(450, 435);
            this.listViewBirthdays.TabIndex = 17;
            this.listViewBirthdays.UseCompatibleStateImageBehavior = false;
            // 
            // listBirthdays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(608, 535);
            this.Controls.Add(this.listViewBirthdays);
            this.Controls.Add(this.btnBack);
            this.Name = "listBirthdays";
            this.Text = "Birthdays";
            this.Load += new System.EventHandler(this.listBirthdays_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView listViewBirthdays;
    }
}