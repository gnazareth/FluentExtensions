using Newtonsoft.Json;

namespace FluentExtensions.Object
{
    public static class ObjectToJsonExtensions
    {
        public static string ToJson(this object value)
        {
            return JsonConvert.SerializeObject(value);
        }

        public static string ToPrettyJson(this object value)
        {
            return JsonConvert.SerializeObject(value, Formatting.Indented);
        }

        public static string ToJsonPreservingReferences(this object value)
        {
            return JsonConvert.SerializeObject(value, Formatting.None, new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            });
        }

        public static string ToPrettyJsonPreservingReferences(this object value)
        {
            return JsonConvert.SerializeObject(value, Formatting.Indented, new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            });
        }
    }
}