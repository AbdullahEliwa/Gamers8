using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
namespace Gamers8.Api.Extensions
{
    public static class MappingExtensions
    {
        public static Task<PaginatedList<TDestination>> PaginatedListAsync<TDestination>(this IQueryable<TDestination> queryable, int pageNumber, int pageSize)
          => PaginatedList<TDestination>.CreateAsync(queryable, pageNumber, pageSize);
        public static Task<PaginatedList<TDestination>> PaginatedListwithoutAsync<TDestination>(this IQueryable<TDestination> queryable, int pageNumber, int pageSize)
            => PaginatedList<TDestination>.Create(queryable, pageNumber, pageSize);

        public static async Task<PaginatedList<TDestination>> PaginatedListAsync<TEntity, TDestination>(this IQueryable<TEntity> queryable, IMapper mapper, int pageNumber, int pageSize)
        {
            var paginatedList = await PaginatedList<TEntity>.CreateAsync(queryable, pageNumber, pageSize);
            return new PaginatedList<TDestination>(mapper.Map<List<TDestination>>(paginatedList.Items), paginatedList.TotalCount, pageNumber, pageSize);
        }

        public static Task<List<TDestination>> ProjectToListAsync<TDestination>(this IQueryable queryable, AutoMapper.IConfigurationProvider configuration)
            => queryable.ProjectTo<TDestination>(configuration).ToListAsync();

        private const string DefaultLanguage = "ar";

     
        public static Task<T> MapAsync<T>(this T obj, Func<T, T> mapFunction)
            => Task.FromResult(mapFunction(obj));

        public static T Map<T>(this T obj, Func<T, T> mapFunction)
         => (mapFunction(obj));


    }
}

