using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace BulkFileNamer.main.utils
{
    /// <summary>
    /// Handles which files are to be retrieved from the user's file system.
    /// </summary>
    public class FileManager
    {
        /// <summary>
        /// Filters out files which do not match the user's requirements, located in the directory the user has selected.
        /// </summary>
        /// <param name="options">The filter options which determine which files are to be retrieved.</param>
        /// <param name="directory">The directory to check for files.</param>
        /// <returns>A list containing FileInfo of each file successfully retrieved.</returns>
        public static List<FileInfo> GetFilesFromDirectory(FilterOptions options, string directory)
        {
            List<FileInfo> files = new List<FileInfo>(); // Stores the files

            // Loops through each file found in the directory
            foreach (FileInfo file in (new DirectoryInfo(directory)).GetFiles().ToList())
            {
                // If the user has entered text, then check if the file contains this text
                if (options.ContainsText.Length == 0 || file.Name.ToLower().Contains(options.ContainsText))
                {
                    // If the user has entered a specific file extension, then check if the file has that file extension
                    if (options.FileExtension.Length == 0 || file.Extension.ToLower().Equals(options.FileExtension))
                    {
                        files.Add(file);
                    }
                }
            }
            return files;
        }
    }
}
