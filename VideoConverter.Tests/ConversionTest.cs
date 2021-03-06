﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using NReco.VideoConverter;
using System;

namespace VideoConverter.Tests
{
    [TestClass]
    public class ConversionTest
    {
        private static string currentPath = Path.GetFullPath(@"..\..\");

        [ClassCleanup]
        public static void Cleanup()
        {
            File.Delete(currentPath + "\\SampleVideo.mkv");
            File.Delete(currentPath + "\\SampleVideo.mov");
            File.Delete(currentPath + "\\SampleVideo.mpeg");
            File.Delete(currentPath + "\\SampleVideo.ogg");
            File.Delete(currentPath + "\\SampleVideo.flv");
            File.Delete(currentPath + "\\SampleVideo.webm");
        }

        [TestMethod]
        public void TestMkvConversion()
        {
            Converter converter = new Converter();
            ConvertSettings VideoSettings = new ConvertSettings();
            bool result = converter.ConvertFile(currentPath + "\\SampleVideo.mp4", 1, 1, false, VideoSettings);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestAviConversion()
        {
            Converter converter = new Converter();
            ConvertSettings VideoSettings = new ConvertSettings();
            bool result = converter.ConvertFile(currentPath + "\\SampleVideo.mp4", 2, 1, false, VideoSettings);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMovConversion()
        {
            Converter converter = new Converter();
            ConvertSettings VideoSettings = new ConvertSettings();
            bool result = converter.ConvertFile(currentPath + "\\SampleVideo.mp4", 3, 1, false, VideoSettings);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMpegConversion()
        {
            Converter converter = new Converter();
            ConvertSettings VideoSettings = new ConvertSettings();
            bool result = converter.ConvertFile(currentPath + "\\SampleVideo.mp4", 4, 1, false, VideoSettings);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestOggConversion()
        {
            Converter converter = new Converter();
            ConvertSettings VideoSettings = new ConvertSettings();
            bool result = converter.ConvertFile(currentPath + "\\SampleVideo.mp4", 5, 1, false, VideoSettings);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestFlvConversion()
        {
            Converter converter = new Converter();
            ConvertSettings VideoSettings = new ConvertSettings();
            bool result = converter.ConvertFile(currentPath + "\\SampleVideo.mp4", 6, 1, false, VideoSettings);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestWebmConversion()
        {
            Converter converter = new Converter();
            ConvertSettings VideoSettings = new ConvertSettings();
            bool result = converter.ConvertFile(currentPath + "\\SampleVideo.mp4", 7, 1, false, VideoSettings);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMp4Conversion()
        {
            Converter converter = new Converter();
            ConvertSettings VideoSettings = new ConvertSettings();
            bool result = converter.ConvertFile(currentPath + "\\SampleVideo.avi", 0, 3, false, VideoSettings);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestConversionFailure()
        {
            Converter converter = new Converter();
            ConvertSettings VideoSettings = new ConvertSettings();
            bool result = converter.ConvertFile(currentPath + "\\SampleVideo.docx", 1, 1, false, VideoSettings);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestConversionVFramerate()
        {
            Converter converter = new Converter();
            ConvertSettings VideoSettings = new ConvertSettings();
            VideoSettings.AudioSampleRate = Convert.ToInt32("60");
            bool result = converter.ConvertFile(currentPath + "\\SampleVideo.mp4", 1, 1, false, VideoSettings);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestConversionASRate()
        {
            Converter converter = new Converter();
            ConvertSettings VideoSettings = new ConvertSettings();
            VideoSettings.VideoFrameRate = Convert.ToInt32("8000");
            bool result = converter.ConvertFile(currentPath + "\\SampleVideo.mp4", 1, 1, false, VideoSettings);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestFolderConversion()
        {
            Converter converter = new Converter();
            ConvertSettings VideoSettings = new ConvertSettings();
            bool result = converter.ConvertFolder(currentPath, 1, 1, false, false, VideoSettings);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestSubdirConversion()
        {
            Converter converter = new Converter();
            ConvertSettings VideoSettings = new ConvertSettings();
            bool result = converter.ConvertFolder(currentPath + "../", 1, 1, false, true, VideoSettings);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestDeleteConversion()
        {
            Converter converter = new Converter();
            ConvertSettings VideoSettings = new ConvertSettings();
            converter.ConvertFile(currentPath + "//SampleVideo.mp4", 1, 1, false, VideoSettings);
            bool result = converter.ConvertFile(currentPath + "//SampleVideo.mkv", 0, 2, true, VideoSettings);
            Assert.AreEqual(true, result);
            Assert.AreEqual(false, File.Exists(currentPath + "//SampleVideo.mkv"));
        }
    }
}
