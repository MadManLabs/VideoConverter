using System;
using System.IO;
using NReco.VideoConverter;
using System.Windows.Forms;

namespace VideoConverter
{
    public class Converter
    {

        // Initialize the FFMpegConverter class
        public static FFMpegConverter ffMpeg = new FFMpegConverter();

        // The array of supported file extensions
        private static string[] mediaExtensions = {
                                                  ".mp4",".mkv",".avi",".mov",".mpeg",
                                                  ".ogg",".flv",".webm"
                                              };

        // Runs the process of conversion.
        //
        // \param path mediaFiles - The files to be converted.
        // \param int toFormatcomboBoxIndex - The index of the format to be converted to.
        // \param int fromFormatcomboBoxIndex - The index of the format to be converted from.
        //
        public void Process(string[] mediaFiles, int toFormatcomboBoxIndex, int fromFormatcomboBoxIndex)
        {
            VideoConverterForm.threadStatus = true;

            // Determine how long is remaining and the current progress of the process.
            ffMpeg.ConvertProgress += (o, args) =>
            {
                VideoConverterForm.conversionProgress = (String.Format("Progress: {0:HH:mm:ss}/{1:HH:mm:ss}", new DateTime(args.Processed.Ticks), new DateTime(args.TotalDuration.Ticks)));
                VideoConverterForm.currentProgress = (int)((args.Processed.TotalSeconds / args.TotalDuration.TotalSeconds) * 100);
            };

            // For loop to go through each file.
            foreach (string file in mediaFiles)
            {
                ConvertFile(file, toFormatcomboBoxIndex, fromFormatcomboBoxIndex);
            }

            VideoConverterForm.threadStatus = false;
        }

        // Converts a single media file.
        //
        // \param path file - The file to be converted.
        // \param int toFormatcomboBoxIndex - The index of the format to be converted to.
        // \param int fromFormatcomboBoxIndex - The index of the format to be converted from.
        // \return bool - True if media file is converted correctly otherwise false.
        //
        public bool ConvertFile(String file, int toFormatcomboBoxIndex, int fromFormatcomboBoxIndex)
        {
            // The array of supported file formats
            string[] formats = {
                                        Format.mp4, Format.matroska, Format.avi,
                                        Format.mov, Format.mpeg, Format.ogg,
                                        Format.flv,Format.webm
                                    };

            // If the file is a media file and it is not already the correct format.
            if (((fromFormatcomboBoxIndex == 0 && IsMediaFile(file)) || (fromFormatcomboBoxIndex != 0 &&
                Path.GetExtension(file) == mediaExtensions[fromFormatcomboBoxIndex - 1])) && Path.GetExtension(file) != mediaExtensions[toFormatcomboBoxIndex])
            {
                // Determine which file is currently being processed.
                VideoConverterForm.currentFile = "Currently Processing: " + Path.GetFileName(file);

                // Create the new file name.
                string newFile = file.Substring(0, file.Length - Path.GetExtension(file).Length) + mediaExtensions[toFormatcomboBoxIndex];
                string format = formats[toFormatcomboBoxIndex];
                string oldFormat = Path.GetExtension(file).Substring(1);
                if (oldFormat == "mkv")
                {
                    oldFormat = Format.matroska;
                }

                try
                {
                    // Initialize Video Settings
                    ConvertSettings VideoSettings = new ConvertSettings();

                    // Converts the file to the selected format.
                    ffMpeg.ConvertMedia(file, oldFormat, newFile, format, VideoSettings);
                    return true;
                }
                catch
                {
                    MessageBox.Show("Error Detected in File " + Path.GetFileName(file) + " Skipping");
                    if (File.Exists(newFile))
                    {
                        File.Delete(newFile);
                    }
                    return false;
                }
            }
            return false;
        }

        // Determines if a file is a media file or not.
        //
        // \param path string - The path to the file.
        // \return bool - True if the file is a media file otherwise false.
        //
        private bool IsMediaFile(string path)
        {
            foreach (string extension in mediaExtensions)
            {
                if (Path.GetExtension(path) == extension)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
