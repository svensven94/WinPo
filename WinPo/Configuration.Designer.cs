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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.buttonLoad = new System.Windows.Forms.Button();
            this.groupApp = new System.Windows.Forms.GroupBox();
            this.comboApp = new System.Windows.Forms.ComboBox();
            this.tableLower = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitBackground)).BeginInit();
            this.splitBackground.Panel1.SuspendLayout();
            this.splitBackground.Panel2.SuspendLayout();
            this.splitBackground.SuspendLayout();
            this.tableUpper.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableResAndPos.SuspendLayout();
            this.groupPosTop.SuspendLayout();
            this.groupPosLeft.SuspendLayout();
            this.groupPosBottom.SuspendLayout();
            this.groupPosRight.SuspendLayout();
            this.groupApp.SuspendLayout();
            this.tableLower.SuspendLayout();
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
            this.splitBackground.Panel2.Controls.Add(this.tableLower);
            this.splitBackground.Size = new System.Drawing.Size(956, 611);
            this.splitBackground.SplitterDistance = 437;
            this.splitBackground.TabIndex = 0;
            // 
            // tableUpper
            // 
            this.tableUpper.ColumnCount = 2;
            this.tableUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.13807F));
            this.tableUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.86192F));
            this.tableUpper.Controls.Add(this.comboBox1, 0, 1);
            this.tableUpper.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableUpper.Controls.Add(this.groupApp, 0, 0);
            this.tableUpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableUpper.Location = new System.Drawing.Point(0, 0);
            this.tableUpper.Name = "tableUpper";
            this.tableUpper.RowCount = 2;
            this.tableUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.25629F));
            this.tableUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.74371F));
            this.tableUpper.Size = new System.Drawing.Size(956, 437);
            this.tableUpper.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 362F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableResAndPos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonLoad, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(271, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(682, 99);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.tableResAndPos.Size = new System.Drawing.Size(314, 93);
            this.tableResAndPos.TabIndex = 1;
            // 
            // groupPosTop
            // 
            this.groupPosTop.Controls.Add(this.textPosTop);
            this.groupPosTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPosTop.Location = new System.Drawing.Point(3, 3);
            this.groupPosTop.Name = "groupPosTop";
            this.groupPosTop.Size = new System.Drawing.Size(151, 40);
            this.groupPosTop.TabIndex = 0;
            this.groupPosTop.TabStop = false;
            this.groupPosTop.Text = "Position: Top";
            // 
            // textPosTop
            // 
            this.textPosTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPosTop.Location = new System.Drawing.Point(3, 16);
            this.textPosTop.Name = "textPosTop";
            this.textPosTop.Size = new System.Drawing.Size(145, 20);
            this.textPosTop.TabIndex = 0;
            // 
            // groupPosLeft
            // 
            this.groupPosLeft.Controls.Add(this.textPosLeft);
            this.groupPosLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPosLeft.Location = new System.Drawing.Point(160, 3);
            this.groupPosLeft.Name = "groupPosLeft";
            this.groupPosLeft.Size = new System.Drawing.Size(151, 40);
            this.groupPosLeft.TabIndex = 1;
            this.groupPosLeft.TabStop = false;
            this.groupPosLeft.Text = "Position: Left";
            // 
            // textPosLeft
            // 
            this.textPosLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPosLeft.Location = new System.Drawing.Point(3, 16);
            this.textPosLeft.Name = "textPosLeft";
            this.textPosLeft.Size = new System.Drawing.Size(145, 20);
            this.textPosLeft.TabIndex = 0;
            // 
            // groupPosBottom
            // 
            this.groupPosBottom.Controls.Add(this.textPosBottom);
            this.groupPosBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPosBottom.Location = new System.Drawing.Point(3, 49);
            this.groupPosBottom.Name = "groupPosBottom";
            this.groupPosBottom.Size = new System.Drawing.Size(151, 41);
            this.groupPosBottom.TabIndex = 2;
            this.groupPosBottom.TabStop = false;
            this.groupPosBottom.Text = "Position: Bottom";
            // 
            // textPosBottom
            // 
            this.textPosBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPosBottom.Location = new System.Drawing.Point(3, 16);
            this.textPosBottom.Name = "textPosBottom";
            this.textPosBottom.Size = new System.Drawing.Size(145, 20);
            this.textPosBottom.TabIndex = 0;
            // 
            // groupPosRight
            // 
            this.groupPosRight.Controls.Add(this.textPosRight);
            this.groupPosRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPosRight.Location = new System.Drawing.Point(160, 49);
            this.groupPosRight.Name = "groupPosRight";
            this.groupPosRight.Size = new System.Drawing.Size(151, 41);
            this.groupPosRight.TabIndex = 3;
            this.groupPosRight.TabStop = false;
            this.groupPosRight.Text = "Position: Right";
            // 
            // textPosRight
            // 
            this.textPosRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPosRight.Location = new System.Drawing.Point(3, 16);
            this.textPosRight.Name = "textPosRight";
            this.textPosRight.Size = new System.Drawing.Size(145, 20);
            this.textPosRight.TabIndex = 0;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLoad.Location = new System.Drawing.Point(323, 3);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(356, 93);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "button3";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // groupApp
            // 
            this.groupApp.Controls.Add(this.comboApp);
            this.groupApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupApp.Location = new System.Drawing.Point(3, 3);
            this.groupApp.Name = "groupApp";
            this.groupApp.Size = new System.Drawing.Size(262, 99);
            this.groupApp.TabIndex = 2;
            this.groupApp.TabStop = false;
            this.groupApp.Text = "Application";
            // 
            // comboApp
            // 
            this.comboApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboApp.FormattingEnabled = true;
            this.comboApp.Location = new System.Drawing.Point(3, 16);
            this.comboApp.Name = "comboApp";
            this.comboApp.Size = new System.Drawing.Size(256, 21);
            this.comboApp.TabIndex = 0;
            // 
            // tableLower
            // 
            this.tableLower.ColumnCount = 2;
            this.tableLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLower.Controls.Add(this.button1, 0, 0);
            this.tableLower.Controls.Add(this.button2, 1, 0);
            this.tableLower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLower.Location = new System.Drawing.Point(0, 0);
            this.tableLower.Name = "tableLower";
            this.tableLower.RowCount = 1;
            this.tableLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLower.Size = new System.Drawing.Size(956, 170);
            this.tableLower.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(472, 164);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(481, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(472, 164);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 611);
            this.Controls.Add(this.splitBackground);
            this.Name = "Configuration";
            this.Text = "WinPo";
            this.Load += new System.EventHandler(this.Configuration_Load);
            this.splitBackground.Panel1.ResumeLayout(false);
            this.splitBackground.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitBackground)).EndInit();
            this.splitBackground.ResumeLayout(false);
            this.tableUpper.ResumeLayout(false);
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
            this.groupApp.ResumeLayout(false);
            this.tableLower.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitBackground;
        private System.Windows.Forms.TableLayoutPanel tableUpper;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLower;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableResAndPos;
        private System.Windows.Forms.GroupBox groupPosTop;
        private System.Windows.Forms.GroupBox groupPosLeft;
        private System.Windows.Forms.GroupBox groupPosBottom;
        private System.Windows.Forms.GroupBox groupPosRight;
        private System.Windows.Forms.TextBox textPosTop;
        private System.Windows.Forms.TextBox textPosLeft;
        private System.Windows.Forms.TextBox textPosBottom;
        private System.Windows.Forms.TextBox textPosRight;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.GroupBox groupApp;
        private System.Windows.Forms.ComboBox comboApp;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

