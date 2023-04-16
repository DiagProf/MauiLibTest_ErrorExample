namespace MauiLibraryWithAsync.Services.PartialMethods
{
    //https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/invoke-platform-code?view=net-maui-7.0
    // All the code in this file is included in all platforms.
    public partial class DelayLibService
    {
        public partial Task<int> DelayLibWithDummyReturnAsync(int ms);

        public partial int DelayLibWithDummyReturn(int ms);
    }
}