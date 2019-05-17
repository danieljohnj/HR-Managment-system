namespace HR_Management_System
{
    partial class Job_title
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label emp_idLabel;
            System.Windows.Forms.Label job_titleLabel;
            System.Windows.Forms.Label from_dateLabel;
            System.Windows.Forms.Label to_dateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Job_title));
            this.emp_Data = new HR_Management_System.Emp_Data();
            this.job_titlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.job_titlesTableAdapter = new HR_Management_System.Emp_DataTableAdapters.Job_titlesTableAdapter();
            this.tableAdapterManager = new HR_Management_System.Emp_DataTableAdapters.TableAdapterManager();
            this.job_titlesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.job_titlesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.emp_idTextBox = new System.Windows.Forms.TextBox();
            this.from_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.to_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.job_titlesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            emp_idLabel = new System.Windows.Forms.Label();
            job_titleLabel = new System.Windows.Forms.Label();
            from_dateLabel = new System.Windows.Forms.Label();
            to_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.emp_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.job_titlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.job_titlesBindingNavigator)).BeginInit();
            this.job_titlesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.job_titlesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // emp_idLabel
            // 
            emp_idLabel.AutoSize = true;
            emp_idLabel.Location = new System.Drawing.Point(63, 63);
            emp_idLabel.Name = "emp_idLabel";
            emp_idLabel.Size = new System.Drawing.Size(42, 13);
            emp_idLabel.TabIndex = 1;
            emp_idLabel.Text = "Emp id:";
            // 
            // job_titleLabel
            // 
            job_titleLabel.AutoSize = true;
            job_titleLabel.Location = new System.Drawing.Point(63, 89);
            job_titleLabel.Name = "job_titleLabel";
            job_titleLabel.Size = new System.Drawing.Size(46, 13);
            job_titleLabel.TabIndex = 3;
            job_titleLabel.Text = "Job title:";
            // 
            // from_dateLabel
            // 
            from_dateLabel.AutoSize = true;
            from_dateLabel.Location = new System.Drawing.Point(63, 116);
            from_dateLabel.Name = "from_dateLabel";
            from_dateLabel.Size = new System.Drawing.Size(57, 13);
            from_dateLabel.TabIndex = 5;
            from_dateLabel.Text = "From date:";
            // 
            // to_dateLabel
            // 
            to_dateLabel.AutoSize = true;
            to_dateLabel.Location = new System.Drawing.Point(63, 142);
            to_dateLabel.Name = "to_dateLabel";
            to_dateLabel.Size = new System.Drawing.Size(47, 13);
            to_dateLabel.TabIndex = 7;
            to_dateLabel.Text = "To date:";
            // 
            // emp_Data
            // 
            this.emp_Data.DataSetName = "Emp_Data";
            this.emp_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // job_titlesBindingSource
            // 
            this.job_titlesBindingSource.DataMember = "Job_titles";
            this.job_titlesBindingSource.DataSource = this.emp_Data;
            // 
            // job_titlesTableAdapter
            // 
            this.job_titlesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Branch_infoTableAdapter = null;
            this.tableAdapterManager.Department_infoTableAdapter = null;
            this.tableAdapterManager.Department_managerTableAdapter = null;
            this.tableAdapterManager.departmentsTableAdapter = null;
            this.tableAdapterManager.Employee_infoTableAdapter = null;
            this.tableAdapterManager.Job_titlesTableAdapter = this.job_titlesTableAdapter;
            this.tableAdapterManager.SalaryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HR_Management_System.Emp_DataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // job_titlesBindingNavigator
            // 
            this.job_titlesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.job_titlesBindingNavigator.BindingSource = this.job_titlesBindingSource;
            this.job_titlesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.job_titlesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.job_titlesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.job_titlesBindingNavigatorSaveItem});
            this.job_titlesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.job_titlesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.job_titlesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.job_titlesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.job_titlesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.job_titlesBindingNavigator.Name = "job_titlesBindingNavigator";
            this.job_titlesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.job_titlesBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.job_titlesBindingNavigator.TabIndex = 0;
            this.job_titlesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // job_titlesBindingNavigatorSaveItem
            // 
            this.job_titlesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.job_titlesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("job_titlesBindingNavigatorSaveItem.Image")));
            this.job_titlesBindingNavigatorSaveItem.Name = "job_titlesBindingNavigatorSaveItem";
            this.job_titlesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.job_titlesBindingNavigatorSaveItem.Text = "Save Data";
            this.job_titlesBindingNavigatorSaveItem.Click += new System.EventHandler(this.job_titlesBindingNavigatorSaveItem_Click);
            // 
            // emp_idTextBox
            // 
            this.emp_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.job_titlesBindingSource, "Emp_id", true));
            this.emp_idTextBox.Location = new System.Drawing.Point(126, 60);
            this.emp_idTextBox.Name = "emp_idTextBox";
            this.emp_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.emp_idTextBox.TabIndex = 2;
            // 
            // from_dateDateTimePicker
            // 
            this.from_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.job_titlesBindingSource, "From_date", true));
            this.from_dateDateTimePicker.Location = new System.Drawing.Point(126, 112);
            this.from_dateDateTimePicker.Name = "from_dateDateTimePicker";
            this.from_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.from_dateDateTimePicker.TabIndex = 6;
            // 
            // to_dateDateTimePicker
            // 
            this.to_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.job_titlesBindingSource, "To_date", true));
            this.to_dateDateTimePicker.Location = new System.Drawing.Point(126, 138);
            this.to_dateDateTimePicker.Name = "to_dateDateTimePicker";
            this.to_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.to_dateDateTimePicker.TabIndex = 8;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(506, 341);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 37;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.Location = new System.Drawing.Point(614, 336);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(75, 23);
            this.btn_Previous.TabIndex = 36;
            this.btn_Previous.Text = "Previous";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(594, 167);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 35;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(594, 292);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 34;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(594, 118);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 33;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(704, 336);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 32;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(594, 245);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 31;
            this.btn_Clear.Text = "Cear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(594, 78);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 30;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(594, 202);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 29;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // job_titlesDataGridView
            // 
            this.job_titlesDataGridView.AutoGenerateColumns = false;
            this.job_titlesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.job_titlesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.job_titlesDataGridView.DataSource = this.job_titlesBindingSource;
            this.job_titlesDataGridView.Location = new System.Drawing.Point(46, 180);
            this.job_titlesDataGridView.Name = "job_titlesDataGridView";
            this.job_titlesDataGridView.Size = new System.Drawing.Size(444, 220);
            this.job_titlesDataGridView.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Emp_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Emp_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Job_title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Job_title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "From_date";
            this.dataGridViewTextBoxColumn3.HeaderText = "From_date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "To_date";
            this.dataGridViewTextBoxColumn4.HeaderText = "To_date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Maintenance Technician",
            "Production Worker",
            "Production Supervisor",
            "Maintenance Supervisor",
            "Qualtiy Assurance Technician",
            "Quality Assurance Supervisor",
            "Plant Manager",
            "CEO",
            "CFO",
            "Customer Service Clerk",
            "Accountant Supervisor",
            "Accountant",
            "IT Technician",
            "IT Manager",
            "Maintainance Manager",
            "HR Manager",
            "Director"});
            this.comboBox1.Location = new System.Drawing.Point(126, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 38;
            // 
            // Job_title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.job_titlesDataGridView);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Previous);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(emp_idLabel);
            this.Controls.Add(this.emp_idTextBox);
            this.Controls.Add(job_titleLabel);
            this.Controls.Add(from_dateLabel);
            this.Controls.Add(this.from_dateDateTimePicker);
            this.Controls.Add(to_dateLabel);
            this.Controls.Add(this.to_dateDateTimePicker);
            this.Controls.Add(this.job_titlesBindingNavigator);
            this.Name = "Job_title";
            this.Text = "Job_title";
            this.Load += new System.EventHandler(this.Job_title_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emp_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.job_titlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.job_titlesBindingNavigator)).EndInit();
            this.job_titlesBindingNavigator.ResumeLayout(false);
            this.job_titlesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.job_titlesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emp_Data emp_Data;
        private System.Windows.Forms.BindingSource job_titlesBindingSource;
        private Emp_DataTableAdapters.Job_titlesTableAdapter job_titlesTableAdapter;
        private Emp_DataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator job_titlesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton job_titlesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox emp_idTextBox;
        private System.Windows.Forms.DateTimePicker from_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker to_dateDateTimePicker;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridView job_titlesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}