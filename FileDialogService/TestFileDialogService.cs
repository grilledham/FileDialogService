using System;

namespace FileDialogService
{
    public class TestFileDialogService : IFileDialogService
    {
        private Func<IOpenFileDialog, bool?> showOpenFileDialogCallback;
        private Func<ISaveFileDialog, bool?> showSaveFileDialogCallback;

        public TestFileDialogService(Func<IOpenFileDialog, bool?> showOpenFileDialogCallback = null, Func<ISaveFileDialog, bool?> showSaveFileDialogCallback = null)
        {
            this.showOpenFileDialogCallback = showOpenFileDialogCallback;
            this.showSaveFileDialogCallback = showSaveFileDialogCallback;
        }

        public IOpenFileDialog CreateOpenFileDialog() => new TestOpenFileDialog(showOpenFileDialogCallback);

        public ISaveFileDialog CreateSaveFileDialog() => new TestSaveFileDialog(showSaveFileDialogCallback);
    }
}
