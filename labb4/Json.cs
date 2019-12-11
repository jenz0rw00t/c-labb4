using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace labb4
{
    public class Json<T>
    {
        public T Model { get; private set; }

        public void Deserialize(string filename)
        {
            var assembly = typeof(T).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{filename}");
            using (var reader = new StreamReader(stream))
            {
                Model = JsonConvert.DeserializeObject<T>(reader.ReadToEnd());
            }
        }
    }
}
