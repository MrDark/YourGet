﻿using System.Globalization;
using System.IO;

namespace YourGet.Core.Services
{
    public class LocalFileReference : IFileReference
    {
        private FileInfo _file;

        public string ContentId
        {
            get { return _file.LastWriteTimeUtc.ToString("O", CultureInfo.CurrentCulture); }
        }

        public LocalFileReference(FileInfo file)
        {
            _file = file;
        }

        public Stream OpenRead()
        {
            return _file.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        }
    }
}