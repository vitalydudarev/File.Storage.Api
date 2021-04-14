using System;

namespace FileStorage.Api.Models
{
    public class OutgoingFileInfo
    {
        public long Id { get; set; }
        public string FileName { get; set; }
        public long Size { get; set; }
        public DateTime AddedOn { get; set; }
    }
}
