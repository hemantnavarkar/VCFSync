using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace VCFSync.Skia.Tizen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new VCFSync.App());
            host.Run();
        }
    }
}
