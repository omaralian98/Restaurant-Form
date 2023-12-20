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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            Records = new Label();
            DataViewer = new DataGridView();
            SeedData = new CustomButton();
            CreateTable = new CustomButton();
            Add = new CustomButton();
            Edit = new CustomButton();
            Delete = new CustomButton();
            Tables = new CustomComboBox();
            Info = new CustomButton();
            More = new CustomButton();
            HighestPaymentSupplier = new CustomButton();
            EmployeeOrders = new CustomButton();
            Less = new CustomButton();
            ((ISupportInitialize)DataViewer).BeginInit();
            SuspendLayout();
            // 
            // Records
            // 
            Records.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Records.AutoSize = true;
            Records.BackColor = Color.Navy;
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
            DataViewer.Location = new Point(12, 54);
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
            DataViewer.Size = new Size(1068, 693);
            DataViewer.TabIndex = 19;
            // 
            // SeedData
            // 
            SeedData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SeedData.BackColor = Color.Navy;
            SeedData.BackgroundColor = Color.Navy;
            SeedData.BorderColor = Color.Cyan;
            SeedData.BorderRadius = 10;
            SeedData.BorderSize = 2;
            SeedData.Cursor = Cursors.Hand;
            SeedData.FlatAppearance.BorderSize = 0;
            SeedData.FlatStyle = FlatStyle.Flat;
            SeedData.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SeedData.ForeColor = Color.Cyan;
            SeedData.Location = new Point(1, 796);
            SeedData.Name = "SeedData";
            SeedData.Size = new Size(149, 40);
            SeedData.TabIndex = 20;
            SeedData.Text = "Seed Data";
            SeedData.TextColor = Color.Cyan;
            SeedData.UseVisualStyleBackColor = false;
            SeedData.Click += SeedData_Click;
            // 
            // CreateTable
            // 
            CreateTable.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CreateTable.BackColor = Color.Navy;
            CreateTable.BackgroundColor = Color.Navy;
            CreateTable.BorderColor = Color.Cyan;
            CreateTable.BorderRadius = 10;
            CreateTable.BorderSize = 2;
            CreateTable.Cursor = Cursors.Hand;
            CreateTable.FlatAppearance.BorderSize = 0;
            CreateTable.FlatStyle = FlatStyle.Flat;
            CreateTable.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateTable.ForeColor = Color.Cyan;
            CreateTable.Location = new Point(156, 797);
            CreateTable.Name = "CreateTable";
            CreateTable.Size = new Size(160, 40);
            CreateTable.TabIndex = 21;
            CreateTable.Text = "Create Tables";
            CreateTable.TextColor = Color.Cyan;
            CreateTable.UseVisualStyleBackColor = false;
            CreateTable.Click += CreateTable_Click;
            // 
            // Add
            // 
            Add.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Add.BackColor = Color.Navy;
            Add.BackgroundColor = Color.Navy;
            Add.BorderColor = Color.Cyan;
            Add.BorderRadius = 10;
            Add.BorderSize = 2;
            Add.Cursor = Cursors.Hand;
            Add.FlatAppearance.BorderSize = 0;
            Add.FlatStyle = FlatStyle.Flat;
            Add.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.ForeColor = Color.Cyan;
            Add.Location = new Point(1, 753);
            Add.Name = "Add";
            Add.Size = new Size(101, 40);
            Add.TabIndex = 23;
            Add.Text = "Add";
            Add.TextColor = Color.Cyan;
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Edit
            // 
            Edit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Edit.BackColor = Color.Navy;
            Edit.BackgroundColor = Color.Navy;
            Edit.BorderColor = Color.Cyan;
            Edit.BorderRadius = 10;
            Edit.BorderSize = 2;
            Edit.Cursor = Cursors.Hand;
            Edit.FlatAppearance.BorderSize = 0;
            Edit.FlatStyle = FlatStyle.Flat;
            Edit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Edit.ForeColor = Color.Cyan;
            Edit.Location = new Point(108, 753);
            Edit.Name = "Edit";
            Edit.Size = new Size(101, 40);
            Edit.TabIndex = 24;
            Edit.Text = "Edit";
            Edit.TextColor = Color.Cyan;
            Edit.UseVisualStyleBackColor = false;
            Edit.Click += Edit_Click;
            // 
            // Delete
            // 
            Delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Delete.BackColor = Color.Navy;
            Delete.BackgroundColor = Color.Navy;
            Delete.BorderColor = Color.Cyan;
            Delete.BorderRadius = 10;
            Delete.BorderSize = 2;
            Delete.Cursor = Cursors.Hand;
            Delete.FlatAppearance.BorderSize = 0;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.ForeColor = Color.Cyan;
            Delete.Location = new Point(215, 753);
            Delete.Name = "Delete";
            Delete.Size = new Size(101, 40);
            Delete.TabIndex = 25;
            Delete.Text = "Delete";
            Delete.TextColor = Color.Cyan;
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // Tables
            // 
            Tables.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Tables.BackColor = Color.Navy;
            Tables.BorderColor = Color.LightSkyBlue;
            Tables.BorderSize = 1;
            Tables.Cursor = Cursors.Hand;
            Tables.DropDownStyle = ComboBoxStyle.DropDownList;
            Tables.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tables.ForeColor = Color.White;
            Tables.IconColor = Color.Violet;
            Tables.ListBackColor = Color.Navy;
            Tables.ListTextColor = Color.White;
            Tables.Location = new Point(825, 0);
            Tables.MinimumSize = new Size(200, 30);
            Tables.Name = "Tables";
            Tables.Padding = new Padding(1);
            Tables.Size = new Size(267, 47);
            Tables.TabIndex = 26;
            Tables.Texts = "";
            Tables.OnSelectedIndexChanged += Tables_SelectedIndexChanged;
            // 
            // Info
            // 
            Info.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Info.BackColor = Color.MediumSlateBlue;
            Info.BackgroundColor = Color.MediumSlateBlue;
            Info.BackgroundImage = Properties.Resources.Info;
            Info.BackgroundImageLayout = ImageLayout.Zoom;
            Info.BorderColor = Color.PaleVioletRed;
            Info.BorderRadius = 20;
            Info.BorderSize = 0;
            Info.Cursor = Cursors.Hand;
            Info.FlatAppearance.BorderSize = 0;
            Info.FlatStyle = FlatStyle.Flat;
            Info.ForeColor = Color.White;
            Info.Location = new Point(1057, 803);
            Info.Name = "Info";
            Info.Size = new Size(35, 35);
            Info.TabIndex = 27;
            Info.TextColor = Color.White;
            Info.UseVisualStyleBackColor = false;
            Info.Click += Info_Click;
            // 
            // More
            // 
            More.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            More.BackColor = Color.Transparent;
            More.BackgroundColor = Color.Transparent;
            More.BackgroundImage = Properties.Resources.Right;
            More.BackgroundImageLayout = ImageLayout.Zoom;
            More.BorderColor = Color.Transparent;
            More.BorderRadius = 10;
            More.BorderSize = 2;
            More.Cursor = Cursors.Hand;
            More.FlatAppearance.BorderSize = 0;
            More.FlatStyle = FlatStyle.Flat;
            More.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            More.ForeColor = Color.Cyan;
            More.Location = new Point(322, 797);
            More.Name = "More";
            More.Size = new Size(56, 39);
            More.TabIndex = 28;
            More.TextColor = Color.Cyan;
            More.UseVisualStyleBackColor = false;
            More.Click += More_Click;
            // 
            // HighestPaymentSupplier
            // 
            HighestPaymentSupplier.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            HighestPaymentSupplier.BackColor = Color.Navy;
            HighestPaymentSupplier.BackgroundColor = Color.Navy;
            HighestPaymentSupplier.BorderColor = Color.Cyan;
            HighestPaymentSupplier.BorderRadius = 10;
            HighestPaymentSupplier.BorderSize = 2;
            HighestPaymentSupplier.Cursor = Cursors.Hand;
            HighestPaymentSupplier.FlatAppearance.BorderSize = 0;
            HighestPaymentSupplier.FlatStyle = FlatStyle.Flat;
            HighestPaymentSupplier.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HighestPaymentSupplier.ForeColor = Color.Cyan;
            HighestPaymentSupplier.Location = new Point(322, 797);
            HighestPaymentSupplier.Name = "HighestPaymentSupplier";
            HighestPaymentSupplier.Size = new Size(266, 40);
            HighestPaymentSupplier.TabIndex = 29;
            HighestPaymentSupplier.Text = "HighestPaymentSupplier";
            HighestPaymentSupplier.TextColor = Color.Cyan;
            HighestPaymentSupplier.UseVisualStyleBackColor = false;
            HighestPaymentSupplier.Visible = false;
            HighestPaymentSupplier.Click += HighestPaymentSupplier_Click;
            // 
            // EmployeeOrders
            // 
            EmployeeOrders.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EmployeeOrders.BackColor = Color.Navy;
            EmployeeOrders.BackgroundColor = Color.Navy;
            EmployeeOrders.BorderColor = Color.Cyan;
            EmployeeOrders.BorderRadius = 10;
            EmployeeOrders.BorderSize = 2;
            EmployeeOrders.Cursor = Cursors.Hand;
            EmployeeOrders.FlatAppearance.BorderSize = 0;
            EmployeeOrders.FlatStyle = FlatStyle.Flat;
            EmployeeOrders.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeeOrders.ForeColor = Color.Cyan;
            EmployeeOrders.Location = new Point(594, 798);
            EmployeeOrders.Name = "EmployeeOrders";
            EmployeeOrders.Size = new Size(186, 40);
            EmployeeOrders.TabIndex = 30;
            EmployeeOrders.Text = "EmployeeOrders";
            EmployeeOrders.TextColor = Color.Cyan;
            EmployeeOrders.UseVisualStyleBackColor = false;
            EmployeeOrders.Visible = false;
            EmployeeOrders.Click += EmployeeOrders_Click;
            // 
            // Less
            // 
            Less.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Less.BackColor = Color.Transparent;
            Less.BackgroundColor = Color.Transparent;
            Less.BackgroundImage = Properties.Resources.Left;
            Less.BackgroundImageLayout = ImageLayout.Zoom;
            Less.BorderColor = Color.Transparent;
            Less.BorderRadius = 10;
            Less.BorderSize = 2;
            Less.Cursor = Cursors.Hand;
            Less.FlatAppearance.BorderSize = 0;
            Less.FlatStyle = FlatStyle.Flat;
            Less.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Less.ForeColor = Color.Cyan;
            Less.Location = new Point(786, 799);
            Less.Name = "Less";
            Less.Size = new Size(56, 39);
            Less.TabIndex = 31;
            Less.TextColor = Color.Cyan;
            Less.UseVisualStyleBackColor = false;
            Less.Visible = false;
            Less.Click += Less_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(1092, 839);
            Controls.Add(Less);
            Controls.Add(EmployeeOrders);
            Controls.Add(More);
            Controls.Add(Info);
            Controls.Add(Tables);
            Controls.Add(Delete);
            Controls.Add(Edit);
            Controls.Add(Add);
            Controls.Add(CreateTable);
            Controls.Add(SeedData);
            Controls.Add(DataViewer);
            Controls.Add(Records);
            Controls.Add(HighestPaymentSupplier);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Restaurant Managment App";
            Load += Form1_Load;
            ((ISupportInitialize)DataViewer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Tables_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label Records;
        private DataGridView DataViewer;
        private CustomButton SeedData;
        private CustomButton CreateTable;
        private CustomButton Add;
        private CustomButton Edit;
        private CustomButton Delete;
        private CustomComboBox Tables;
        private CustomButton Info;
        private CustomButton More;
        private CustomButton HighestPaymentSupplier;
        private CustomButton EmployeeOrders;
        private CustomButton Less;
    }
}
