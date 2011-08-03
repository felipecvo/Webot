using System;

namespace Webot.Console {
    class MainClass {
        public static void Main(string[] args) {
            System.Console.WriteLine("Hello World!");
            var form = WebForm.Get("https://graph.facebook.com/oauth/authorize?client_id=161520467221210&redirect_uri=http://www.facebook.com/connect/login_success.html&type=user_agent&display=popup");

            form.Fields["email"] = "felipecvo@gmail.com";
            form.Fields["pass"] = "4657god";

            //form.Action = form.Action.Replace("http", "https");
            //form.Action = form.Action.Replace("https://login.facebook.com/", "http://localhost.facebook.com:3000/");
            var sss = form.Submit("login");
            System.Console.WriteLine(sss);
            //System.Console.WriteLine("dones");
        }
    }
}

