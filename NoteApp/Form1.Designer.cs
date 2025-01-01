namespace NoteApp
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
            richTextBoxNote = new RichTextBox();
            listCategories = new ListBox();
            listNotes = new ListBox();
            txtCategory = new TextBox();
            btnAddCategory = new Button();
            btnAddNote = new Button();
            btnEditNote = new Button();
            btnSave = new Button();
            lblNoteDates = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // richTextBoxNote
            // 
            richTextBoxNote.Location = new Point(201, 189);
            richTextBoxNote.Name = "richTextBoxNote";
            richTextBoxNote.Size = new Size(664, 218);
            richTextBoxNote.TabIndex = 0;
            richTextBoxNote.Text = "";
            // 
            // listCategories
            // 
            listCategories.FormattingEnabled = true;
            listCategories.ItemHeight = 15;
            listCategories.Location = new Point(201, 42);
            listCategories.Name = "listCategories";
            listCategories.Size = new Size(317, 109);
            listCategories.TabIndex = 1;
            listCategories.SelectedIndexChanged += listCategories_SelectedIndexChanged;
            // 
            // listNotes
            // 
            listNotes.FormattingEnabled = true;
            listNotes.ItemHeight = 15;
            listNotes.Location = new Point(4, 42);
            listNotes.Name = "listNotes";
            listNotes.Size = new Size(191, 394);
            listNotes.TabIndex = 2;
            listNotes.SelectedIndexChanged += listNotes_SelectedIndexChanged;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(524, 42);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(169, 23);
            txtCategory.TabIndex = 3;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(699, 41);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(152, 23);
            btnAddCategory.TabIndex = 4;
            btnAddCategory.Text = "Добавить категорию";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // btnAddNote
            // 
            btnAddNote.Location = new Point(201, 413);
            btnAddNote.Name = "btnAddNote";
            btnAddNote.Size = new Size(163, 23);
            btnAddNote.TabIndex = 5;
            btnAddNote.Text = "Добавить";
            btnAddNote.UseVisualStyleBackColor = true;
            btnAddNote.Click += btnAddNote_Click;
            // 
            // btnEditNote
            // 
            btnEditNote.Location = new Point(370, 413);
            btnEditNote.Name = "btnEditNote";
            btnEditNote.Size = new Size(163, 23);
            btnEditNote.TabIndex = 6;
            btnEditNote.Text = "Изменить";
            btnEditNote.UseVisualStyleBackColor = true;
            btnEditNote.Click += btnEditNote_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(539, 413);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(166, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblNoteDates
            // 
            lblNoteDates.AutoSize = true;
            lblNoteDates.Location = new Point(539, 136);
            lblNoteDates.Name = "lblNoteDates";
            lblNoteDates.Size = new Size(79, 15);
            lblNoteDates.TabIndex = 8;
            lblNoteDates.Text = "Дата заметки";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 163);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 9;
            label1.Text = "Заметка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 15);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 10;
            label2.Text = "Категории";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 15);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 11;
            label3.Text = "Список заметок";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNoteDates);
            Controls.Add(btnSave);
            Controls.Add(btnEditNote);
            Controls.Add(btnAddNote);
            Controls.Add(btnAddCategory);
            Controls.Add(txtCategory);
            Controls.Add(listNotes);
            Controls.Add(listCategories);
            Controls.Add(richTextBoxNote);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxNote;
        private ListBox listCategories;
        private ListBox listNotes;
        private TextBox txtCategory;
        private Button btnAddCategory;
        private Button btnAddNote;
        private Button btnEditNote;
        private Button btnSave;
        private Label lblNoteDates;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
