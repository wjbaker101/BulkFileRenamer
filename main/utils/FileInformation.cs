using System;

namespace BulkFileNamer.main.utils
{
    public class FileInformation
    {
        /// <summary>
        /// Stores the original file name, before renaming has been executed.
        /// </summary>
        public string OriginalFileName
        { get; }

        /// <summary>
        /// Stores the file extension from the original file.
        /// </summary>
        public string OriginalExtension
        { get; }

        /// <summary>
        /// Stores the name the file will take after renaming has been executed.
        /// </summary>
        public string RenamedFileName
        { get; }

        /// <summary>
        /// Stores the file extension from the renamed file.
        /// </summary>
        public string RenamedExtension
        { get; }

        /// <summary>
        /// Stores the full path this file is located at.
        /// Does not include the name of the file.
        /// </summary>
        public string Directory
        { get; }

        /// <summary>
        /// Creates the file information.
        /// </summary>
        /// <param name="directory">The full path of the file, from the user's file system.</param>
        /// <param name="originalFileName">The original file name.</param>
        /// <param name="originalExtension">The original file extension.</param>
        /// <param name="renamedFileName">The renamed file name.</param>
        /// <param name="renamedExtension">The renamed file extension.</param>
        public FileInformation(string directory, string originalFileName, string originalExtension, string renamedFileName, string renamedExtension)
        {
            Directory = directory;

            OriginalFileName = originalFileName;
            OriginalExtension = originalExtension;

            RenamedFileName = renamedFileName;
            RenamedExtension = renamedExtension;
        }
    }
}
