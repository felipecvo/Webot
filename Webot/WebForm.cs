namespace Webot {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Net;
    using System.Text;
    using System.Web;

    public class WebForm {
        public static Regex formRegex = new Regex("<form(\\s+(\\w+)\\s*=\\s*(\"[^\"]*\"|[^\\s]+?))*?\\s*>(.*?)</form>", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline);
        private static Regex textareaRegex = new Regex("<textarea(\\s+(\\w+)\\s*=\\s*(\"[^\"]*\"|[^\\s]+?))*?\\s*>(.*?)</textarea>", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline);
        private static Regex inputRegex = new Regex("<input(\\s+(\\w+)\\s*=\\s*(\"[^\"]*\"|[^\\s]+?))*?\\s*/?>", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline);

        static WebForm() {
            System.Net.ServicePointManager.Expect100Continue = false;
        }

        public static string UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; pt-BR; rv:1.9.2.12) Gecko/20101026 Firefox/3.6.12";

        public static WebForm Get(string url) {
            var uri = new Uri(url);
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.CookieContainer = new CookieContainer();
            request.UserAgent = UserAgent;

            var response = (HttpWebResponse)request.GetResponse();
            using(var responseStream = new StreamReader(response.GetResponseStream())) {
                var form = Build(responseStream.ReadToEnd());
                if(form != null) {
                    if(!form.Action.StartsWith("http")) {
                        form.Action = new Uri(uri, form.Action).ToString();
                    }
                    form.Cookies = response.Cookies;
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
            Buttons = new Dictionary<string, string>();
            Method = "GET";
        }

        public CookieCollection Cookies { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public string Action { get; set; }
        public string Method { get; set; }
        public string EncType { get; set; }
        public Dictionary<string, string> Fields { get; set; }
        public Dictionary<string, string> Buttons { get; set; }

        public void FillProperty(string name, string value) {
            value = StripQuote(value);
            switch(name.ToLower()) {
                case "action":
                    Action = HttpUtility.HtmlDecode(value);
                    break;
                case "name":
                    Name = value;
                    break;
                case "id":
                    Id = value;
                    break;
                case "method":
                    Method = value.ToUpper();
                    break;
                case "enctype":
                    EncType = value;
                    break;
                default:
                    break;
            }
        }

        public string Submit() {
            return Submit(null);
        }

        public string Submit(string button) {
            var request = (HttpWebRequest)WebRequest.Create(Action);
            byte[] data = null;
            
            request.UserAgent = UserAgent;
            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(Cookies);
            request.Method = Method;
            request.Headers.Add("Accept-Encoding", "gzip,deflate");
            if(request.Method == "POST") {
                var fields = new string[Fields.Count];
                int i = 0;
                foreach(var field in Fields) {
                    fields[i++] = string.Format("{0}={1}", field.Key, HttpUtility.UrlEncode(field.Value));
                }
                var postData = string.Join("&", fields);
                if(!string.IsNullOrEmpty(button)) {
                    var buttonValue = Buttons[button];
                    postData += string.Format("&{0}={1}", button, buttonValue);
                }
                data = ASCIIEncoding.ASCII.GetBytes(postData);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                
                using(var postStream = request.GetRequestStream()) {
                    postStream.Write(data, 0, data.Length);
                }
            }
            
            using(var response = (HttpWebResponse)request.GetResponse()) {
                using(var responseStream = response.GetResponseStream()) {
                    if(response.ContentEncoding == "gzip") {
                        using (var gzipedResponseStream = new System.IO.Compression.GZipStream(responseStream, System.IO.Compression.CompressionMode.Decompress)){
                            using(var readStream = new StreamReader(gzipedResponseStream)) {
                                return readStream.ReadToEnd();
                            }
                        }
                    }
                    using(var readStream = new StreamReader(responseStream)) {
                        return readStream.ReadToEnd();
                    }
                }
            }
        }

        private void ProcessFields(string html) {
            var match = inputRegex.Match(html);
            while(match.Success) {
                string name = null, value = null, type = null;
                
                for(int i = 0; i < match.Groups[2].Captures.Count; i++) {
                    switch(match.Groups[2].Captures[i].Value) {
                        case "name":
                            name = StripQuote(match.Groups[3].Captures[i].Value);
                            break;
                        case "value":
                            value = HttpUtility.HtmlDecode(StripQuote(match.Groups[3].Captures[i].Value));
                            break;
                        case "type":
                            type = StripQuote(match.Groups[3].Captures[i].Value);
                            break;
                        default:
                            break;
                    }
                }
                
                if(!string.IsNullOrEmpty(name)) {
                    if(!IsButton(type)) {
                        if(Fields.ContainsKey(name)) {
                            Fields[name] = value;
                        } else {
                            Fields.Add(name, value);
                        }
                    } else {
                        if(Buttons.ContainsKey(name)) {
                            Buttons[name] = value;
                        } else {
                            Buttons.Add(name, value);
                        }
                    }
                }
                
                match = match.NextMatch();
            }
            match = textareaRegex.Match(html);
            if(match.Success) {
                for(int i = 0; i < match.Groups[2].Captures.Count; i++) {
                    Fields.Add(match.Groups[2].Captures[i].Value, match.Groups[4].Captures[i].Value);
                }
            }
        }

        public bool IsButton(string type) {
            if(string.IsNullOrEmpty(type))
                return false;
            type = type.ToLower();
            return (type == "submit" || type == "reset" || type == "button");
        }

        private string StripQuote(string text) {
            return Regex.Replace(text, "^\"([^\"]*)\"$", "${1}");
        }
    }
}

