using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoConverter
{
    public partial class VideoConverterForm : Form
    {
        public VideoConverterForm()
        {
            InitializeComponent();

            fromFormatcomboBox.SelectedIndex = 0;
            toFormatcomboBox.SelectedIndex = 0;
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            // Determines if a folder has been selected or not.
            if (!String.IsNullOrEmpty(OpenFiletextBox.Text))
            {
                // Determine the files to be converted and the format to be converted to.
                string[] mediaFiles = new string[1];
                mediaFiles[0] = OpenFiletextBox.Text;

                int fromFormatcomboBoxIndex = fromFormatcomboBox.SelectedIndex;
                int toFormatcomboBoxIndex = toFormatcomboBox.SelectedIndex;

                // Starts a thread to run the conversion process.
                Converter converter = new Converter();
                converter.Process(mediaFiles, toFormatcomboBoxIndex, fromFormatcomboBoxIndex);
            }
            // Otherwise display a message to the user.
            else
            {
                MessageBox.Show("Please make sure you have selected a folder then try again");
            }
        }

        // Exits the application if the Exitbutton is clicked.
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Opens a file dialog when the OpenFilebutton is clicked and
        // adds the file path to the OpenFiletextBox text.
        private void OpenFilebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Convert.ToString(Environment.SpecialFolder.Personal);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OpenFiletextBox.Text = Convert.ToString(openFileDialog1.FileName);
            }
        }
    }
}
