﻿namespace MagicMongoDBTool
{
    partial class frmConnect
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
            this.cmdModifyCon = new System.Windows.Forms.Button();
            this.cmdDelCon = new System.Windows.Forms.Button();
            this.cmdAddCon = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.lstServerce = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmdModifyCon
            // 
            this.cmdModifyCon.BackColor = System.Drawing.Color.Transparent;
            this.cmdModifyCon.Location = new System.Drawing.Point(433, 84);
            this.cmdModifyCon.Name = "cmdModifyCon";
            this.cmdModifyCon.Size = new System.Drawing.Size(90, 36);
            this.cmdModifyCon.TabIndex = 9;
            this.cmdModifyCon.Text = "Modify";
            this.cmdModifyCon.UseVisualStyleBackColor = false;
            this.cmdModifyCon.Click += new System.EventHandler(this.cmdModifyCon_Click);
            // 
            // cmdDelCon
            // 
            this.cmdDelCon.BackColor = System.Drawing.Color.Transparent;
            this.cmdDelCon.Location = new System.Drawing.Point(433, 151);
            this.cmdDelCon.Name = "cmdDelCon";
            this.cmdDelCon.Size = new System.Drawing.Size(90, 36);
            this.cmdDelCon.TabIndex = 10;
            this.cmdDelCon.Text = "Drop";
            this.cmdDelCon.UseVisualStyleBackColor = false;
            this.cmdDelCon.Click += new System.EventHandler(this.cmdDelCon_Click);
            // 
            // cmdAddCon
            // 
            this.cmdAddCon.BackColor = System.Drawing.Color.Transparent;
            this.cmdAddCon.Location = new System.Drawing.Point(433, 16);
            this.cmdAddCon.Name = "cmdAddCon";
            this.cmdAddCon.Size = new System.Drawing.Size(90, 36);
            this.cmdAddCon.TabIndex = 8;
            this.cmdAddCon.Text = "New";
            this.cmdAddCon.UseVisualStyleBackColor = false;
            this.cmdAddCon.Click += new System.EventHandler(this.cmdAddCon_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.Transparent;
            this.cmdClose.Location = new System.Drawing.Point(278, 205);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(90, 36);
            this.cmdClose.TabIndex = 7;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.BackColor = System.Drawing.Color.Transparent;
            this.cmdOK.Location = new System.Drawing.Point(103, 205);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(90, 36);
            this.cmdOK.TabIndex = 6;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = false;
            this.cmdOK.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // lstServerce
            // 
            this.lstServerce.FormattingEnabled = true;
            this.lstServerce.ItemHeight = 15;
            this.lstServerce.Location = new System.Drawing.Point(13, 16);
            this.lstServerce.Name = "lstServerce";
            this.lstServerce.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstServerce.Size = new System.Drawing.Size(412, 169);
            this.lstServerce.TabIndex = 5;
            // 
            // frmConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(542, 254);
            this.Controls.Add(this.cmdModifyCon);
            this.Controls.Add(this.cmdDelCon);
            this.Controls.Add(this.cmdAddCon);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.lstServerce);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Server Connection";
            this.Load += new System.EventHandler(this.frmConnect_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdModifyCon;
        private System.Windows.Forms.Button cmdDelCon;
        private System.Windows.Forms.Button cmdAddCon;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.ListBox lstServerce;
    }
}