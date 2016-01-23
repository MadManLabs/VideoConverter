using System;
using System.Threading;
using System.Windows.Forms;
using NReco.VideoConverter;

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

        // Various variables for global use.
        Thread thread;
        public static bool threadStatus = false;
        public static string conversionProgress = "";
        public static int currentProgress = 0;
        public static string currentFile = "";

        private void Startbutton_Click(object sender, EventArgs e)
        {
            if (!threadStatus)
            {
                // Determines if a folder has been selected or not.
                if (!String.IsNullOrEmpty(OpenFiletextBox.Text))
                {
                    // Determine the files to be converted and the format to be converted to.
                    string[] mediaFiles = new string[1];
                    mediaFiles[0] = OpenFiletextBox.Text;

                    int fromFormatcomboBoxIndex = fromFormatcomboBox.SelectedIndex;
                    int toFormatcomboBoxIndex = toFormatcomboBox.SelectedIndex;

                    // Disable user interactive objects.
                    OpenFilebutton.Enabled = false;
                    Startbutton.Enabled = false;
                    OpenFiletextBox.Enabled = false;
                    fromFormatcomboBox.Enabled = false;
                    toFormatcomboBox.Enabled = false;

                    // Starts a thread to run the conversion process.
                    Converter converter = new Converter();
                    thread = new Thread(() => converter.Process(mediaFiles, toFormatcomboBoxIndex, fromFormatcomboBoxIndex));
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
                Startbutton.Enabled = true;
                OpenFiletextBox.Enabled = true;
                toFormatcomboBox.Enabled = true;
                fromFormatcomboBox.Enabled = true;
                Processinglabel.Text = "Currently Processing: ";
                Progresslabel.Text = "Progress 00:00:00/00:00:00";
                progressBar.Value = 0;
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
    }
}
