using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Tartarus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<byte> endian1 = new List<byte>();
            List<byte> endian2 = new List<byte>();
            byte[] e2 = new Byte[endian2.Count];
            switch (args[0])
            {
                case "-f":
                    endian1 = File.ReadAllBytes(args[1]).ToList();
                    endian2 = endian1.ToList();
                    endian2.Reverse();
                    e2 = endian2.ToArray();
                    File.WriteAllBytes(args[1] + ".conv", e2);
                    break;
                case "-d":
                    foreach (var filefound in Directory.GetFiles(args[1]))
                    {
                        
                        endian1 = File.ReadAllBytes(args[1]).ToList();
                        endian2 = endian1.ToList();
                        endian2.Reverse();
                        e2 = endian2.ToArray();
                        File.WriteAllBytes(args[1] + ".conv", e2);
                    }
                    break;

            }
            
               
        }
    }
}
