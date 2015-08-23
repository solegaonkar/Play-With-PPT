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

namespace SplitPPt
{
    public partial class SplitPpt : Form
    {
        List<string> MyFiles = new List<string>();

        public SplitPpt()
        {
            InitializeComponent();
        }

        private void Button_Choose_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == OpenFile.ShowDialog())
            {
                MyFiles.Clear();
                MyFiles.AddRange(OpenFile.FileNames);
            }
        }

        private void Button_Split_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == ChooseFolder.ShowDialog())
            {
                Cursor = Cursors.WaitCursor;
                Microsoft.Office.Interop.PowerPoint.Application A = new Microsoft.Office.Interop.PowerPoint.Application();
                foreach (string file in MyFiles)
                {
                    FileInfo F = new FileInfo(file);
                    string Name = F.Name;
                    Presentation P = A.Presentations.Open(file, MsoTriState.msoTrue,
                        MsoTriState.msoFalse, MsoTriState.msoFalse);
                    for (int i = 1; i <= P.Slides.Count; i++)
                    {
                        P.Slides[i].Copy();
                        Presentation P1 = A.Presentations.Add(MsoTriState.msoFalse);
                        P1.Slides.Paste(1);
                        P1.Slides[1].FollowMasterBackground = MsoTriState.msoFalse;
                        P1.SaveAs(ChooseFolder.SelectedPath + "\\" + i.ToString() + "_" + Name,
                            PpSaveAsFileType.ppSaveAsDefault, MsoTriState.msoFalse);
                        P1.Close();
                    }
                    P.Close();
                }
                Cursor = Cursors.Default;
            }

        }
    }
}
