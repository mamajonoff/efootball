using efootball.Models;

namespace efootball.Services
{
    public interface INewsInterface
    {
        List<News> GetNews();
        News GetNewsById(Guid id);
        News AddNews(News News);
        News UpdateNews(News News);
        void DeleteNews(Guid id);
    }
}
