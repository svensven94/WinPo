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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.tableButtonsLower = new System.Windows.Forms.TableLayoutPanel();
            this.appPanel1 = new WinPo.AppPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitBackground)).BeginInit();
            this.splitBackground.Panel1.SuspendLayout();
            this.splitBackground.Panel2.SuspendLayout();
            this.splitBackground.SuspendLayout();
            this.tableUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitButtons)).BeginInit();
            this.splitButtons.Panel1.SuspendLayout();
            this.splitButtons.Panel2.SuspendLayout();
            this.splitButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.splitBackground.Size = new System.Drawing.Size(956, 428);
            this.splitBackground.SplitterDistance = 306;
            this.splitBackground.TabIndex = 0;
            // 
            // tableUpper
            // 
            this.tableUpper.ColumnCount = 1;
            this.tableUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.13807F));
            this.tableUpper.Controls.Add(this.appPanel1, 0, 0);
            this.tableUpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableUpper.Location = new System.Drawing.Point(0, 0);
            this.tableUpper.Name = "tableUpper";
            this.tableUpper.RowCount = 1;
            this.tableUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.25629F));
            this.tableUpper.Size = new System.Drawing.Size(956, 306);
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
            this.splitButtons.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitButtons.Panel2
            // 
            this.splitButtons.Panel2.Controls.Add(this.tableButtonsLower);
            this.splitButtons.Size = new System.Drawing.Size(956, 118);
            this.splitButtons.SplitterDistance = 69;
            this.splitButtons.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonAdd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonRemove, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(956, 69);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(233, 63);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemove.Location = new System.Drawing.Point(242, 3);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(233, 63);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "-";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // tableButtonsLower
            // 
            this.tableButtonsLower.ColumnCount = 3;
            this.tableButtonsLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableButtonsLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableButtonsLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableButtonsLower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableButtonsLower.Location = new System.Drawing.Point(0, 0);
            this.tableButtonsLower.Name = "tableButtonsLower";
            this.tableButtonsLower.RowCount = 1;
            this.tableButtonsLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButtonsLower.Size = new System.Drawing.Size(956, 45);
            this.tableButtonsLower.TabIndex = 0;
            // 
            // appPanel1
            // 
            this.appPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.appPanel1.Location = new System.Drawing.Point(3, 3);
            this.appPanel1.Name = "appPanel1";
            this.appPanel1.Size = new System.Drawing.Size(950, 100);
            this.appPanel1.TabIndex = 0;
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 428);
            this.Controls.Add(this.splitBackground);
            this.Name = "Configuration";
            this.Text = "WinPo";
            this.Load += new System.EventHandler(this.Configuration_Load);
            this.splitBackground.Panel1.ResumeLayout(false);
            this.splitBackground.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitBackground)).EndInit();
            this.splitBackground.ResumeLayout(false);
            this.tableUpper.ResumeLayout(false);
            this.splitButtons.Panel1.ResumeLayout(false);
            this.splitButtons.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitButtons)).EndInit();
            this.splitButtons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitBackground;
        private System.Windows.Forms.TableLayoutPanel tableUpper;
        private System.Windows.Forms.SplitContainer splitButtons;
        private AppPanel appPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableButtonsLower;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
    }
}

