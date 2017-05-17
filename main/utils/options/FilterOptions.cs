namespace BulkFileNamer.main.utils
{
    /// <summary>
    /// Class for an object that stores the information from what the user has inputted from the UI.
    /// Stores the conditions the user has set for which files should be renamed from the 
    /// </summary>
    public class FilterOptions
    {
        /// <summary>
        /// Stores the text that the file should contain.
        /// </summary>
        public string ContainsText
        { get; }

        /// <summary>
        /// Stores the file extension that the file should have.
        /// </summary>
        public string FileExtension
        { get; }

        /// <summary>
        /// Stores the order in which the sorting will be executed.
        /// </summary>
        public string[] SortOrder
        { get; }

        /// <summary>
        /// Stores whether the sort shoudl be executed in ascending order.
        /// </summary>
        public bool IsSortAscending
        { get; }

        /// <summary>
        /// Creation of the object. Parameters passed is the information for filtering.
        /// </summary>
        public FilterOptions(string containsText, string fileExtension, string[] sortOrder, bool isSortAscending)
        {
            ContainsText = containsText.ToLower();

            // Adds the dot if there isn't one already
            FileExtension = (fileExtension.Length > 0 && fileExtension[0] != '.' ? "." : "") + fileExtension.ToLower();
            
            IsSortAscending = isSortAscending;

            SortOrder = sortOrder;
        }
    }
}
