using Microsoft.Win32;

namespace FileDialogService
{
    public interface ISaveFileDialog : IFileDialog
    {
        /// <inheritdoc cref="SaveFileDialog.CreatePrompt"/>
        bool CreatePrompt { get; set; }

        /// <inheritdoc cref="SaveFileDialog.OverwritePrompt"/>    
        bool OverwritePrompt { get; set; }
    }
}
