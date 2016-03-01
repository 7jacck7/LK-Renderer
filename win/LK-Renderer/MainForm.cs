//
//  MainForm.cs
//  LK-Renderer
//
//  Created by ArdiMaster on 29.02.2016
//
//  Copyright (C) 2016 LK-Studios
//
//  Distributed under the terms and conditions of the MIT license.
//  You can obtain a copy of the license at https://opensource.org/licenses/MIT
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
//using Microsoft.VisualBasic.Devices;

namespace LK_Renderer
{
    public partial class MainForm : Form
    {
        string dataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\LK-Studios\\LK-Renderer";
        string blenderVersion = Properties.Settings.Default.versions[0];
        int versionAvailability = 0;

        private WebClient webClient = new WebClient();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(dataFolder))
            {
                System.IO.Directory.CreateDirectory(dataFolder + "\\BlenderVersions");
            }

            foreach(string ver in Properties.Settings.Default.versions)
            {
                blenderVersionSelector.Items.Add(ver);
            }

            blenderVersionSelector.SelectedItem = blenderVersion;
            doAvailability(checkAvailability(blenderVersion));
        }

        private void loadBlenderButton_Click(object sender, EventArgs e)
        {
            switch (versionAvailability)
            {
                case 0:
                    blenderVersionSelector.Enabled = false;
                    loadBlenderButton.Enabled = false;
                    loadBlenderButton.Text = "Downloading...";
                    // TODO: get download URL
                    // string dlVersionSubstring = (string) Properties.Settings.Default.GetType().GetProperty(blenderVersion.Replace(".", "")).GetValue(Properties.Settings.Default);
                    // string dlURL = Properties.Settings.Default.baseurl + dlVersionSubstring;
                    progressBar.Minimum = 0;
                    progressBar.Maximum = 100;
                    progressBar.Value = 0;
                    statusLabel.Text = "Preparing to download Blender " + blenderVersion + "...";
                    // webClient.DownloadFileAsync(new Uri(dlURL), dataFolder + "\\BlenderVersions\\" + blenderVersion + ".zip");
                    break;
                case 1:
                    blenderVersionSelector.Enabled = false;
                    loadBlenderButton.Enabled = false;
                    loadBlenderButton.Text = "Unpacking...";
                    progressBar.Style = ProgressBarStyle.Marquee;
                    // TODO: Add unzipping
                    doAvailability(2);
                    break;
                case 2:
                    // Do nothing - this Blender version was already downloaded and unzipped
                    loadBlenderButton.Enabled = false;
                    break;
            }
        }

        private void blenderVersionSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            blenderVersion = blenderVersionSelector.SelectedText;
            doAvailability(checkAvailability(blenderVersion));
        }

        private int checkAvailability(String version)
        {
            return 0;
        }

        private void doAvailability(int availability)
        {
            switch (availability)
            {
                case 0:
                    loadBlenderButton.Text = "Download";
                    loadBlenderButton.Enabled = true;
                    break;
                case 1:
                    loadBlenderButton.Text = "Unzip";
                    loadBlenderButton.Enabled = true;
                    break;
                case 2:
                    loadBlenderButton.Text = "Available";
                    loadBlenderButton.Enabled = false;
                    break;
            }

            versionAvailability = availability;
        }

        void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            statusLabel.Text = "Downloading (" + e.BytesReceived + "/" + e.TotalBytesToReceive + ")";
        }

        void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            progressBar.Value = 100;
            statusLabel.Text = "Blender " + blenderVersion + " - download completed";
            loadBlenderButton.Text = "Unpacking...";
            progressBar.Style = ProgressBarStyle.Marquee;
            // TODO: Add unzipping
            doAvailability(1);
        }

        private void unzipper_DoWork(object sender, DoWorkEventArgs e)
        {
            // System.IO.StreamReader reader = new System.IO.StreamReader(path);
            // System.IO.Compression.DeflateStream deflateStream = new System.IO.Compression.DeflateStream(reader.BaseStream, System.IO.Compression.CompressionMode.Decompress)
            // System.IO.Compression.ZipFile.ExtractToDirectory(path, dataFolder + "\\BlenderVersions\\" + version);
        }
    }
}
