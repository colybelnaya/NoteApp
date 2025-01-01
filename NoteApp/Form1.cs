using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<Note>> notesByCategory = new Dictionary<string, List<Note>>();
        private const string SaveFilePath = "notes_with_dates.txt";

        public Form1()
        {
            InitializeComponent();
            LoadNotes();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string category = txtCategory.Text.Trim();
            if (!string.IsNullOrEmpty(category) && !notesByCategory.ContainsKey(category))
            {
                notesByCategory[category] = new List<Note>();
                listCategories.Items.Add(category);
                txtCategory.Clear();
            }
        }

        private void listCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = listCategories.SelectedItem?.ToString();
            if (selectedCategory != null && notesByCategory.ContainsKey(selectedCategory))
            {
                listNotes.Items.Clear();
                foreach (var note in notesByCategory[selectedCategory])
                {
                    listNotes.Items.Add($"{note.Text} ({note.CreatedAt:yyyy-MM-dd})");
                }
            }
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            string selectedCategory = listCategories.SelectedItem?.ToString();
            if (selectedCategory != null)
            {
                string noteText = richTextBoxNote.Text.Trim();
                if (!string.IsNullOrEmpty(noteText))
                {
                    var newNote = new Note
                    {
                        Text = noteText,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    };

                    notesByCategory[selectedCategory].Add(newNote);
                    listNotes.Items.Add($"{newNote.Text} ({newNote.CreatedAt:yyyy-MM-dd})");
                    richTextBoxNote.Clear();
                }
            }
        }

        private void listNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = listCategories.SelectedItem?.ToString();
            int selectedIndex = listNotes.SelectedIndex;

            if (selectedCategory != null && selectedIndex >= 0)
            {
                var selectedNote = notesByCategory[selectedCategory][selectedIndex];
                richTextBoxNote.Text = selectedNote.Text;
                lblNoteDates.Text = $"Created: {selectedNote.CreatedAt:yyyy-MM-dd HH:mm}\n" +
                                    $"Edited: {selectedNote.UpdatedAt:yyyy-MM-dd HH:mm}";
            }
        }

        private void btnEditNote_Click(object sender, EventArgs e)
        {
            string selectedCategory = listCategories.SelectedItem?.ToString();
            int selectedIndex = listNotes.SelectedIndex;

            if (selectedCategory != null && selectedIndex >= 0)
            {
                var selectedNote = notesByCategory[selectedCategory][selectedIndex];
                selectedNote.Text = richTextBoxNote.Text.Trim();
                selectedNote.UpdatedAt = DateTime.Now;

                listNotes.Items[selectedIndex] = $"{selectedNote.Text} ({selectedNote.CreatedAt:yyyy-MM-dd})";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveNotes();
        }

        private void LoadNotes()
        {
            if (File.Exists(SaveFilePath))
            {
                string[] lines = File.ReadAllLines(SaveFilePath);
                foreach (var line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 4)
                    {
                        string category = parts[0];
                        string noteText = parts[1];
                        DateTime createdAt = DateTime.Parse(parts[2]);
                        DateTime updatedAt = DateTime.Parse(parts[3]);

                        if (!notesByCategory.ContainsKey(category))
                            notesByCategory[category] = new List<Note>();

                        notesByCategory[category].Add(new Note
                        {
                            Text = noteText,
                            CreatedAt = createdAt,
                            UpdatedAt = updatedAt
                        });
                    }
                }

                listCategories.Items.AddRange(notesByCategory.Keys.ToArray());
            }
        }

        private void SaveNotes()
        {
            List<string> lines = new List<string>();
            foreach (var category in notesByCategory)
            {
                foreach (var note in category.Value)
                {
                    lines.Add($"{category.Key}|{note.Text}|{note.CreatedAt:O}|{note.UpdatedAt:O}");
                }
            }
            File.WriteAllLines(SaveFilePath, lines);
        }
    }
    public class Note
    {
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
