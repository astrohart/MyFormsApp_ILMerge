using Alphaleonis.Win32.Filesystem;
using Core.Logging;
using Core.Logging.Constants;
using Core.Win32.Interact;
using MyFormsApp_ILMerge.Documents.Constants;
using MyFormsApp_ILMerge.Documents.Factories;
using MyFormsApp_ILMerge.Documents.Interfaces;
using MyFormsApp_ILMerge.Properties;
using System;
using System.Windows.Forms;

namespace MyFormsApp_ILMerge
{
    /// <summary> The main window of the application. </summary>
    public partial class MainWindow : Form, IDocTemplate
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MyFormsApp_ILMerge.MainWindow" /> and returns a reference to it.
        /// </summary>
        public MainWindow()
            => InitializeComponent();

        /// <summary>
        /// Gets a reference to the sole instance of an object that implements
        /// the <see cref="T:MyFormsApp_ILMerge.Documents.Interfaces.IDocument" />
        /// interface.
        /// </summary>
        private static IDocument Document { get; } = GetDocument.SoleInstance();

        /// <summary> Opens the document having the specified <paramref name="path" />. </summary>
        /// <param name="path">
        /// (Required.) A <see cref="T:System.String" /> containing the
        /// fully-qualified pathname of the file you wish to open.
        /// </param>
        public void OpenDocumentFile(string path)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(path)) return;
                if (!File.Exists(path)) return;
                if (!Document.IsFileTypeSupported(path))
                {
                    Messages.ShowStopError(
                        this,
                        string.Format(
                            Resources.Error_FileTypeNotSupported, path
                        )
                    );
                    return;
                }

                Document.OpenDocument(path);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                Messages.ShowStopError(this, ex.Message);
            }
        }

        /// <summary>
        /// Sets the caption(s) of all views that are displaying documents of
        /// this type.
        /// </summary>
        public void SetCaption()
        {
            if (Document.CurrentState == DocumentState.Opening) return;

            Text = string.IsNullOrWhiteSpace(Document.FileName)
                ? $"Untitled - {Application.ProductName}"
                : $"{Path.GetFileName(Document.FileName)}{(Document.Dirty ? "*" : "")} - {Application.ProductName}";
        }

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.</summary>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        protected override void OnLoad(EventArgs e)
        {
            try
            {
                base.OnLoad(e);

                Document.DataUpdated += OnDocumentDataUpdated;
                Document.DocTemplate = this;

                ResetFileContentTextBox();

                fileContentsBindingSource.DataSource = Document;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                Messages.ShowStopError(this, ex.Message);
            }
        }

        private void OnDocumentDataUpdated(object sender, EventArgs e)
        {
            try
            {
                SetCaption();
                ResetFileContentTextBox();

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** INFO: Causing the file content text box to re-read from its data source..."
                );

                fileContentsBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                Messages.ShowStopError(this, ex.Message);
            }
        }

        private void OnFileExit(object sender, EventArgs e)
            => Close();

        private void OnFileOpen(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.Cancel) return;

            OpenDocumentFile(openFileDialog.FileName);
        }

        private void OnViewStatusBar(object sender, EventArgs e)
            => statusBar.Visible = !statusBar.Visible;

        private void OnViewToolbar(object sender, EventArgs e)
            => standardToolStrip.Visible = !standardToolStrip.Visible;

        private void ResetFileContentTextBox()
        {
            try
            {
                fileContentTextBox.Clear();
                fileContentTextBox.ClearUndo();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                Messages.ShowStopError(this, ex.Message);
            }
        }
    }
}