namespace Ex2.FacebookApp.Translator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class TranslatorFactory
    {
        public static ITranslator Create(string i_TargetLanguageCode, IEnumerable<string> i_SkippedLanguageCodes = null)
        {
            return new Bing.BingTranslator(i_TargetLanguageCode, i_SkippedLanguageCodes);
        }
    }
}
