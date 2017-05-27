using BulkFileNamer.main.controls;

namespace BulkFileNamer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label_Directory = new BulkFileNamer.main.controls.BorderedLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Panel_Directory_Container = new System.Windows.Forms.Panel();
            this.Button_Directory = new System.Windows.Forms.Button();
            this.TextBox_Directory = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_Output = new BulkFileNamer.main.controls.BorderedLabel();
            this.DataGridView_Files = new System.Windows.Forms.DataGridView();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new BulkFileNamer.main.controls.BorderlessTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Button_Sort_Down = new System.Windows.Forms.Button();
            this.Button_ApplyFilterSort = new System.Windows.Forms.Button();
            this.Button_Sort_Up = new System.Windows.Forms.Button();
            this.CheckBox_SortAscending = new System.Windows.Forms.CheckBox();
            this.ListBox_Sort = new System.Windows.Forms.ListBox();
            this.Label_Sort = new BulkFileNamer.main.controls.BorderedLabel();
            this.TextBox_Extension = new System.Windows.Forms.TextBox();
            this.Label_Extension = new BulkFileNamer.main.controls.BorderedLabel();
            this.TextBox_Contains = new System.Windows.Forms.TextBox();
            this.Label_Contains = new BulkFileNamer.main.controls.BorderedLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TablePanel_Insert = new System.Windows.Forms.TableLayoutPanel();
            this.TextBox_Insert = new System.Windows.Forms.TextBox();
            this.TextBox_AtText = new System.Windows.Forms.TextBox();
            this.Label_Insert = new BulkFileNamer.main.controls.BorderedLabel();
            this.RadioButton_FromStart = new System.Windows.Forms.RadioButton();
            this.Label_AtText = new BulkFileNamer.main.controls.BorderedLabel();
            this.RadioButton_FromEnd = new System.Windows.Forms.RadioButton();
            this.TablePanel_ReplaceWith = new System.Windows.Forms.TableLayoutPanel();
            this.TextBox_WithText = new System.Windows.Forms.TextBox();
            this.TextBox_Replace = new System.Windows.Forms.TextBox();
            this.Label_WithText = new BulkFileNamer.main.controls.BorderedLabel();
            this.Label_Replace = new BulkFileNamer.main.controls.BorderedLabel();
            this.CheckBox_IndexingFormat = new System.Windows.Forms.CheckBox();
            this.TextBox_IndexingStart = new System.Windows.Forms.TextBox();
            this.TextBox_IndexingLength = new System.Windows.Forms.TextBox();
            this.Button_ResetRename = new System.Windows.Forms.Button();
            this.Label_IndexingLength = new BulkFileNamer.main.controls.BorderedLabel();
            this.Label_IndexingStart = new BulkFileNamer.main.controls.BorderedLabel();
            this.Button_ApplyRename = new System.Windows.Forms.Button();
            this.CheckBox_IndexingPrefix = new System.Windows.Forms.CheckBox();
            this.CheckBox_IndexingEnabled = new System.Windows.Forms.CheckBox();
            this.Label_Indexing = new BulkFileNamer.main.controls.BorderedLabel();
            this.CheckBox_OriginalName = new System.Windows.Forms.CheckBox();
            this.TextBox_NewFileName = new System.Windows.Forms.TextBox();
            this.Label_FileName = new BulkFileNamer.main.controls.BorderedLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CheckBox_OutputCopy = new System.Windows.Forms.CheckBox();
            this.Panel_OutputDirectory_Container = new System.Windows.Forms.Panel();
            this.Button_OutputDirectory = new System.Windows.Forms.Button();
            this.TextBox_OutputDirectory = new System.Windows.Forms.TextBox();
            this.Label_OutputDirectory = new BulkFileNamer.main.controls.BorderedLabel();
            this.Button_Rename = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Panel_Directory_Container.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Files)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.TablePanel_Insert.SuspendLayout();
            this.TablePanel_ReplaceWith.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.Panel_OutputDirectory_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 537);
            this.splitContainer1.SplitterDistance = 504;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.DataGridView_Files, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(504, 537);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.panel2.Controls.Add(this.Label_Directory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 24);
            this.panel2.TabIndex = 20;
            // 
            // Label_Directory
            // 
            this.Label_Directory.AutoSize = true;
            this.Label_Directory.Location = new System.Drawing.Point(8, 3);
            this.Label_Directory.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.Label_Directory.Name = "Label_Directory";
            this.Label_Directory.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Label_Directory.Size = new System.Drawing.Size(52, 18);
            this.Label_Directory.TabIndex = 47;
            this.Label_Directory.Text = "Directory:";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.panel3.Controls.Add(this.Panel_Directory_Container);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.panel3.Size = new System.Drawing.Size(504, 38);
            this.panel3.TabIndex = 21;
            // 
            // Panel_Directory_Container
            // 
            this.Panel_Directory_Container.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Directory_Container.BackColor = System.Drawing.Color.White;
            this.Panel_Directory_Container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Directory_Container.Controls.Add(this.Button_Directory);
            this.Panel_Directory_Container.Controls.Add(this.TextBox_Directory);
            this.Panel_Directory_Container.Location = new System.Drawing.Point(8, 3);
            this.Panel_Directory_Container.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.Panel_Directory_Container.Name = "Panel_Directory_Container";
            this.Panel_Directory_Container.Padding = new System.Windows.Forms.Padding(3);
            this.Panel_Directory_Container.Size = new System.Drawing.Size(488, 28);
            this.Panel_Directory_Container.TabIndex = 18;
            // 
            // Button_Directory
            // 
            this.Button_Directory.BackColor = System.Drawing.Color.Transparent;
            this.Button_Directory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Directory.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button_Directory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_Directory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_Directory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Directory.ForeColor = System.Drawing.Color.Black;
            this.Button_Directory.Location = new System.Drawing.Point(448, 3);
            this.Button_Directory.Name = "Button_Directory";
            this.Button_Directory.Size = new System.Drawing.Size(35, 20);
            this.Button_Directory.TabIndex = 1;
            this.Button_Directory.Text = "...";
            this.Button_Directory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Directory.UseVisualStyleBackColor = false;
            this.Button_Directory.Click += new System.EventHandler(this.Button_Directory_Click);
            // 
            // TextBox_Directory
            // 
            this.TextBox_Directory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Directory.BackColor = System.Drawing.Color.White;
            this.TextBox_Directory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Directory.Location = new System.Drawing.Point(3, 6);
            this.TextBox_Directory.Name = "TextBox_Directory";
            this.TextBox_Directory.ReadOnly = true;
            this.TextBox_Directory.Size = new System.Drawing.Size(439, 13);
            this.TextBox_Directory.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.panel1.Controls.Add(this.Label_Output);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 505);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 2);
            this.panel1.Size = new System.Drawing.Size(504, 32);
            this.panel1.TabIndex = 22;
            // 
            // Label_Output
            // 
            this.Label_Output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Output.ForeColor = System.Drawing.Color.Black;
            this.Label_Output.Location = new System.Drawing.Point(8, 7);
            this.Label_Output.Margin = new System.Windows.Forms.Padding(3);
            this.Label_Output.Name = "Label_Output";
            this.Label_Output.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Label_Output.Size = new System.Drawing.Size(493, 20);
            this.Label_Output.TabIndex = 2;
            this.Label_Output.Text = "Select a directory to add files.";
            this.Label_Output.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DataGridView_Files
            // 
            this.DataGridView_Files.AllowUserToAddRows = false;
            this.DataGridView_Files.AllowUserToDeleteRows = false;
            this.DataGridView_Files.AllowUserToResizeColumns = false;
            this.DataGridView_Files.AllowUserToResizeRows = false;
            this.DataGridView_Files.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_Files.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_Files.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_Files.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Files.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_Files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Files.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_Files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_Files.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView_Files.EnableHeadersVisualStyles = false;
            this.DataGridView_Files.Location = new System.Drawing.Point(8, 70);
            this.DataGridView_Files.Margin = new System.Windows.Forms.Padding(8);
            this.DataGridView_Files.MultiSelect = false;
            this.DataGridView_Files.Name = "DataGridView_Files";
            this.DataGridView_Files.ReadOnly = true;
            this.DataGridView_Files.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Files.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_Files.RowHeadersVisible = false;
            this.DataGridView_Files.RowTemplate.Height = 28;
            this.DataGridView_Files.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Files.ShowCellErrors = false;
            this.DataGridView_Files.ShowCellToolTips = false;
            this.DataGridView_Files.ShowEditingIcon = false;
            this.DataGridView_Files.ShowRowErrors = false;
            this.DataGridView_Files.Size = new System.Drawing.Size(488, 427);
            this.DataGridView_Files.TabIndex = 23;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.splitContainer5.Panel2.Controls.Add(this.Button_Rename);
            this.splitContainer5.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer5.Size = new System.Drawing.Size(503, 537);
            this.splitContainer5.SplitterDistance = 503;
            this.splitContainer5.SplitterWidth = 1;
            this.splitContainer5.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(503, 503);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.tabPage1.Controls.Add(this.Button_Sort_Down);
            this.tabPage1.Controls.Add(this.Button_ApplyFilterSort);
            this.tabPage1.Controls.Add(this.Button_Sort_Up);
            this.tabPage1.Controls.Add(this.CheckBox_SortAscending);
            this.tabPage1.Controls.Add(this.ListBox_Sort);
            this.tabPage1.Controls.Add(this.Label_Sort);
            this.tabPage1.Controls.Add(this.TextBox_Extension);
            this.tabPage1.Controls.Add(this.Label_Extension);
            this.tabPage1.Controls.Add(this.TextBox_Contains);
            this.tabPage1.Controls.Add(this.Label_Contains);
            this.tabPage1.Location = new System.Drawing.Point(0, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(8);
            this.tabPage1.Size = new System.Drawing.Size(503, 479);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filter and Sorting";
            // 
            // Button_Sort_Down
            // 
            this.Button_Sort_Down.BackColor = System.Drawing.Color.White;
            this.Button_Sort_Down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Sort_Down.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(107)))), ((int)(((byte)(150)))));
            this.Button_Sort_Down.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.Button_Sort_Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Sort_Down.Location = new System.Drawing.Point(167, 212);
            this.Button_Sort_Down.Name = "Button_Sort_Down";
            this.Button_Sort_Down.Size = new System.Drawing.Size(25, 52);
            this.Button_Sort_Down.TabIndex = 1;
            this.Button_Sort_Down.Text = "▼";
            this.Button_Sort_Down.UseVisualStyleBackColor = false;
            this.Button_Sort_Down.Click += new System.EventHandler(this.Button_Sort_Down_Click);
            // 
            // Button_ApplyFilterSort
            // 
            this.Button_ApplyFilterSort.BackColor = System.Drawing.Color.White;
            this.Button_ApplyFilterSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ApplyFilterSort.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.Button_ApplyFilterSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ApplyFilterSort.Location = new System.Drawing.Point(11, 293);
            this.Button_ApplyFilterSort.MaximumSize = new System.Drawing.Size(150, 100);
            this.Button_ApplyFilterSort.Name = "Button_ApplyFilterSort";
            this.Button_ApplyFilterSort.Size = new System.Drawing.Size(150, 35);
            this.Button_ApplyFilterSort.TabIndex = 46;
            this.Button_ApplyFilterSort.Text = "Apply Changes";
            this.Button_ApplyFilterSort.UseVisualStyleBackColor = false;
            this.Button_ApplyFilterSort.Click += new System.EventHandler(this.Button_ApplyFilterSort_Click);
            // 
            // Button_Sort_Up
            // 
            this.Button_Sort_Up.BackColor = System.Drawing.Color.White;
            this.Button_Sort_Up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Sort_Up.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(107)))), ((int)(((byte)(150)))));
            this.Button_Sort_Up.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.Button_Sort_Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Sort_Up.Location = new System.Drawing.Point(167, 155);
            this.Button_Sort_Up.Name = "Button_Sort_Up";
            this.Button_Sort_Up.Size = new System.Drawing.Size(25, 52);
            this.Button_Sort_Up.TabIndex = 0;
            this.Button_Sort_Up.Text = "▲";
            this.Button_Sort_Up.UseVisualStyleBackColor = false;
            this.Button_Sort_Up.Click += new System.EventHandler(this.Button_Sort_Up_Click);
            // 
            // CheckBox_SortAscending
            // 
            this.CheckBox_SortAscending.AutoSize = true;
            this.CheckBox_SortAscending.Checked = true;
            this.CheckBox_SortAscending.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_SortAscending.Location = new System.Drawing.Point(11, 270);
            this.CheckBox_SortAscending.Name = "CheckBox_SortAscending";
            this.CheckBox_SortAscending.Size = new System.Drawing.Size(103, 17);
            this.CheckBox_SortAscending.TabIndex = 41;
            this.CheckBox_SortAscending.Text = "Ascending order";
            this.CheckBox_SortAscending.UseVisualStyleBackColor = true;
            // 
            // ListBox_Sort
            // 
            this.ListBox_Sort.FormattingEnabled = true;
            this.ListBox_Sort.Location = new System.Drawing.Point(11, 155);
            this.ListBox_Sort.Name = "ListBox_Sort";
            this.ListBox_Sort.Size = new System.Drawing.Size(150, 108);
            this.ListBox_Sort.TabIndex = 39;
            // 
            // Label_Sort
            // 
            this.Label_Sort.AutoSize = true;
            this.Label_Sort.Location = new System.Drawing.Point(11, 129);
            this.Label_Sort.Margin = new System.Windows.Forms.Padding(3);
            this.Label_Sort.Name = "Label_Sort";
            this.Label_Sort.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Label_Sort.Size = new System.Drawing.Size(29, 18);
            this.Label_Sort.TabIndex = 37;
            this.Label_Sort.Text = "Sort:";
            // 
            // TextBox_Extension
            // 
            this.TextBox_Extension.Location = new System.Drawing.Point(11, 97);
            this.TextBox_Extension.MaximumSize = new System.Drawing.Size(150, 100);
            this.TextBox_Extension.Name = "TextBox_Extension";
            this.TextBox_Extension.Size = new System.Drawing.Size(150, 20);
            this.TextBox_Extension.TabIndex = 27;
            // 
            // Label_Extension
            // 
            this.Label_Extension.AutoSize = true;
            this.Label_Extension.Location = new System.Drawing.Point(11, 70);
            this.Label_Extension.Margin = new System.Windows.Forms.Padding(3);
            this.Label_Extension.Name = "Label_Extension";
            this.Label_Extension.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Label_Extension.Size = new System.Drawing.Size(75, 18);
            this.Label_Extension.TabIndex = 19;
            this.Label_Extension.Text = "File Extension:";
            // 
            // TextBox_Contains
            // 
            this.TextBox_Contains.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Contains.Location = new System.Drawing.Point(11, 38);
            this.TextBox_Contains.Name = "TextBox_Contains";
            this.TextBox_Contains.Size = new System.Drawing.Size(480, 20);
            this.TextBox_Contains.TabIndex = 17;
            // 
            // Label_Contains
            // 
            this.Label_Contains.AutoSize = true;
            this.Label_Contains.Location = new System.Drawing.Point(11, 11);
            this.Label_Contains.Margin = new System.Windows.Forms.Padding(3);
            this.Label_Contains.Name = "Label_Contains";
            this.Label_Contains.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Label_Contains.Size = new System.Drawing.Size(121, 18);
            this.Label_Contains.TabIndex = 0;
            this.Label_Contains.Text = "Rename if contains text:";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.tabPage2.Controls.Add(this.TablePanel_Insert);
            this.tabPage2.Controls.Add(this.TablePanel_ReplaceWith);
            this.tabPage2.Controls.Add(this.CheckBox_IndexingFormat);
            this.tabPage2.Controls.Add(this.TextBox_IndexingStart);
            this.tabPage2.Controls.Add(this.TextBox_IndexingLength);
            this.tabPage2.Controls.Add(this.Button_ResetRename);
            this.tabPage2.Controls.Add(this.Label_IndexingLength);
            this.tabPage2.Controls.Add(this.Label_IndexingStart);
            this.tabPage2.Controls.Add(this.Button_ApplyRename);
            this.tabPage2.Controls.Add(this.CheckBox_IndexingPrefix);
            this.tabPage2.Controls.Add(this.CheckBox_IndexingEnabled);
            this.tabPage2.Controls.Add(this.Label_Indexing);
            this.tabPage2.Controls.Add(this.CheckBox_OriginalName);
            this.tabPage2.Controls.Add(this.TextBox_NewFileName);
            this.tabPage2.Controls.Add(this.Label_FileName);
            this.tabPage2.Location = new System.Drawing.Point(0, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(8);
            this.tabPage2.Size = new System.Drawing.Size(503, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rename Rules";
            // 
            // TablePanel_Insert
            // 
            this.TablePanel_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablePanel_Insert.ColumnCount = 3;
            this.TablePanel_Insert.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanel_Insert.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.TablePanel_Insert.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.TablePanel_Insert.Controls.Add(this.TextBox_Insert, 0, 1);
            this.TablePanel_Insert.Controls.Add(this.TextBox_AtText, 1, 1);
            this.TablePanel_Insert.Controls.Add(this.Label_Insert, 0, 0);
            this.TablePanel_Insert.Controls.Add(this.RadioButton_FromStart, 2, 0);
            this.TablePanel_Insert.Controls.Add(this.Label_AtText, 1, 0);
            this.TablePanel_Insert.Controls.Add(this.RadioButton_FromEnd, 2, 1);
            this.TablePanel_Insert.Location = new System.Drawing.Point(11, 152);
            this.TablePanel_Insert.Name = "TablePanel_Insert";
            this.TablePanel_Insert.RowCount = 2;
            this.TablePanel_Insert.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TablePanel_Insert.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TablePanel_Insert.Size = new System.Drawing.Size(487, 61);
            this.TablePanel_Insert.TabIndex = 53;
            // 
            // TextBox_Insert
            // 
            this.TextBox_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Insert.Enabled = false;
            this.TextBox_Insert.Location = new System.Drawing.Point(0, 33);
            this.TextBox_Insert.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.TextBox_Insert.Name = "TextBox_Insert";
            this.TextBox_Insert.Size = new System.Drawing.Size(293, 20);
            this.TextBox_Insert.TabIndex = 23;
            // 
            // TextBox_AtText
            // 
            this.TextBox_AtText.Enabled = false;
            this.TextBox_AtText.Location = new System.Drawing.Point(299, 33);
            this.TextBox_AtText.MaxLength = 5;
            this.TextBox_AtText.Name = "TextBox_AtText";
            this.TextBox_AtText.Size = new System.Drawing.Size(75, 20);
            this.TextBox_AtText.TabIndex = 26;
            this.TextBox_AtText.Text = "0";
            this.TextBox_AtText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_Insert
            // 
            this.Label_Insert.AutoSize = true;
            this.Label_Insert.Location = new System.Drawing.Point(0, 3);
            this.Label_Insert.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.Label_Insert.Name = "Label_Insert";
            this.Label_Insert.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Label_Insert.Size = new System.Drawing.Size(36, 18);
            this.Label_Insert.TabIndex = 2;
            this.Label_Insert.Text = "Insert:";
            // 
            // RadioButton_FromStart
            // 
            this.RadioButton_FromStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RadioButton_FromStart.AutoSize = true;
            this.RadioButton_FromStart.Checked = true;
            this.RadioButton_FromStart.Enabled = false;
            this.RadioButton_FromStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.RadioButton_FromStart.Location = new System.Drawing.Point(380, 10);
            this.RadioButton_FromStart.Name = "RadioButton_FromStart";
            this.RadioButton_FromStart.Size = new System.Drawing.Size(87, 17);
            this.RadioButton_FromStart.TabIndex = 32;
            this.RadioButton_FromStart.TabStop = true;
            this.RadioButton_FromStart.Text = "From START";
            this.RadioButton_FromStart.UseVisualStyleBackColor = true;
            // 
            // Label_AtText
            // 
            this.Label_AtText.AutoSize = true;
            this.Label_AtText.Location = new System.Drawing.Point(299, 3);
            this.Label_AtText.Margin = new System.Windows.Forms.Padding(3);
            this.Label_AtText.Name = "Label_AtText";
            this.Label_AtText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Label_AtText.Size = new System.Drawing.Size(20, 18);
            this.Label_AtText.TabIndex = 24;
            this.Label_AtText.Text = "At:";
            // 
            // RadioButton_FromEnd
            // 
            this.RadioButton_FromEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RadioButton_FromEnd.AutoSize = true;
            this.RadioButton_FromEnd.Enabled = false;
            this.RadioButton_FromEnd.Location = new System.Drawing.Point(380, 41);
            this.RadioButton_FromEnd.Name = "RadioButton_FromEnd";
            this.RadioButton_FromEnd.Size = new System.Drawing.Size(74, 17);
            this.RadioButton_FromEnd.TabIndex = 30;
            this.RadioButton_FromEnd.Text = "From END";
            this.RadioButton_FromEnd.UseVisualStyleBackColor = true;
            // 
            // TablePanel_ReplaceWith
            // 
            this.TablePanel_ReplaceWith.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablePanel_ReplaceWith.ColumnCount = 2;
            this.TablePanel_ReplaceWith.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.TablePanel_ReplaceWith.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.TablePanel_ReplaceWith.Controls.Add(this.TextBox_WithText, 1, 1);
            this.TablePanel_ReplaceWith.Controls.Add(this.TextBox_Replace, 0, 1);
            this.TablePanel_ReplaceWith.Controls.Add(this.Label_WithText, 1, 0);
            this.TablePanel_ReplaceWith.Controls.Add(this.Label_Replace, 0, 0);
            this.TablePanel_ReplaceWith.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.TablePanel_ReplaceWith.Location = new System.Drawing.Point(11, 92);
            this.TablePanel_ReplaceWith.Name = "TablePanel_ReplaceWith";
            this.TablePanel_ReplaceWith.RowCount = 2;
            this.TablePanel_ReplaceWith.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TablePanel_ReplaceWith.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TablePanel_ReplaceWith.Size = new System.Drawing.Size(487, 57);
            this.TablePanel_ReplaceWith.TabIndex = 52;
            // 
            // TextBox_WithText
            // 
            this.TextBox_WithText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_WithText.Enabled = false;
            this.TextBox_WithText.Location = new System.Drawing.Point(248, 28);
            this.TextBox_WithText.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.TextBox_WithText.Name = "TextBox_WithText";
            this.TextBox_WithText.Size = new System.Drawing.Size(239, 20);
            this.TextBox_WithText.TabIndex = 23;
            // 
            // TextBox_Replace
            // 
            this.TextBox_Replace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Replace.Enabled = false;
            this.TextBox_Replace.Location = new System.Drawing.Point(0, 28);
            this.TextBox_Replace.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.TextBox_Replace.Name = "TextBox_Replace";
            this.TextBox_Replace.Size = new System.Drawing.Size(242, 20);
            this.TextBox_Replace.TabIndex = 23;
            // 
            // Label_WithText
            // 
            this.Label_WithText.AutoSize = true;
            this.Label_WithText.Location = new System.Drawing.Point(248, 3);
            this.Label_WithText.Margin = new System.Windows.Forms.Padding(3);
            this.Label_WithText.Name = "Label_WithText";
            this.Label_WithText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Label_WithText.Size = new System.Drawing.Size(32, 18);
            this.Label_WithText.TabIndex = 3;
            this.Label_WithText.Text = "With:";
            // 
            // Label_Replace
            // 
            this.Label_Replace.AutoSize = true;
            this.Label_Replace.Location = new System.Drawing.Point(0, 3);
            this.Label_Replace.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.Label_Replace.Name = "Label_Replace";
            this.Label_Replace.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Label_Replace.Size = new System.Drawing.Size(50, 18);
            this.Label_Replace.TabIndex = 2;
            this.Label_Replace.Text = "Replace:";
            // 
            // CheckBox_IndexingFormat
            // 
            this.CheckBox_IndexingFormat.AutoSize = true;
            this.CheckBox_IndexingFormat.Checked = true;
            this.CheckBox_IndexingFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_IndexingFormat.Location = new System.Drawing.Point(92, 351);
            this.CheckBox_IndexingFormat.Name = "CheckBox_IndexingFormat";
            this.CheckBox_IndexingFormat.Size = new System.Drawing.Size(103, 17);
            this.CheckBox_IndexingFormat.TabIndex = 49;
            this.CheckBox_IndexingFormat.Text = "Format Numbers";
            this.CheckBox_IndexingFormat.UseVisualStyleBackColor = true;
            // 
            // TextBox_IndexingStart
            // 
            this.TextBox_IndexingStart.Location = new System.Drawing.Point(11, 325);
            this.TextBox_IndexingStart.MaxLength = 5;
            this.TextBox_IndexingStart.Name = "TextBox_IndexingStart";
            this.TextBox_IndexingStart.Size = new System.Drawing.Size(75, 20);
            this.TextBox_IndexingStart.TabIndex = 44;
            this.TextBox_IndexingStart.Text = "1";
            this.TextBox_IndexingStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextBox_IndexingLength
            // 
            this.TextBox_IndexingLength.Location = new System.Drawing.Point(92, 325);
            this.TextBox_IndexingLength.MaxLength = 5;
            this.TextBox_IndexingLength.Name = "TextBox_IndexingLength";
            this.TextBox_IndexingLength.Size = new System.Drawing.Size(75, 20);
            this.TextBox_IndexingLength.TabIndex = 47;
            this.TextBox_IndexingLength.Text = "3";
            this.TextBox_IndexingLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Button_ResetRename
            // 
            this.Button_ResetRename.BackColor = System.Drawing.Color.White;
            this.Button_ResetRename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ResetRename.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.Button_ResetRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ResetRename.Location = new System.Drawing.Point(11, 424);
            this.Button_ResetRename.MaximumSize = new System.Drawing.Size(100, 100);
            this.Button_ResetRename.Name = "Button_ResetRename";
            this.Button_ResetRename.Size = new System.Drawing.Size(100, 25);
            this.Button_ResetRename.TabIndex = 48;
            this.Button_ResetRename.Text = "Reset";
            this.Button_ResetRename.UseVisualStyleBackColor = false;
            this.Button_ResetRename.Click += new System.EventHandler(this.Button_ResetRename_Click);
            // 
            // Label_IndexingLength
            // 
            this.Label_IndexingLength.AutoSize = true;
            this.Label_IndexingLength.Location = new System.Drawing.Point(92, 298);
            this.Label_IndexingLength.Margin = new System.Windows.Forms.Padding(3);
            this.Label_IndexingLength.Name = "Label_IndexingLength";
            this.Label_IndexingLength.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Label_IndexingLength.Size = new System.Drawing.Size(72, 18);
            this.Label_IndexingLength.TabIndex = 32;
            this.Label_IndexingLength.Text = "Index Length:";
            // 
            // Label_IndexingStart
            // 
            this.Label_IndexingStart.AutoSize = true;
            this.Label_IndexingStart.Location = new System.Drawing.Point(11, 298);
            this.Label_IndexingStart.Margin = new System.Windows.Forms.Padding(3);
            this.Label_IndexingStart.Name = "Label_IndexingStart";
            this.Label_IndexingStart.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Label_IndexingStart.Size = new System.Drawing.Size(61, 18);
            this.Label_IndexingStart.TabIndex = 42;
            this.Label_IndexingStart.Text = "Start Index:";
            // 
            // Button_ApplyRename
            // 
            this.Button_ApplyRename.BackColor = System.Drawing.Color.White;
            this.Button_ApplyRename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ApplyRename.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.Button_ApplyRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ApplyRename.Location = new System.Drawing.Point(11, 383);
            this.Button_ApplyRename.MaximumSize = new System.Drawing.Size(150, 100);
            this.Button_ApplyRename.Name = "Button_ApplyRename";
            this.Button_ApplyRename.Size = new System.Drawing.Size(150, 35);
            this.Button_ApplyRename.TabIndex = 46;
            this.Button_ApplyRename.Text = "Apply Changes";
            this.Button_ApplyRename.UseVisualStyleBackColor = false;
            this.Button_ApplyRename.Click += new System.EventHandler(this.Button_ApplyRename_Click);
            // 
            // CheckBox_IndexingPrefix
            // 
            this.CheckBox_IndexingPrefix.AutoSize = true;
            this.CheckBox_IndexingPrefix.Location = new System.Drawing.Point(11, 272);
            this.CheckBox_IndexingPrefix.Name = "CheckBox_IndexingPrefix";
            this.CheckBox_IndexingPrefix.Size = new System.Drawing.Size(52, 17);
            this.CheckBox_IndexingPrefix.TabIndex = 35;
            this.CheckBox_IndexingPrefix.Text = "Prefix";
            this.CheckBox_IndexingPrefix.UseVisualStyleBackColor = true;
            // 
            // CheckBox_IndexingEnabled
            // 
            this.CheckBox_IndexingEnabled.AutoSize = true;
            this.CheckBox_IndexingEnabled.Checked = true;
            this.CheckBox_IndexingEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_IndexingEnabled.Location = new System.Drawing.Point(11, 246);
            this.CheckBox_IndexingEnabled.Name = "CheckBox_IndexingEnabled";
            this.CheckBox_IndexingEnabled.Size = new System.Drawing.Size(65, 17);
            this.CheckBox_IndexingEnabled.TabIndex = 33;
            this.CheckBox_IndexingEnabled.Text = "Enabled";
            this.CheckBox_IndexingEnabled.UseVisualStyleBackColor = true;
            this.CheckBox_IndexingEnabled.CheckedChanged += new System.EventHandler(this.CheckBox_IndexingEnabled_CheckedChanged);
            // 
            // Label_Indexing
            // 
            this.Label_Indexing.AutoSize = true;
            this.Label_Indexing.Location = new System.Drawing.Point(11, 219);
            this.Label_Indexing.Margin = new System.Windows.Forms.Padding(3);
            this.Label_Indexing.Name = "Label_Indexing";
            this.Label_Indexing.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Label_Indexing.Size = new System.Drawing.Size(50, 18);
            this.Label_Indexing.TabIndex = 31;
            this.Label_Indexing.Text = "Indexing:";
            // 
            // CheckBox_OriginalName
            // 
            this.CheckBox_OriginalName.AutoSize = true;
            this.CheckBox_OriginalName.Location = new System.Drawing.Point(11, 70);
            this.CheckBox_OriginalName.Name = "CheckBox_OriginalName";
            this.CheckBox_OriginalName.Size = new System.Drawing.Size(125, 17);
            this.CheckBox_OriginalName.TabIndex = 24;
            this.CheckBox_OriginalName.Text = "Edit original file name";
            this.CheckBox_OriginalName.UseVisualStyleBackColor = true;
            this.CheckBox_OriginalName.CheckedChanged += new System.EventHandler(this.CheckBox_OriginalName_CheckedChanged);
            // 
            // TextBox_NewFileName
            // 
            this.TextBox_NewFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_NewFileName.Location = new System.Drawing.Point(11, 38);
            this.TextBox_NewFileName.Name = "TextBox_NewFileName";
            this.TextBox_NewFileName.Size = new System.Drawing.Size(487, 20);
            this.TextBox_NewFileName.TabIndex = 22;
            // 
            // Label_FileName
            // 
            this.Label_FileName.AutoSize = true;
            this.Label_FileName.Location = new System.Drawing.Point(11, 11);
            this.Label_FileName.Margin = new System.Windows.Forms.Padding(3);
            this.Label_FileName.Name = "Label_FileName";
            this.Label_FileName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Label_FileName.Size = new System.Drawing.Size(82, 18);
            this.Label_FileName.TabIndex = 1;
            this.Label_FileName.Text = "New File Name:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.tabPage3.Controls.Add(this.CheckBox_OutputCopy);
            this.tabPage3.Controls.Add(this.Panel_OutputDirectory_Container);
            this.tabPage3.Controls.Add(this.Label_OutputDirectory);
            this.tabPage3.Location = new System.Drawing.Point(0, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(8);
            this.tabPage3.Size = new System.Drawing.Size(503, 476);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Output";
            // 
            // CheckBox_OutputCopy
            // 
            this.CheckBox_OutputCopy.AutoSize = true;
            this.CheckBox_OutputCopy.Location = new System.Drawing.Point(11, 72);
            this.CheckBox_OutputCopy.Name = "CheckBox_OutputCopy";
            this.CheckBox_OutputCopy.Size = new System.Drawing.Size(79, 17);
            this.CheckBox_OutputCopy.TabIndex = 33;
            this.CheckBox_OutputCopy.Text = "Make copy";
            this.CheckBox_OutputCopy.UseVisualStyleBackColor = true;
            // 
            // Panel_OutputDirectory_Container
            // 
            this.Panel_OutputDirectory_Container.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_OutputDirectory_Container.BackColor = System.Drawing.Color.White;
            this.Panel_OutputDirectory_Container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_OutputDirectory_Container.Controls.Add(this.Button_OutputDirectory);
            this.Panel_OutputDirectory_Container.Controls.Add(this.TextBox_OutputDirectory);
            this.Panel_OutputDirectory_Container.Location = new System.Drawing.Point(11, 38);
            this.Panel_OutputDirectory_Container.Name = "Panel_OutputDirectory_Container";
            this.Panel_OutputDirectory_Container.Padding = new System.Windows.Forms.Padding(3);
            this.Panel_OutputDirectory_Container.Size = new System.Drawing.Size(480, 28);
            this.Panel_OutputDirectory_Container.TabIndex = 31;
            // 
            // Button_OutputDirectory
            // 
            this.Button_OutputDirectory.BackColor = System.Drawing.Color.White;
            this.Button_OutputDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_OutputDirectory.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button_OutputDirectory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button_OutputDirectory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Button_OutputDirectory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Button_OutputDirectory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button_OutputDirectory.ForeColor = System.Drawing.Color.Black;
            this.Button_OutputDirectory.Location = new System.Drawing.Point(440, 3);
            this.Button_OutputDirectory.Name = "Button_OutputDirectory";
            this.Button_OutputDirectory.Size = new System.Drawing.Size(35, 20);
            this.Button_OutputDirectory.TabIndex = 1;
            this.Button_OutputDirectory.Text = "...";
            this.Button_OutputDirectory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_OutputDirectory.UseVisualStyleBackColor = false;
            this.Button_OutputDirectory.Click += new System.EventHandler(this.Button_OutputDirectory_Click);
            // 
            // TextBox_OutputDirectory
            // 
            this.TextBox_OutputDirectory.BackColor = System.Drawing.Color.White;
            this.TextBox_OutputDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_OutputDirectory.Location = new System.Drawing.Point(3, 6);
            this.TextBox_OutputDirectory.Name = "TextBox_OutputDirectory";
            this.TextBox_OutputDirectory.ReadOnly = true;
            this.TextBox_OutputDirectory.Size = new System.Drawing.Size(431, 13);
            this.TextBox_OutputDirectory.TabIndex = 0;
            // 
            // Label_OutputDirectory
            // 
            this.Label_OutputDirectory.AutoSize = true;
            this.Label_OutputDirectory.Location = new System.Drawing.Point(11, 11);
            this.Label_OutputDirectory.Margin = new System.Windows.Forms.Padding(3);
            this.Label_OutputDirectory.Name = "Label_OutputDirectory";
            this.Label_OutputDirectory.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Label_OutputDirectory.Size = new System.Drawing.Size(87, 18);
            this.Label_OutputDirectory.TabIndex = 2;
            this.Label_OutputDirectory.Text = "Output Directory:";
            // 
            // Button_Rename
            // 
            this.Button_Rename.BackColor = System.Drawing.Color.White;
            this.Button_Rename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Rename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Rename.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.Button_Rename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Rename.Location = new System.Drawing.Point(3, 3);
            this.Button_Rename.Name = "Button_Rename";
            this.Button_Rename.Size = new System.Drawing.Size(497, 27);
            this.Button_Rename.TabIndex = 47;
            this.Button_Rename.Text = "Rename";
            this.Button_Rename.UseVisualStyleBackColor = false;
            this.Button_Rename.Click += new System.EventHandler(this.Button_Rename_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bulk File Namer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.Panel_Directory_Container.ResumeLayout(false);
            this.Panel_Directory_Container.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Files)).EndInit();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.TablePanel_Insert.ResumeLayout(false);
            this.TablePanel_Insert.PerformLayout();
            this.TablePanel_ReplaceWith.ResumeLayout(false);
            this.TablePanel_ReplaceWith.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.Panel_OutputDirectory_Container.ResumeLayout(false);
            this.Panel_OutputDirectory_Container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel Panel_Directory_Container;
        private System.Windows.Forms.Button Button_Directory;
        private System.Windows.Forms.TextBox TextBox_Directory;
        private main.controls.BorderedLabel Label_Output;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private BorderlessTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Button_ApplyFilterSort;
        private System.Windows.Forms.CheckBox CheckBox_SortAscending;
        private System.Windows.Forms.Button Button_Sort_Down;
        private System.Windows.Forms.Button Button_Sort_Up;
        private System.Windows.Forms.ListBox ListBox_Sort;
        private BorderedLabel Label_Sort;
        private System.Windows.Forms.TextBox TextBox_Extension;
        private BorderedLabel Label_Extension;
        private System.Windows.Forms.TextBox TextBox_Contains;
        private BorderedLabel Label_Contains;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Button_ResetRename;
        private System.Windows.Forms.Button Button_ApplyRename;
        private System.Windows.Forms.TextBox TextBox_IndexingStart;
        private BorderedLabel Label_IndexingStart;
        private System.Windows.Forms.CheckBox CheckBox_IndexingFormat;
        private System.Windows.Forms.TextBox TextBox_IndexingLength;
        private BorderedLabel Label_IndexingLength;
        private System.Windows.Forms.CheckBox CheckBox_IndexingPrefix;
        private System.Windows.Forms.CheckBox CheckBox_IndexingEnabled;
        private BorderedLabel Label_Indexing;
        private System.Windows.Forms.TextBox TextBox_Insert;
        private BorderedLabel Label_Insert;
        private System.Windows.Forms.TextBox TextBox_AtText;
        private BorderedLabel Label_AtText;
        private System.Windows.Forms.RadioButton RadioButton_FromStart;
        private System.Windows.Forms.RadioButton RadioButton_FromEnd;
        private System.Windows.Forms.TextBox TextBox_Replace;
        private BorderedLabel Label_Replace;
        private System.Windows.Forms.TextBox TextBox_WithText;
        private BorderedLabel Label_WithText;
        private System.Windows.Forms.CheckBox CheckBox_OriginalName;
        private System.Windows.Forms.TextBox TextBox_NewFileName;
        private BorderedLabel Label_FileName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox CheckBox_OutputCopy;
        private System.Windows.Forms.Panel Panel_OutputDirectory_Container;
        private System.Windows.Forms.Button Button_OutputDirectory;
        private System.Windows.Forms.TextBox TextBox_OutputDirectory;
        private BorderedLabel Label_OutputDirectory;
        private System.Windows.Forms.Button Button_Rename;
        private System.Windows.Forms.TableLayoutPanel TablePanel_ReplaceWith;
        private System.Windows.Forms.TableLayoutPanel TablePanel_Insert;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private BorderedLabel Label_Directory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DataGridView_Files;
    }
}

