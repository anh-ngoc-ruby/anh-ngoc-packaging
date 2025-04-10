namespace anh_ngoc_packaging.Infrastructure.Extenstions
{
    public static class PagingExtenstion
    {
        //used by LINQ to SQL
        public static IQueryable<TSource> Paging<TSource>(this IQueryable<TSource> source, int skip = 0, int limit = 10)
        {
            return source.Skip(skip).Take(limit);
        }

        //used by LINQ
        public static IEnumerable<TSource> Paging<TSource>(this IEnumerable<TSource> source, int skip = 0, int limit = 10)
        {
            return source.Skip(skip).Take(limit);
        }

        public static IFindFluent<TSource, TSource> Paging<TSource>(this IFindFluent<TSource, TSource> source, int page = 1, int pageSize = 10)
        {
            return source.Skip((page - 1) * pageSize).Limit(pageSize);
        }
    }
}
