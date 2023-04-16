namespace MauiLibTest.Services.PartialMethods
{
    //https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/invoke-platform-code?view=net-maui-7.0
    // All the code in this file is included in all platforms.
    public partial class DelayService
    {
        public partial Task<int> DelayWithDummyReturnAsync(int ms);

        public partial int DelayWithDummyReturn(int ms);
    }
}