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

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            blenderVersionSelector.SelectedItem = "v2.76b";
            if (!System.IO.Directory.Exists(dataFolder))
            {
                System.IO.Directory.CreateDirectory(dataFolder + "\\BlenderVersions");
            }
        }

        private void loadBlenderButton_Click(object sender, EventArgs e)
        {

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
        }

        private void unzipper_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
