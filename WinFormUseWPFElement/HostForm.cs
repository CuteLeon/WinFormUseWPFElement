using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WPFWindow = System.Windows.Window;
using WPFControl = System.Windows.Controls;
using WPFMedia = System.Windows.Media;

namespace WinFormUseWPFElement
{
    public partial class HostForm : Form
    {
        Random Random = new Random();
        WPFControl.WrapPanel WPFPanel = new WPFControl.WrapPanel();

        public HostForm()
        {
            InitializeComponent();

            WPFPanel.Background = new WPFMedia.LinearGradientBrush(WPFMedia.Color.FromArgb(255, 255, 229, 59), WPFMedia.Color.FromArgb(255, 255, 37, 37), 30.0);
            WPFPanel.MouseLeftButtonDown += (s,e)=>AddNewLabel();
            MyElementHost.Child = WPFPanel;
        }
        
        private void AddNewLabel()
        {
            WPFControl.Label WPFLabel = new WPFControl.Label()
            {
                Width = Random.Next(100, 200),
                Height = Random.Next(50,150),
            };
            WPFLabel.Background = new WPFMedia.LinearGradientBrush(
                WPFMedia.Color.FromArgb(255, Convert.ToByte(Random.Next(256)), Convert.ToByte(Random.Next(256)), Convert.ToByte(Random.Next(256))),
                WPFMedia.Color.FromArgb(255, Convert.ToByte(Random.Next(256)), Convert.ToByte(Random.Next(256)), Convert.ToByte(Random.Next(256))),
                Random.Next(360)
                );
            WPFLabel.MouseRightButtonDown += (s, e) => WPFPanel.Children.Remove(WPFLabel);

            WPFPanel.Children.Add(WPFLabel);
        }

    }
}
