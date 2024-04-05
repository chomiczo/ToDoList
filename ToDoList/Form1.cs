using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class ToDoList : Form
    {
        private BindingList<ToDoEntry> entries = new BindingList<ToDoEntry>();
        private string filePath = "todolist.txt"; // Ścieżka do pliku
        public ToDoList()
        {
            InitializeComponent();


            titleText.DataBindings.Add("Text", entrySource ,"Title",true, DataSourceUpdateMode.OnPropertyChanged);

            textDescription.DataBindings.Add("Text", entrySource, "Description", true, DataSourceUpdateMode.OnPropertyChanged);

            dateTimePicker1.DataBindings.Add("Value", entrySource, "DueDate", true, DataSourceUpdateMode.OnPropertyChanged);

            // Odczytaj listę z pliku przy starcie aplikacji
            LoadToDoListFromFile();

            entrySource.DataSource = entries;
            CreateNewItem();
        }
        private void CreateNewItem()
        {
            ToDoEntry newEntry = (ToDoEntry)entrySource.AddNew();
            newEntry.Title = "Nowe zadanie";
            newEntry.Description = "Nowy Opis";
            newEntry.DueDate = DateTime.Now;
            entrySource.ResetCurrentItem();
        }
        private void entrySource_ListChanged(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                    MakeListViewItemForNewEntry(e.NewIndex); 
                    break;
                case ListChangedType.ItemDeleted:
                    RemoveListViewItem(e.NewIndex);
                    break;
                case ListChangedType.ItemChanged:
                    UpdateListViewItem(e.NewIndex);
                    break;
            }
        }
        private void MakeListViewItemForNewEntry(int newItemIndex)
        {
            if (newItemIndex >= 0 && newItemIndex <= entriesListView.Items.Count)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add("");
                entriesListView.Items.Insert(newItemIndex, item);
            }
            else
            {
                // Jeśli newItemIndex wykracza poza zakres, możesz wstawić nowy element na końcu listy
                ListViewItem item = new ListViewItem();
                item.SubItems.Add("");
                entriesListView.Items.Add(item);
            }
        }


        private void RemoveListViewItem(int deletedItemIndex)
        {
            entriesListView.Items.RemoveAt(deletedItemIndex);
        }

        private void UpdateListViewItem(int updateItemIndex)
        {
            if (updateItemIndex >= 0 && updateItemIndex < entriesListView.Items.Count)
            {
                ListViewItem item = entriesListView.Items[updateItemIndex];
                ToDoEntry entry = entries[updateItemIndex];

                item.SubItems[0].Text = entry.Title;
                item.SubItems[1].Text = entry.DueDate.ToShortDateString();
            }
        }



        private void newButton_Click_1(object sender, EventArgs e)
        {
            CreateNewItem();
        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            if (entriesListView.SelectedIndices.Count > 0)
            {
                int entryIndex = entriesListView.SelectedIndices[0];
                entrySource.RemoveAt(entryIndex);
            }
        }

        private void entriesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (entriesListView.SelectedIndices.Count > 0)
            {
                int entryIndex = entriesListView.SelectedIndices[0];
                entrySource.Position = entryIndex;
            }
        }
        private void LoadToDoListFromFile()
        {
            if (File.Exists(filePath))
            {
                entries.Clear(); // Wyczyść listę przed wczytaniem nowych danych
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            string title = parts[0];
                            string description = parts[1];
                            DateTime dueDate;
                            if (DateTime.TryParse(parts[2], out dueDate))
                            {
                                entries.Add(new ToDoEntry { Title = title, Description = description, DueDate = dueDate });
                            }
                        }
                    }
                }
                entriesListView.Refresh(); // Odśwież widok listy po wczytaniu danych
            }
        }

        private void SaveToDoListToFile()
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var entry in entries)
                {
                    sw.WriteLine($"{entry.Title},{entry.Description},{entry.DueDate}");
                }
            }
        }
        private void Zapisz_Click(object sender, EventArgs e)
        {
            SaveToDoListToFile();
            LoadToDoListFromFile();
            entrySource.ResetBindings(false); // Ponowne przypisanie źródła danych
        }


        private void Wczytaj_Click(object sender, EventArgs e)
        {
            LoadToDoListFromFile();
        }

    }
}
