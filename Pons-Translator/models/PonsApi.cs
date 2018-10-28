using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pons_Translator.models
{
    class PonsApi
    {
        public static List<string> Translate(string word, string language)
        {
            // string json = GetJSON(word, language);
            // string json = "[{\"lang\":\"de\",\"hits\":[{\"type\":\"entry\",\"opendict\":false,\"roms\":[{\"headword\":\"kom·plex\",\"headword_full\":\"kom<span class=\\\"separator\\\">·<\\/span>plex <span class=\\\"phonetics\\\">[kɔmplɛks]<\\/span> <span class=\\\"wordclass\\\"><acronym title=\\\"adjective\\\">ADJ<\\/acronym><\\/span> <span class=\\\"style\\\"><acronym title=\\\"formal language\\\">geh<\\/acronym><\\/span>\",\"wordclass\":\"adjective and adverb\",\"arabs\":[{\"header\":\"\",\"translations\":[{\"source\":\"<strong class=\\\"headword\\\">komplex<\\/strong>\",\"target\":\"complex\"},{\"source\":\"<strong class=\\\"headword\\\">komplex<\\/strong>\",\"target\":\"complicated\"},{\"source\":\"<span class=\\\"full_collocation\\\"> <strong class=\\\"tilde\\\">komplexe<\\/strong> Zahl<\\/span> <span class=\\\"topic\\\"><acronym title=\\\"mathematics\\\">MATH<\\/acronym><\\/span>\",\"target\":\"complex number\"}]}]},{\"headword\":\"kom·plex\",\"headword_full\":\"kom<span class=\\\"separator\\\">·<\\/span>plex <span class=\\\"phonetics\\\">[kɔmplɛks]<\\/span> <span class=\\\"wordclass\\\"><acronym title=\\\"adverb\\\">ADV<\\/acronym><\\/span> <span class=\\\"style\\\"><acronym title=\\\"formal language\\\">geh<\\/acronym><\\/span>\",\"wordclass\":\"adverb\",\"arabs\":[{\"header\":\"\",\"translations\":[{\"source\":\"<strong class=\\\"headword\\\">komplex<\\/strong>\",\"target\":\"complexly\"},{\"source\":\"<strong class=\\\"headword\\\">komplex<\\/strong>\",\"target\":\"in a complicated manner <span class=\\\"info\\\"><acronym title=\\\"predicative\\\">pred<\\/acronym><\\/span>\"},{\"source\":\"<span class=\\\"full_collocation\\\"> <strong class=\\\"tilde\\\">komplex<\\/strong> aufgebaut sein<\\/span>\",\"target\":\"to have a complex structure\"}]}]}]},{\"type\":\"entry\",\"opendict\":false,\"roms\":[{\"headword\":\"Kom·plex\",\"headword_full\":\"Kom<span class=\\\"separator\\\">·<\\/span>plex <span class=\\\"flexion\\\">&lt;-es, -e&gt;<\\/span> <span class=\\\"phonetics\\\">[kɔmplɛks]<\\/span> <span class=\\\"wordclass\\\"><acronym title=\\\"noun\\\">NOUN<\\/acronym><\\/span> <span class=\\\"genus\\\"><acronym title=\\\"masculine\\\">m<\\/acronym><\\/span>\",\"wordclass\":\"noun\",\"arabs\":[{\"header\":\"1. Komplex <span class=\\\"sense\\\">(Gesamtheit von Gebäuden)<\\/span>:\",\"translations\":[{\"source\":\"<strong class=\\\"headword\\\">Komplex<\\/strong>\",\"target\":\"complex\"}]},{\"header\":\"2. Komplex <span class=\\\"sense\\\">(Gesamtheit)<\\/span>:\",\"translations\":[{\"source\":\"<strong class=\\\"headword\\\">Komplex<\\/strong>\",\"target\":\"complex\"}]},{\"header\":\"3. Komplex <span class=\\\"topic\\\"><acronym title=\\\"psychology\\\">PSYCH<\\/acronym><\\/span>:\",\"translations\":[{\"source\":\"<strong class=\\\"headword\\\">Komplex<\\/strong>\",\"target\":\"complex\"},{\"source\":\"<span class=\\\"full_collocation\\\"> <strong class=\\\"tilde\\\">Komplexe<\\/strong> [wegen einer <acronym title=\\\"Sache\\\">S.<\\/acronym> <span class=\\\"case\\\"><acronym title=\\\"genitive\\\">gen<\\/acronym><\\/span>] haben<\\/span>\",\"target\":\"to have a complex [about <acronym title=\\\"something\\\">sth<\\/acronym>]\"}]}]}]},{\"type\":\"entry\",\"opendict\":false,\"roms\":[{\"headword\":\"Vi·ta·min-B-Kom·plex\",\"headword_full\":\"Vi<span class=\\\"separator\\\">·<\\/span>ta<span class=\\\"separator\\\">·<\\/span>min-B-Kom<span class=\\\"separator\\\">·<\\/span>plex <span class=\\\"wordclass\\\"><acronym title=\\\"noun\\\">NOUN<\\/acronym><\\/span> <span class=\\\"genus\\\"><acronym title=\\\"masculine\\\">m<\\/acronym><\\/span>\",\"wordclass\":\"noun\",\"arabs\":[{\"header\":\"\",\"translations\":[{\"source\":\"<strong class=\\\"headword\\\">Vitamin-B-Komplex<\\/strong>\",\"target\":\"vitamin B complex\"}]}]}]}]}]";
            string json = "[{\"lang\":\"de\",\"hits\":[{\"type\":\"entry\",\"opendict\":false,\"roms\":[{\"headword\":\"Am·pel\",\"headword_full\":\"Am<span class=\\\"separator\\\">·<\\/span>pel <span class=\\\"flexion\\\">&lt;-, -n&gt;<\\/span> <span class=\\\"phonetics\\\">[ˈampl̩]<\\/span> <span class=\\\"wordclass\\\"><acronym title=\\\"noun\\\">NOUN<\\/acronym><\\/span> <span class=\\\"genus\\\"><acronym title=\\\"feminine\\\">f<\\/acronym><\\/span>\",\"wordclass\":\"noun\",\"arabs\":[{\"header\":\"\",\"translations\":[{\"source\":\"<strong class=\\\"headword\\\">Ampel<\\/strong>\",\"target\":\"traffic lights <span class=\\\"info\\\"><acronym title=\\\"plural noun\\\">npl<\\/acronym><\\/span>\"},{\"source\":\"<span class=\\\"example\\\">die <strong class=\\\"tilde\\\">Ampel<\\/strong> ist auf rot gesprungen<\\/span>\",\"target\":\"the lights have turned red\"},{\"source\":\"<span class=\\\"example\\\">fahr los, die <strong class=\\\"tilde\\\">Ampel<\\/strong> ist grün!<\\/span>\",\"target\":\"drive on! it&#39;s green!\"},{\"source\":\"<span class=\\\"example\\\">du hast eine rote <strong class=\\\"tilde\\\">Ampel<\\/strong> überfahren<\\/span>\",\"target\":\"you&#39;ve just driven through a red light\"}]}]}]},{\"type\":\"entry\",\"opendict\":true,\"roms\":[{\"headword\":\"Ampel\",\"headword_full\":\"Ampel <span class=\\\"wordclass\\\"><acronym title=\\\"noun\\\">NOUN<\\/acronym><\\/span>\",\"wordclass\":\"noun\",\"arabs\":[{\"header\":\"\",\"translations\":[{\"source\":\"<strong class=\\\"tilde\\\">Ampel<\\/strong> <span class=\\\"sense\\\">(Ampelkoalition)<\\/span> <span class=\\\"grammar SUBST\\\"><acronym title=\\\"feminine\\\">f<\\/acronym><\\/span> <span class=\\\"topic\\\"><acronym title=\\\"politics\\\">POL<\\/acronym><\\/span> <span class=\\\"style\\\"><acronym title=\\\"informal\\\">fam<\\/acronym><\\/span>\",\"target\":\"a coalition of the three political parties SPD/FDP/the Greens (red-yellow-green)\"}]}]}]}]}]";
            List<string> translations = GetTranslationsFromJSON(json);
            return translations;
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

        public static List<string> GetTranslationsFromJSON(string json)
        {
            List<string> translations = new List<string>();
            JArray array = JArray.Parse(json);
            JArray t = (JArray)array[0]["hits"][0]["roms"][0]["arabs"][0]["translations"];
            foreach (var item in t)
            {
                string target = (string)item["target"];
                string strippedTarget = StripHTML(target);
                translations.Add(strippedTarget);
            }
            return translations;
        }

        public static string StripHTML(string input)
        {
            return Regex.Replace(input, "<.*?>", String.Empty);
        }
    }
}
