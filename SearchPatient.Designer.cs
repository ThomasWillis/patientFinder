namespace PatientFinder
{
    partial class SearchPatient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.patientList = new System.Windows.Forms.ListView();
            this.backBut = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.detailLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.patientList);
            this.panel1.Controls.Add(this.backBut);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.detailLabel);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 443);
            this.panel1.TabIndex = 3;
            // 
            // patientList
            // 
            this.patientList.Location = new System.Drawing.Point(104, 225);
            this.patientList.Name = "patientList";
            this.patientList.Size = new System.Drawing.Size(285, 162);
            this.patientList.TabIndex = 9;
            this.patientList.UseCompatibleStateImageBehavior = false;
            // 
            // backBut
            // 
            this.backBut.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBut.Location = new System.Drawing.Point(3, 417);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(75, 23);
            this.backBut.TabIndex = 8;
            this.backBut.Text = "Back";
            this.backBut.UseVisualStyleBackColor = true;
            this.backBut.Click += new System.EventHandler(this.backBut_Click);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(156, 144);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(191, 26);
            this.nameBox.TabIndex = 6;
            this.nameBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clearList);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(211, 176);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // detailLabel
            // 
            this.detailLabel.AutoSize = true;
            this.detailLabel.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailLabel.Location = new System.Drawing.Point(152, 103);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(202, 38);
            this.detailLabel.TabIndex = 1;
            this.detailLabel.Text = "Please enter a name below\r\n to search for a patient:";
            this.detailLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.titleLabel.Location = new System.Drawing.Point(155, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(192, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Patient Search";
            // 
            // SearchPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 439);
            this.Controls.Add(this.panel1);
            this.Name = "SearchPatient";
            this.Text = "SearchPatient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label detailLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button backBut;
        private System.Windows.Forms.ListView patientList;
    }
}