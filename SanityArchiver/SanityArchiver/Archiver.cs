using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanityArchiver
{
    class Archiver
    {
        public static bool Compress(FileInfo FileToCompress )
        {
            using (FileStream originalFileStream = FileToCompress.OpenRead())
            {
                if ((File.GetAttributes(FileToCompress.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden & FileToCompress.Extension != ".gz" )
                {
                    using(FileStream compressedFileStream = File.Create(FileToCompress.FullName + ".gz"))
                    {
                        using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                        {
                            originalFileStream.CopyTo(compressionStream);
                        }
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public static bool Extract(FileInfo FileToDecompress)
        {
            using (FileStream originalStream = FileToDecompress.OpenRead())
            {
                string currentFileName = FileToDecompress.FullName;
                string newFileName = currentFileName.Remove(currentFileName.Length - FileToDecompress.Extension.Length);

                using (FileStream DecompressedFileStream = File.Create(newFileName))
                {
                    using (GZipStream DecompressionStream = new GZipStream(originalStream, CompressionMode.Decompress))
                    {
                        if(FileToDecompress.Extension == ".gz")
                        {
                            DecompressionStream.CopyTo(DecompressedFileStream);
                            return true; 
                        }
                        else
                        {
                            return false;
                        }
                    }
                }

            }
        }
    }
}
