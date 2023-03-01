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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StepColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bullsCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cowsCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StepColumn,
            this.numberColumn,
            this.bullsCountColumn,
            this.cowsCountColumn});
            this.dataGridView1.Location = new System.Drawing.Point(322, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 450);
            this.dataGridView1.TabIndex = 5;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cowsCountLabel);
            this.Controls.Add(this.bullsCountLabel);
            this.Controls.Add(this.userNumberTextBox);
            this.Controls.Add(this.hiddenNumberLabel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hiddenNumberLabel;
        private System.Windows.Forms.TextBox userNumberTextBox;
        private System.Windows.Forms.Label bullsCountLabel;
        private System.Windows.Forms.Label cowsCountLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StepColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bullsCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cowsCountColumn;
    }
}

