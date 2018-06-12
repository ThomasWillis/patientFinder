namespace PatientFinder
{
    partial class DischargeForm
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
            this.hNumberBox = new System.Windows.Forms.TextBox();
            this.dischButton = new System.Windows.Forms.Button();
            this.detailLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.backBut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.backBut);
            this.panel1.Controls.Add(this.hNumberBox);
            this.panel1.Controls.Add(this.dischButton);
            this.panel1.Controls.Add(this.detailLabel);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 443);
            this.panel1.TabIndex = 2;
            // 
            // hNumberBox
            // 
            this.hNumberBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hNumberBox.Location = new System.Drawing.Point(156, 144);
            this.hNumberBox.Name = "hNumberBox";
            this.hNumberBox.Size = new System.Drawing.Size(191, 26);
            this.hNumberBox.TabIndex = 6;
            this.hNumberBox.Text = "Hospital number";
            // 
            // dischButton
            // 
            this.dischButton.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dischButton.Location = new System.Drawing.Point(211, 176);
            this.dischButton.Name = "dischButton";
            this.dischButton.Size = new System.Drawing.Size(75, 23);
            this.dischButton.TabIndex = 4;
            this.dischButton.Text = "Discharge";
            this.dischButton.UseVisualStyleBackColor = true;
            // 
            // detailLabel
            // 
            this.detailLabel.AutoSize = true;
            this.detailLabel.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailLabel.Location = new System.Drawing.Point(81, 108);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(374, 19);
            this.detailLabel.TabIndex = 1;
            this.detailLabel.Text = "Please enter hospital number to discharge patient:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.titleLabel.Location = new System.Drawing.Point(132, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(231, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Patient Discharge";
            // 
            // backBut
            // 
            this.backBut.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBut.Location = new System.Drawing.Point(0, 417);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(75, 23);
            this.backBut.TabIndex = 9;
            this.backBut.Text = "Back";
            this.backBut.UseVisualStyleBackColor = true;
            this.backBut.Click += new System.EventHandler(this.backBut_Click);
            // 
            // DischargeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 439);
            this.Controls.Add(this.panel1);
            this.Name = "DischargeForm";
            this.Text = "DischargeForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox hNumberBox;
        private System.Windows.Forms.Button dischButton;
        private System.Windows.Forms.Label detailLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button backBut;
    }
}