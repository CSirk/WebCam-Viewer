using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCamViewer
{
    public partial class Form1 : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        public Form1()
        {

            

            InitializeComponent();

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                SourcesListBox.Items.Add(filterInfo.Name);
                SourcesListBox.SelectedIndex = 0;
                videoCaptureDevice = new VideoCaptureDevice();
            }
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            WebCamPictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[SourcesListBox.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void Form1Closing(object sender, FormClosingEventArgs e)
        {
            if(videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
            }
        }
    }
}
