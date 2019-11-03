using Microsoft.Win32;

namespace FileDialogService
{
    public class PhysicalFileDialogService : IFileDialogService
    {
        public ISaveFileDialog CreateSaveFileDialog() => new PhysicalSaveFileDialog(new SaveFileDialog());

        public IOpenFileDialog CreateOpenFileDialog() => new PhysicalOpenFileDialog(new OpenFileDialog());
    }
}
