namespace WinPo
{
    partial class AppPanel
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupApp = new System.Windows.Forms.GroupBox();
            this.comboApp = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableResAndPos = new System.Windows.Forms.TableLayoutPanel();
            this.groupPosTop = new System.Windows.Forms.GroupBox();
            this.textPosTop = new System.Windows.Forms.TextBox();
            this.groupPosLeft = new System.Windows.Forms.GroupBox();
            this.textPosLeft = new System.Windows.Forms.TextBox();
            this.groupPosBottom = new System.Windows.Forms.GroupBox();
            this.textPosBottom = new System.Windows.Forms.TextBox();
            this.groupPosRight = new System.Windows.Forms.GroupBox();
            this.textPosRight = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSet = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupApp.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableResAndPos.SuspendLayout();
            this.groupPosTop.SuspendLayout();
            this.groupPosLeft.SuspendLayout();
            this.groupPosBottom.SuspendLayout();
            this.groupPosRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupApp);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(600, 100);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupApp
            // 
            this.groupApp.Controls.Add(this.comboApp);
            this.groupApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupApp.Location = new System.Drawing.Point(0, 0);
            this.groupApp.Name = "groupApp";
            this.groupApp.Size = new System.Drawing.Size(200, 100);
            this.groupApp.TabIndex = 3;
            this.groupApp.TabStop = false;
            this.groupApp.Text = "Application";
            // 
            // comboApp
            // 
            this.comboApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboApp.FormattingEnabled = true;
            this.comboApp.Location = new System.Drawing.Point(3, 16);
            this.comboApp.Name = "comboApp";
            this.comboApp.Size = new System.Drawing.Size(194, 21);
            this.comboApp.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableResAndPos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(396, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableResAndPos
            // 
            this.tableResAndPos.ColumnCount = 2;
            this.tableResAndPos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableResAndPos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableResAndPos.Controls.Add(this.groupPosTop, 0, 0);
            this.tableResAndPos.Controls.Add(this.groupPosLeft, 1, 0);
            this.tableResAndPos.Controls.Add(this.groupPosBottom, 0, 1);
            this.tableResAndPos.Controls.Add(this.groupPosRight, 1, 1);
            this.tableResAndPos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableResAndPos.Location = new System.Drawing.Point(3, 3);
            this.tableResAndPos.Name = "tableResAndPos";
            this.tableResAndPos.RowCount = 2;
            this.tableResAndPos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableResAndPos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableResAndPos.Size = new System.Drawing.Size(234, 94);
            this.tableResAndPos.TabIndex = 1;
            // 
            // groupPosTop
            // 
            this.groupPosTop.Controls.Add(this.textPosTop);
            this.groupPosTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPosTop.Location = new System.Drawing.Point(3, 3);
            this.groupPosTop.Name = "groupPosTop";
            this.groupPosTop.Size = new System.Drawing.Size(111, 41);
            this.groupPosTop.TabIndex = 0;
            this.groupPosTop.TabStop = false;
            this.groupPosTop.Text = "Position: Vertical";
            // 
            // textPosTop
            // 
            this.textPosTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPosTop.Location = new System.Drawing.Point(3, 16);
            this.textPosTop.Name = "textPosTop";
            this.textPosTop.Size = new System.Drawing.Size(105, 20);
            this.textPosTop.TabIndex = 0;
            // 
            // groupPosLeft
            // 
            this.groupPosLeft.Controls.Add(this.textPosLeft);
            this.groupPosLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPosLeft.Location = new System.Drawing.Point(120, 3);
            this.groupPosLeft.Name = "groupPosLeft";
            this.groupPosLeft.Size = new System.Drawing.Size(111, 41);
            this.groupPosLeft.TabIndex = 1;
            this.groupPosLeft.TabStop = false;
            this.groupPosLeft.Text = "Position: Horizontal";
            // 
            // textPosLeft
            // 
            this.textPosLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPosLeft.Location = new System.Drawing.Point(3, 16);
            this.textPosLeft.Name = "textPosLeft";
            this.textPosLeft.Size = new System.Drawing.Size(105, 20);
            this.textPosLeft.TabIndex = 0;
            // 
            // groupPosBottom
            // 
            this.groupPosBottom.Controls.Add(this.textPosBottom);
            this.groupPosBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPosBottom.Location = new System.Drawing.Point(3, 50);
            this.groupPosBottom.Name = "groupPosBottom";
            this.groupPosBottom.Size = new System.Drawing.Size(111, 41);
            this.groupPosBottom.TabIndex = 2;
            this.groupPosBottom.TabStop = false;
            this.groupPosBottom.Text = "Position: Bottom";
            // 
            // textPosBottom
            // 
            this.textPosBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPosBottom.Enabled = false;
            this.textPosBottom.Location = new System.Drawing.Point(3, 16);
            this.textPosBottom.Name = "textPosBottom";
            this.textPosBottom.Size = new System.Drawing.Size(105, 20);
            this.textPosBottom.TabIndex = 0;
            // 
            // groupPosRight
            // 
            this.groupPosRight.Controls.Add(this.textPosRight);
            this.groupPosRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPosRight.Location = new System.Drawing.Point(120, 50);
            this.groupPosRight.Name = "groupPosRight";
            this.groupPosRight.Size = new System.Drawing.Size(111, 41);
            this.groupPosRight.TabIndex = 3;
            this.groupPosRight.TabStop = false;
            this.groupPosRight.Text = "Position: Right";
            // 
            // textPosRight
            // 
            this.textPosRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPosRight.Enabled = false;
            this.textPosRight.Location = new System.Drawing.Point(3, 16);
            this.textPosRight.Name = "textPosRight";
            this.textPosRight.Size = new System.Drawing.Size(105, 20);
            this.textPosRight.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(243, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonLoad);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.buttonSet);
            this.splitContainer2.Size = new System.Drawing.Size(150, 94);
            this.splitContainer2.SplitterDistance = 74;
            this.splitContainer2.TabIndex = 2;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLoad.Location = new System.Drawing.Point(0, 0);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(74, 94);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSet
            // 
            this.buttonSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSet.Location = new System.Drawing.Point(0, 0);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(72, 94);
            this.buttonSet.TabIndex = 0;
            this.buttonSet.Text = "Set";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // AppPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "AppPanel";
            this.Size = new System.Drawing.Size(600, 100);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupApp.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableResAndPos.ResumeLayout(false);
            this.groupPosTop.ResumeLayout(false);
            this.groupPosTop.PerformLayout();
            this.groupPosLeft.ResumeLayout(false);
            this.groupPosLeft.PerformLayout();
            this.groupPosBottom.ResumeLayout(false);
            this.groupPosBottom.PerformLayout();
            this.groupPosRight.ResumeLayout(false);
            this.groupPosRight.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableResAndPos;
        private System.Windows.Forms.GroupBox groupPosTop;
        private System.Windows.Forms.TextBox textPosTop;
        private System.Windows.Forms.GroupBox groupPosLeft;
        private System.Windows.Forms.TextBox textPosLeft;
        private System.Windows.Forms.GroupBox groupPosBottom;
        private System.Windows.Forms.TextBox textPosBottom;
        private System.Windows.Forms.GroupBox groupPosRight;
        private System.Windows.Forms.TextBox textPosRight;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.GroupBox groupApp;
        private System.Windows.Forms.ComboBox comboApp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
