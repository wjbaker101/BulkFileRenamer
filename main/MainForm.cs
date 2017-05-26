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
using BulkFileNamer.main.controls.utils;
using System.ComponentModel;

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
        /// Stores the total number of files that have successfully been renamed during the renaming process.
        /// </summary>
        private int totalRenamedFiles;

        /// <summary>
        /// Initialises the Form.
        /// Creates elements, allowing the user to interact with the Form.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            this.Font = GuiStyle.Fonts.REGULAR;

            Label_Directory.Font =
            Label_Contains.Font =
            Label_Extension.Font =
            Label_Sort.Font =
            Label_FileName.Font =
            Label_Replace.Font =
            Label_WithText.Font =
            Label_Insert.Font =
            Label_AtText.Font =
            Label_Indexing.Font =
            Label_IndexingStart.Font =
            Label_IndexingLength.Font =
            Label_OutputDirectory.Font = GuiStyle.Fonts.HEADING3;

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

        /// <summary>
        /// Called when the user clicks on the "Edit Original File Name" CheckBox.
        /// Disables controls that are not needed when the CheckBox is checked.
        /// Reason because the user does not need to insert or replace if they are creating a brand new file name.
        /// </summary>
        private void CheckBox_OriginalName_CheckedChanged(object sender, EventArgs e)
        {
            // Stores the controls that are relevant to the change
            Control[] editOriginalNameControls =
            {
                TextBox_Replace,
                TextBox_WithText,
                TextBox_Insert,
                TextBox_AtText,
                RadioButton_FromStart,
                RadioButton_FromEnd
            };

            // Changes the Enabled state of all controls depending on whether the CheckBox is checked
            foreach (Control control in editOriginalNameControls)
            {
                control.Enabled = CheckBox_OriginalName.Checked;
            }

            // Changes the Enabled state of the textbox to the opposite of the CheckBox checked state
            TextBox_NewFileName.Enabled = !CheckBox_OriginalName.Checked;
        }

        /// <summary>
        /// Called when the user clicks on the "Enable Indexing" CheckBox.
        /// Enables/Disables relevant controls depending on the Checked state of the CheckBox.
        /// </summary>
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
                TextBox_OutputDirectory.Text = newDirectory; // Sets the output to the same location

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
            if (TextBox_Directory.Text.Length > 0)
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
            else
            {

            }
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
                ConvertToInt(TextBox_AtText.Text),
                CheckBox_IndexingEnabled.Checked,
                CheckBox_IndexingPrefix.Checked,
                CheckBox_IndexingFormat.Checked,
                ConvertToInt(TextBox_IndexingStart.Text),
                ConvertToInt(TextBox_IndexingLength.Text)
            );
        }

        /// <summary>
        /// Converts a string value to an int value.
        /// Will return 1 if format is incorrect.
        /// </summary>
        /// <param name="input">The string to convert from.</param>
        /// <returns>An int value converted from the input, or 1 if invalid int.</returns>
        private int ConvertToInt(string input)
        {
            try
            {
                return int.Parse(input);
            }
            catch (Exception e)
            {
                return 1;
            }
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
        private void Button_Rename_Click(object sender, EventArgs e)
        {
            if (TextBox_Directory.Text != string.Empty) // Checks whether the user has actually entered a directory
            {
                RenameFiles();
            }
        }

        /// <summary>
        /// Asyncronously renames the files from the selected location.
        /// </summary>
        private void RenameFiles()
        {
            // Creates a background worker
            // Will run code in a new thread
            BackgroundWorker worker = new BackgroundWorker();

            worker.DoWork += Worker_DoWork;

            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;

            worker.RunWorkerAsync(); // Start renaming process
        }

        /// <summary>
        /// Does the process of renaming the files.
        /// </summary>
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<FileInformation> files = filesBindingSource.List.Cast<FileInformation>().ToList();

            totalRenamedFiles = 0;

            // Iterates through each of the files so that it can be renamed
            for (int i = 0; i < files.Count; ++i)
            {
                File.Move(files[i].Directory + "\\" + files[i].OriginalFileName, TextBox_OutputDirectory.Text + "\\" + files[i].RenamedFileName);

                SetText("Renamed " + ++totalRenamedFiles + " files.");
            }
        }

        /// <summary>
        /// Called when the renaming process has been completed.
        /// </summary>
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SetText("Renaming Finished! Total of " + totalRenamedFiles + " files renamed.");
        }

        delegate void SetTextCallback(string text);

        /// <summary>
        /// Sets the text of the output label so that it will work from another thread.
        /// </summary>
        /// <param name="text">New text for the output label.</param>
        private void SetText(string text)
        {
            // https://stackoverflow.com/a/10775421
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (Label_Output.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                SetOutputMessage(text, MessageType.REGULAR);
            }
        }

        /// <summary>
        /// Sets the Output Label to the given text.
        /// Also allows the type of message to be passed so that font colour is applied.
        /// </summary>
        /// <param name="message">The new text for the label.</param>
        /// <param name="messageType">The type of message.</param>
        private void SetOutputMessage(string message, MessageType messageType)
        {
            Label_Output.Text = message;

            // Changes the colour of the label depending on the message type
            switch (messageType)
            {
                case MessageType.ERROR:
                    Label_Output.ForeColor = GuiStyle.Colours.ERROR;
                    break;
                case MessageType.SUCCESS:
                    Label_Output.ForeColor = GuiStyle.Colours.SUCCESS;
                    break;
                case MessageType.WARNING:
                    Label_Output.ForeColor = GuiStyle.Colours.WARNING;
                    break;
                default:
                    Label_Output.ForeColor = GuiStyle.Colours.REGULAR;
                    break;
            }
        }
    }
}
