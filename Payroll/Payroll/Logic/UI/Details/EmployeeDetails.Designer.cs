using System.ComponentModel;

namespace Payroll.Logic.UI;

partial class EmployeeDetails
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        panel1 = new System.Windows.Forms.Panel();
        fireButton = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        statsButton = new System.Windows.Forms.Button();
        panel2 = new System.Windows.Forms.Panel();
        button3 = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.SystemColors.MenuBar;
        label1.Dock = System.Windows.Forms.DockStyle.Top;
        label1.Font = new System.Drawing.Font("Segoe UI", 11F);
        label1.Location = new System.Drawing.Point(0, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(800, 43);
        label1.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.Controls.Add(statsButton);
        panel1.Controls.Add(button3);
        panel1.Controls.Add(fireButton);
        panel1.Controls.Add(button2);
        panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
        panel1.Location = new System.Drawing.Point(0, 380);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(800, 70);
        panel1.TabIndex = 1;
        // 
        // fireButton
        // 
        fireButton.Location = new System.Drawing.Point(600, 17);
        fireButton.Name = "fireButton";
        fireButton.Size = new System.Drawing.Size(100, 35);
        fireButton.TabIndex = 2;
        fireButton.Text = "Fire";
        fireButton.UseVisualStyleBackColor = true;
        fireButton.Click += fireButton_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(428, 17);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(100, 35);
        button2.TabIndex = 1;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        // 
        // statsButton
        // 
        statsButton.Location = new System.Drawing.Point(73, 17);
        statsButton.Name = "statsButton";
        statsButton.Size = new System.Drawing.Size(100, 35);
        statsButton.TabIndex = 0;
        statsButton.Text = "Stats";
        statsButton.UseVisualStyleBackColor = true;
        statsButton.Click += statsButton_Click;
        // 
        // panel2
        // 
        panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        panel2.Location = new System.Drawing.Point(0, 43);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(800, 337);
        panel2.TabIndex = 2;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(256, 17);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(100, 35);
        button3.TabIndex = 3;
        button3.Text = "button3";
        button3.UseVisualStyleBackColor = true;
        // 
        // EmployeeDetails
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Window;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(label1);
        Text = "EmployeeDetails";
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Button statsButton;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button fireButton;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Label label1;

    #endregion
}