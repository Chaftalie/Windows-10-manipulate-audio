using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win10manipulateAudio
{
    public partial class Form1 : Form
    {
        CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;

        public Form1( )
        {
            InitializeComponent();
        }

        private void btn_vol_up_Click(object sender, EventArgs e)
        {
            defaultPlaybackDevice.Volume += 1;
        }

        private void btn_vol_down_Click(object sender, EventArgs e)
        {
            defaultPlaybackDevice.Volume -= 1;
        }

        private void btn_change_audio_device_Click(object sender, EventArgs e)
        {
            var test = new CoreAudioController().GetDevices();
            new CoreAudioController().SetDefaultDevice(test.ToArray()[6]);
            Thread.Sleep(1000);
            new CoreAudioController().SetDefaultDevice(test.ToArray()[2]);
            Thread.Sleep(1000);
            new CoreAudioController().SetDefaultDevice(test.ToArray()[6]);
            Thread.Sleep(1000);
            new CoreAudioController().SetDefaultDevice(test.ToArray()[2]);
            Thread.Sleep(1000);
            new CoreAudioController().SetDefaultDevice(test.ToArray()[6]);
            Thread.Sleep(1000);
            new CoreAudioController().SetDefaultDevice(test.ToArray()[2]);
            Thread.Sleep(1000);
            new CoreAudioController().SetDefaultDevice(test.ToArray()[6]);
            Thread.Sleep(1000);
            new CoreAudioController().SetDefaultDevice(test.ToArray()[2]);
            Thread.Sleep(1000);
            new CoreAudioController().SetDefaultDevice(test.ToArray()[6]);
            Thread.Sleep(1000);
            new CoreAudioController().SetDefaultDevice(test.ToArray()[2]);
            Thread.Sleep(1000);
            new CoreAudioController().SetDefaultDevice(test.ToArray()[6]);
            Thread.Sleep(1000);
            new CoreAudioController().SetDefaultDevice(test.ToArray()[2]);
            Thread.Sleep(1000);
            new CoreAudioController().SetDefaultDevice(test.ToArray()[6]);
            Thread.Sleep(1000);
            new CoreAudioController().SetDefaultDevice(test.ToArray()[2]);
            Thread.Sleep(1000);
            new CoreAudioController().SetDefaultDevice(test.ToArray()[6]);
            Thread.Sleep(1000);
            new CoreAudioController().SetDefaultDevice(test.ToArray()[2]);
            Thread.Sleep(1000);
            new CoreAudioController().SetDefaultDevice(test.ToArray()[6]);
            Thread.Sleep(1000);
            new CoreAudioController().SetDefaultDevice(test.ToArray()[2]);
            Thread.Sleep(1000);
            new CoreAudioController().SetDefaultDevice(test.ToArray()[6]);
            Thread.Sleep(1000);
            new CoreAudioController().SetDefaultDevice(test.ToArray()[2]);
            Thread.Sleep(1000);
            foreach (var tets in test)
            {
                tBx.Text = tets.ToString() + "\n";
            }
        }
    }
}
