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

            filesBindingSource = new BindingSource();
            DataGridView_Files.DataSource = filesBindingSource;
            DataGridView_Files.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "OriginalFileName";
            column.Name = "Original File Name";
            DataGridView_Files.Columns.Add(column);

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
            Control[] indexingControls =
            {
                CheckBox_IndexingPrefix,
                TextBox_IndexingStart,
                TextBox_IndexingLength,
                CheckBox_IndexingFormat
            };

            foreach (Control control in indexingControls)
            {
                control.Enabled = CheckBox_IndexingEnabled.Checked;
            }
        }

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

        private void Button_Sort_Up_Click(object sender, EventArgs e)
        {
            moveSortItem(true);
        }

        private void Button_Sort_Down_Click(object sender, EventArgs e)
        {
            moveSortItem(false);
        }

        private void moveSortItem(bool moveUp)
        {
            if (ListBox_Sort.SelectedIndex > -1)
            {
                int newPosition = ListBox_Sort.SelectedIndex + (moveUp ? -1 : 1);

                if (newPosition > -1 && newPosition < ListBox_Sort.Items.Count)
                {
                    object prevItem = ListBox_Sort.Items[newPosition];

                    ListBox_Sort.Items[newPosition] = ListBox_Sort.SelectedItem;
                    ListBox_Sort.Items[ListBox_Sort.SelectedIndex] = prevItem;
                    ListBox_Sort.SelectedIndex = newPosition;
                }
            }
        }

        private void Button_Directory_Click(object sender, EventArgs e)
        {
            string newDirectory = openFolderDialog();

            if (!newDirectory.Equals(string.Empty))
            {
                TextBox_Directory.Text = newDirectory;

                AddFilesToTable();
            }
        }

        private void Button_OutputDirectory_Click(object sender, EventArgs e)
        {
            TextBox_OutputDirectory.Text = openFolderDialog();
        }

        private String openFolderDialog()
        {
            VistaFolderBrowserDialog folderBrowserDialog = new VistaFolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = false;

            DialogResult result = folderBrowserDialog.ShowDialog();

            return result == DialogResult.OK ? folderBrowserDialog.SelectedPath : string.Empty;
        }

        private void Button_ApplyRename_Click(object sender, EventArgs e)
        {
            AddFilesToTable();
        }

        /// <summary>
        /// Adds the files retrieved to the DataGrid, along with what it will be renamed to.
        /// </summary>
        private void AddFilesToTable()
        {
            // Retrieves files from the selected directory
            List<FileInfo> filesFromDirectory = FileManager.GetFilesFromDirectory(GetCurrentDirectoryOptions(), TextBox_Directory.Text);

            filesBindingSource.Clear();

            FileInformation newFile; // Stores the current file being added to the BindingSource
            string directory;
            string originalFileName;
            string originalExtension;
            string renamedFileName;
            string renamedExtension;
            for (int i = 0; i < filesFromDirectory.Count; ++i)
            {
                directory = filesFromDirectory[i].DirectoryName;
                originalFileName = filesFromDirectory[i].Name;
                originalExtension = renamedExtension = filesFromDirectory[i].Extension;
                renamedFileName = RenameManager.GetRenamedFile(GetCurrentRenameOptions(), originalFileName, i) + renamedExtension;
                
                newFile = new FileInformation(directory, originalFileName, originalExtension, renamedFileName, renamedExtension);
           
                filesBindingSource.Add(newFile);
            }
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
                    using (Stream destination = File.Create(files[i].Directory + "\\" + files[i].RenamedFileName))
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
