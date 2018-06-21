using System;

namespace WebApplication1.Resource_Models
{
    public class PostImageResourceModel
    {
        public byte[] Image { get; set; }
        public string Id { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
