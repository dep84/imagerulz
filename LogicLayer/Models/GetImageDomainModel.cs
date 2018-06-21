using System;

namespace DomainLayer.Models
{
    class GetImageDomainModel
    {
        public byte[] Image { get; set; }
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public decimal ImageSize { get; set; }
    }
}
