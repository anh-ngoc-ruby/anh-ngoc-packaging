namespace anh_ngoc_packagingHelper
{
    public static class FuncHelper
    {
        public static string ToJsonString(this object obj)
        {
            return JsonSerializer.Serialize(obj);
        }

        public static T? ToObject<T>(this string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
