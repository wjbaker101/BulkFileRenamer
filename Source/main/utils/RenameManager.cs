namespace BulkFileNamer.main.utils
{
    /// <summary>
    /// Handles how files are to be renamed.
    /// </summary>
    public class RenameManager
    {
        /// <summary>
        /// Gets a renamed file from an original file name, index and renaming options.
        /// </summary>
        /// <param name="options">Options to rename the file with.</param>
        /// <param name="fileName">File name to rename.</param>
        /// <param name="index">The index of the file in the array.</param>
        /// <returns>The renamed file.</returns>
        public static string GetRenamedFile(RenameOptions options, string fileName, int index)
        {
            // Checks if the the file is to be 
            if (!options.DoEditOriginal) fileName = options.NewFileName; // Sets the file name to the new file name
            else
            {
                // Checks if the "Replace Text" is not empty
                // Then replaces the old text with the new text
                if (!options.ReplaceText.Equals(string.Empty))
                    fileName = fileName.Replace(options.ReplaceText, options.WithText);

                // Checks if the "Insert Text" is not empty
                if (!options.InsertText.Equals(string.Empty))
                {
                    // Stores the position of insertion
                    int start = options.InsertPosition;

                    // Checks if the insertion should be relative to the start or end
                    if (options.InsertStart)
                    {
                        // Limits the position to the length of the file name
                        if (start > fileName.Length) start = fileName.Length;
                    }
                    else
                    {
                        // Calculates the position relative to the end
                        start = fileName.Length - start;

                        // Makes sure the position is not less than 0
                        if (start < 0) start = 0;
                    }
                    fileName = fileName.Insert(start, options.InsertText); // Inserts text at given position
                }
            }

            // Checks if the file name should be indexed
            // If the user has selected to create a new file name, then indexing is forced on
            if (options.DoIndexing || !options.DoEditOriginal)
            {
                // Calculates and formats the index
                string formattedIndex = FormatDigits((index + options.IndexStart), options.IndexDigits);

                // Checks if the indeing should be prefixed (added at the start of the file name)
                // Adds the indexing at the correct position
                if (options.PrefixIndexing) fileName = formattedIndex + fileName;
                else fileName = fileName + formattedIndex;
            }

            return fileName;
        }

        /// <summary>
        /// Formats a given integer to a given number of digits.
        /// </summary>
        /// <param name="number">The number to format.</param>
        /// <param name="length">The number of digits to format to.</param>
        /// <returns>The formatted number.</returns>
        private static string FormatDigits(int number, int length)
        {
            string formattedNumber = number.ToString();

            // Checks if the given number actually needs to be formatted
            if (formattedNumber.Length >= length) return formattedNumber;
            else
            {
                // Adds a leading 0 to expand the number to the given number of digits
                for (int i = 0; i <= length - formattedNumber.Length; ++i)
                {
                    formattedNumber = "0" + formattedNumber;
                }
                return formattedNumber;
            }
        }
    }
}
