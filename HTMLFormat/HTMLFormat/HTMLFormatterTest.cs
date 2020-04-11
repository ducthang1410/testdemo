using System;
using NUnit.Framework;

namespace HTMLFormat
{
    [TestFixture]
    public class HtmlFormatterTests
    {

        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");

            
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("abc"));
        }
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithAnotherElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");


            Assert.That(result, Is.EqualTo("<strong>abc</bold>").IgnoreCase);
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</bold>"));
            Assert.That(result, Does.Contain("abc"));
        }
        [Test]
        public void FormatAsBold_WhenCalled_ContentisNumbers()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("123");


            Assert.That(result, Is.EqualTo("<strong>123</strong>").IgnoreCase);
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("123"));
        }
        [Test]
        public void FormatAsBold_StartWithAnotherElements()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");


            Assert.That(result, Is.EqualTo("<html>abc</strong>").IgnoreCase);
            Assert.That(result, Does.StartWith("<html>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("abc"));
        }
    }
}
