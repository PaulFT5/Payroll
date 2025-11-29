using System.ComponentModel;

namespace Payroll.Logic.UI;

partial class ManageEmployee
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        listView1 = new System.Windows.Forms.ListView();
        ID = new System.Windows.Forms.ColumnHeader();
        Type = new System.Windows.Forms.ColumnHeader();
        workHours = new System.Windows.Forms.ColumnHeader();
        expectedSalary = new System.Windows.Forms.ColumnHeader();
        remove = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // listView1
        // 
        listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { ID, Type, workHours, expectedSalary });
        listView1.Location = new System.Drawing.Point(0, 0);
        listView1.Name = "listView1";
        listView1.Size = new System.Drawing.Size(600, 214);
        listView1.TabIndex = 0;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = System.Windows.Forms.View.Details;
        listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
        // 
        // ID
        // 
        ID.Name = "ID";
        ID.Text = "ID";
        ID.Width = 100;
        // 
        // Type
        // 
        Type.Name = "Type";
        Type.Text = "Type";
        Type.Width = 120;
        // 
        // workHours
        // 
        workHours.Name = "workHours";
        workHours.Text = "Work hours";
        workHours.Width = 120;
        // 
        // expectedSalary
        // 
        expectedSalary.Name = "expectedSalary";
        expectedSalary.Text = "Expected salary";
        expectedSalary.Width = 120;
        // 
        // remove
        // 
        remove.Location = new System.Drawing.Point(328, 255);
        remove.Name = "remove";
        remove.Size = new System.Drawing.Size(92, 32);
        remove.TabIndex = 1;
        remove.Text = "Remove";
        remove.UseVisualStyleBackColor = true;
        remove.Click += button1_Click;
        // 
        // ManageEmployee
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(remove);
        Controls.Add(listView1);
        Size = new System.Drawing.Size(438, 300);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button remove;

    private System.Windows.Forms.ColumnHeader workHours;
    private System.Windows.Forms.ColumnHeader expectedSalary;

    private System.Windows.Forms.ColumnHeader Type;

    private System.Windows.Forms.ColumnHeader ID;

    private System.Windows.Forms.ListView listView1;

    #endregion
}