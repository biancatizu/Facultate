namespace MyPhotosWForms
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.videoOption = new System.Windows.Forms.RadioButton();
            this.photoOption = new System.Windows.Forms.RadioButton();
            this.eventInput = new System.Windows.Forms.TextBox();
            this.locationInput = new System.Windows.Forms.TextBox();
            this.dateInput = new System.Windows.Forms.DateTimePicker();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.confirmTag = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tagPersonInput = new System.Windows.Forms.TextBox();
            this.showDeletedMedia = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.showMedia = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.mediaList = new System.Windows.Forms.ListBox();
            this.mediaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myPhotosDatabaseDataSet = new MyPhotosWForms.MyPhotosDatabaseDataSet();
            this.mediaTableAdapter = new MyPhotosWForms.MyPhotosDatabaseDataSetTableAdapters.MediaTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.myPhotosDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.updateLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.confirmSearchBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPhotosDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPhotosDatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.videoOption);
            this.groupBox1.Controls.Add(this.photoOption);
            this.groupBox1.Controls.Add(this.eventInput);
            this.groupBox1.Controls.Add(this.locationInput);
            this.groupBox1.Controls.Add(this.dateInput);
            this.groupBox1.Controls.Add(this.descriptionInput);
            this.groupBox1.Controls.Add(this.nameInput);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(61, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(364, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adaugare media";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(21, 213);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 30);
            this.button5.TabIndex = 17;
            this.button5.Text = "Incarca fisier";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 246);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Reseteaza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(249, 246);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 28);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Salvare";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // videoOption
            // 
            this.videoOption.AutoSize = true;
            this.videoOption.Location = new System.Drawing.Point(193, 183);
            this.videoOption.Margin = new System.Windows.Forms.Padding(4);
            this.videoOption.Name = "videoOption";
            this.videoOption.Size = new System.Drawing.Size(86, 21);
            this.videoOption.TabIndex = 13;
            this.videoOption.TabStop = true;
            this.videoOption.Text = "Videoclip";
            this.videoOption.UseVisualStyleBackColor = true;
            // 
            // photoOption
            // 
            this.photoOption.AutoSize = true;
            this.photoOption.Location = new System.Drawing.Point(89, 185);
            this.photoOption.Margin = new System.Windows.Forms.Padding(4);
            this.photoOption.Name = "photoOption";
            this.photoOption.Size = new System.Drawing.Size(93, 21);
            this.photoOption.TabIndex = 12;
            this.photoOption.TabStop = true;
            this.photoOption.Text = "Fotografie";
            this.photoOption.UseVisualStyleBackColor = true;
            // 
            // eventInput
            // 
            this.eventInput.Location = new System.Drawing.Point(92, 153);
            this.eventInput.Margin = new System.Windows.Forms.Padding(4);
            this.eventInput.Multiline = true;
            this.eventInput.Name = "eventInput";
            this.eventInput.Size = new System.Drawing.Size(132, 24);
            this.eventInput.TabIndex = 11;
            // 
            // locationInput
            // 
            this.locationInput.Location = new System.Drawing.Point(69, 121);
            this.locationInput.Margin = new System.Windows.Forms.Padding(4);
            this.locationInput.Multiline = true;
            this.locationInput.Name = "locationInput";
            this.locationInput.Size = new System.Drawing.Size(132, 24);
            this.locationInput.TabIndex = 10;
            // 
            // dateInput
            // 
            this.dateInput.Location = new System.Drawing.Point(104, 91);
            this.dateInput.Margin = new System.Windows.Forms.Padding(4);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(248, 22);
            this.dateInput.TabIndex = 9;
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(92, 58);
            this.descriptionInput.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionInput.Multiline = true;
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(132, 24);
            this.descriptionInput.TabIndex = 8;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(69, 23);
            this.nameInput.Margin = new System.Windows.Forms.Padding(4);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(132, 22);
            this.nameInput.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Descriere";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data crearii";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Locatie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Eveniment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tip media";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.confirmSearchBox);
            this.groupBox2.Controls.Add(this.confirmTag);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tagPersonInput);
            this.groupBox2.Controls.Add(this.showDeletedMedia);
            this.groupBox2.Controls.Add(this.searchBox);
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.showMedia);
            this.groupBox2.Controls.Add(this.editButton);
            this.groupBox2.Controls.Add(this.mediaList);
            this.groupBox2.Location = new System.Drawing.Point(511, 59);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(267, 325);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Afisare media";
            // 
            // confirmTag
            // 
            this.confirmTag.AutoSize = true;
            this.confirmTag.Location = new System.Drawing.Point(230, 235);
            this.confirmTag.Name = "confirmTag";
            this.confirmTag.Size = new System.Drawing.Size(18, 17);
            this.confirmTag.TabIndex = 9;
            this.confirmTag.UseVisualStyleBackColor = true;
            this.confirmTag.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Etichetare persoana";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // tagPersonInput
            // 
            this.tagPersonInput.Location = new System.Drawing.Point(10, 235);
            this.tagPersonInput.Name = "tagPersonInput";
            this.tagPersonInput.Size = new System.Drawing.Size(213, 22);
            this.tagPersonInput.TabIndex = 7;
            this.tagPersonInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // showDeletedMedia
            // 
            this.showDeletedMedia.Location = new System.Drawing.Point(0, 281);
            this.showDeletedMedia.Name = "showDeletedMedia";
            this.showDeletedMedia.Size = new System.Drawing.Size(267, 37);
            this.showDeletedMedia.TabIndex = 4;
            this.showDeletedMedia.Text = "Show deleted media";
            this.showDeletedMedia.UseVisualStyleBackColor = true;
            this.showDeletedMedia.Click += new System.EventHandler(this.showDeletedMedia_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(8, 22);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(215, 22);
            this.searchBox.TabIndex = 6;
            this.searchBox.Text = "Search media by tagged persons";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(159, 173);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 28);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Stergere";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // showMedia
            // 
            this.showMedia.Location = new System.Drawing.Point(0, 281);
            this.showMedia.Name = "showMedia";
            this.showMedia.Size = new System.Drawing.Size(267, 37);
            this.showMedia.TabIndex = 5;
            this.showMedia.Text = "Show media";
            this.showMedia.UseVisualStyleBackColor = true;
            this.showMedia.Visible = false;
            this.showMedia.Click += new System.EventHandler(this.showMedia_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(8, 174);
            this.editButton.Margin = new System.Windows.Forms.Padding(4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 28);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Editare";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // mediaList
            // 
            this.mediaList.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mediaBindingSource, "path", true));
            this.mediaList.DataSource = this.mediaBindingSource;
            this.mediaList.DisplayMember = "name";
            this.mediaList.FormattingEnabled = true;
            this.mediaList.ItemHeight = 16;
            this.mediaList.Location = new System.Drawing.Point(8, 48);
            this.mediaList.Margin = new System.Windows.Forms.Padding(4);
            this.mediaList.Name = "mediaList";
            this.mediaList.Size = new System.Drawing.Size(249, 116);
            this.mediaList.TabIndex = 0;
            this.mediaList.ValueMember = "name";
            // 
            // mediaBindingSource
            // 
            this.mediaBindingSource.DataMember = "Media";
            this.mediaBindingSource.DataSource = this.myPhotosDatabaseDataSet;
            // 
            // myPhotosDatabaseDataSet
            // 
            this.myPhotosDatabaseDataSet.DataSetName = "MyPhotosDatabaseDataSet";
            this.myPhotosDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mediaTableAdapter
            // 
            this.mediaTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 337);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Media adaugata";
            this.label8.Visible = false;
            // 
            // myPhotosDatabaseDataSetBindingSource
            // 
            this.myPhotosDatabaseDataSetBindingSource.DataSource = this.myPhotosDatabaseDataSet;
            this.myPhotosDatabaseDataSetBindingSource.Position = 0;
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.Location = new System.Drawing.Point(199, 338);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(118, 17);
            this.updateLabel.TabIndex = 3;
            this.updateLabel.Text = "Media actualizata";
            this.updateLabel.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // confirmSearchBox
            // 
            this.confirmSearchBox.AutoSize = true;
            this.confirmSearchBox.Location = new System.Drawing.Point(230, 24);
            this.confirmSearchBox.Name = "confirmSearchBox";
            this.confirmSearchBox.Size = new System.Drawing.Size(18, 17);
            this.confirmSearchBox.TabIndex = 10;
            this.confirmSearchBox.UseVisualStyleBackColor = true;
            this.confirmSearchBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPhotosDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPhotosDatabaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RadioButton videoOption;
        private System.Windows.Forms.RadioButton photoOption;
        private System.Windows.Forms.TextBox eventInput;
        private System.Windows.Forms.TextBox locationInput;
        private System.Windows.Forms.DateTimePicker dateInput;
        private System.Windows.Forms.TextBox descriptionInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ListBox mediaList;
        private MyPhotosDatabaseDataSet myPhotosDatabaseDataSet;
        private System.Windows.Forms.BindingSource mediaBindingSource;
        private MyPhotosDatabaseDataSetTableAdapters.MediaTableAdapter mediaTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource myPhotosDatabaseDataSetBindingSource;
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.Button showDeletedMedia;
        private System.Windows.Forms.Button showMedia;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tagPersonInput;
        private System.Windows.Forms.CheckBox confirmTag;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox confirmSearchBox;
    }
}

