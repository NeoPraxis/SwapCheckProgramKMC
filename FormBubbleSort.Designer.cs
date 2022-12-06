namespace SwapCheckProgramKMC
{
    partial class FormBubbleSort
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
            this.listBoxPreSort = new System.Windows.Forms.ListBox();
            this.listBoxPostSort = new System.Windows.Forms.ListBox();
            this.labelPreSort = new System.Windows.Forms.Label();
            this.labelPostSort = new System.Windows.Forms.Label();
            this.buttonExecuteSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPreSort
            // 
            this.listBoxPreSort.FormattingEnabled = true;
            this.listBoxPreSort.ItemHeight = 25;
            this.listBoxPreSort.Location = new System.Drawing.Point(12, 102);
            this.listBoxPreSort.Name = "listBoxPreSort";
            this.listBoxPreSort.Size = new System.Drawing.Size(215, 329);
            this.listBoxPreSort.TabIndex = 0;
            // 
            // listBoxPostSort
            // 
            this.listBoxPostSort.FormattingEnabled = true;
            this.listBoxPostSort.ItemHeight = 25;
            this.listBoxPostSort.Location = new System.Drawing.Point(233, 102);
            this.listBoxPostSort.Name = "listBoxPostSort";
            this.listBoxPostSort.Size = new System.Drawing.Size(215, 329);
            this.listBoxPostSort.TabIndex = 1;
            // 
            // labelPreSort
            // 
            this.labelPreSort.AutoSize = true;
            this.labelPreSort.Location = new System.Drawing.Point(13, 71);
            this.labelPreSort.Name = "labelPreSort";
            this.labelPreSort.Size = new System.Drawing.Size(91, 25);
            this.labelPreSort.TabIndex = 2;
            this.labelPreSort.Text = "Pre-Sort";
            // 
            // labelPostSort
            // 
            this.labelPostSort.AutoSize = true;
            this.labelPostSort.Location = new System.Drawing.Point(228, 71);
            this.labelPostSort.Name = "labelPostSort";
            this.labelPostSort.Size = new System.Drawing.Size(101, 25);
            this.labelPostSort.TabIndex = 3;
            this.labelPostSort.Text = "Post-Sort";
            // 
            // buttonExecuteSort
            // 
            this.buttonExecuteSort.Location = new System.Drawing.Point(466, 102);
            this.buttonExecuteSort.Name = "buttonExecuteSort";
            this.buttonExecuteSort.Size = new System.Drawing.Size(146, 67);
            this.buttonExecuteSort.TabIndex = 4;
            this.buttonExecuteSort.Text = "Execute Sort";
            this.buttonExecuteSort.UseVisualStyleBackColor = true;
            this.buttonExecuteSort.Click += new System.EventHandler(this.buttonExecuteSort_Click);
            // 
            // FormBubbleSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 451);
            this.Controls.Add(this.buttonExecuteSort);
            this.Controls.Add(this.labelPostSort);
            this.Controls.Add(this.labelPreSort);
            this.Controls.Add(this.listBoxPostSort);
            this.Controls.Add(this.listBoxPreSort);
            this.Name = "FormBubbleSort";
            this.Text = "Bubble Sort w/ Pass Counter";
            //this.Load += new System.EventHandler(this.FormBubbleSort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPreSort;
        private System.Windows.Forms.ListBox listBoxPostSort;
        private System.Windows.Forms.Label labelPreSort;
        private System.Windows.Forms.Label labelPostSort;
        private System.Windows.Forms.Button buttonExecuteSort;
    }
}

