using Riok.Mapperly.IntegrationTests.Mapper;
using Riok.Mapperly.IntegrationTests.Models;
using Shouldly;
using Xunit;

namespace Riok.Mapperly.IntegrationTests
{
    public class UseUserMethodWithRefAutoDetectTest : BaseMapperTest
    {
        [Fact]
        public void RunMappingWithAutoDetectedRefMethod()
        {
            var src = new StringWrapperObject { Name = new StringWrapper("hello") };
            var target = new PlainStringObject();
            UseUserMethodWithRefAutoDetect.Map(target, src);
            target.Name.ShouldBe("hello");
        }
    }
}
