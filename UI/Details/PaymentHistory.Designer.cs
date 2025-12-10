namespace Payroll.Logic.UI
{
    partial class PaymentHistory
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.colDate = new System.Windows.Forms.ColumnHeader();
            this.colGross = new System.Windows.Forms.ColumnHeader();
            this.colNet = new System.Windows.Forms.ColumnHeader();
            this.colCAS = new System.Windows.Forms.ColumnHeader();
            this.colCASS = new System.Windows.Forms.ColumnHeader();
            this.colTax = new System.Windows.Forms.ColumnHeader();
            this.colDays = new System.Windows.Forms.ColumnHeader();

            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDate,
            this.colGross,
            this.colNet,
            this.colCAS,
            this.colCASS,
            this.colTax,
            this.colDays});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 500);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.Width = 100;
            // 
            // colGross
            // 
            this.colGross.Text = "Gross Pay";
            this.colGross.Width = 100;
            // 
            // colNet
            // 
            this.colNet.Text = "Net Pay";
            this.colNet.Width = 100;
            // 
            // colCAS
            // 
            this.colCAS.Text = "CAS";
            this.colCAS.Width = 80;
            // 
            // colCASS
            // 
            this.colCASS.Text = "CASS";
            this.colCASS.Width = 80;
            // 
            // colTax
            // 
            this.colTax.Text = "Income Tax";
            this.colTax.Width = 80;
            // 
            // colDays
            // 
            this.colDays.Text = "Worked Days";
            this.colDays.Width = 90;
            // 
            // PaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Name = "PaymentHistory";
            this.Size = new System.Drawing.Size(800, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colGross;
        private System.Windows.Forms.ColumnHeader colNet;
        private System.Windows.Forms.ColumnHeader colCAS;
        private System.Windows.Forms.ColumnHeader colCASS;
        private System.Windows.Forms.ColumnHeader colTax;
        private System.Windows.Forms.ColumnHeader colDays;
    }
}