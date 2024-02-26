namespace Resturant_Management_System
{
    partial class ordercard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.itemname = new System.Windows.Forms.Label();
            this.quentitylbl = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.itmdeletebtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.itemname, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.quentitylbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pricelbl, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.itmdeletebtn, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(575, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // itemname
            // 
            this.itemname.AutoSize = true;
            this.itemname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemname.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemname.Location = new System.Drawing.Point(3, 0);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(259, 50);
            this.itemname.TabIndex = 0;
            this.itemname.Text = "Item Name";
            this.itemname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quentitylbl
            // 
            this.quentitylbl.AutoSize = true;
            this.quentitylbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quentitylbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quentitylbl.Location = new System.Drawing.Point(268, 0);
            this.quentitylbl.Name = "quentitylbl";
            this.quentitylbl.Size = new System.Drawing.Size(94, 50);
            this.quentitylbl.TabIndex = 1;
            this.quentitylbl.Text = "Quentity";
            this.quentitylbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pricelbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelbl.Location = new System.Drawing.Point(368, 0);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(154, 50);
            this.pricelbl.TabIndex = 2;
            this.pricelbl.Text = "Price";
            this.pricelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itmdeletebtn
            // 
            this.itmdeletebtn.Animated = true;
            this.itmdeletebtn.BorderThickness = 1;
            this.itmdeletebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.itmdeletebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.itmdeletebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.itmdeletebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.itmdeletebtn.FillColor = System.Drawing.Color.Transparent;
            this.itmdeletebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.itmdeletebtn.ForeColor = System.Drawing.Color.White;
            this.itmdeletebtn.Image = global::Resturant_Management_System.Properties.Resources.delete_932x1024;
            this.itmdeletebtn.Location = new System.Drawing.Point(528, 3);
            this.itmdeletebtn.Name = "itmdeletebtn";
            this.itmdeletebtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.itmdeletebtn.Size = new System.Drawing.Size(44, 44);
            this.itmdeletebtn.TabIndex = 3;
            // 
            // ordercard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(114)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ordercard";
            this.Size = new System.Drawing.Size(575, 50);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label itemname;
        private System.Windows.Forms.Label quentitylbl;
        private System.Windows.Forms.Label pricelbl;
        private Guna.UI2.WinForms.Guna2CircleButton itmdeletebtn;
    }
}
