namespace BulkFileNamer.main.utils
{
    /// <summary>
    /// Class for an object that stores the information from what the user has inputted from the UI.
    /// Stores how the user would like the file names to be renamed to.
    /// </summary>
    public class RenameOptions
    {
        /// <summary>
        /// Stores whether the user wants to edit the original file name.
        /// </summary>
        public bool DoEditOriginal
        { get; }

        /// <summary>
        /// Stores the new file name for the file.
        /// Only used if DoEditOriginal is false.
        /// </summary>
        public string NewFileName
        { get; }

        /// <summary>
        /// Stores the text that is going to be replaced.
        /// Used if DoEditOriginal is true, and if not empty.
        /// </summary>
        public string ReplaceText
        { get; }

        /// <summary>
        /// Stores the text that will replace the ReplaceText.
        /// Used if DoEditOriginal is true.
        /// </summary>
        public string WithText
        { get; }

        /// <summary>
        /// Stores the text that will be inserted into the new file name.
        /// Used if DoEditOriginal is true, and if not empty.
        /// </summary>
        public string InsertText
        { get; }

        /// <summary>
        /// Stores the index which the InsertText will be inserted at in the new file name.
        /// </summary>
        public int InsertPosition
        { get; }

        /// <summary>
        /// Stores whether the InsertIndex should be relative to the start or end of the file name.
        /// </summary>
        public bool InsertStart
        { get; }

        /// <summary>
        /// Stores whether indexing is enabled when renaming.
        /// Adds a unique number to the file name.
        /// Will always be true if DoEditOriginal is false.
        /// </summary>
        public bool DoIndexing
        { get; }

        /// <summary>
        /// Stores whether the indexing should be added before or after the main file name.
        /// </summary>
        public bool PrefixIndexing
        { get; }

        /// <summary>
        /// Stores whether the indexing should be formatted to a certain number of digits.
        /// </summary>
        public bool FormatIndexing
        { get; }

        /// <summary>
        /// Stores the number that indexing will start at.
        /// </summary>
        public int IndexStart
        { get; }

        /// <summary>
        /// Stores the number of digits to format the indexing number to.
        /// </summary>
        public int IndexDigits
        { get; }

        /// <summary>
        /// Creation of the object. Parameters passed is the information for renaming.
        /// </summary>
        public RenameOptions(bool doEditOriginal, string newFileName, string replaceText, string withText, string insertText, bool insertStart, int insertPosition, bool doIndexing, bool prefixIndexing, bool formatIndexing, int indexStart, int indexDigits)
        {
            DoEditOriginal = doEditOriginal;
            NewFileName = newFileName;

            ReplaceText = replaceText;
            WithText = withText;

            InsertText = insertText;
            InsertStart = insertStart;
            InsertPosition = insertPosition;

            DoIndexing = doIndexing;
            PrefixIndexing = prefixIndexing;
            FormatIndexing = formatIndexing;
            IndexStart = indexStart;
            IndexDigits = indexDigits;
        }
    }
}
