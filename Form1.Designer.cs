namespace MergeSort
{
    partial class Form1
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>


        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LowerLabel = new System.Windows.Forms.Label();
            this.Grid_2 = new System.Windows.Forms.DataGridView();
            this.Grid_1 = new System.Windows.Forms.DataGridView();
            this.UpperLabel = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.MergeSort_label = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Sort_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_1)).BeginInit();
            this.UpperPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LowerLabel
            // 
            this.LowerLabel.AutoSize = true;
            this.LowerLabel.BackColor = System.Drawing.Color.SpringGreen;
            this.LowerLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.LowerLabel.Location = new System.Drawing.Point(254, 171);
            this.LowerLabel.Name = "LowerLabel";
            this.LowerLabel.Size = new System.Drawing.Size(156, 25);
            this.LowerLabel.TabIndex = 28;
            this.LowerLabel.Text = "Your sorted array";
            // 
            // Grid_2
            // 
            this.Grid_2.AllowUserToDeleteRows = false;
            this.Grid_2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid_2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid_2.BackgroundColor = System.Drawing.Color.Honeydew;
            this.Grid_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_2.ColumnHeadersVisible = false;
            this.Grid_2.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.Grid_2.Location = new System.Drawing.Point(138, 197);
            this.Grid_2.Name = "Grid_2";
            this.Grid_2.ReadOnly = true;
            this.Grid_2.RowHeadersVisible = false;
            this.Grid_2.RowHeadersWidth = 51;
            this.Grid_2.Size = new System.Drawing.Size(393, 40);
            this.Grid_2.TabIndex = 27;
            // 
            // Grid_1
            // 
            this.Grid_1.AllowUserToDeleteRows = false;
            this.Grid_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid_1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid_1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.Grid_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_1.ColumnHeadersVisible = false;
            this.Grid_1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.Grid_1.Location = new System.Drawing.Point(139, 118);
            this.Grid_1.Name = "Grid_1";
            this.Grid_1.ReadOnly = true;
            this.Grid_1.RowHeadersVisible = false;
            this.Grid_1.RowHeadersWidth = 51;
            this.Grid_1.Size = new System.Drawing.Size(393, 37);
            this.Grid_1.TabIndex = 25;
            // 
            // UpperLabel
            // 
            this.UpperLabel.AutoSize = true;
            this.UpperLabel.BackColor = System.Drawing.Color.SpringGreen;
            this.UpperLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.UpperLabel.Location = new System.Drawing.Point(242, 39);
            this.UpperLabel.Name = "UpperLabel";
            this.UpperLabel.Size = new System.Drawing.Size(168, 25);
            this.UpperLabel.TabIndex = 24;
            this.UpperLabel.Text = "Your entered array\r\n";
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.Honeydew;
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TextBox1.Location = new System.Drawing.Point(139, 67);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(393, 25);
            this.TextBox1.TabIndex = 23;
            // 
            // Edit_Button
            // 
            this.Edit_Button.BackColor = System.Drawing.Color.SpringGreen;
            this.Edit_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Button.Location = new System.Drawing.Point(25, 120);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(88, 35);
            this.Edit_Button.TabIndex = 22;
            this.Edit_Button.Text = "Edit";
            this.Edit_Button.UseVisualStyleBackColor = false;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.Color.White;
            this.UpperPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpperPanel.Controls.Add(this.MergeSort_label);
            this.UpperPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(579, 34);
            this.UpperPanel.TabIndex = 29;
            this.UpperPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpperPanel_MouseDown);
            this.UpperPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpperPanel_MouseMove);
            // 
            // MergeSort_label
            // 
            this.MergeSort_label.AutoSize = true;
            this.MergeSort_label.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.MergeSort_label.Location = new System.Drawing.Point(3, 4);
            this.MergeSort_label.Name = "MergeSort_label";
            this.MergeSort_label.Size = new System.Drawing.Size(103, 23);
            this.MergeSort_label.TabIndex = 2;
            this.MergeSort_label.Text = "Merge Sort";
            this.MergeSort_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MergeSort_label_MouseDown);
            this.MergeSort_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MergeSort_label_MouseMove);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.MainPanel.Controls.Add(this.Exit_Button);
            this.MainPanel.Controls.Add(this.UpperLabel);
            this.MainPanel.Controls.Add(this.Edit_Button);
            this.MainPanel.Controls.Add(this.Sort_Button);
            this.MainPanel.Controls.Add(this.Grid_2);
            this.MainPanel.Controls.Add(this.LowerLabel);
            this.MainPanel.Controls.Add(this.TextBox1);
            this.MainPanel.Controls.Add(this.Grid_1);
            this.MainPanel.Location = new System.Drawing.Point(12, 40);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(555, 311);
            this.MainPanel.TabIndex = 30;
            // 
            // Exit_Button
            // 
            this.Exit_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Exit_Button.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Exit_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exit_Button.Location = new System.Drawing.Point(480, 3);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(72, 58);
            this.Exit_Button.TabIndex = 36;
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Sort_Button
            // 
            this.Sort_Button.BackColor = System.Drawing.Color.SpringGreen;
            this.Sort_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sort_Button.Enabled = false;
            this.Sort_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sort_Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sort_Button.Location = new System.Drawing.Point(25, 197);
            this.Sort_Button.Name = "Sort_Button";
            this.Sort_Button.Size = new System.Drawing.Size(88, 40);
            this.Sort_Button.TabIndex = 26;
            this.Sort_Button.Text = "Sort";
            this.Sort_Button.UseVisualStyleBackColor = false;
            this.Sort_Button.Click += new System.EventHandler(this.Sort_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 365);
            this.Controls.Add(this.UpperPanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merge Sort";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_1)).EndInit();
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LowerLabel;
        private System.Windows.Forms.DataGridView Grid_2;
        private System.Windows.Forms.DataGridView Grid_1;
        private System.Windows.Forms.Label UpperLabel;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Label MergeSort_label;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button Sort_Button;
    }
}

