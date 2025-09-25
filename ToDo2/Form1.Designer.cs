namespace ToDo2
{
    partial class ToDoList
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
            Title = new Label();
            titleTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            titleLabel = new Label();
            descriptionLabel = new Label();
            newButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            saveButton = new Button();
            toDoListView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)toDoListView).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.Location = new Point(14, -1);
            Title.Name = "Title";
            Title.Size = new Size(939, 73);
            Title.TabIndex = 0;
            Title.Text = "To Do List";
            Title.TextAlign = ContentAlignment.TopCenter;
            Title.Click += label1_Click;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(12, 75);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(939, 27);
            titleTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(12, 132);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(939, 27);
            descriptionTextBox.TabIndex = 2;
            // 
            // titleLabel
            // 
            titleLabel.Location = new Point(14, 50);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(62, 25);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(12, 105);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(85, 20);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description";
            // 
            // newButton
            // 
            newButton.Location = new Point(12, 165);
            newButton.Name = "newButton";
            newButton.Size = new Size(223, 42);
            newButton.TabIndex = 5;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(241, 165);
            editButton.Name = "editButton";
            editButton.Size = new Size(232, 42);
            editButton.TabIndex = 6;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(479, 165);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(244, 42);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(729, 165);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(224, 42);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // toDoListView
            // 
            toDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            toDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            toDoListView.Location = new Point(15, 213);
            toDoListView.Name = "toDoListView";
            toDoListView.RowHeadersWidth = 51;
            toDoListView.Size = new Size(936, 324);
            toDoListView.TabIndex = 9;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(963, 549);
            Controls.Add(toDoListView);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(newButton);
            Controls.Add(descriptionLabel);
            Controls.Add(titleLabel);
            Controls.Add(descriptionTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(Title);
            Name = "ToDoList";
            Text = "Form1";
            Load += ToDoList_Load;
            ((System.ComponentModel.ISupportInitialize)toDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private Label titleLabel;
        private Label descriptionLabel;
        private Button newButton;
        private Button editButton;
        private Button deleteButton;
        private Button saveButton;
        private DataGridView toDoListView;
    }
}
