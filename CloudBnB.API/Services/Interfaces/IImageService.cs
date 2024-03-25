namespace CloudBnB.API.Services.Interfaces
{
    public interface IImageService
    {
        /// <summary>
        /// Uploads a formfile to an external image hosting service
        /// </summary>
        /// <param name="file">File to upload</param>
        /// <param name="cancellationToken">Token to cancel execution</param>
        /// <returns>Uri of upload image</returns>
        public Task<string?> Upload(IFormFile file, CancellationToken cancellationToken);
    }
}