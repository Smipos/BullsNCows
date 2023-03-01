namespace BullsNCowsWindowsFormsApp
{
    partial class MainForm
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
            this.hiddenNumberLabel = new System.Windows.Forms.Label();
            this.userNumberTextBox = new System.Windows.Forms.TextBox();
            this.bullsCountLabel = new System.Windows.Forms.Label();
            this.cowsCountLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.mainHistoryTable = new System.Windows.Forms.DataGridView();
            this.StepColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bullsCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cowsCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainHistoryTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hiddenNumberLabel
            // 
            this.hiddenNumberLabel.AutoSize = true;
            this.hiddenNumberLabel.Font = new System.Drawing.Font("Lucida Console", 15.75F);
            this.hiddenNumberLabel.Location = new System.Drawing.Point(51, 32);
            this.hiddenNumberLabel.Name = "hiddenNumberLabel";
            this.hiddenNumberLabel.Size = new System.Drawing.Size(88, 21);
            this.hiddenNumberLabel.TabIndex = 0;
            this.hiddenNumberLabel.Text = "label1";
            // 
            // userNumberTextBox
            // 
            this.userNumberTextBox.Location = new System.Drawing.Point(54, 102);
            this.userNumberTextBox.Name = "userNumberTextBox";
            this.userNumberTextBox.Size = new System.Drawing.Size(109, 20);
            this.userNumberTextBox.TabIndex = 1;
            // 
            // bullsCountLabel
            // 
            this.bullsCountLabel.AutoSize = true;
            this.bullsCountLabel.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bullsCountLabel.Location = new System.Drawing.Point(50, 142);
            this.bullsCountLabel.Name = "bullsCountLabel";
            this.bullsCountLabel.Size = new System.Drawing.Size(127, 21);
            this.bullsCountLabel.TabIndex = 2;
            this.bullsCountLabel.Text = "Быков = 0";
            // 
            // cowsCountLabel
            // 
            this.cowsCountLabel.AutoSize = true;
            this.cowsCountLabel.Font = new System.Drawing.Font("Lucida Console", 15.75F);
            this.cowsCountLabel.Location = new System.Drawing.Point(50, 177);
            this.cowsCountLabel.Name = "cowsCountLabel";
            this.cowsCountLabel.Size = new System.Drawing.Size(127, 21);
            this.cowsCountLabel.TabIndex = 3;
            this.cowsCountLabel.Text = "Коров = 0";
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Lucida Console", 15.75F);
            this.confirmButton.Location = new System.Drawing.Point(182, 102);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 35);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "OK";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // mainHistoryTable
            // 
            this.mainHistoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainHistoryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StepColumn,
            this.numberColumn,
            this.bullsCountColumn,
            this.cowsCountColumn});
            this.mainHistoryTable.Location = new System.Drawing.Point(322, 1);
            this.mainHistoryTable.Name = "mainHistoryTable";
            this.mainHistoryTable.Size = new System.Drawing.Size(444, 450);
            this.mainHistoryTable.TabIndex = 5;
            // 
            // StepColumn
            // 
            this.StepColumn.HeaderText = "Ход";
            this.StepColumn.Name = "StepColumn";
            // 
            // numberColumn
            // 
            this.numberColumn.HeaderText = "Число";
            this.numberColumn.Name = "numberColumn";
            // 
            // bullsCountColumn
            // 
            this.bullsCountColumn.HeaderText = "Быков";
            this.bullsCountColumn.Name = "bullsCountColumn";
            // 
            // cowsCountColumn
            // 
            this.cowsCountColumn.HeaderText = "Коров";
            this.cowsCountColumn.Name = "cowsCountColumn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // restartGameToolStripMenuItem
            // 
            this.restartGameToolStripMenuItem.Name = "restartGameToolStripMenuItem";
            this.restartGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restartGameToolStripMenuItem.Text = "Restart Game";
            this.restartGameToolStripMenuItem.Click += new System.EventHandler(this.restartGameToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.mainHistoryTable);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cowsCountLabel);
            this.Controls.Add(this.bullsCountLabel);
            this.Controls.Add(this.userNumberTextBox);
            this.Controls.Add(this.hiddenNumberLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainHistoryTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hiddenNumberLabel;
        private System.Windows.Forms.TextBox userNumberTextBox;
        private System.Windows.Forms.Label bullsCountLabel;
        private System.Windows.Forms.Label cowsCountLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.DataGridView mainHistoryTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn StepColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bullsCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cowsCountColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartGameToolStripMenuItem;
    }
}

