namespace _1_RegEx_Base
{
    partial class Form1
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
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.gbRegExMain = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbResullts = new System.Windows.Forms.GroupBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnSearchFile = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.gbRegExMain.SuspendLayout();
            this.gbResullts.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(54, 31);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(341, 20);
            this.txtPattern.TabIndex = 0;
            // 
            // gbRegExMain
            // 
            this.gbRegExMain.Controls.Add(this.btnRead);
            this.gbRegExMain.Controls.Add(this.btnSearchFile);
            this.gbRegExMain.Controls.Add(this.btnSearch);
            this.gbRegExMain.Controls.Add(this.lblFile);
            this.gbRegExMain.Controls.Add(this.txtFile);
            this.gbRegExMain.Controls.Add(this.lblName);
            this.gbRegExMain.Controls.Add(this.txtPattern);
            this.gbRegExMain.Location = new System.Drawing.Point(22, 30);
            this.gbRegExMain.Name = "gbRegExMain";
            this.gbRegExMain.Size = new System.Drawing.Size(479, 147);
            this.gbRegExMain.TabIndex = 1;
            this.gbRegExMain.TabStop = false;
            this.gbRegExMain.Text = "RegEx Is Fun";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Pattern";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(8, 73);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(26, 13);
            this.lblFile.TabIndex = 3;
            this.lblFile.Text = "File ";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(55, 70);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(340, 20);
            this.txtFile.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(320, 107);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbResullts
            // 
            this.gbResullts.Controls.Add(this.txtResults);
            this.gbResullts.Location = new System.Drawing.Point(22, 183);
            this.gbResullts.Name = "gbResullts";
            this.gbResullts.Size = new System.Drawing.Size(479, 234);
            this.gbResullts.TabIndex = 2;
            this.gbResullts.TabStop = false;
            this.gbResullts.Text = "Results";
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(3, 16);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(470, 212);
            this.txtResults.TabIndex = 0;
            // 
            // btnSearchFile
            // 
            this.btnSearchFile.Location = new System.Drawing.Point(401, 70);
            this.btnSearchFile.Name = "btnSearchFile";
            this.btnSearchFile.Size = new System.Drawing.Size(35, 22);
            this.btnSearchFile.TabIndex = 5;
            this.btnSearchFile.Text = "...";
            this.btnSearchFile.UseVisualStyleBackColor = true;
            this.btnSearchFile.Click += new System.EventHandler(this.btnSearchFile_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(228, 107);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.gbResullts);
            this.Controls.Add(this.gbRegExMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbRegExMain.ResumeLayout(false);
            this.gbRegExMain.PerformLayout();
            this.gbResullts.ResumeLayout(false);
            this.gbResullts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.GroupBox gbRegExMain;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSearchFile;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.GroupBox gbResullts;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnRead;
    }
}

