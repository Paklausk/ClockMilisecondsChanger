namespace TimeChanger
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.resetButton = new System.Windows.Forms.Button();
            this.BigForwardButton = new System.Windows.Forms.Button();
            this.smallForwardButton = new System.Windows.Forms.Button();
            this.smallBackButton = new System.Windows.Forms.Button();
            this.bigBackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timeDifLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.resetButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BigForwardButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.smallForwardButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.smallBackButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.bigBackButton, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 62);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // resetButton
            // 
            this.resetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.resetButton.Location = new System.Drawing.Point(323, 3);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(154, 56);
            this.resetButton.TabIndex = 0;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // BigForwardButton
            // 
            this.BigForwardButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BigForwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BigForwardButton.Location = new System.Drawing.Point(3, 3);
            this.BigForwardButton.Name = "BigForwardButton";
            this.BigForwardButton.Size = new System.Drawing.Size(154, 56);
            this.BigForwardButton.TabIndex = 1;
            this.BigForwardButton.Text = "+ 100ms";
            this.BigForwardButton.UseVisualStyleBackColor = true;
            this.BigForwardButton.Click += new System.EventHandler(this.BigForwardButton_Click);
            // 
            // smallForwardButton
            // 
            this.smallForwardButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.smallForwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.smallForwardButton.Location = new System.Drawing.Point(163, 3);
            this.smallForwardButton.Name = "smallForwardButton";
            this.smallForwardButton.Size = new System.Drawing.Size(154, 56);
            this.smallForwardButton.TabIndex = 2;
            this.smallForwardButton.Text = "+ 10ms";
            this.smallForwardButton.UseVisualStyleBackColor = true;
            this.smallForwardButton.Click += new System.EventHandler(this.smallForwardButton_Click);
            // 
            // smallBackButton
            // 
            this.smallBackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.smallBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.smallBackButton.Location = new System.Drawing.Point(483, 3);
            this.smallBackButton.Name = "smallBackButton";
            this.smallBackButton.Size = new System.Drawing.Size(154, 56);
            this.smallBackButton.TabIndex = 3;
            this.smallBackButton.Text = "- 10ms";
            this.smallBackButton.UseVisualStyleBackColor = true;
            this.smallBackButton.Click += new System.EventHandler(this.smallBackButton_Click);
            // 
            // bigBackButton
            // 
            this.bigBackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bigBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bigBackButton.Location = new System.Drawing.Point(643, 3);
            this.bigBackButton.Name = "bigBackButton";
            this.bigBackButton.Size = new System.Drawing.Size(154, 56);
            this.bigBackButton.TabIndex = 4;
            this.bigBackButton.Text = "- 100ms";
            this.bigBackButton.UseVisualStyleBackColor = true;
            this.bigBackButton.Click += new System.EventHandler(this.bigBackButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(255, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Set time difference:";
            // 
            // timeDifLabel
            // 
            this.timeDifLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timeDifLabel.AutoSize = true;
            this.timeDifLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.timeDifLabel.Location = new System.Drawing.Point(416, 13);
            this.timeDifLabel.Name = "timeDifLabel";
            this.timeDifLabel.Size = new System.Drawing.Size(18, 20);
            this.timeDifLabel.TabIndex = 2;
            this.timeDifLabel.Text = "0";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 98);
            this.Controls.Add(this.timeDifLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows time changer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeDifLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button BigForwardButton;
        private System.Windows.Forms.Button smallForwardButton;
        private System.Windows.Forms.Button smallBackButton;
        private System.Windows.Forms.Button bigBackButton;
    }
}

