﻿using System.ComponentModel;

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
        statsButton = new System.Windows.Forms.Button();
        button = new System.Windows.Forms.Button();
        fireButton = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        panel2 = new System.Windows.Forms.Panel();
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
        panel1.Controls.Add(button);
        panel1.Controls.Add(fireButton);
        panel1.Controls.Add(button2);
        panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
        panel1.Location = new System.Drawing.Point(0, 380);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(800, 70);
        panel1.TabIndex = 1;
        // 
        // statsButton
        // 
        statsButton.Location = new System.Drawing.Point(73, 17);
        statsButton.Name = "statsButton";
        statsButton.Size = new System.Drawing.Size(108, 41);
        statsButton.TabIndex = 0;
        statsButton.Text = "Stats";
        statsButton.UseVisualStyleBackColor = true;
        statsButton.Click += statsButton_Click;
        // 
        // button
        // 
        button.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button.Location = new System.Drawing.Point(247, 17);
        button.Name = "button";
        button.Size = new System.Drawing.Size(113, 41);
        button.TabIndex = 3;
        button.Text = "Payment history";
        button.UseVisualStyleBackColor = true;
        button.Click += button_Click;
        // 
        // fireButton
        // 
        fireButton.Location = new System.Drawing.Point(592, 17);
        fireButton.Name = "fireButton";
        fireButton.Size = new System.Drawing.Size(108, 41);
        fireButton.TabIndex = 2;
        fireButton.Text = "Fire";
        fireButton.UseVisualStyleBackColor = true;
        fireButton.Click += fireButton_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(439, 17);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(107, 41);
        button2.TabIndex = 1;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        // 
        // panel2
        // 
        panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        panel2.Location = new System.Drawing.Point(0, 43);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(800, 337);
        panel2.TabIndex = 2;
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

    private System.Windows.Forms.Button button;

    private System.Windows.Forms.Button statsButton;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button fireButton;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Label label1;

    #endregion
}