using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Pons_Translator.models
{
    class PonsApi
    {
        public static string Translate(string word, string language)
        {
            string translation = "";
            string json = GetJSON(word, language);
            return translation;
        }

        public static string GetJSON(string word, string language)
        {
            string uri = string.Format("https://api.pons.com/v1/dictionary?l=de{0}&in=de&q={1}", language, word);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Headers["X-Secret"] = "bfe6be1df32d4db535788c300036167c66ea9bca1c9eded2f73a9e8626ec0373";
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
