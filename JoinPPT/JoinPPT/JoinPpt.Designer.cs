namespace JoinPPT
{
    partial class JoinPpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinPpt));
            this.Text_InputFiles = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Button_New = new System.Windows.Forms.ToolStripButton();
            this.Button_Add = new System.Windows.Forms.ToolStripButton();
            this.Button_Save = new System.Windows.Forms.ToolStripButton();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Text_InputFiles
            // 
            this.Text_InputFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_InputFiles.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_InputFiles.Location = new System.Drawing.Point(0, 28);
            this.Text_InputFiles.Multiline = true;
            this.Text_InputFiles.Name = "Text_InputFiles";
            this.Text_InputFiles.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Text_InputFiles.Size = new System.Drawing.Size(396, 276);
            this.Text_InputFiles.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Button_New,
            this.Button_Add,
            this.Button_Save});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(396, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Button_New
            // 
            this.Button_New.Image = ((System.Drawing.Image)(resources.GetObject("Button_New.Image")));
            this.Button_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_New.Name = "Button_New";
            this.Button_New.Size = new System.Drawing.Size(48, 22);
            this.Button_New.Text = "&New";
            this.Button_New.Click += new System.EventHandler(this.Button_New_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.Image = ((System.Drawing.Image)(resources.GetObject("Button_Add.Image")));
            this.Button_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(89, 22);
            this.Button_Add.Text = "&Add New File";
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Image = ((System.Drawing.Image)(resources.GetObject("Button_Save.Image")));
            this.Button_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(51, 22);
            this.Button_Save.Text = "&Save";
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Filter = "Power Point (*.ppt;*.pptx)|*.ppt;*.pptx";
            this.OpenFile.Multiselect = true;
            this.OpenFile.Title = "Choose File to Add";
            // 
            // SaveFile
            // 
            this.SaveFile.Filter = "Power Point|*.pptx";
            this.SaveFile.Title = "Save File";
            // 
            // JoinPpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 305);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Text_InputFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JoinPpt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Join Ppt\'s";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_InputFiles;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Button_New;
        private System.Windows.Forms.ToolStripButton Button_Save;
        private System.Windows.Forms.ToolStripButton Button_Add;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.SaveFileDialog SaveFile;
    }
}

