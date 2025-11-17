using System.ComponentModel;

namespace Payroll.UI
{
    partial class MainPage
    {
        private IContainer components = null;

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel AppPanel;

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label labelMockDate;

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button manage;
        private System.Windows.Forms.Button stats;
        private System.Windows.Forms.Button timer;
        private System.Windows.Forms.Button exit;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MenuPanel = new System.Windows.Forms.Panel();
            exit = new System.Windows.Forms.Button();
            timer = new System.Windows.Forms.Button();
            stats = new System.Windows.Forms.Button();
            manage = new System.Windows.Forms.Button();
            Add = new System.Windows.Forms.Button();
            Title = new System.Windows.Forms.Label();
            labelMockDate = new System.Windows.Forms.Label();
            AppPanel = new System.Windows.Forms.Panel();
            MenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            MenuPanel.Controls.Add(exit);
            MenuPanel.Controls.Add(timer);
            MenuPanel.Controls.Add(stats);
            MenuPanel.Controls.Add(manage);
            MenuPanel.Controls.Add(Add);
            MenuPanel.Controls.Add(Title);
            MenuPanel.Controls.Add(labelMockDate);
            MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            MenuPanel.Location = new System.Drawing.Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new System.Drawing.Size(200, 450);
            MenuPanel.TabIndex = 1;
            // 
            // exit
            // 
            exit.Location = new System.Drawing.Point(0, 366);
            exit.Name = "exit";
            exit.Size = new System.Drawing.Size(200, 41);
            exit.TabIndex = 0;
            exit.Text = "Exit";
            exit.Click += exit_Click;
            // 
            // timer
            // 
            timer.Location = new System.Drawing.Point(0, 280);
            timer.Name = "timer";
            timer.Size = new System.Drawing.Size(200, 41);
            timer.TabIndex = 1;
            timer.Text = "Timer";
            timer.Click += timer_Click;
            // 
            // stats
            // 
            stats.Location = new System.Drawing.Point(0, 233);
            stats.Name = "stats";
            stats.Size = new System.Drawing.Size(200, 41);
            stats.TabIndex = 2;
            stats.Text = "Stats";
            stats.Click += stats_Click;
            // 
            // manage
            // 
            manage.Location = new System.Drawing.Point(0, 186);
            manage.Name = "manage";
            manage.Size = new System.Drawing.Size(200, 41);
            manage.TabIndex = 3;
            manage.Text = "Manage employee";
            manage.Click += manage_Click;
            // 
            // Add
            // 
            Add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            Add.Location = new System.Drawing.Point(0, 139);
            Add.Name = "Add";
            Add.Size = new System.Drawing.Size(200, 41);
            Add.TabIndex = 4;
            Add.Text = "Add employee";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Title
            // 
            Title.Location = new System.Drawing.Point(0, 0);
            Title.Name = "Title";
            Title.Size = new System.Drawing.Size(200, 43);
            Title.TabIndex = 5;
            Title.Text = "Payroll system";
            Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMockDate
            // 
            labelMockDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            labelMockDate.Location = new System.Drawing.Point(0, 410);
            labelMockDate.Name = "labelMockDate";
            labelMockDate.Size = new System.Drawing.Size(200, 40);
            labelMockDate.TabIndex = 6;
            labelMockDate.Text = "Date: ---";
            labelMockDate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // AppPanel
            // 
            AppPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            AppPanel.Location = new System.Drawing.Point(200, 0);
            AppPanel.Name = "AppPanel";
            AppPanel.Size = new System.Drawing.Size(600, 450);
            AppPanel.TabIndex = 0;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(AppPanel);
            Controls.Add(MenuPanel);
            Text = "MainPage";
            MenuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
