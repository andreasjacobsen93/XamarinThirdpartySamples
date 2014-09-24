using Newtonsoft.Json;

namespace Metro
{
    public class JsonSerializer
    {
        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static string Serialize(object data)
        {
            return JsonConvert.SerializeObject(data);
        }
    }
}
