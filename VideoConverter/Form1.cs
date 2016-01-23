using System;
using System.Threading;
using System.Windows.Forms;
using NReco.VideoConverter;
using System.IO;

namespace VideoConverter
{
    public partial class VideoConverterForm : Form
    {
        // Initalises the form and sets the fromFormatcomboBox to All and the toFormatcomboBox to .mp4. 
        // Also sets the VFrameratetextBox to Default and the ASRatecomboBox to Default.
        public VideoConverterForm()
        {
            InitializeComponent();

            this.Height = 375;
            fromFormatcomboBox.SelectedIndex = 0;
            toFormatcomboBox.SelectedIndex = 0;

            VFrameratetextBox.Text = "Default";
            ASRatecomboBox.SelectedIndex = 0;
        }

        // Various variables for global use.
        Thread thread;
        public static bool threadStatus = false;
        public static string conversionProgress = "";
        public static int currentProgress = 0;
        public static string currentFile = "";

        // Converts all the media files in the folder to the selected format.
        private void Startbutton_Click(object sender, EventArgs e)
        {
            if (!threadStatus)
            {
                // Determines if a folder has been selected or not.
                if (!String.IsNullOrEmpty(OpenFoldertextBox.Text) || !String.IsNullOrEmpty(OpenFiletextBox.Text))
                {
                    // Determine the files to be converted and the format to be converted to.
                    string[] mediaFiles = new string[1];
                    if (!String.IsNullOrEmpty(OpenFiletextBox.Text))
                    {
                        mediaFiles[0] = OpenFiletextBox.Text;
                    }
                    else if (!String.IsNullOrEmpty(OpenFoldertextBox.Text))
                    {
                        if (subDircheckBox.Checked)
                        {
                            mediaFiles = Directory.GetFiles(OpenFoldertextBox.Text, "*.*", SearchOption.AllDirectories);
                        }
                        else
                        {
                            mediaFiles = Directory.GetFiles(OpenFoldertextBox.Text);
                        }
                    }

                    int fromFormatcomboBoxIndex = fromFormatcomboBox.SelectedIndex;
                    int toFormatcomboBoxIndex = toFormatcomboBox.SelectedIndex;
                    string VFramerate = VFrameratetextBox.Text;
                    string ASRate = ASRatecomboBox.SelectedItem.ToString();

                    // Disable user interactive objects.
                    OpenFilebutton.Enabled = false;
                    OpenFolderbutton.Enabled = true;
                    Startbutton.Enabled = false;
                    OpenFiletextBox.Enabled = false;
                    OpenFoldertextBox.Enabled = true;
                    fromFormatcomboBox.Enabled = false;
                    toFormatcomboBox.Enabled = false;
                    Settingsbutton.Enabled = false;
                    VFrameratetextBox.Enabled = false;
                    ASRatecomboBox.Enabled = false;

                    // Starts a thread to run the conversion process.
                    Converter converter = new Converter();
                    thread = new Thread(() => converter.Process(mediaFiles, toFormatcomboBoxIndex, fromFormatcomboBoxIndex, VFramerate, ASRate));
                    thread.Start();

                    // Start a timer to update the progressLabel and progressBar every second.
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Tick += new EventHandler((obj, Ev) => TimerEventProcessor(obj, Ev));
                    timer.Interval = 1000;
                    timer.Start();
                }
                // Otherwise display a message to the user.
                else
                {
                    MessageBox.Show("Please make sure you have selected a folder then try again");
                }
            }
        }

        // Updates the form every second.
        // \param path mediaFiles - The files to be converted.
        //
        private void TimerEventProcessor(object sender, EventArgs e)
        {
            // If the thread is running update the progressBar, progressLabel and Processinglabel.
            if (threadStatus)
            {
                Progresslabel.Text = conversionProgress;
                progressBar.Value = currentProgress;
                Processinglabel.Text = currentFile;
            }
            // Otherwise ensure the progressBar, progressLabel are reset.
            // and if the the DeletecheckBox is checked and the process finishes delete the file.
            else
            {
                // Reenable user interactive objects and reset progressLabel, progressBar and Processinglabel.
                OpenFilebutton.Enabled = true;
                OpenFolderbutton.Enabled = true;
                Startbutton.Enabled = true;
                OpenFiletextBox.Enabled = true;
                OpenFoldertextBox.Enabled = true;
                toFormatcomboBox.Enabled = true;
                fromFormatcomboBox.Enabled = true;
                Processinglabel.Text = "Currently Processing: ";
                Progresslabel.Text = "Progress 00:00:00/00:00:00";
                progressBar.Value = 0;
                Settingsbutton.Enabled = true;
                VFrameratetextBox.Enabled = true;
                ASRatecomboBox.Enabled = true;
            }
        }

        // Exits the application if the Exitbutton is clicked.
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            if (threadStatus)
            {
                thread.Abort();
                Converter.ffMpeg.Abort();
            }

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

        // Toggles the form size when the Settingsbutton is clicked to show/unshow the advanced settings.
        private void Settingsbutton_Click(object sender, EventArgs e)
        {
            if (this.Height == 450)
            {
                this.Height = 375;
            }
            else
            {
                this.Height = 450;
            }
        }

        // Opens a folder dialog when the OpenFolderbutton is clicked and
        // adds the folder path to the OpenFoldertextBox text.
        private void OpenFolderbutton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolderDialog1 = new FolderBrowserDialog();
            openFolderDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            if (openFolderDialog1.ShowDialog() == DialogResult.OK)
            {
                OpenFoldertextBox.Text = Convert.ToString(openFolderDialog1.SelectedPath);
            }
        }
    }
}
