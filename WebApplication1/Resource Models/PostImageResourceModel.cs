using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Resource_Models
{
    public class PostImageResourceModel
    {
        public byte[] Image { get; set; }
        public string Id { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
