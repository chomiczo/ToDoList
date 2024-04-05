namespace ToDoList
{
    partial class ToDoList
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.entriesListView = new System.Windows.Forms.ListView();
            this.titleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dueDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.entrySource = new System.Windows.Forms.BindingSource(this.components);
            this.Zapisz = new System.Windows.Forms.Button();
            this.Wczytaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entrySource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.entriesListView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Wczytaj);
            this.splitContainer1.Panel2.Controls.Add(this.Zapisz);
            this.splitContainer1.Panel2.Controls.Add(this.newButton);
            this.splitContainer1.Panel2.Controls.Add(this.deleteButton);
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel2.Controls.Add(this.textDescription);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.titleText);
            this.splitContainer1.Size = new System.Drawing.Size(458, 575);
            this.splitContainer1.SplitterDistance = 282;
            this.splitContainer1.TabIndex = 0;
            // 
            // entriesListView
            // 
            this.entriesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleColumn,
            this.dueDateColumn});
            this.entriesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entriesListView.HideSelection = false;
            this.entriesListView.Location = new System.Drawing.Point(0, 0);
            this.entriesListView.Name = "entriesListView";
            this.entriesListView.Size = new System.Drawing.Size(458, 282);
            this.entriesListView.TabIndex = 0;
            this.entriesListView.UseCompatibleStateImageBehavior = false;
            this.entriesListView.View = System.Windows.Forms.View.Details;
            this.entriesListView.SelectedIndexChanged += new System.EventHandler(this.entriesListView_SelectedIndexChanged);
            // 
            // titleColumn
            // 
            this.titleColumn.Text = "Tytuł";
            this.titleColumn.Width = 211;
            // 
            // dueDateColumn
            // 
            this.dueDateColumn.Text = "do dnia";
            this.dueDateColumn.Width = 189;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(332, 254);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 7;
            this.newButton.Text = "Nowe";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click_1);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(251, 254);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Usuń";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // textDescription
            // 
            this.textDescription.AcceptsReturn = true;
            this.textDescription.Location = new System.Drawing.Point(110, 108);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(275, 134);
            this.textDescription.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Opis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Do dnia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tytuł";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(110, 31);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(275, 20);
            this.titleText.TabIndex = 0;
            // 
            // entrySource
            // 
            this.entrySource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.entrySource_ListChanged);
            // 
            // Zapisz
            // 
            this.Zapisz.Location = new System.Drawing.Point(170, 254);
            this.Zapisz.Name = "Zapisz";
            this.Zapisz.Size = new System.Drawing.Size(75, 23);
            this.Zapisz.TabIndex = 8;
            this.Zapisz.Text = "Zapisz";
            this.Zapisz.UseVisualStyleBackColor = true;
            this.Zapisz.Click += new System.EventHandler(this.Zapisz_Click);
            // 
            // Wczytaj
            // 
            this.Wczytaj.Location = new System.Drawing.Point(89, 254);
            this.Wczytaj.Name = "Wczytaj";
            this.Wczytaj.Size = new System.Drawing.Size(75, 23);
            this.Wczytaj.TabIndex = 9;
            this.Wczytaj.Text = "Wczytaj";
            this.Wczytaj.UseVisualStyleBackColor = true;
            this.Wczytaj.Click += new System.EventHandler(this.Wczytaj_Click);
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 575);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ToDoList";
            this.Text = "ToDoList";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.entrySource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource entrySource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView entriesListView;
        private System.Windows.Forms.ColumnHeader titleColumn;
        private System.Windows.Forms.ColumnHeader dueDateColumn;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button Zapisz;
        private System.Windows.Forms.Button Wczytaj;
    }
}

