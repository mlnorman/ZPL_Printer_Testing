using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Text;
using ZPL_Print_Testing.ViewModels;

namespace ZPL_Print_Testing.WebClients
{
    public class ImageHttpClient
    {
        private MainViewModel viewModel;
        public ImageHttpClient(MainViewModel vm)
        {
            this.viewModel = vm;
        }
        public byte[] Send(string requestBody)
        {
            byte[] zpl = Encoding.UTF8.GetBytes(requestBody);

            // adjust print density (8dpmm), label width (4 inches), label height (6 inches), and label index (0) as necessary
            //var request = (HttpWebRequest) WebRequest.Create("http://api.labelary.com/v1/printers/8dpmm/labels/4x6/0/");
            var request = (HttpWebRequest) WebRequest.Create($"http://api.labelary.com/v1/printers/{viewModel.PrintDensity}/labels/{viewModel.Width}x{viewModel.Height}/0/");
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = zpl.Length;

            var requestStream = request.GetRequestStream();
            requestStream.Write(zpl, 0, zpl.Length);
            requestStream.Close();

            try
            {
                var response = (HttpWebResponse) request.GetResponse();
                var responseStream = response.GetResponseStream();
                MemoryStream ms = new MemoryStream();
                responseStream.CopyTo(ms);

                if (viewModel.SaveLabels)
                {
                    Image image = Image.FromStream(ms);
                    image.Save(viewModel.Path + "/" + DateTime.Now.ToString("yyyy - dd - M--HH - mm - ss") + ".png", ImageFormat.Png);
                    //var fileStream = File.Create(viewModel.Path + "/" + DateTime.Now.ToString("yyyy - dd - M--HH - mm - ss") + ".png"); // change file name for PNG images
                    //responseStream.CopyTo(fileStream);
                }
                responseStream.Close();
                return ms.ToArray();

            }
            catch (WebException e)
            {
                Console.WriteLine("Error: {0}", e.Status);
                return null;
            }
        }
    }
}
   
