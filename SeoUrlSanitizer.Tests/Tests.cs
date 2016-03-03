﻿using Shouldly;
using Xunit;

namespace SeoUrlSanitizer.Tests
{
    public class Tests
    {
        [Fact]
        public void SanitizeText()
        {
            string before = "How to sanitize a url for seo purposes";
            string after = "how-to-sanitize-a-url-for-seo-purposes";

            StringToUrlSanitizer.Sanitize(before).ShouldBe(after);
        }

        [Fact]
        public void StripHtmlTags()
        {
            string before = "<p>How to sanitize a <a href=\"http://www.google.co.uk\" target=\"_blank\">url</a> for <span style=\"font-weight: bold;\">seo</span> purposes</p>";
            string after = "how-to-sanitize-a-url-for-seo-purposes";

            StringToUrlSanitizer.Sanitize(before).ShouldBe(after);
        }


        [Fact]
        public void RemoveStopWords()
        {
            string before = "How to sanitize a url for seo purposes and remove stop words";
            string after = "how-sanitize-url-seo-purposes-remove-stop-words";

            StringToUrlSanitizer.Sanitize(before, true).ShouldBe(after);
        }
    }
}