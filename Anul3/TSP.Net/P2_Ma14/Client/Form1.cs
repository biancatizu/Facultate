using MyPhotosProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhotosWForms
{
    public partial class Form1 : Form
    {
        int editId = -1;
        string path = "";
        Boolean isEdit = false;
        MediaController ctrl = new MediaController();
        PersonsController personctrl = new PersonsController();
        public Form1()
        {
            InitializeComponent();
            this.setDatasource();
        }

        private void setDatasource()
        {
            List<Media> allMedia = ctrl.getAllMedia().FindAll(media => !media.path.StartsWith("DELETED"));            
            mediaList.DataSource = allMedia;
        }

        private void setDataSourceDeletedMedia()
        {
            List<Media> allMedia = ctrl.getAllMedia().FindAll(media => media.path.StartsWith("DELETED"));
            mediaList.DataSource = allMedia;
        }

        //SAVE BUTTON FOR ADD/EDIT
        private void button2_Click(object sender, EventArgs e)
        {
            
            Media formMedia = new Media();
            formMedia.name = nameInput.Text;
            formMedia.description = descriptionInput.Text;
            formMedia.date = dateInput.Value;
            formMedia.location = locationInput.Text;
            formMedia.@event = eventInput.Text;
            if (photoOption.Checked == true)
               formMedia.type = photoOption.Text;
            else
               formMedia.type = videoOption.Text;
            formMedia.path = this.path;
            if (!isEdit)
            {
                ctrl.createMedia(formMedia);
                this.setDatasource();
                label8.Visible = true;
                this.button1_Click(null, null);
            } else
            {
                ctrl.updateMedia(formMedia, this.editId);
                this.setDatasource();
                updateLabel.Visible = true;
                this.button1_Click(null, null);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Media selectedMedia = mediaList.SelectedItem as Media;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myPhotosDatabaseDataSet.Media' table. You can move, or remove it, as needed.
            this.mediaTableAdapter.Fill(this.myPhotosDatabaseDataSet.Media);

        }

        //CLEAR FORM BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            this.isEdit = false;
            nameInput.Text = "";
            descriptionInput.Text = "";
            locationInput.Text = "";
            eventInput.Text = "";
            photoOption.Checked = false;
            videoOption.Checked = false;
            this.path = "";
        }

        //UPLOAD FILE BUTTON
        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (photoOption.Checked) {
                dialog.Filter = "Image files (*.jpg, *jpeg, *.jpe, *.jfif, *.png) | *.jpg; *jpeg; *.jpe; *.jfif; *.png";
            }
            else
            {
                dialog.Filter = "Media files (*.mpg, *.avi, *.wma, *.mov, *.mp4) | *.mpg; *.avi; *.wma; *.mov; *.mp4";
            }
            dialog.Multiselect = false;
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                this.path = dialog.FileName;
            }
        }
        //EDIT BUTTON
        private void editButton_Click(object sender, EventArgs e)
        {
            this.isEdit = true;
            updateLabel.Visible = false;
            label8.Visible = false;
            Media selectedMedia = mediaList.SelectedItem as Media;
            this.editId = selectedMedia.Id;
            nameInput.Text = selectedMedia.name;
            descriptionInput.Text = selectedMedia.description;
            locationInput.Text = selectedMedia.location;
            eventInput.Text = selectedMedia.@event;
            photoOption.Checked = selectedMedia.type == "Fotografie";
            videoOption.Checked = selectedMedia.type == "Videoclip";
            this.path = selectedMedia.path;
        }
        //SHOW ITEMS WHICH WERE DELETED
        private void showDeletedMedia_Click(object sender, EventArgs e)
        {
            this.setDataSourceDeletedMedia();
            editButton.Enabled = false;
            showDeletedMedia.Visible = false;
            showMedia.Visible = true;
        }
        //HANDLE DELETE
        private void deleteButton_Click(object sender, EventArgs e)
        {
            updateLabel.Visible = false;
            label8.Visible = false;
            Media selectedMedia = mediaList.SelectedItem as Media;
            if(selectedMedia.path.StartsWith("DELETED"))
            {
                if(MessageBox.Show("Sunteti sigur ca vreti sa stergeti acest continut definitiv?", "OK") == DialogResult.OK)
                {
                    this.ctrl.removeMediaFromDb(selectedMedia.Id);
                    this.setDataSourceDeletedMedia();
                }
            }
            else
            {
                this.ctrl.removeMedia(selectedMedia.Id);
                this.setDatasource();
            }
        }
        //SHOW MEDIA WHICH IS NOT DELETED
        private void showMedia_Click(object sender, EventArgs e)
        {
            this.setDatasource();
            editButton.Enabled = true;
            showMedia.Visible = false;
            showDeletedMedia.Visible = true;
        }
        //SEARCH BY PERSONS
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (confirmSearchBox.Checked && searchBox.Text!="")
            {
                mediaList.DataSource = this.ctrl.getMediaByPersonName(searchBox.Text);
                searchBox.Text = "";
                confirmSearchBox.Checked = false;
            } else
            {
                this.setDatasource();
            }
        }

        //ADD PERSON TO MEDIA
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (confirmTag.Checked)
            {
                Media selectedMedia = mediaList.SelectedItem as Media;
                Persons person = new Persons();
                person.personName = tagPersonInput.Text;
                person = this.personctrl.createPerson(person);
                this.ctrl.addPersonToMedia(person, selectedMedia.Id);
                tagPersonInput.Text = "";
                confirmTag.Checked = false;
            }
        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
