using System;
using System.IO;

namespace DomainLayer.Services
{
    public class ImageService
    {
        public void SaveImageToFile(string path, byte[] imageData)
        {
            try
            {
                if(string.IsNullOrEmpty(path)) throw new ArgumentNullException($"{nameof(path)} most not be empty.");

                if (imageData == null) return;

                File.WriteAllBytes($"{path}/{Guid.NewGuid()}.jpg", imageData);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}