using Alphaleonis.Win32.Filesystem;
using MyFormsApp_ILMerge.Documents.Constants;
using MyFormsApp_ILMerge.Documents.Factories;
using MyFormsApp_ILMerge.Documents.Interfaces;
using System;
using System.Windows.Forms;

namespace MyFormsApp_ILMerge
{
    /// <summary>
    /// The main window of the application.
    /// </summary>
    public partial class MainWindow : Form, IDocTemplate
    {
        /// <summary>
        /// Constructs a new instance of <see cref="T:MyFormsApp_ILMerge.MainWindow" /> and
        /// returns a reference to it.
        /// </summary>
        public MainWindow()
            => InitializeComponent();

        /// <summary>
        /// Gets a reference to the sole instance of an object that implements the
        /// <see cref="T:MyFormsApp_ILMerge.Documents.Interfaces.IDocument" /> interface.
        /// </summary>
        private static IDocument Document
            => GetDocument.SoleInstance();

        /// <summary>
        /// Opens the document having the specified <paramref name="path" />.
        /// </summary>
        /// <param name="path">
        /// (Required.) A <see cref="T:System.String" /> containing the fully-qualified
        /// pathname of the file you wish to open.
        /// </param>
        public void OpenDocumentFile(string path)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(path)) return;
                if (!File.Exists(path)) return;
                if (!Document.IsFileTypeSupported(path))
                {
                    MessageBox.Show(
                        this,
                        $"{path}\nThis file is not of a type supported by this application.",
                        Application.ProductName, MessageBoxButtons.OK,
                        MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1
                    );
                    return;
                }

                Document.OpenDocument(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Sets the caption(s) of all views that are displaying documents of this type.
        /// </summary>
        public void SetCaption()
        {
            if (Document.CurrentState == DocumentState.Opening) return;

            Text = string.IsNullOrWhiteSpace(Document.FileName)
                ? $"Untitled - {Application.ProductName}"
                : $"{Document.FileName}{(Document.Dirty ? "*" : ")$")} - {Application.ProductName}";
        }

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.</summary>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Document.DataUpdated += OnDocumentDataUpdated;
            Document.DocTemplate = this;

            ResetFileContentTextBox();
        }

        private void OnDocumentDataUpdated(object sender, EventArgs e)
        {
            SetCaption();
            ResetFileContentTextBox();

            fileContentTextBox.AppendText(Document.FileContents);
        }

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

        private void ResetFileContentTextBox()
        {
            fileContentTextBox.Clear();
            fileContentTextBox.ClearUndo();
        }
    }
}