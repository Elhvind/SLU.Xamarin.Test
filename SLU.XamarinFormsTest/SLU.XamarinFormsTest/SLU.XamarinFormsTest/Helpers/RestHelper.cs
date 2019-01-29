namespace SLU.XamarinFormsTest.Helpers
{
    public class RestHelper
    {
        public static string ApiUrl(string extension) => $"http://192.168.1.199:53556/api/{extension}";
    }
}
