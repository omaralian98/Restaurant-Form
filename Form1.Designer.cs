namespace Restaurant_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            SeedDate = new Button();
            CreateTable = new Button();
            Edit = new Button();
            Delete = new Button();
            Add = new Button();
            Tables = new ComboBox();
            Records = new Label();
            DataViewer = new DataGridView();
            ((ISupportInitialize)DataViewer).BeginInit();
            SuspendLayout();
            // 
            // SeedDate
            // 
            SeedDate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SeedDate.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            SeedDate.Location = new Point(1, 798);
            SeedDate.Name = "SeedDate";
            SeedDate.Size = new Size(149, 38);
            SeedDate.TabIndex = 0;
            SeedDate.Text = "Seed Data";
            SeedDate.UseVisualStyleBackColor = true;
            SeedDate.Click += Seed_Click;
            // 
            // CreateTable
            // 
            CreateTable.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CreateTable.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            CreateTable.Location = new Point(156, 798);
            CreateTable.Name = "CreateTable";
            CreateTable.Size = new Size(149, 38);
            CreateTable.TabIndex = 1;
            CreateTable.Text = "Create Tables";
            CreateTable.UseVisualStyleBackColor = true;
            CreateTable.Click += CreateTable_Click;
            // 
            // Edit
            // 
            Edit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Edit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Edit.Location = new Point(884, 798);
            Edit.Name = "Edit";
            Edit.Size = new Size(100, 38);
            Edit.TabIndex = 17;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // Delete
            // 
            Delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Delete.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.Location = new Point(990, 798);
            Delete.Name = "Delete";
            Delete.Size = new Size(100, 38);
            Delete.TabIndex = 16;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Add
            // 
            Add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Add.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.Location = new Point(777, 798);
            Add.Name = "Add";
            Add.Size = new Size(101, 38);
            Add.TabIndex = 15;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Tables
            // 
            Tables.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Tables.BackColor = Color.Indigo;
            Tables.DrawMode = DrawMode.OwnerDrawFixed;
            Tables.DropDownStyle = ComboBoxStyle.DropDownList;
            Tables.FlatStyle = FlatStyle.Flat;
            Tables.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tables.ForeColor = Color.White;
            Tables.FormattingEnabled = true;
            Tables.Location = new Point(763, 0);
            Tables.Name = "Tables";
            Tables.Size = new Size(331, 47);
            Tables.TabIndex = 13;
            Tables.DrawItem += Tables_DrawItem;
            Tables.SelectedIndexChanged += Tables_SelectedIndexChanged;
            // 
            // Records
            // 
            Records.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Records.AutoSize = true;
            Records.BackColor = Color.Indigo;
            Records.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Records.ForeColor = Color.White;
            Records.Location = new Point(1, 0);
            Records.Name = "Records";
            Records.Padding = new Padding(0, 8, 1500, 8);
            Records.Size = new Size(1713, 48);
            Records.TabIndex = 18;
            Records.Text = "No Table Records";
            // 
            // DataViewer
            // 
            DataViewer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataViewer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataViewer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataViewer.BackgroundColor = Color.FromArgb(45, 66, 91);
            DataViewer.BorderStyle = BorderStyle.None;
            DataViewer.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            DataViewer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataViewer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataViewer.ColumnHeadersHeight = 30;
            DataViewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataViewer.DefaultCellStyle = dataGridViewCellStyle2;
            DataViewer.EnableHeadersVisualStyles = false;
            DataViewer.GridColor = Color.SteelBlue;
            DataViewer.Location = new Point(12, 68);
            DataViewer.Name = "DataViewer";
            DataViewer.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.PaleVioletRed;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DataViewer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DataViewer.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            DataViewer.RowsDefaultCellStyle = dataGridViewCellStyle4;
            DataViewer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataViewer.ShowEditingIcon = false;
            DataViewer.Size = new Size(1068, 652);
            DataViewer.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(1092, 839);
            Controls.Add(DataViewer);
            Controls.Add(Tables);
            Controls.Add(Records);
            Controls.Add(SeedDate);
            Controls.Add(CreateTable);
            Controls.Add(Add);
            Controls.Add(Edit);
            Controls.Add(Delete);
            HelpButton = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((ISupportInitialize)DataViewer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SeedDate;
        private Button CreateTable;
        private ComboBox Tables;
        private Button Edit;
        private Button Delete;
        private Button Add;
        private Label Records;
        private DataGridView DataViewer;
    }
}
