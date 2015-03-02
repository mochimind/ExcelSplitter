namespace WindowsFormsApplication1
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataSelect = new System.Windows.Forms.Button();
            this.OutputSelect = new System.Windows.Forms.Button();
            this.Begin = new System.Windows.Forms.Button();
            this.SelectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SelectFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // DataSelect
            // 
            this.DataSelect.Location = new System.Drawing.Point(12, 12);
            this.DataSelect.Name = "DataSelect";
            this.DataSelect.Size = new System.Drawing.Size(194, 35);
            this.DataSelect.TabIndex = 0;
            this.DataSelect.Text = "Select Data Files";
            this.DataSelect.UseVisualStyleBackColor = true;
            this.DataSelect.Click += new System.EventHandler(this.DataSelect_Click);
            // 
            // OutputSelect
            // 
            this.OutputSelect.Enabled = false;
            this.OutputSelect.Location = new System.Drawing.Point(12, 53);
            this.OutputSelect.Name = "OutputSelect";
            this.OutputSelect.Size = new System.Drawing.Size(194, 35);
            this.OutputSelect.TabIndex = 0;
            this.OutputSelect.Text = "Select Output Folder";
            this.OutputSelect.UseVisualStyleBackColor = true;
            this.OutputSelect.Click += new System.EventHandler(this.OutputSelect_Click);
            // 
            // Begin
            // 
            this.Begin.Enabled = false;
            this.Begin.Location = new System.Drawing.Point(12, 94);
            this.Begin.Name = "Begin";
            this.Begin.Size = new System.Drawing.Size(194, 35);
            this.Begin.TabIndex = 0;
            this.Begin.Text = "Begin Split";
            this.Begin.UseVisualStyleBackColor = true;
            this.Begin.Click += new System.EventHandler(this.Begin_Click);
            // 
            // SelectFileDialog
            // 
            this.SelectFileDialog.Multiselect = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 185);
            this.Controls.Add(this.Begin);
            this.Controls.Add(this.OutputSelect);
            this.Controls.Add(this.DataSelect);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DataSelect;
        private System.Windows.Forms.Button OutputSelect;
        private System.Windows.Forms.Button Begin;
        private System.Windows.Forms.OpenFileDialog SelectFileDialog;
        private System.Windows.Forms.FolderBrowserDialog SelectFolderDialog;
    }
}

