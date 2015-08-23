namespace SplitPPt
{
    partial class SplitPpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplitPpt));
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.Button_Choose = new System.Windows.Forms.Button();
            this.Button_Split = new System.Windows.Forms.Button();
            this.ChooseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.Filter = "Power Point Files (*.ppt;*.pptx)|*.ppt;*.pptx";
            this.OpenFile.Multiselect = true;
            this.OpenFile.Title = "Choose the Ppt/Pptx to open";
            // 
            // Button_Choose
            // 
            this.Button_Choose.Location = new System.Drawing.Point(13, 13);
            this.Button_Choose.Name = "Button_Choose";
            this.Button_Choose.Size = new System.Drawing.Size(87, 23);
            this.Button_Choose.TabIndex = 0;
            this.Button_Choose.Text = "Choose File";
            this.Button_Choose.UseVisualStyleBackColor = true;
            this.Button_Choose.Click += new System.EventHandler(this.Button_Choose_Click);
            // 
            // Button_Split
            // 
            this.Button_Split.Location = new System.Drawing.Point(108, 12);
            this.Button_Split.Name = "Button_Split";
            this.Button_Split.Size = new System.Drawing.Size(87, 23);
            this.Button_Split.TabIndex = 1;
            this.Button_Split.Text = "Split Slides";
            this.Button_Split.UseVisualStyleBackColor = true;
            this.Button_Split.Click += new System.EventHandler(this.Button_Split_Click);
            // 
            // ChooseFolder
            // 
            this.ChooseFolder.Description = "Choose Folder for Split Slides";
            // 
            // SplitPpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 48);
            this.Controls.Add(this.Button_Split);
            this.Controls.Add(this.Button_Choose);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplitPpt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Split PPT\'s";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Button Button_Choose;
        private System.Windows.Forms.Button Button_Split;
        private System.Windows.Forms.FolderBrowserDialog ChooseFolder;
    }
}

