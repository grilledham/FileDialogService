using System;
using System.Collections.Generic;
using Microsoft.Win32;

namespace FileDialogService
{
    /// <summary>
    /// An implementation of <see cref="IOpenFileDialog"/> used for testing. 
    /// </summary>
    public class TestOpenFileDialog : IOpenFileDialog
    {
        private Func<IOpenFileDialog, bool?> showDialogCallback;

        /// <inheritdoc cref="OpenFileDialog.Multiselect"/>
        public bool Multiselect { get; set; } = false;

        /// <inheritdoc cref="OpenFileDialog.ReadOnlyChecked"/>
        public bool ReadOnlyChecked { get; set; } = false;

        /// <inheritdoc cref="OpenFileDialog.ShowReadOnly"/>
        public bool ShowReadOnly { get; set; } = false;

        /// <inheritdoc cref="FileDialog.Title"/>
        public string Title { get; set; } = string.Empty;

        /// <inheritdoc cref="FileDialog.SafeFileNames"/>
        public string[] SafeFileNames { get; } = Array.Empty<string>();

        /// <inheritdoc cref="FileDialog.SafeFileName"/>
        public string SafeFileName { get; } = string.Empty;

        /// <inheritdoc cref="FileDialog.RestoreDirectory"/>
        public bool RestoreDirectory { get; set; } = false;

        /// <inheritdoc cref="FileDialog.InitialDirectory"/>
        public string InitialDirectory { get; set; } = string.Empty;

        /// <inheritdoc cref="FileDialog.FilterIndex"/>
        public int FilterIndex { get; set; } = 1;

        /// <inheritdoc cref="FileDialog.Filter"/>
        public string Filter { get; set; } = string.Empty;

        /// <inheritdoc cref="FileDialog.FileNames"/>
        public string[] FileNames { get; } = Array.Empty<string>();

        /// <inheritdoc cref="FileDialog.FileName"/>
        public string FileName { get; set; } = string.Empty;

        /// <inheritdoc cref="FileDialog.ValidateNames"/>
        public bool ValidateNames { get; set; } = true;

        /// <inheritdoc cref="FileDialog.DereferenceLinks"/>
        public bool DereferenceLinks { get; set; } = true;

        /// <inheritdoc cref="FileDialog.CustomPlaces"/>
        public IList<FileDialogCustomPlace> CustomPlaces { get; set; } = new List<FileDialogCustomPlace>();

        /// <inheritdoc cref="FileDialog.CheckPathExists"/>
        public bool CheckPathExists { get; set; } = true;

        /// <inheritdoc cref="FileDialog.CheckFileExists"/>
        public bool CheckFileExists { get; set; } = true;

        /// <inheritdoc cref="FileDialog.AddExtension"/>
        public bool AddExtension { get; set; } = true;

        /// <inheritdoc cref="FileDialog.DefaultExt"/>
        public string DefaultExt { get; set; } = string.Empty;

        /// <summary>
        /// Constructs an instance of <see cref="TestOpenFileDialog"/>.
        /// </summary>
        /// <param name="showDialogCallback">Called when <see cref="TestOpenFileDialog.ShowDialog"/> is called.</param>
        public TestOpenFileDialog(Func<IOpenFileDialog, bool?> showDialogCallback)
        {
            this.showDialogCallback = showDialogCallback ?? throw new ArgumentNullException(nameof(showDialogCallback));
        }

        /// <inheritdoc cref="CommonDialog.ShowDialog"/>
        public bool? ShowDialog() => showDialogCallback(this);
    }
}
