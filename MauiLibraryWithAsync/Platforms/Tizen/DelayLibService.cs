//namespace MauiLibraryWithAsync.Services.PartialMethods
//{
//    // All the code in this file is only included on Android.
//    public partial class DelayLibService
//    {
//        public async partial Task<int> DelayLibWithDummyReturnAsync(int ms)
//        {
//            await Task.Delay(ms);
//            return ms;
//        }

//        public partial int DelayLibWithDummyReturn(int ms)
//        {
//            Thread.Sleep(ms);
//            return ms;
//        }

//    }
//}