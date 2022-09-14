using efootball.DataLayer;
using efootball.Models;

namespace efootball.Services
{
    public class NewsRepository : INewsInterface
    {
        private readonly ApplicationDbContext dbContext;

        public NewsRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public News AddNews(News News)
        {
            dbContext.News.Add(News);
            dbContext.SaveChanges();

            return News;
        }

        public void DeleteNews(Guid id)
        {
            var news = dbContext.News.FirstOrDefault(n => n.Id == id);
            dbContext.News.Remove(news);
            dbContext.SaveChanges();
        }

        public List<News> GetNews() => dbContext.News.ToList();

        public News GetNewsById(Guid id) => dbContext.News.FirstOrDefault(n => n.Id == id);

        public News UpdateNews(News News)
        {
            dbContext.News.Update(News);
            dbContext.SaveChanges();

            return News;
        }
    }
}
