namespace anh_ngoc_packaging.Infrastructure.Extenstions
{
    public static class SortExtension
    {
        public static IFindFluent<TSource, TSource> SortByField<TSource>(
         this IFindFluent<TSource, TSource> source,
         string? fieldName,
         bool isAscending = true)
        {
            if (!string.IsNullOrEmpty(fieldName))
            {
                var property = typeof(TSource).GetProperty(fieldName);
                if (property != null)
                {
                    var sortDefinition = isAscending
                        ? Builders<TSource>.Sort.Ascending(fieldName)
                        : Builders<TSource>.Sort.Descending(fieldName);

                    return source.Sort(sortDefinition);
                }
            }

            return source;
        }
    }
}
