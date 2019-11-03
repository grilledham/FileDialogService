using Microsoft.Win32;

namespace FileDialogService
{
    /// <summary>
    /// An implementation of <see cref="ISaveFileDialog"/> that wraps a real <see cref="SaveFileDialog"/>.
    /// </summary>
    public class PhysicalSaveFileDialog : PhysicalFileDialog, ISaveFileDialog
    {
        private SaveFileDialog UnderlyingSaveFileDialog => (SaveFileDialog)UnderlyingFileDialog;

        /// <summary>
        /// Constructs an instance of <see cref="PhysicalSaveFileDialog"/>
        /// </summary>        
        public PhysicalSaveFileDialog(SaveFileDialog UnderlyingSaveFileDialog) : base(UnderlyingSaveFileDialog)
        {
        }

        /// <inheritdoc cref="SaveFileDialog.CreatePrompt"/>
        public bool CreatePrompt { get => UnderlyingSaveFileDialog.CreatePrompt; set => UnderlyingSaveFileDialog.CreatePrompt = value; }

        /// <inheritdoc cref="SaveFileDialog.OverwritePrompt"/>r a filename that previously        
        public bool OverwritePrompt { get => UnderlyingSaveFileDialog.OverwritePrompt; set => UnderlyingSaveFileDialog.OverwritePrompt = value; }

        /// <inheritdoc cref="CommonDialog.ShowDialog"/>
        public override bool? ShowDialog() => UnderlyingSaveFileDialog.ShowDialog();
    }
}
