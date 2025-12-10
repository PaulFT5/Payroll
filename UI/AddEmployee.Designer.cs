﻿using System.ComponentModel;

namespace Payroll.Logic.UI;

partial class AddEmployee
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
        salary = new System.Windows.Forms.NumericUpDown();
        workHoursComboBox = new System.Windows.Forms.ComboBox();
        ContractTypeComboBox = new System.Windows.Forms.ComboBox();
        AddEmployeeButton = new System.Windows.Forms.Button();
        textBox1 = new System.Windows.Forms.TextBox();
        EmployeeNameLabel = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)salary).BeginInit();
        SuspendLayout();
        // 
        // salary
        // 
        salary.BackColor = System.Drawing.SystemColors.InactiveBorder;
        salary.Location = new System.Drawing.Point(229, 218);
        salary.Name = "salary";
        salary.Size = new System.Drawing.Size(161, 27);
        salary.TabIndex = 0;
        salary.ValueChanged += salary_ValueChanged;
        // 
        // workHoursComboBox
        // 
        workHoursComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
        workHoursComboBox.FormattingEnabled = true;
        workHoursComboBox.Location = new System.Drawing.Point(228, 104);
        workHoursComboBox.Name = "workHoursComboBox";
        workHoursComboBox.Size = new System.Drawing.Size(162, 28);
        workHoursComboBox.TabIndex = 1;
        workHoursComboBox.SelectedIndexChanged += workHoursComboBox_SelectedIndexChanged;
        // 
        // ContractTypeComboBox
        // 
        ContractTypeComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
        ContractTypeComboBox.FormattingEnabled = true;
        ContractTypeComboBox.Location = new System.Drawing.Point(228, 164);
        ContractTypeComboBox.Name = "ContractTypeComboBox";
        ContractTypeComboBox.Size = new System.Drawing.Size(162, 28);
        ContractTypeComboBox.TabIndex = 2;
        ContractTypeComboBox.SelectedIndexChanged += ContractTypeComboBox_SelectedIndexChanged;
        // 
        // AddEmployeeButton
        // 
        AddEmployeeButton.Location = new System.Drawing.Point(343, 333);
        AddEmployeeButton.Name = "AddEmployeeButton";
        AddEmployeeButton.Size = new System.Drawing.Size(166, 40);
        AddEmployeeButton.TabIndex = 3;
        AddEmployeeButton.Text = "add new employee";
        AddEmployeeButton.UseVisualStyleBackColor = true;
        AddEmployeeButton.Click += AddEmployeeButton_Click;
        // 
        // textBox1
        // 
        textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
        textBox1.Location = new System.Drawing.Point(229, 59);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(161, 27);
        textBox1.TabIndex = 4;
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // EmployeeNameLabel
        // 
        EmployeeNameLabel.Location = new System.Drawing.Point(25, 62);
        EmployeeNameLabel.Name = "EmployeeNameLabel";
        EmployeeNameLabel.Size = new System.Drawing.Size(170, 34);
        EmployeeNameLabel.TabIndex = 5;
        EmployeeNameLabel.Text = "Employee Full name";
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(25, 109);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(170, 23);
        label1.TabIndex = 6;
        label1.Text = "Employee Work Hours";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(25, 164);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(170, 23);
        label2.TabIndex = 7;
        label2.Text = "Employee Type";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(25, 218);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(156, 23);
        label3.TabIndex = 8;
        label3.Text = "Employee Salary";
        // 
        // AddEmployee
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.ButtonFace;
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(EmployeeNameLabel);
        Controls.Add(textBox1);
        Controls.Add(AddEmployeeButton);
        Controls.Add(ContractTypeComboBox);
        Controls.Add(workHoursComboBox);
        Controls.Add(salary);
        Size = new System.Drawing.Size(544, 426);
        ((System.ComponentModel.ISupportInitialize)salary).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label EmployeeNameLabel;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.NumericUpDown salary;
    private System.Windows.Forms.ComboBox workHoursComboBox;
    private System.Windows.Forms.ComboBox ContractTypeComboBox;
    private System.Windows.Forms.Button AddEmployeeButton;

    #endregion
}