namespace WinPo
{
    partial class Configuration
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitBackground = new System.Windows.Forms.SplitContainer();
            this.tableUpper = new System.Windows.Forms.TableLayoutPanel();
            this.splitButtons = new System.Windows.Forms.SplitContainer();
            this.tableBottom = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSetAll = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonImportAll = new System.Windows.Forms.Button();
            this.tableButtonsLower = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitBackground)).BeginInit();
            this.splitBackground.Panel1.SuspendLayout();
            this.splitBackground.Panel2.SuspendLayout();
            this.splitBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitButtons)).BeginInit();
            this.splitButtons.Panel1.SuspendLayout();
            this.splitButtons.Panel2.SuspendLayout();
            this.splitButtons.SuspendLayout();
            this.tableBottom.SuspendLayout();
            this.tableButtonsLower.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitBackground
            // 
            this.splitBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitBackground.Location = new System.Drawing.Point(0, 0);
            this.splitBackground.Name = "splitBackground";
            this.splitBackground.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitBackground.Panel1
            // 
            this.splitBackground.Panel1.Controls.Add(this.tableUpper);
            // 
            // splitBackground.Panel2
            // 
            this.splitBackground.Panel2.Controls.Add(this.splitButtons);
            this.splitBackground.Size = new System.Drawing.Size(609, 421);
            this.splitBackground.SplitterDistance = 320;
            this.splitBackground.TabIndex = 0;
            // 
            // tableUpper
            // 
            this.tableUpper.AutoScroll = true;
            this.tableUpper.ColumnCount = 1;
            this.tableUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.13807F));
            this.tableUpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableUpper.Location = new System.Drawing.Point(0, 0);
            this.tableUpper.Name = "tableUpper";
            this.tableUpper.RowCount = 1;
            this.tableUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.25629F));
            this.tableUpper.Size = new System.Drawing.Size(609, 320);
            this.tableUpper.TabIndex = 1;
            // 
            // splitButtons
            // 
            this.splitButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitButtons.Location = new System.Drawing.Point(0, 0);
            this.splitButtons.Name = "splitButtons";
            this.splitButtons.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitButtons.Panel1
            // 
            this.splitButtons.Panel1.Controls.Add(this.tableBottom);
            // 
            // splitButtons.Panel2
            // 
            this.splitButtons.Panel2.Controls.Add(this.tableButtonsLower);
            this.splitButtons.Size = new System.Drawing.Size(609, 97);
            this.splitButtons.SplitterDistance = 46;
            this.splitButtons.TabIndex = 0;
            // 
            // tableBottom
            // 
            this.tableBottom.ColumnCount = 4;
            this.tableBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableBottom.Controls.Add(this.buttonSetAll, 3, 0);
            this.tableBottom.Controls.Add(this.buttonAdd, 0, 0);
            this.tableBottom.Controls.Add(this.buttonRemove, 1, 0);
            this.tableBottom.Controls.Add(this.buttonImportAll, 2, 0);
            this.tableBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBottom.Location = new System.Drawing.Point(0, 0);
            this.tableBottom.Name = "tableBottom";
            this.tableBottom.RowCount = 1;
            this.tableBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableBottom.Size = new System.Drawing.Size(609, 46);
            this.tableBottom.TabIndex = 0;
            // 
            // buttonSetAll
            // 
            this.buttonSetAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSetAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSetAll.Location = new System.Drawing.Point(675, 3);
            this.buttonSetAll.Name = "buttonSetAll";
            this.buttonSetAll.Size = new System.Drawing.Size(278, 50);
            this.buttonSetAll.TabIndex = 3;
            this.buttonSetAll.Text = "Set All";
            this.buttonSetAll.UseVisualStyleBackColor = true;
            this.buttonSetAll.Click += new System.EventHandler(this.buttonSetAll_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(162, 50);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemove.Location = new System.Drawing.Point(171, 3);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(162, 50);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "-";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonImportAll
            // 
            this.buttonImportAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonImportAll.Location = new System.Drawing.Point(339, 3);
            this.buttonImportAll.Name = "buttonImportAll";
            this.buttonImportAll.Size = new System.Drawing.Size(330, 50);
            this.buttonImportAll.TabIndex = 2;
            this.buttonImportAll.Text = "Import All";
            this.buttonImportAll.UseVisualStyleBackColor = true;
            this.buttonImportAll.Click += new System.EventHandler(this.buttonImportAll_Click);
            // 
            // tableButtonsLower
            // 
            this.tableButtonsLower.ColumnCount = 2;
            this.tableButtonsLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableButtonsLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableButtonsLower.Controls.Add(this.buttonSave, 1, 0);
            this.tableButtonsLower.Controls.Add(this.buttonLoad, 0, 0);
            this.tableButtonsLower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableButtonsLower.Location = new System.Drawing.Point(0, 0);
            this.tableButtonsLower.Name = "tableButtonsLower";
            this.tableButtonsLower.RowCount = 1;
            this.tableButtonsLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButtonsLower.Size = new System.Drawing.Size(609, 47);
            this.tableButtonsLower.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.Location = new System.Drawing.Point(307, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(299, 41);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLoad.Location = new System.Drawing.Point(3, 3);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(298, 41);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load Configuration";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 421);
            this.Controls.Add(this.splitBackground);
            this.MinimumSize = new System.Drawing.Size(625, 300);
            this.Name = "Configuration";
            this.Text = "WinPo";
            this.Load += new System.EventHandler(this.Configuration_Load);
            this.splitBackground.Panel1.ResumeLayout(false);
            this.splitBackground.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitBackground)).EndInit();
            this.splitBackground.ResumeLayout(false);
            this.splitButtons.Panel1.ResumeLayout(false);
            this.splitButtons.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitButtons)).EndInit();
            this.splitButtons.ResumeLayout(false);
            this.tableBottom.ResumeLayout(false);
            this.tableButtonsLower.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitBackground;
        private System.Windows.Forms.TableLayoutPanel tableUpper;
        private System.Windows.Forms.SplitContainer splitButtons;
        private System.Windows.Forms.TableLayoutPanel tableBottom;
        private System.Windows.Forms.TableLayoutPanel tableButtonsLower;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSetAll;
        private System.Windows.Forms.Button buttonImportAll;
    }
}

