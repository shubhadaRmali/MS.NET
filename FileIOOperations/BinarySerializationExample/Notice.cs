using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializationExample
{
    [Serializable]
    internal class Notice
    {
        public int NoticeId { get; set; }
        public string NoticeTitle { get; set;}
        public string NoticeDescription { get; set;}
        public DateTime NoticeDate { get; set; }
        public string CreatedBy { get; set; } = "Admin";
    }
}
