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
            /// <summary>
            /// Defines the default, base, font for controls in the application.
            /// </summary>
            public static readonly Font REGULAR = new Font("Arial", 9, FontStyle.Regular);

            /// <summary>
            /// Defines the first level heading font.
            /// </summary>
            public static readonly Font HEADING = new Font("Arial", 18, FontStyle.Bold);

            /// <summary>
            /// Defines the second level heading font.
            /// </summary>
            public static readonly Font HEADING2 = new Font("Arial", 14, FontStyle.Bold);

            /// <summary>
            /// Defines the third level heading font.
            /// </summary>
            public static readonly Font HEADING3 = new Font("Arial", 9, FontStyle.Bold);
        }

        public static class Colours
        {
            public static readonly Color REGULAR = Color.Black;

            public static readonly Color ERROR = Color.Red;

            public static readonly Color SUCCESS = Color.DarkGreen;

            public static readonly Color WARNING = Color.Orange;
        }
    }
}
