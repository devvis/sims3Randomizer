using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sims3RandomizerGenerator
{
    public partial class mainWnd : Form
    {
        public mainWnd()
        {
            InitializeComponent();
        }

        private void simSaveButton_Click(object sender, EventArgs e)
        {
            // This should save all the changes to a file :D
            simSaveChallengeFile.ShowDialog();
        }

        private void simSelectionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Here we should save all the current values of the fields into an object
            // for later use when the user presses the simSaveButton
        }

        private void simSaveChallengeFile_FileOk(object sender, CancelEventArgs e)
        {
            // okay :(
            MessageBox.Show("D:");
        }
    }
}
