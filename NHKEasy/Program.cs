using System;
using System.Diagnostics;

namespace NHKEasy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: nhk-easy id");

                return;
            }

            var id = args[0];
            var m3u8Url = $"https://nhks-vh.akamaihd.net/i/news/easy/{id}.mp4/master.m3u8";
            var command = $"-y -i {m3u8Url} -codec:a libmp3lame -qscale:a 2 {id}.mp3";

            RunCommand(command);
        }

        private static void RunCommand(string command)
        {
            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "ffmpeg",
                    Arguments = command,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    WorkingDirectory = Environment.CurrentDirectory,
                },
            };

            process.Start();
            process.WaitForExit();
        }
    }
}
