namespace Resturant_Management_System
{
    partial class Customer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cusname = new Guna.UI2.WinForms.Guna2TextBox();
            this.custelno = new Guna.UI2.WinForms.Guna2TextBox();
            this.gobtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hey There!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(85, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tel.Number";
            // 
            // cusname
            // 
            this.cusname.AutoRoundedCorners = true;
            this.cusname.BorderRadius = 23;
            this.cusname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cusname.DefaultText = "";
            this.cusname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cusname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cusname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cusname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cusname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(15)))));
            this.cusname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cusname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cusname.ForeColor = System.Drawing.Color.White;
            this.cusname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cusname.Location = new System.Drawing.Point(267, 146);
            this.cusname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cusname.Name = "cusname";
            this.cusname.PasswordChar = '\0';
            this.cusname.PlaceholderText = "Enter Your Name";
            this.cusname.SelectedText = "";
            this.cusname.Size = new System.Drawing.Size(320, 48);
            this.cusname.TabIndex = 3;
            // 
            // custelno
            // 
            this.custelno.AutoRoundedCorners = true;
            this.custelno.BorderRadius = 23;
            this.custelno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custelno.DefaultText = "";
            this.custelno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.custelno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.custelno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.custelno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.custelno.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(15)))));
            this.custelno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.custelno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.custelno.ForeColor = System.Drawing.Color.White;
            this.custelno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.custelno.Location = new System.Drawing.Point(267, 227);
            this.custelno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.custelno.Name = "custelno";
            this.custelno.PasswordChar = '\0';
            this.custelno.PlaceholderText = "Enter Your Tel.Number";
            this.custelno.SelectedText = "";
            this.custelno.Size = new System.Drawing.Size(320, 48);
            this.custelno.TabIndex = 4;
            // 
            // gobtn
            // 
            this.gobtn.Animated = true;
            this.gobtn.AutoRoundedCorners = true;
            this.gobtn.BorderRadius = 21;
            this.gobtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gobtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gobtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gobtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gobtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(114)))), ((int)(((byte)(48)))));
            this.gobtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobtn.ForeColor = System.Drawing.Color.White;
            this.gobtn.Location = new System.Drawing.Point(267, 330);
            this.gobtn.Name = "gobtn";
            this.gobtn.Size = new System.Drawing.Size(152, 45);
            this.gobtn.TabIndex = 5;
            this.gobtn.Text = "GO";
            this.gobtn.Click += new System.EventHandler(this.gobtn_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(684, 435);
            this.Controls.Add(this.gobtn);
            this.Controls.Add(this.custelno);
            this.Controls.Add(this.cusname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox cusname;
        private Guna.UI2.WinForms.Guna2TextBox custelno;
        private Guna.UI2.WinForms.Guna2Button gobtn;
    }
}