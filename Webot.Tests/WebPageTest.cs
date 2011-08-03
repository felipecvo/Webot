namespace Webot.Tests {
    using System;
    using NUnit.Framework;

    [TestFixture()]
    public class WebPageTest {
        [Test()]
        public void GetWebPageText() {
            var url = "http://www.anothersite.com/";
            var expected = "<html><title>test</title><body>this is a web page text.</body></html>";
            FactoryRequest.Factory.Register(url, expected);
            var page = WebPage.Get(url);

            Assert.IsNotNull(page);
            Assert.AreEqual(expected, page.Html);
            Assert.AreEqual("test", page.Title);
            Assert.AreEqual("this is a web page text.", page.Body);
        }
    }
}

