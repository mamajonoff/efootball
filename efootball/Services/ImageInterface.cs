namespace efootball.Services
{
    public interface ImageInterface
    {
        string SaveImage(IFormFile file);
        void DeleteImage(string fileName);
    }
}
