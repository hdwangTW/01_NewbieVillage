using LanguageBasics.Common;
using Xunit;

namespace LanguageBasics
{
    public class ImplicitAndExplicitConversions
    {
        [Fact]
        public void should_implicitly_convert_to_target_type()
        {
            Name name = "Bill Gates";

            // please update variable value to fix the test.
            const string expectedName = "Bill Gates";

            Assert.Equal(expectedName, name.ToString());
        }

        // ReSharper disable once RedundantCast
        [Fact]
        public void should_explicity_convert_to_target_type()
        {
            Name name = "Bill Gates";

            // please update variable value to fix the test.
            const string expectedName = "Bill Gates";

            Assert.Equal(expectedName, (string)name);            
        }
    }
}