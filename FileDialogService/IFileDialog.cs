using Microsoft.Win32;
using System.Collections.Generic;

namespace FileDialogService
{
    public interface IFileDialog
    {
        /// <inheritdoc cref="FileDialog.Title"/>
        string Title { get; set; }

        /// <inheritdoc cref="FileDialog.SafeFileNames"/>
        string[] SafeFileNames { get; }

        /// <inheritdoc cref="FileDialog.SafeFileName"/>
        string SafeFileName { get; }

        /// <inheritdoc cref="FileDialog.RestoreDirectory"/>
        bool RestoreDirectory { get; set; }

        /// <inheritdoc cref="FileDialog.InitialDirectory"/>
        string InitialDirectory { get; set; }

        /// <inheritdoc cref="FileDialog.FilterIndex"/>
        int FilterIndex { get; set; }

        /// <inheritdoc cref="FileDialog.Filter"/>
        string Filter { get; set; }

        /// <inheritdoc cref="FileDialog.FileNames"/>
        string[] FileNames { get; }

        /// <inheritdoc cref="FileDialog.FileName"/>
        string FileName { get; set; }

        /// <inheritdoc cref="FileDialog.ValidateNames"/>
        bool ValidateNames { get; set; }

        /// <inheritdoc cref="FileDialog.DereferenceLinks"/>
        bool DereferenceLinks { get; set; }

        /// <inheritdoc cref="FileDialog.CustomPlaces"/>
        IList<FileDialogCustomPlace> CustomPlaces { get; set; }

        /// <inheritdoc cref="FileDialog.CheckPathExists"/>
        bool CheckPathExists { get; set; }

        /// <inheritdoc cref="FileDialog.CheckFileExists"/>
        bool CheckFileExists { get; set; }

        /// <inheritdoc cref="FileDialog.AddExtension"/>
        bool AddExtension { get; set; }

        /// <inheritdoc cref="FileDialog.DefaultExt"/>
        string DefaultExt { get; set; }

        /// <inheritdoc cref="CommonDialog.ShowDialog"/>
        bool? ShowDialog();
    }
}
