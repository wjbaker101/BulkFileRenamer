using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkFileNamer.main.utils.gui
{
    /// <summary>
    /// Styling for controls in the application.
    /// </summary>
    public class GuiStyle
    {
        /// <summary>
        /// Stores the fonts that are used in the application.
        /// </summary>
        public static class Fonts
        {
            public static readonly Font REGULAR = new Font("Arial", 9, FontStyle.Regular);

            public static readonly Font HEADING = new Font("Arial", 18, FontStyle.Bold);

            public static readonly Font HEADING2 = new Font("Arial", 14, FontStyle.Bold);

            public static readonly Font HEADING3 = new Font("Arial", 9, FontStyle.Bold);
        }
    }
}
