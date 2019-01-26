namespace SLU.XamarinTest.Helpers.Rest
{
    public static class RestHelper
    {
        public static string RestUrl(string type) => $"http://192.168.1.199:53556/api/{type}/";

        public static class Types
        {
            public const string Items = "Items";
            public const string UsedItems = "UsedItems";
            public const string Wholesalers = "Wholesalers";
        }
    }
}