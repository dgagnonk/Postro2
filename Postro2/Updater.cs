using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Postro2
{
    public static class Updater
    {

        private static float _version;
        private static string CheckLink;
        private static WebClient client;
        public static float Version { get { return _version; } }

       
        static Updater()
        {
            client = new WebClient();
            _version = 0.2f;
            CheckLink = "http://www.dangk.net/files/updateserver/postro.txt";
        }

        public static async Task<bool> CheckVersion(bool OpenBrowser)
        {

            Task<bool> task = new Task<bool>(() =>
            {
                try
                {
                    string html = client.DownloadString(new Uri(CheckLink));
                    string[] split = html.Split(("|").ToCharArray());
                    float ver = (float)Convert.ToDouble(split[0]);
                    string download = split[1]; // download the exe file

                    bool updateAvailable = (ver > _version);

                    if (updateAvailable && OpenBrowser)
                    {
                        var result = System.Windows.Forms.MessageBox.Show("A new update is available. Update now?", "Update", System.Windows.Forms.MessageBoxButtons.YesNoCancel, System.Windows.Forms.MessageBoxIcon.Question);
                        if (result == System.Windows.Forms.DialogResult.Yes) Process.Start(download);
                    }

                    return updateAvailable;
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }

                return false;

            });

            task.Start();

            return await task;
         
        }


    }
}
