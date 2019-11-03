using Microsoft.Win32;

namespace FileDialogService
{
    public interface IOpenFileDialog : IFileDialog
    {
        /// <inheritdoc cref="OpenFileDialog.Multiselect"/>
        bool Multiselect { get; set; }

        /// <inheritdoc cref="OpenFileDialog.ReadOnlyChecked"/>
        bool ReadOnlyChecked { get; set; }

        /// <inheritdoc cref="OpenFileDialog.ShowReadOnly"/>
        bool ShowReadOnly { get; set; }
    }
}
