using System.ComponentModel;

namespace Payroll2.UI;

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
        ((System.ComponentModel.ISupportInitialize)salary).BeginInit();
        SuspendLayout();
        // 
        // salary
        // 
        salary.Location = new System.Drawing.Point(55, 83);
        salary.Name = "salary";
        salary.Size = new System.Drawing.Size(120, 27);
        salary.TabIndex = 0;
        salary.ValueChanged += salary_ValueChanged;
        // 
        // workHoursComboBox
        // 
        workHoursComboBox.FormattingEnabled = true;
        workHoursComboBox.Location = new System.Drawing.Point(55, 116);
        workHoursComboBox.Name = "workHoursComboBox";
        workHoursComboBox.Size = new System.Drawing.Size(121, 28);
        workHoursComboBox.TabIndex = 1;
        workHoursComboBox.SelectedIndexChanged += workHoursComboBox_SelectedIndexChanged;
        // 
        // ContractTypeComboBox
        // 
        ContractTypeComboBox.FormattingEnabled = true;
        ContractTypeComboBox.Location = new System.Drawing.Point(54, 150);
        ContractTypeComboBox.Name = "ContractTypeComboBox";
        ContractTypeComboBox.Size = new System.Drawing.Size(121, 28);
        ContractTypeComboBox.TabIndex = 2;
        ContractTypeComboBox.SelectedIndexChanged += ContractTypeComboBox_SelectedIndexChanged;
        // 
        // AddEmployeeButton
        // 
        AddEmployeeButton.Location = new System.Drawing.Point(54, 354);
        AddEmployeeButton.Name = "AddEmployeeButton";
        AddEmployeeButton.Size = new System.Drawing.Size(166, 40);
        AddEmployeeButton.TabIndex = 3;
        AddEmployeeButton.Text = "add new employee";
        AddEmployeeButton.UseVisualStyleBackColor = true;
        AddEmployeeButton.Click += AddEmployeeButton_Click;
        // 
        // AddEmployee
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.ControlLight;
        Controls.Add(AddEmployeeButton);
        Controls.Add(ContractTypeComboBox);
        Controls.Add(workHoursComboBox);
        Controls.Add(salary);
        Size = new System.Drawing.Size(544, 426);
        ((System.ComponentModel.ISupportInitialize)salary).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.NumericUpDown salary;
    private System.Windows.Forms.ComboBox workHoursComboBox;
    private System.Windows.Forms.ComboBox ContractTypeComboBox;
    private System.Windows.Forms.Button AddEmployeeButton;

    #endregion
}