﻿namespace net.r_eg.DllExport.Wizard.UI.Kit
{
    partial class FilterLineControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.panelFBorder = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelFBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxFilter.Location = new System.Drawing.Point(1, 1);
            this.textBoxFilter.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(464, 16);
            this.textBoxFilter.TabIndex = 0;
            this.toolTip.SetToolTip(this.textBoxFilter, "Filter by project path");
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // panelFBorder
            // 
            this.panelFBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFBorder.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelFBorder.Controls.Add(this.textBoxFilter);
            this.panelFBorder.Location = new System.Drawing.Point(1, 0);
            this.panelFBorder.Margin = new System.Windows.Forms.Padding(0);
            this.panelFBorder.Name = "panelFBorder";
            this.panelFBorder.Padding = new System.Windows.Forms.Padding(1);
            this.panelFBorder.Size = new System.Drawing.Size(466, 18);
            this.panelFBorder.TabIndex = 7;
            // 
            // FilterLineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelFBorder);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FilterLineControl";
            this.Size = new System.Drawing.Size(467, 18);
            this.panelFBorder.ResumeLayout(false);
            this.panelFBorder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Panel panelFBorder;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
