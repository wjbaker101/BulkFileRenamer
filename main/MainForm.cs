using Ookii.Dialogs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BulkFileNamer.main.utils;
using BulkFileNamer.main.utils.gui;
using BulkFileNamer.main.utils.options;

namespace BulkFileNamer
{
    /// <summary>
    /// Main form of the application.
    /// Initialises the Form and handles the Event Listeners for elements on the Form.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Binding source for the data grid that will allow file information to be displayed.
        /// </summary>
        private BindingSource filesBindingSource;

        /// <summary>
        /// Initialises the Form.
        /// Creates elements, allowing the user to interact with the Form.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            this.Font = GuiStyle.Fonts.REGULAR;

            // Displays the sorting options in the ListBox
            for (int i = 0; i < SortOptions.OPTIONS.Length; ++i)
            {
                ListBox_Sort.Items.Add(SortOptions.OPTIONS[i]);
            }

            // Creates the binding source
            filesBindingSource = new BindingSource();
            
            DataGridView_Files.DataSource = filesBindingSource;
            DataGridView_Files.AutoGenerateColumns = false;

            // Creates the "original file name" column
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "OriginalFileName";
            column.Name = "Original File Name";
            DataGridView_Files.Columns.Add(column);

            // Creates the "renamed file name" column
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "RenamedFileName";
            column.Name = "Renamed File Name";
            DataGridView_Files.Columns.Add(column);
        }

        private void CheckBox_OriginalName_CheckedChanged(object sender, EventArgs e)
        {
            Control[] editOriginalNameControls =
            {
                TextBox_Replace,
                TextBox_WithText,
                TextBox_Insert,
                TextBox_AtText,
                RadioButton_FromStart,
                RadioButton_FromEnd
            };

            foreach (Control control in editOriginalNameControls)
            {
                control.Enabled = CheckBox_OriginalName.Checked;
            }

            TextBox_NewFileName.Enabled = !CheckBox_OriginalName.Checked;
        }

        private void CheckBox_IndexingEnabled_CheckedChanged(object sender, EventArgs e)
        {
            // Creates an array of controls that should be enabled or disabled
            Control[] indexingControls =
            {
                CheckBox_IndexingPrefix,
                TextBox_IndexingStart,
                TextBox_IndexingLength,
                CheckBox_IndexingFormat
            };

            // Sets Enabled property of each control
            foreach (Control control in indexingControls)
            {
                control.Enabled = CheckBox_IndexingEnabled.Checked;
            }
        }

        /// <summary>
        /// Called when the user presses the reset button in the "Rename" tab.
        /// Sets editable controls to their default value.
        /// </summary>
        private void Button_ResetRename_Click(object sender, EventArgs e)
        {
            TextBox_NewFileName.Text = String.Empty;

            CheckBox_OriginalName.Checked = false;
            TextBox_Replace.Text = String.Empty;
            TextBox_WithText.Text = String.Empty;
            TextBox_Insert.Text = String.Empty;
            TextBox_AtText.Text = "0";
            RadioButton_FromStart.Checked = true;

            CheckBox_IndexingEnabled.Checked = true;
            CheckBox_IndexingPrefix.Checked = false;
            TextBox_IndexingStart.Text = "1";
            TextBox_IndexingLength.Text = "3";
            CheckBox_IndexingFormat.Checked = true;
        }

        /// <summary>
        /// Called when the user presses the button to move the sort item UP.
        /// </summary>
        private void Button_Sort_Up_Click(object sender, EventArgs e)
        {
            swapSortItem(-1);
        }

        /// <summary>
        /// Called when the user presses the button to move the sort item DOWN.
        /// </summary>
        private void Button_Sort_Down_Click(object sender, EventArgs e)
        {
            swapSortItem(1);
        }

        /// <summary>
        /// Swaps 2 items in the sort ListBox.
        /// </summary>
        /// <param name="direction">The offset of the swap from the currently selected item.</param>
        private void swapSortItem(int direction)
        {
            if (ListBox_Sort.SelectedIndex > -1) // Checks whether an item has been selected
            {
                int newPosition = ListBox_Sort.SelectedIndex + direction; // Gets the new position of the selected item

                // Checks whether the new position is within the bounds of the list
                if (newPosition > -1 && newPosition < ListBox_Sort.Items.Count)
                {
                    object prevItem = ListBox_Sort.Items[newPosition]; // Gets the object at the new position

                    // Performs the swap
                    ListBox_Sort.Items[newPosition] = ListBox_Sort.SelectedItem;
                    ListBox_Sort.Items[ListBox_Sort.SelectedIndex] = prevItem;
                    ListBox_Sort.SelectedIndex = newPosition;
                }
            }
        }

        /// <summary>
        /// Called when the user presses the button to select a directory.
        /// </summary>
        private void Button_Directory_Click(object sender, EventArgs e)
        {
            string newDirectory = openFolderDialog(); // Stores the user's choice

            if (!newDirectory.Equals(string.Empty)) // Checks if the user actually chose a directory
            {
                TextBox_Directory.Text = newDirectory; // Updates the text in the textbox

                AddFilesToTable(); // Displays the files in the folder
            }
        }

        /// <summary>
        /// Called when the user presses the button to select an output directory.
        /// </summary>
        private void Button_OutputDirectory_Click(object sender, EventArgs e)
        {
            TextBox_OutputDirectory.Text = openFolderDialog(); // Sets the textbox to display the selected directory
        }

        /// <summary>
        /// Opens a folder dialog for the user to select the directory.
        /// </summary>
        /// <returns>The selected directory or string.Empty if nothing was selected.</returns>
        private String openFolderDialog()
        {
            // Uses Okii dialog for a nicer looking folder browser
            VistaFolderBrowserDialog folderBrowserDialog = new VistaFolderBrowserDialog();

            // Don't allow the user to create an empty folder
            // As it won't contain any files to rename
            folderBrowserDialog.ShowNewFolderButton = false;

            // Stores the user's choice
            DialogResult result = folderBrowserDialog.ShowDialog();

            return result == DialogResult.OK ? folderBrowserDialog.SelectedPath : string.Empty;
        }

        /// <summary>
        /// Called when the user wishes to select a directory.
        /// </summary>
        private void Button_ApplyRename_Click(object sender, EventArgs e)
        {
            AddFilesToTable(); // Adds the retrieved files to the GridView
        }

        /// <summary>
        /// Called when the user presses the apply button in the Filter tab.
        /// </summary>
        private void Button_ApplyFilterSort_Click(object sender, EventArgs e)
        {
            AddFilesToTable(); // Adds the retrieved files to the GridView
        }

        /// <summary>
        /// Adds the files retrieved to the DataGrid, along with what it will be renamed to.
        /// </summary>
        private void AddFilesToTable()
        {
            // Retrieves files from the selected directory
            List<FileInfo> filesFromDirectory = FileManager.GetFilesFromDirectory(GetCurrentDirectoryOptions(), TextBox_Directory.Text);

            filesBindingSource.Clear(); // Clears binding source of existing files

            FileInformation newFile; // Stores the current file being added to the BindingSource

            // Stores the data to be added to the file information
            string directory;
            string originalFileName;
            string originalExtension;
            string renamedFileName;
            string renamedExtension;

            // Iterates through each of the files found from the directory
            for (int i = 0; i < filesFromDirectory.Count; ++i)
            {
                // Creates the information
                directory = filesFromDirectory[i].DirectoryName;
                originalFileName = filesFromDirectory[i].Name;
                originalExtension = renamedExtension = filesFromDirectory[i].Extension;
                renamedFileName = RenameManager.GetRenamedFile(GetCurrentRenameOptions(), originalFileName, i) + renamedExtension;
                
                // Creates the new file information
                newFile = new FileInformation(directory, originalFileName, originalExtension, renamedFileName, renamedExtension);
           
                filesBindingSource.Add(newFile); // Adds the file to the binding source, to display in the GridView
            }

            // Updates the output text
            Label_Output.Text = "Retrieved a total of " + filesFromDirectory.Count + " files.";
        }

        /// <summary>
        /// Creates an object with options based on the information the user has entered in the UI elements in the "Rename Rules" section.
        /// </summary>
        /// <returns>An object containing rename information.</returns>
        private RenameOptions GetCurrentRenameOptions()
        {
            return new RenameOptions
            (
                CheckBox_OriginalName.Checked,
                TextBox_NewFileName.Text,
                TextBox_Replace.Text,
                TextBox_WithText.Text,
                TextBox_Insert.Text,
                RadioButton_FromStart.Checked,
                int.Parse(TextBox_AtText.Text),
                CheckBox_IndexingEnabled.Checked,
                CheckBox_IndexingPrefix.Checked,
                CheckBox_IndexingFormat.Checked,
                int.Parse(TextBox_IndexingStart.Text),
                int.Parse(TextBox_IndexingLength.Text)
            );
        }

        /// <summary>
        /// Creates an object with options based on the information the user has entered in the UI elements in the "Conditions and Sorting" section.
        /// </summary>
        /// <returns>An object containing directory information.</returns>
        private FilterOptions GetCurrentDirectoryOptions()
        {
            return new FilterOptions
            (
                TextBox_Contains.Text,
                TextBox_Extension.Text,
                ListBox_Sort.Items.Cast<String>().ToArray(), // Converts the ObjectCollection to string[]
                CheckBox_SortAscending.Checked
            );
        }

        /// <summary>
        /// Called when the "Rename" button is clicked.
        /// Handles the renaming Task of selected files.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Button_Rename_Click(object sender, EventArgs e)
        {
            if (TextBox_Directory.Text != string.Empty)// Checks whether the user has actually entered a directory
            {
                // Creates the asyncronous Task for renaming the files
                Task<int> rename = RenameFilesAsync(filesBindingSource.List.Cast<FileInformation>().ToList());

                int renamedFiles = await rename; // Awaits the total number of renamed files

                Label_Output.Text = "Renaming Finished! Total of " + renamedFiles + " files renamed.";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        private async Task<int> RenameFilesAsync(List<FileInformation> files)
        {
            for (int i = 0; i < files.Count; ++i)
            {
                using (Stream source = File.Open(files[i].Directory + "\\" + files[i].OriginalFileName, FileMode.Open))
                {
                    using (Stream destination = File.Create(TextBox_OutputDirectory.Text + "\\" + files[i].RenamedFileName))
                    {
                        await source.CopyToAsync(destination);
                        Label_Output.Text = "Renamed " + (i + 1) + " files.";
                    }
                }
            }

            return 1;
        }
    }
}
