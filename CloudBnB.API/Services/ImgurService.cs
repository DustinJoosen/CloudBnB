using CloudBnB.API.Models;
using CloudBnB.API.Services.Interfaces;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace CloudBnB.API.Services
{
    public class ImgurService : IImageService
    {
        private IImageRepository _imageRepos;
        private IConfiguration _configuration;
        public ImgurService(IImageRepository imageRepos, IConfiguration configuration)
        {
            _imageRepos = imageRepos;
            _configuration = configuration;
        }

        /// <summary>
        /// Uploads a formfile to imgur
        /// </summary>
        /// <param name="file">File to upload</param>
        /// <returns>Uri of upload image</returns>
        public async Task<string?> Upload(IFormFile file)
        {
            string clientId = _configuration["ImgurClientId"] ?? throw new KeyNotFoundException("Could not find imgur client id");

            // Get image data.
            byte[] imageData;
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                imageData = memoryStream.ToArray();
            }

            using (HttpClient client = new HttpClient())
            {
                // Set headers.
                client.DefaultRequestHeaders.Add("Authorization", $"Client-ID {clientId}");

                // Set multipart form content with image data.
                MultipartFormDataContent formData = new MultipartFormDataContent
                {
                    { new ByteArrayContent(imageData), "image", "image.jpg" }
                };

                var response = await client.PostAsync("https://api.imgur.com/3/image", formData);
                if (!response.IsSuccessStatusCode)
                    return null;

                // Get the url from the response
                var content = await response.Content.ReadAsStringAsync();
                return this.FilterUrlOut(content);
            }
        }


        private string? FilterUrlOut(string json)
        {
            string pattern = "\"link\":\"([^\"]+)\"";

            Regex regex = new Regex(pattern);
            Match match = regex.Match(json);

            return match.Success
                ? match.Groups[1].Value
                : null;
        }
    }
}
