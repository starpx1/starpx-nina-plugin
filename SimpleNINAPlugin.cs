using NINA.Plugin.Interfaces;
using NINA.Plugin;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using NINA.Core.Utility;

namespace SimpleNINAPlugin
{
    [Export(typeof(IPluginManifest))]
    public class SimpleWindowPlugin : PluginBase, INotifyPropertyChanged
    {
        [ImportingConstructor]
        public SimpleWindowPlugin()
        {
            //// Show the window when the plugin is initialized
            //if (Settings.Default.UpdateSettings)
            //{
            //    Settings.Default.Upgrade();
            //    Settings.Default.UpdateSettings = false;
            //    CoreUtil.SaveSettings(Settings.Default);
            //}
            ShowWindow();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ShowWindow()
        {
            Window window = new Window
            {
                Title = "Simple NINA Plugin",
                Width = 400,
                Height = 300,
                Content = "Hello, this is a simple window from SimpleNINAPlugin!"
            };
            window.Show();
        }
    }
}
