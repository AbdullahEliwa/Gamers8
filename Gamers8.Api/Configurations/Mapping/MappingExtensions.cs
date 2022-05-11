using AutoMapper;
using AutoMapper.QueryableExtensions;

using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace Booking.Application.Common.Mappings
{
    public static class MappingExtensions
    {
        //public static Task<PaginatedList<TDestination>> PaginatedListAsync<TDestination>(this IQueryable<TDestination> queryable, int pageNumber, int pageSize)
        //    => PaginatedList<TDestination>.CreateAsync(queryable, pageNumber, pageSize);
        //public static Task<PaginatedList<TDestination>> PaginatedListwithoutAsync<TDestination>(this IQueryable<TDestination> queryable, int pageNumber, int pageSize)
        //    => PaginatedList<TDestination>.Create(queryable, pageNumber, pageSize);

        //public static async Task<PaginatedList<TDestination>> PaginatedListAsync<TEntity, TDestination>(this IQueryable<TEntity> queryable, IMapper mapper, int pageNumber, int pageSize)
        //{
        //    var paginatedList = await PaginatedList<TEntity>.CreateAsync(queryable, pageNumber, pageSize);
        //    return new PaginatedList<TDestination>(mapper.Map<List<TDestination>>(paginatedList.Items), paginatedList.TotalCount, pageNumber, pageSize);
        //}

        //public static Task<List<TDestination>> ProjectToListAsync<TDestination>(this IQueryable queryable, IConfigurationProvider configuration)
        //    => queryable.ProjectTo<TDestination>(configuration).ToListAsync();

        //private const string DefaultLanguage = "ar";

        //public static CreateMultiLingualMapResult<TMultiLingualEntity, TTranslation, TDestination> CreateMultiLingualMap<TMultiLingualEntity, TTranslation, TDestination, TPrimaryKeyOfMultiLingualEntity>(this Profile profile)
        //    where TTranslation : class, IEntityTranslation<TMultiLingualEntity, TPrimaryKeyOfMultiLingualEntity>
        //    where TMultiLingualEntity : IMultiLingualEntity<TTranslation>
        //{
        //    var result = new CreateMultiLingualMapResult<TMultiLingualEntity, TTranslation, TDestination>();

        //    result.TranslationMap = profile.CreateMap<TTranslation, TDestination>();
        //    result.EntityMap = profile.CreateMap<TMultiLingualEntity, TDestination>().BeforeMap((source, destination, context) =>
        //    {
        //        if (source.Translations == null || !source.Translations.Any())
        //        {
        //            return;
        //        }

        //        var translation = source.Translations.FirstOrDefault(pt => pt.Language == CultureInfo.CurrentUICulture.Name);
        //        if (translation != null)
        //        {
        //            context.Mapper.Map(translation, destination);
        //            return;
        //        }

        //        translation = source.Translations.FirstOrDefault(pt => pt.Language == DefaultLanguage);
        //        if (translation != null)
        //        {
        //            context.Mapper.Map(translation, destination);
        //            return;
        //        }

        //        translation = source.Translations.FirstOrDefault();
        //        if (translation != null)
        //        {
        //            context.Mapper.Map(translation, destination);
        //        }
        //    });

        //    return result;
        //}

        //public static Task<T> MapAsync<T>(this T obj, Func<T, T> mapFunction)
        //    => Task.FromResult(mapFunction(obj));

        //public static T Map<T>(this T obj, Func<T, T> mapFunction)
        // => (mapFunction(obj));


    }
}
