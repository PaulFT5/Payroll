﻿using System.ComponentModel;

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
        nameCol = new System.Windows.Forms.ColumnHeader();
        surnameCol = new System.Windows.Forms.ColumnHeader();
        contractTypeCol = new System.Windows.Forms.ColumnHeader();
        remove = new System.Windows.Forms.Button();
        workHoursCol = new System.Windows.Forms.ColumnHeader();
        SuspendLayout();
        // 
        // listView1
        // 
        listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { ID, nameCol, surnameCol, contractTypeCol, workHoursCol });
        listView1.Location = new System.Drawing.Point(0, 0);
        listView1.Name = "listView1";
        listView1.Size = new System.Drawing.Size(600, 209);
        listView1.TabIndex = 0;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = System.Windows.Forms.View.Details;
        listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
        // 
        // ID
        // 
        ID.Name = "ID";
        ID.Text = "ID";
        ID.Width = 120;
        // 
        // nameCol
        // 
        nameCol.Name = "Type";
        nameCol.Text = "Name";
        nameCol.Width = 115;
        // 
        // surnameCol
        // 
        surnameCol.Name = "workHours";
        surnameCol.Text = "Surname";
        surnameCol.Width = 120;
        // 
        // contractTypeCol
        // 
        contractTypeCol.Name = "contractTypeCol";
        contractTypeCol.Text = "Contract Type";
        contractTypeCol.Width = 120;
        // 
        // remove
        // 
        remove.Location = new System.Drawing.Point(451, 322);
        remove.Name = "remove";
        remove.Size = new System.Drawing.Size(121, 46);
        remove.TabIndex = 1;
        remove.Text = "Details";
        remove.UseVisualStyleBackColor = true;
        remove.Click += button1_Click;
        // 
        // workHoursCol
        // 
        workHoursCol.Name = "workHoursCol";
        workHoursCol.Text = "Work Hours";
        workHoursCol.Width = 120;
        // 
        // ManageEmployee
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(remove);
        Controls.Add(listView1);
        Size = new System.Drawing.Size(600, 450);
        ResumeLayout(false);
    }

    private System.Windows.Forms.ColumnHeader workHoursCol;

    private System.Windows.Forms.Button remove;

    private System.Windows.Forms.ColumnHeader surnameCol;
    private System.Windows.Forms.ColumnHeader contractTypeCol;

    private System.Windows.Forms.ColumnHeader nameCol;

    private System.Windows.Forms.ColumnHeader ID;

    private System.Windows.Forms.ListView listView1;

    #endregion
}