namespace Webot {
    using System;
    using System.IO;
    using System.Net;
    using System.Text.RegularExpressions;

    public class WebPage {
        public static string UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; pt-BR; rv:1.9.2.12) Gecko/20101026 Firefox/3.6.12";

        public static WebPage Get(string url) {
            var uri = new Uri(url);
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.CookieContainer = new CookieContainer();
            request.UserAgent = UserAgent;
            var response = (HttpWebResponse)request.GetResponse();
            using(var responseStream = new StreamReader(response.GetResponseStream())) {
                return new WebPage() { Html = responseStream.ReadToEnd() };
            }
        }

        private string title;
        private string body;

        public string Html { get; private set; }

        public string Title {
            get {
                return title ?? (title = GetTitle());
            }
        }

        public string Body {
            get {
                return body ?? (body = GetBody());
            }
        }

        private string GetTitle() {
            var match = Regex.Match(Html, "<title>(.+)</title>");
            if (match.Success){
                return match.Groups[1].Value;
            }
            return null;
        }

        private string GetBody() {
            var match = Regex.Match(Html, "<body[^>]*>(.+)</body>", RegexOptions.Singleline);
            if (match.Success){
                return match.Groups[1].Value;
            }
            return null;
        }
    }
}

