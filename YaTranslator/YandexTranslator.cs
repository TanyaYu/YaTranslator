using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace YaTranslator
{
    class YandexTranslator
    {
        public string Translate(string s, string lang)
        {
            if (s.Length > 0)
            {
                WebRequest request = WebRequest.Create("https://translate.yandex.net/api/v1.5/tr.json/translate?"
                    + "key=trnsl.1.1.20170627T105355Z.c66fadeb9dc12514.887ef1fa778c8a88f95c18af393539b129f9dd9a"
                    + "&text=" + s
                    + "&lang=" + lang);
                WebResponse response = request.GetResponse();
                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    string line;
                    if ((line = stream.ReadLine()) != null)
                    {
                        Translation translation = JsonConvert.DeserializeObject<Translation>(line);
                        s = "";
                        foreach (string str in translation.text)
                        {
                            s += str;
                        }
                    }
                }
                return s;
            }
            else
                return "";
        }
    }

    class Translation
    {
        public string code { get; set; }
        public string lang { get; set; }
        public string[] text { get; set; }
    }
}
