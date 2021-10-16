
namespace BlankFilesRemover
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pathLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pathBox
            // 
            this.pathBox.AllowDrop = true;
            this.pathBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pathBox.Location = new System.Drawing.Point(3, 26);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(375, 27);
            this.pathBox.TabIndex = 0;
            this.pathBox.Text = "(double click me)";
            this.pathBox.TextChanged += new System.EventHandler(this.pathBox_TextChanged);
            this.pathBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.pathBox_DragDrop);
            this.pathBox.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.pathBox_GiveFeedback);
            this.pathBox.DoubleClick += new System.EventHandler(this.pathBox_DoubleClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pathLabel);
            this.flowLayoutPanel1.Controls.Add(this.pathBox);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(163, 113);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(378, 125);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pathLabel
            // 
            this.pathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pathLabel.Location = new System.Drawing.Point(3, 0);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(375, 23);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "Path:";
            this.pathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(3, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(375, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Remove Empty Files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "BlankFileRemover";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button button1;
    }
}

