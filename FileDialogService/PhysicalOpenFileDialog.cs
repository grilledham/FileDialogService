using Microsoft.Win32;

namespace FileDialogService
{
    /// <summary>
    /// An implementation of <see cref="IOpenFileDialog"/> that wraps a real <see cref="OpenFileDialog"/>.
    /// </summary>
    public class PhysicalOpenFileDialog : PhysicalFileDialog, IOpenFileDialog
    {
        private OpenFileDialog UnderlyingOpenFileDialog => (OpenFileDialog)UnderlyingFileDialog;

        /// <inheritdoc cref="OpenFileDialog.Multiselect"/>
        public bool Multiselect { get => UnderlyingOpenFileDialog.Multiselect; set => UnderlyingOpenFileDialog.Multiselect = value; }

        /// <inheritdoc cref="OpenFileDialog.ReadOnlyChecked"/>
        public bool ReadOnlyChecked { get => UnderlyingOpenFileDialog.ReadOnlyChecked; set => UnderlyingOpenFileDialog.ReadOnlyChecked = value; }

        /// <inheritdoc cref="OpenFileDialog.ShowReadOnly"/>
        public bool ShowReadOnly { get => UnderlyingOpenFileDialog.ShowReadOnly; set => UnderlyingOpenFileDialog.ShowReadOnly = value; }

        /// <summary>
        /// Constructs an instance of <see cref="PhysicalOpenFileDialog"/>
        /// </summary>  
        public PhysicalOpenFileDialog(OpenFileDialog UnderlyingSaveFileDialog) : base(UnderlyingSaveFileDialog)
        {
        }

        /// <inheritdoc cref="CommonDialog.ShowDialog"/>
        public override bool? ShowDialog() => UnderlyingOpenFileDialog.ShowDialog();
    }
}
