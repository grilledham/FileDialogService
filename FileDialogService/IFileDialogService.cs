namespace FileDialogService
{
    public interface IFileDialogService
    {
        ISaveFileDialog CreateSaveFileDialog();

        IOpenFileDialog CreateOpenFileDialog();
    }
}
