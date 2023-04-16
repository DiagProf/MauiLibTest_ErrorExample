namespace MauiLibTest.Services.PartialMethods
{
    // All the code in this file is only included on Windows.
    public partial class DelayService
    {
        public async partial Task<int> DelayWithDummyReturnAsync(int ms)
        {
            await Task.Delay(ms);
            return ms;
        }

        public partial int DelayWithDummyReturn(int ms)
        {
            Thread.Sleep(ms);
            return ms;
        }

    }
}