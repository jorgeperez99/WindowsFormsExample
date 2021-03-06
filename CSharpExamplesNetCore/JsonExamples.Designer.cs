﻿namespace CSharpExamples {
    partial class JsonExamples {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lstJsonReport = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.lnkCreateJson = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lstJsonReport
            // 
            this.lstJsonReport.AutoSize = true;
            this.lstJsonReport.Location = new System.Drawing.Point(313, 189);
            this.lstJsonReport.Name = "lstJsonReport";
            this.lstJsonReport.Size = new System.Drawing.Size(105, 15);
            this.lstJsonReport.TabIndex = 0;
            this.lstJsonReport.TabStop = true;
            this.lstJsonReport.Text = "Create Json Report";
            this.lstJsonReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lstJsonReport_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(313, 222);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(150, 15);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add report to list of reports";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lstJsonReport_AddReport);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(313, 255);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(59, 15);
            this.linkLabel2.TabIndex = 0;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Filter Json";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lstJsonReport_FilterReport);
            // 
            // lnkCreateJson
            // 
            this.lnkCreateJson.AutoSize = true;
            this.lnkCreateJson.Location = new System.Drawing.Point(313, 288);
            this.lnkCreateJson.Name = "lnkCreateJson";
            this.lnkCreateJson.Size = new System.Drawing.Size(164, 15);
            this.lnkCreateJson.TabIndex = 0;
            this.lnkCreateJson.TabStop = true;
            this.lnkCreateJson.Text = "Create json string from object";
            this.lnkCreateJson.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lstCreateJson_LinkClicked);
            // 
            // JsonExamples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lnkCreateJson);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lstJsonReport);
            this.Name = "JsonExamples";
            this.Text = "JsonExamples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lstJsonReport;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel lnkCreateJson;
    }
}