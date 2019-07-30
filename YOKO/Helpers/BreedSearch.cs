using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace YOKO.Helpers
{
    public class BreedSearch
    {
        private static String breed;

        private string GetHTMLCode()
        {
            string url = "https://www.google.com/search?q=" + breed + "&tbm=isch";

            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();

            Stream dataStream = response.GetResponseStream();

            if (dataStream == null)
                return null;
            {
                using (var streamReader = new StreamReader(dataStream))
                {
                    string data = streamReader.ReadToEnd();

                    return data;
                }
            }
        }

        private List<string> GetURLs(string html)
        {
            var urls = new List<string>();
            int ndx = html.IndexOf("class=\"images_table\"", StringComparison.Ordinal);
            ndx = html.IndexOf("<img", ndx, StringComparison.Ordinal);

            while (ndx >= 0)
            {
                ndx = html.IndexOf("src=\"", ndx, StringComparison.Ordinal);
                ndx += 5;
                int ndx2 = html.IndexOf("\"", ndx, StringComparison.Ordinal);
                string url = html.Substring(ndx, ndx2 - ndx);
                urls.Add(url);
                ndx = html.IndexOf("<img", ndx, StringComparison.Ordinal);
            }

            return urls;
        }

        private byte[] GetImage(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {
                if (dataStream == null)
                    return null;
                using (var sr = new BinaryReader(dataStream))
                {
                    byte[] bytes = sr.ReadBytes(100000000);

                    return bytes;
                }
            }
        }

        public void getBreedImage(PictureBox pictureBox)
        {
            string html = GetHTMLCode();
            List<string> urls = GetURLs(html);

            string luckyURL = urls[0];

            byte[] image = GetImage(luckyURL);
            using (var ms = new MemoryStream(image))
            {
                pictureBox.Image = Image.FromStream(ms);
            }
        }
    }
}
