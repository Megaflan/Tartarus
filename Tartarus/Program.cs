using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tartarus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<byte> endian1 = new List<byte>();
            List<byte> endian2 = new List<byte>();
            int numParam = Int32.Parse(args[1])*(-1);
            byte[] e = new Byte[numParam];
            var state = File.ReadAllBytes(args[2]);
            switch (args[0])
            {
                case "-f":
                    using (BinaryReader br = new BinaryReader(File.Open(args[2], FileMode.Open)))
                    {
                        br.BaseStream.Position = 0;
                        for (int i = 0; i < state.Length/numParam; i++)
                        {
                            endian1 = br.ReadBytes(numParam).ToList();
                            endian1.Reverse();
                            foreach (var item in endian1)
                            {
                                endian2.Add(item);
                            }
                        }
                        e = endian2.ToArray();
                        File.WriteAllBytes(args[2] + ".conv", e);
                    }
                    break;
                case "-d":
                    foreach (var filefound in Directory.GetFiles(args[2]))
                    {
                        using (BinaryReader br = new BinaryReader(File.Open(filefound, FileMode.Open)))
                        {
                            br.BaseStream.Position = 0;
                            for (int i = 0; i < state.Length / numParam; i++)
                            {
                                endian1 = br.ReadBytes(numParam).ToList();
                                endian1.Reverse();
                                foreach (var item in endian1)
                                {
                                    endian2.Add(item);
                                }
                            }
                            e = endian2.ToArray();
                            File.WriteAllBytes(args[2] + ".conv", e);
                        }
                    }
                    break;

            }
            
               
        }
    }
}
