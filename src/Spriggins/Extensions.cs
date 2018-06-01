using System.IO;
using Spriggins.Models;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Spriggins {
    public static class Extensions {

        public static Manifest Parse(this string str) {
            var manifest = new StringReader(str);
            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(new CamelCaseNamingConvention())
                .Build();

            return deserializer.Deserialize<Manifest>(manifest);
        }
    }
}
