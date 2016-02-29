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
//using Microsoft.VisualBasic.Devices;

namespace LK_Renderer
{
    public partial class MainForm : Form
    {
        String dataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\LK-Studios\\LK-Renderer";
        String blenderVersion = "v2.76b";
        int versionAvailability = 0;

        private System.Net.WebClient webClient;

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
            blenderVersionSelector.SelectedItem = "v2.76b";
            doAvailability(checkAvailability("v2.76b"));
        }

        private void loadBlenderButton_Click(object sender, EventArgs e)
        {
            switch (versionAvailability)
            {
                case 0:
                    // TODO: add downloader
                    break;
                case 1:
                    // TODO: add unzipping
                    break;
                case 2:
                    // Do nothing - this Blender version was already downloaded and unzipped
                    loadBlenderButton.Enabled = false;
                    break;
            }
        }

        private void blenderVersionSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            blenderVersion = blenderVersionSelector.SelectedItem.ToString();
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

        private void unzipper_DoWork(object sender, DoWorkEventArgs e)
        {
            // TODO: Add unzipping
        }
    }
}
