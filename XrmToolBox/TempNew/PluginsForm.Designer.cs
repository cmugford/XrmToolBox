﻿namespace XrmToolBox.TempNew
{
    partial class PluginsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginsForm));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlPlugins = new System.Windows.Forms.Panel();
            this.cmsOnePlugin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiOpenProjectHomePage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiShortcutTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShortcutToolConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiHidePlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUninstallPlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHelp = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlNoPluginFound = new System.Windows.Forms.Panel();
            this.llResetSearchFilter = new System.Windows.Forms.LinkLabel();
            this.pbOpenPluginsStore = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPluginsNotFoundText = new System.Windows.Forms.Label();
            this.cmsOnePlugin.SuspendLayout();
            this.pnlHelp.SuspendLayout();
            this.pnlNoPluginFound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenPluginsStore)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1036, 60);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlPlugins
            // 
            this.pnlPlugins.AutoScroll = true;
            this.pnlPlugins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlugins.Location = new System.Drawing.Point(0, 60);
            this.pnlPlugins.Name = "pnlPlugins";
            this.pnlPlugins.Size = new System.Drawing.Size(1036, 701);
            this.pnlPlugins.TabIndex = 1;
            // 
            // cmsOnePlugin
            // 
            this.cmsOnePlugin.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsOnePlugin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenProjectHomePage,
            this.toolStripSeparator9,
            this.tsmiShortcutTool,
            this.tsmiShortcutToolConnection,
            this.toolStripSeparator7,
            this.tsmiHidePlugin,
            this.tsmiUninstallPlugin});
            this.cmsOnePlugin.Name = "cmsOnePlugin";
            this.cmsOnePlugin.Size = new System.Drawing.Size(383, 166);
            this.cmsOnePlugin.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsOnePlugin_ItemClicked);
            // 
            // tsmiOpenProjectHomePage
            // 
            this.tsmiOpenProjectHomePage.Name = "tsmiOpenProjectHomePage";
            this.tsmiOpenProjectHomePage.Size = new System.Drawing.Size(382, 30);
            this.tsmiOpenProjectHomePage.Text = "Open project home page";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(379, 6);
            // 
            // tsmiShortcutTool
            // 
            this.tsmiShortcutTool.Name = "tsmiShortcutTool";
            this.tsmiShortcutTool.Size = new System.Drawing.Size(382, 30);
            this.tsmiShortcutTool.Text = "Create shortcut (Tool)";
            // 
            // tsmiShortcutToolConnection
            // 
            this.tsmiShortcutToolConnection.Name = "tsmiShortcutToolConnection";
            this.tsmiShortcutToolConnection.Size = new System.Drawing.Size(382, 30);
            this.tsmiShortcutToolConnection.Text = "Create shortcut (Tool and Connection)";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(379, 6);
            // 
            // tsmiHidePlugin
            // 
            this.tsmiHidePlugin.Name = "tsmiHidePlugin";
            this.tsmiHidePlugin.Size = new System.Drawing.Size(382, 30);
            this.tsmiHidePlugin.Text = "Hide";
            // 
            // tsmiUninstallPlugin
            // 
            this.tsmiUninstallPlugin.Name = "tsmiUninstallPlugin";
            this.tsmiUninstallPlugin.Size = new System.Drawing.Size(382, 30);
            this.tsmiUninstallPlugin.Text = "Uninstall";
            // 
            // pnlHelp
            // 
            this.pnlHelp.BackColor = System.Drawing.Color.White;
            this.pnlHelp.Controls.Add(this.label2);
            this.pnlHelp.Controls.Add(this.label1);
            this.pnlHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHelp.Location = new System.Drawing.Point(0, 60);
            this.pnlHelp.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlHelp.Name = "pnlHelp";
            this.pnlHelp.Size = new System.Drawing.Size(1036, 701);
            this.pnlHelp.TabIndex = 9;
            this.pnlHelp.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1024, 174);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1036, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oups... no plugin found!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlNoPluginFound
            // 
            this.pnlNoPluginFound.BackColor = System.Drawing.Color.White;
            this.pnlNoPluginFound.Controls.Add(this.llResetSearchFilter);
            this.pnlNoPluginFound.Controls.Add(this.pbOpenPluginsStore);
            this.pnlNoPluginFound.Controls.Add(this.label3);
            this.pnlNoPluginFound.Controls.Add(this.lblPluginsNotFoundText);
            this.pnlNoPluginFound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNoPluginFound.Location = new System.Drawing.Point(0, 60);
            this.pnlNoPluginFound.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlNoPluginFound.Name = "pnlNoPluginFound";
            this.pnlNoPluginFound.Size = new System.Drawing.Size(1036, 701);
            this.pnlNoPluginFound.TabIndex = 10;
            this.pnlNoPluginFound.Visible = false;
            this.pnlNoPluginFound.Resize += new System.EventHandler(this.pnlNoPluginFound_Resize);
            // 
            // llResetSearchFilter
            // 
            this.llResetSearchFilter.AutoSize = true;
            this.llResetSearchFilter.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.llResetSearchFilter.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.llResetSearchFilter.Location = new System.Drawing.Point(430, 408);
            this.llResetSearchFilter.Name = "llResetSearchFilter";
            this.llResetSearchFilter.Size = new System.Drawing.Size(176, 20);
            this.llResetSearchFilter.TabIndex = 3;
            this.llResetSearchFilter.TabStop = true;
            this.llResetSearchFilter.Text = "or reset the search filter";
            this.llResetSearchFilter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llResetSearchFilter_LinkClicked);
            // 
            // pbOpenPluginsStore
            // 
            this.pbOpenPluginsStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbOpenPluginsStore.Image = ((System.Drawing.Image)(resources.GetObject("pbOpenPluginsStore.Image")));
            this.pbOpenPluginsStore.Location = new System.Drawing.Point(218, 240);
            this.pbOpenPluginsStore.Name = "pbOpenPluginsStore";
            this.pbOpenPluginsStore.Size = new System.Drawing.Size(600, 128);
            this.pbOpenPluginsStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOpenPluginsStore.TabIndex = 2;
            this.pbOpenPluginsStore.TabStop = false;
            this.pbOpenPluginsStore.Click += new System.EventHandler(this.pbOpenPluginsStore_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.label3.Location = new System.Drawing.Point(0, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1036, 80);
            this.label3.TabIndex = 1;
            this.label3.Tag = "";
            this.label3.Text = "Please redefine the criteria, reset it, or download some new plugins from our plu" +
    "gin store";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPluginsNotFoundText
            // 
            this.lblPluginsNotFoundText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPluginsNotFoundText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPluginsNotFoundText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.lblPluginsNotFoundText.Location = new System.Drawing.Point(0, 0);
            this.lblPluginsNotFoundText.Name = "lblPluginsNotFoundText";
            this.lblPluginsNotFoundText.Size = new System.Drawing.Size(1036, 80);
            this.lblPluginsNotFoundText.TabIndex = 0;
            this.lblPluginsNotFoundText.Tag = "Searching for \"{0}\" did not match any plugins installed";
            this.lblPluginsNotFoundText.Text = "Searching for \"{0}\" did not match any plugins installed";
            this.lblPluginsNotFoundText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PluginsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 761);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.pnlNoPluginFound);
            this.Controls.Add(this.pnlHelp);
            this.Controls.Add(this.pnlPlugins);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PluginsForm";
            this.Text = "Plugins";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PluginsForm_FormClosing);
            this.Load += new System.EventHandler(this.PluginsForm_Load);
            this.cmsOnePlugin.ResumeLayout(false);
            this.pnlHelp.ResumeLayout(false);
            this.pnlNoPluginFound.ResumeLayout(false);
            this.pnlNoPluginFound.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenPluginsStore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlPlugins;
        private System.Windows.Forms.ContextMenuStrip cmsOnePlugin;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenProjectHomePage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem tsmiShortcutTool;
        private System.Windows.Forms.ToolStripMenuItem tsmiShortcutToolConnection;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem tsmiHidePlugin;
        private System.Windows.Forms.ToolStripMenuItem tsmiUninstallPlugin;
        private System.Windows.Forms.Panel pnlHelp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlNoPluginFound;
        private System.Windows.Forms.LinkLabel llResetSearchFilter;
        private System.Windows.Forms.PictureBox pbOpenPluginsStore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPluginsNotFoundText;
    }
}