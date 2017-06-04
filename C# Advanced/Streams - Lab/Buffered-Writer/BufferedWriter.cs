using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Buffered_Writer
{
    class BufferedWriter
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var fs = new FileStream("text.txt", FileMode.Create);
            using (fs)
            {
                for (int i = 0; i < 100000; i++)
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(i.ToString());
                    fs.Read(buffer, 0, buffer.Length);
                }
            }

            Console.WriteLine("Done: {0}", watch.Elapsed);
        }

        //static void Main(string[] args)
        //{
        //    Stopwatch watch = new Stopwatch();
        //    watch.Start();
        //    var fs = new FileStream("text.txt", FileMode.Open);
        //    var bs = new BufferedStream(fs, 2);
        //    using (fs)
        //    {
        //        using (bs)
        //        {
        //            byte[] buffer = new byte[8012];
        //            while (fs.Read(buffer, 0, buffer.Length) > 0)
        //            {
        //            }
        //        }
        //    }

        //    Console.WriteLine("Done: {0}", watch.Elapsed);
        //}
    }
}
