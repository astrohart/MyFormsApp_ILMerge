using System;
using System.Windows.Forms;

namespace MyFormsApp_ILMerge
{
    /// <summary>
    /// The main window of the application.
    /// </summary>
    public partial class MainWindow : Form
    {
        /// <summary>
        /// Constructs a new instance of <see cref="T:MyFormsApp_ILMerge.MainWindow" /> and
        /// returns a reference to it.
        /// </summary>
        public MainWindow()
            => InitializeComponent();

        private void OnFileExit(object sender, EventArgs e)
            => Close();

        private void OnFileOpen(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.Cancel) return;

            // TODO: Add code here to open the file that is chosen by the user.
        }

        private void OnViewStatusBar(object sender, EventArgs e)
            => statusBar.Visible = !statusBar.Visible;

        private void OnViewToolbar(object sender, EventArgs e)
            => standardToolStrip.Visible = !standardToolStrip.Visible;
    }
}