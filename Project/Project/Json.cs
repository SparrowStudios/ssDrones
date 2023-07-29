using Newtonsoft.Json;
using System;

namespace SparrowStudios.Fivem.Common
{
    public static class Json
    {
        public static T Parse<T>(string json) 
            where T : class
        {
            if (string.IsNullOrWhiteSpace(json))
            {
                return null;
            }

            T obj;
            try
            {
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                };

                obj = JsonConvert.DeserializeObject<T>(json, settings);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                obj = null;
            }

            return obj;
        }

        public static string Stringify(object data)
        {
            if (data == null)
            {
                return null;
            }

            string json;
            try
            {
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    StringEscapeHandling = StringEscapeHandling.EscapeNonAscii
                };

                json = JsonConvert.SerializeObject(data, settings);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                json = null;
            }

            return json;
        }
    }
}
