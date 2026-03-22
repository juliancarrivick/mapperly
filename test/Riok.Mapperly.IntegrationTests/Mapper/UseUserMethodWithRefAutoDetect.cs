using Riok.Mapperly.Abstractions;
using Riok.Mapperly.IntegrationTests.Models;

namespace Riok.Mapperly.IntegrationTests.Mapper
{
    [Mapper]
    public static partial class UseUserMethodWithRefAutoDetect
    {
        public static partial void Map([MappingTarget] PlainStringObject target, StringWrapperObject source);

        private static void MapWrapper(StringWrapper src, ref string target)
        {
            target = src.Value;
        }
    }
}
