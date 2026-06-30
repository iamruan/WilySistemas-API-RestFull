using API.Entities;
using API.Infra;
using AutoMapper;

namespace API.Services
{
    public class NewsService
    {
        private readonly IMapper _mapper;
        private readonly IMongoRepository<News> _news;

        public NewsService(IMongoRepository<News> news, IMapper mapper)
        {
            _mapper = mapper;
            _news = news;
        }
    }
}
