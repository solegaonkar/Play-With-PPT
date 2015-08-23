using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Core;

namespace JoinPPT
{
    public partial class JoinPpt : Form
    {
        private Microsoft.Office.Interop.PowerPoint.Application mi_App;   // Powerpoint Application
        private Presentation mi_Pres1;  // Presentation with all slides (pages)
        private Presentation mi_Pres2;  // Presentation with all slides (pages)

        public JoinPpt()
        {
            InitializeComponent();
            mi_App = new Microsoft.Office.Interop.PowerPoint.Application();
        }

/*
        private void TestAppend()
        {
            mi_App = new Microsoft.Office.Interop.PowerPoint.Application();
            mi_Pres1 = mi_App.Presentations.Open(@"D:\Visual Studio 2008\Projects\JoinPPT\JoinPPT\bin\Debug\File1.pptx",
                MsoTriState.msoFalse, MsoTriState.msoFalse, MsoTriState.msoFalse);
            mi_Pres2 = mi_App.Presentations.Open(@"D:\Visual Studio 2008\Projects\JoinPPT\JoinPPT\bin\Debug\File2.pptx",
                MsoTriState.msoFalse, MsoTriState.msoFalse, MsoTriState.msoFalse);

            for (int i = 1; i <= mi_Pres2.Slides.Count; i++)
            {
                mi_Pres2.Slides[i].Copy();
                mi_Pres1.Slides.Paste(mi_Pres1.Slides.Count+1);
                mi_Pres1.Slides[mi_Pres1.Slides.Count].FollowMasterBackground = MsoTriState.msoFalse;
            }
            mi_Pres1.SaveAs(@"D:\Visual Studio 2008\Projects\JoinPPT\JoinPPT\bin\Debug\File3.pptx",
                PpSaveAsFileType.ppSaveAsDefault, MsoTriState.msoTrue);
            mi_Pres1.Close();
            mi_Pres2.Close();

        }
*/

        private void AppendFile(string file)
        {
            mi_Pres2 = mi_App.Presentations.Open(file, MsoTriState.msoFalse, 
                MsoTriState.msoFalse, MsoTriState.msoFalse);
            for (int i = 1; i <= mi_Pres2.Slides.Count; i++)
            {
                mi_Pres2.Slides[i].Copy();
                mi_Pres1.Slides.Paste(mi_Pres1.Slides.Count + 1);
                mi_Pres1.Slides[mi_Pres1.Slides.Count].FollowMasterBackground = MsoTriState.msoFalse;
            }
            mi_Pres2.Close();
        }

        private void Button_New_Click(object sender, EventArgs e)
        {
            Text_InputFiles.Text = "";
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == OpenFile.ShowDialog())
            {
                foreach (string file in OpenFile.FileNames)
                {
                    Text_InputFiles.Text += file + "\r\n";
                }
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            string[] files = Text_InputFiles.Text.Split("\r\n".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries);
            foreach (string file in files)
            {
                FileInfo F = new FileInfo(file);
                if (!F.Exists)
                {
                    MessageBox.Show("File does not exist " + file, "File Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (F.Extension.ToLower() != ".ppt" && F.Extension.ToLower() != ".pptx")
                {
                    MessageBox.Show("This is not a ppt/pptx " + file, "Not PPT/PPTX",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (DialogResult.OK == SaveFile.ShowDialog())
            {
                Cursor.Current = Cursors.WaitCursor;
                mi_Pres1 = (Presentation)mi_App.Presentations.Add(MsoTriState.msoFalse);
                foreach (string file in files)
                {
                    AppendFile(file);
                }
                mi_Pres1.SaveAs(SaveFile.FileName,
                    PpSaveAsFileType.ppSaveAsDefault, MsoTriState.msoFalse);
                mi_Pres1.Close();
                Cursor.Current = Cursors.Default;
            }
        }

    }
}
