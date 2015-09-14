﻿using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace ExtensionMethods
{
    public static class IOExtension
    {
        #region file info
        public static string NameWithoutExtension(this FileInfo file)
        {
            return Path.GetFileNameWithoutExtension(file.Name);
        }
        #endregion

        #region temp file & directory
        public static FileInfo CreateTempFile()
        {
            return new FileInfo(Path.GetTempFileName());
        }

        public static DirectoryInfo CreateTempDirectory()
        {
            string tmp;
            while (Directory.Exists(tmp = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()))) ;
            return Directory.CreateDirectory(tmp);
        }
        #endregion
    }
}
