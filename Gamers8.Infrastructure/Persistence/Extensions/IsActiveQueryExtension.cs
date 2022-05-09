using Gamers8.Core.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq.Expressions;
using System.Reflection;

namespace Gamers8.Infrastructure.Persistence.Extensions
{
    public static class IsActiveQueryExtension
    {
        public static void AddIsActiveQueryFilter(this IMutableEntityType entityData)
        {
            var methodToCall = typeof(IsActiveQueryExtension)
                .GetMethod(nameof(GetIsActiveFilter),
                    BindingFlags.NonPublic | BindingFlags.Static)
                .MakeGenericMethod(entityData.ClrType);

            var filter = methodToCall.Invoke(null, Array.Empty<object>());

            entityData.SetQueryFilter((LambdaExpression)filter);

            entityData.AddIndex(entityData.FindProperty(nameof(IIsActive.IsActive)));
        }

        private static LambdaExpression GetIsActiveFilter<TEntity>()
            where TEntity : class, IIsActive
        {
            Expression<Func<TEntity, bool>> filter = x => x.IsActive;
            return filter;
        }
    }
}