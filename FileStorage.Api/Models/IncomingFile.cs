using System;

namespace FileStorage.Api.Models
{
    public class IncomingFile
    {
        public string FileName { get; set; }
        public long Size { get; set; }
        public string Path { get; set; }
        public DateTime AddedOn { get; set; }
    }
}
