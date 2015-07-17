using Newtonsoft.Json;

namespace FluentExtensions.Object
{
    /// <summary>
    /// Extensions on any object to serialize it into json format
    /// </summary>
    public static class ObjectToJsonExtension
    {
        /// <summary>
        /// Serializes an object to a Json string
        /// </summary>
        /// <param name="value">object to serialize</param>
        /// <returns>json string of serialized object</returns>
        public static string ToJson(this object value)
        {
            return JsonConvert.SerializeObject(value);
        }

        /// <summary>
        /// Serializes an object to a Json string with indentation
        /// </summary>
        /// <param name="value">object to serialize</param>
        /// <returns>json string of serialized object</returns>
        public static string ToPrettyJson(this object value)
        {
            return JsonConvert.SerializeObject(value, Formatting.Indented);
        }

        /// <summary>
        /// Serializes an object to a Json string preserving references
        /// </summary>
        /// <param name="value">object to serialize</param>
        /// <returns>json string of serialized object</returns>
        public static string ToJsonPreservingReferences(this object value)
        {
            return JsonConvert.SerializeObject(value, Formatting.None, new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            });
        }


        /// <summary>
        /// Serializes an object to a Json string with indentation and preserving references
        /// </summary>
        /// <param name="value">object to serialize</param>
        /// <returns>json string of serialized object</returns>
        public static string ToPrettyJsonPreservingReferences(this object value)
        {
            return JsonConvert.SerializeObject(value, Formatting.Indented, new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            });
        }
    }
}