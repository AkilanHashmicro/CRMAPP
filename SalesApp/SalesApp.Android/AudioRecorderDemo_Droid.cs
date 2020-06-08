using System;
using Android.Media;
using SalesApp.Droid;
using Xamarin.Forms;
using SalesApp.views;
using System.Threading.Tasks;
using System.IO;
using Java.IO;
using Android.OS;
using Java.Nio;
using System.Web;
//using Java.IO;
//using Android.Net.Rtp;

[assembly: Xamarin.Forms.Dependency(typeof(AudioRecorder))]
namespace SalesApp.Droid
{

    class AudioRecorder : IAudioRecorder
    {
        static long Time { get; set; }
        MediaRecorder _recorder;
        MediaPlayer _player;


        string path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "test.wav");
           

        public AudioRecorder()
        {
            _recorder = new MediaRecorder();
            _player = new MediaPlayer();



            _player.Completion += (sender, e) =>
            {
                _player.Reset();
            };


        }

        public async void StartRecording()
        {
            try
            {

                _recorder.SetAudioEncodingBitRate(16000);
                _recorder.SetAudioSource(AudioSource.VoiceRecognition);
                _recorder.SetOutputFormat(OutputFormat.ThreeGpp);
                _recorder.SetAudioEncoder(AudioEncoder.AmrNb);
                _recorder.SetOutputFile(path);
                _recorder.Prepare();
                _recorder.Start();


            }
            catch (Exception e)
            {
                var str = e.Message;
            }

        }

        public void StopRecording()
        {
            try
            {
                _recorder.Stop();

                _recorder.Reset();
                _player.SetDataSource(path);

            }


            catch (Exception e)
            {
                var str = e.Message;
            }
        }

        public async void PlayRecording()
        {
            _player.Prepare();
            Time = _player.Duration;
            _player.Looping = true;
            _player.Start();
        }


        public string OutputString()
        {
            byte[] audiobyte = System.IO.File.ReadAllBytes(path);


            using (FileStream fileStream = System.IO.File.OpenRead(path))
            {
                //create new MemoryStream object
                MemoryStream memStream = new MemoryStream();
                memStream.SetLength(fileStream.Length);
                //read file to MemoryStream
                fileStream.Read(memStream.GetBuffer(), 0, (int)fileStream.Length);

                string UploadData = Convert.ToBase64String(memStream.ToArray());

                return UploadData;
            }


           // WebService ws = new Android.WebService();
           //// byte[] getbytedata = ws.YourMethodName();
            //string directory = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, Android.OS.Environment.DirectoryDownloads);
            //string file = Path.Combine(directory, "temp.pdf");
            //System.IO.File.WriteAllBytes(file, audiobyte);


        }


        //private byte[] short2byte(short[] sData)
        //{
        //    int shortArrsize = sData.Length;
        //    byte[] bytes = new byte[shortArrsize * 2];

        //    for (int i = 0; i < shortArrsize; i++)
        //    {
        //        bytes[i * 2] = (byte)(sData[i] & 0x00FF);
        //        bytes[(i * 2) + 1] = (byte)(sData[i] >> 8);
        //        sData[i] = 0;
        //    }
        //    return bytes;

        //}


    }
}
