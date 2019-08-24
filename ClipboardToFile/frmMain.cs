using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClipboardToFile
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void CmdPro_Click(object sender, EventArgs e)
        {
            string lxNomArch = "";
            ClipboardPro(txtBase.Text, lxNomArch);
        }

        void ClipboardPro(string baseText, string NomArch)
        {
            string lxClip = Clipboard.GetText();
            string[] lxLins =
                lxClip.Split(new[] { Environment.NewLine },
                             StringSplitOptions.None);

            using (StreamWriter lxSW = new StreamWriter(NomArch))
            {
                foreach (string lxLin in lxLins)
                {
                    string[] lxPmts = lxLin.Split('\t');
                    if (!string.IsNullOrEmpty(lxLin))
                    {
                        lxSW.WriteLine(string.Format(baseText, lxPmts));
                    }
                }
                lxSW.Close();
            }
        }

        private void ArchAbr()
        {
            using (OpenFileDialog lxDlg = new OpenFileDialog()
            {
                DefaultExt = "*.txt",
                Filter = "Archivos Texto (*.txt)|*.txt|Todos (*.*)|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            })
            {
                if (lxDlg.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader lxSR = new StreamReader(lxDlg.FileName))
                    {
                        txtBase.Text = lxSR.ReadToEnd();
                    }
                }
            }
        }

        private void MnuAbr_Click(object sender, EventArgs e)
        {
            ArchAbr();
        }
    }
}
