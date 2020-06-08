//using System;
using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Text;
using Android;
using Android.OS;
using Android.Support.V4.App;
using SalesApp.Droid;
using SalesApp.views;
using Xamarin.Forms;

[assembly: Dependency(typeof(AndroidDownloader))]
namespace SalesApp.Droid
{
    public class AndroidDownloader : IDownloader  
{  
    public event EventHandler<DownloadEventArgs> OnFileDownloaded;  

      

        public void SaveFile(byte[] bytes, string folder)
        {
            // string pathToNewFolder = Android.App.Application.Context.GetExternalFilesDir(null).ToString();

            //string pathToNewFolder = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, folder);
            //Directory.CreateDirectory(pathToNewFolder);

            //string pathToNewFolder = Path.Combine(Android.OS.Environment.DirectoryDownloads.ToString());

            //    string directory = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, Android.OS.Environment.DirectoryDownloads);
            //string file = Path.Combine(directory, "/RSI/PaySlip/temp.pdf");

            //  string directory = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath);

            //var permissions = new string[] { Manifest.Permission.ReadExternalStorage, Manifest.Permission.WriteExternalStorage };
            //ActivityCompat.RequestPermissions(permissions, 77);

             var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

          //  string documentsPath = Android.OS.Environment.GetExternalStoragePublicDirectory("");
       
        
            var filePath = Path.Combine(documentsPath, "Akil.pdf");

            File.WriteAllBytes(filePath, bytes);
        }

  
    public void DownloadFile(string url, string folder)  
    {  
       // string pathToNewFolder = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, folder);

        //    string pathToNewFolder = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, folder);  
        //Directory.CreateDirectory(pathToNewFolder);  

            string pathToNewFolder = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, folder);
            Directory.CreateDirectory(pathToNewFolder);


         //   File.WriteAllBytes("Foo.txt", bytes.ToArray());
  
        try  
        {
                //  WebClient webClient = new WebClient();  

                //string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes("demo@demo.com" + ":" + "demo"));
                //webClient.Headers[HttpRequestHeader.Authorization] = string.Format(
                //"Basic {0}", credentials);

                //NetworkCredential myCreds = new NetworkCredential("demo@demo.com", "demo");
                //webClient.Credentials = myCreds;
                //webClient.

                //webClient.Headers.Add("Accept-Language", " en-US");
                //webClient.Headers.Add("Accept-Encoding", "gzip, deflate");
                //webClient.Headers.Add("Accept", " text/html, application/xhtml+xml, */*");
                //webClient.Headers.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)");

                // var browser = new WebView();
                // browser.Source = url;
                //Content = browser;

                //WebView webView = new WebView
                //{
                //    Source = new UrlWebViewSource
                //    {

                //        Url = url,
                //    },
                //    VerticalOptions = LayoutOptions.FillAndExpand
                //};


                //var web = new WebView();
                //var html = new HtmlWebViewSource
                //{
                //    Html = "your html here"
                //};

                Device.OpenUri(new Uri(url));

            //webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);  
            //string pathToNewFile = Path.Combine(pathToNewFolder, Path.GetFileName(url));  
            //webClient.DownloadFileAsync(new Uri(url), pathToNewFile);  
        }  
        catch (Exception ex)  
        {  
            if (OnFileDownloaded != null)  
                OnFileDownloaded.Invoke(this, new DownloadEventArgs(false));  
        }  
    }  
  
    private void Completed(object sender, AsyncCompletedEventArgs e)  
    {  
        if (e.Error != null)  
        {  
            if (OnFileDownloaded != null)  
                OnFileDownloaded.Invoke(this, new DownloadEventArgs(false));  
        }  
        else  
        {  
            if (OnFileDownloaded != null)  
                OnFileDownloaded.Invoke(this, new DownloadEventArgs(true));  
        }  
    }  
}  
}

