using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        private BindingList<ToDoEntry> entries = new BindingList<ToDoEntry>();
        public Form1()
        {
            InitializeComponent();


            titleText.DataBindings.Add("Text", entrySource, "Title", true, DataSourceUpdateMode.OnPropertyChanged);

            dueDatePicker.DataBindings.Add("Value", entrySource, "DueDate",  true, DataSourceUpdateMode.OnPropertyChanged);


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
            ListViewItem item = new ListViewItem();
            item.SubItems.Add("");
            listView1.Items.Insert(newItemIndex, item);
        }

        private void RemoveListViewItem(int deletedItemIndex)
        {
            listView1.Items.RemoveAt(deletedItemIndex);
        }

        private void UpdateListViewItem(int updateItemIndex)
        {
            ListViewItem item = listView1.Items[updateItemIndex];
            ToDoEntry entry = entries[updateItemIndex];
            listView1.Items.RemoveAt(updateItemIndex);

            item.SubItems[0].Text = entry.Title;
            item.SubItems[1].Text = entry.DueDate.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateNewItem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(entriesListView.SelectedIndices.Count != 0)
            {
                int entryIndex = entriesListView.SelectedIndices[0];
                entrySource.RemoveAt(entryIndex);
            }
        }
    }
}
