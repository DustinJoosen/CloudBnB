namespace CloudBnB.API.Services.Interfaces
{
    public interface IImageService
    {
        /// <summary>
        /// Uploads a formfile to imgur
        /// </summary>
        /// <param name="file">File to upload</param>
        /// <param name="autosave">Automatically save the image to the database.</param>
        /// <returns>Uri of upload image</returns>
        public Task<string?> Upload(IFormFile file);
    }
}