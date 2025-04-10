
namespace anh_ngoc_packaging.Core.Constants.ErrorCode
{
    public static class ErrorCode
    {
        public static Dictionary<string, string> ErrorCodes { get; set; } = new Dictionary<string, string>();
        public static void InitErrorDefine()
        {
            if (ErrorCodes.Count < 1)
            {
                string errorJson = File.ReadAllText($"{Directory.GetCurrentDirectory()}/Core/Constants/ErrorCode/ErrorCodes.json");
                ErrorCodes = FuncHelper.ToObject<Dictionary<string, string>>(errorJson) ?? ErrorCodes;
            }
        }

        public static string GetErrorMessage(string errorKey)
        {
            return ErrorCodes[errorKey] ?? errorKey;
        }
    }
}
