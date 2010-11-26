namespace Webot {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Net;

    public class WebForm {
        private static Regex formRegex = new Regex("<form(\\s+(\\w+)\\s*=\\s*(\"[^\"]*\"|[^\\s]+?))*?\\s*>(.*?)</form>", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Multiline);
        private static Regex textareaRegex = new Regex("<textarea(\\s+(\\w+)\\s*=\\s*(\"[^\"]*\"|[^\\s]+?))*?\\s*>(.*?)</textarea>", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Multiline);
        private static Regex inputRegex = new Regex("<input(\\s+(\\w+)\\s*=\\s*(\"[^\"]*\"|[^\\s]+?))*?\\s*/?>", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Multiline);

        public static WebForm Get(string url) {
            var uri = new Uri(url);
            var request = (HttpWebRequest)WebRequest.Create(uri);
            using(var response = new StreamReader(request.GetResponse().GetResponseStream())) {
                var form = Build(response.ReadToEnd());
                if(form != null && !form.Action.StartsWith("http")) {
                    form.Action = new Uri(uri, form.Action).ToString();
                }
                return form;
            }
        }

        public static WebForm Build(string html) {
            var match = formRegex.Match(html);
            if(match.Success) {
                var form = new WebForm();

                for(int i = 0; i < match.Groups[2].Captures.Count; i++) {
                    form.FillProperty(match.Groups[2].Captures[i].Value, match.Groups[3].Captures[i].Value);
                }

                form.ProcessFields(match.Groups[4].Value);

                return form;
            } else {
                return null;
            }
        }

        public WebForm() {
            Fields = new Dictionary<string, string>();
            Method = "GET";
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public string Action { get; set; }
        public string Method { get; set; }
        public string EncType { get; set; }
        public Dictionary<string, string> Fields { get; set; }

        public void FillProperty(string name, string value) {
            switch(name.ToLower()) {
                case "action":
                    Action = StripQuote(value);
                    break;
                case "name":
                    Name = StripQuote(value);
                    break;
                default:
                    break;
            }
        }

        public string Submit() {
            throw new System.NotImplementedException();
        }

        private void ProcessFields(string html) {
            var match = inputRegex.Match(html);
            while(match.Success) {
                string name = null, value = null;

                for(int i = 0; i < match.Groups[2].Captures.Count; i++) {
                    switch(match.Groups[2].Captures[i].Value) {
                    case "name":
                        name = StripQuote(match.Groups[3].Captures[i].Value);
                        break;
                    case "value":
                        value = StripQuote(match.Groups[3].Captures[i].Value);
                        break;
                    default:
                        break;
                    }
                }

                if(!string.IsNullOrEmpty(name))
                    Fields.Add(name, value);

                match = match.NextMatch();
            }
            match = textareaRegex.Match(html);
            if(match.Success) {
                for(int i = 0; i < match.Groups[2].Captures.Count; i++) {
                    Fields.Add(match.Groups[2].Captures[i].Value, match.Groups[4].Captures[i].Value);
                }
            }
        }

        private string StripQuote(string text) {
            return Regex.Replace(text, "^\"([^\"]*)\"$", "${1}");
        }
    }
}

