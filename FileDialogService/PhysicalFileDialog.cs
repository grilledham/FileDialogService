using Microsoft.Win32;
using System.Collections.Generic;

namespace FileDialogService
{
    public abstract class PhysicalFileDialog : IFileDialog
    {
        protected FileDialog UnderlyingFileDialog { get; }

        protected PhysicalFileDialog(FileDialog underlyingFileDialog)
        {
            UnderlyingFileDialog = underlyingFileDialog;
        }

        /// <inheritdoc cref="FileDialog.Title"/>
        public string Title { get => UnderlyingFileDialog.Title; set => UnderlyingFileDialog.Title = value; }

        /// <inheritdoc cref="FileDialog.SafeFileNames"/>
        public string[] SafeFileNames { get => UnderlyingFileDialog.SafeFileNames; }

        /// <inheritdoc cref="FileDialog.SafeFileName"/>
        public string SafeFileName { get => UnderlyingFileDialog.SafeFileName; }

        /// <inheritdoc cref="FileDialog.RestoreDirectory"/>
        public bool RestoreDirectory { get => UnderlyingFileDialog.RestoreDirectory; set => UnderlyingFileDialog.RestoreDirectory = value; }

        /// <inheritdoc cref="FileDialog.InitialDirectory"/>
        public string InitialDirectory { get => UnderlyingFileDialog.InitialDirectory; set => UnderlyingFileDialog.InitialDirectory = value; }

        /// <inheritdoc cref="FileDialog.FilterIndex"/>
        public int FilterIndex { get => UnderlyingFileDialog.FilterIndex; set => UnderlyingFileDialog.FilterIndex = value; }

        /// <inheritdoc cref="FileDialog.Filter"/>
        public string Filter { get => UnderlyingFileDialog.Filter; set => UnderlyingFileDialog.Filter = value; }

        /// <inheritdoc cref="FileDialog.FileNames"/>
        public string[] FileNames { get => UnderlyingFileDialog.FileNames; }

        /// <inheritdoc cref="FileDialog.FileName"/>
        public string FileName { get => UnderlyingFileDialog.FileName; set => UnderlyingFileDialog.FileName = value; }

        /// <inheritdoc cref="FileDialog.ValidateNames"/>
        public bool ValidateNames { get => UnderlyingFileDialog.ValidateNames; set => UnderlyingFileDialog.ValidateNames = value; }

        /// <inheritdoc cref="FileDialog.DereferenceLinks"/>
        public bool DereferenceLinks { get => UnderlyingFileDialog.DereferenceLinks; set => UnderlyingFileDialog.DereferenceLinks = value; }

        /// <inheritdoc cref="FileDialog.CustomPlaces"/>
        public IList<FileDialogCustomPlace> CustomPlaces { get => UnderlyingFileDialog.CustomPlaces; set => UnderlyingFileDialog.CustomPlaces = value; }

        /// <inheritdoc cref="FileDialog.CheckPathExists"/>
        public bool CheckPathExists { get => UnderlyingFileDialog.CheckPathExists; set => UnderlyingFileDialog.CheckPathExists = value; }

        /// <inheritdoc cref="FileDialog.CheckFileExists"/>
        public bool CheckFileExists { get => UnderlyingFileDialog.CheckFileExists; set => UnderlyingFileDialog.CheckFileExists = value; }

        /// <inheritdoc cref="FileDialog.AddExtension"/>
        public bool AddExtension { get => UnderlyingFileDialog.AddExtension; set => UnderlyingFileDialog.AddExtension = value; }

        /// <inheritdoc cref="FileDialog.DefaultExt"/>
        public string DefaultExt { get => UnderlyingFileDialog.DefaultExt; set => UnderlyingFileDialog.DefaultExt = value; }

        /// <inheritdoc cref="CommonDialog.ShowDialog"/>
        public abstract bool? ShowDialog();
    }
}
