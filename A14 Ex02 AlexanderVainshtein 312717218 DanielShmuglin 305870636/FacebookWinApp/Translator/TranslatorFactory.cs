namespace Ex2.FacebookApp.Translator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class TranslatorFactory
    {
        public static ITranslator Create(eTranslatorType i_Type, string i_TargetLanguageCode, IEnumerable<string> i_SkippedLanguageCodes = null)
        {
            switch (i_Type)
            {
                case eTranslatorType.Dummy:
                    return new DummyTranslator();
                case eTranslatorType.Bing:
                    return new BingTranslator(i_TargetLanguageCode, i_SkippedLanguageCodes);
                case eTranslatorType.Base64:
                    return new Base64Translator();
                default:
                    throw new ArgumentException("Unsupported translator type");
            }
        }
    }

    public enum eTranslatorType
    { 
        Dummy,
        Bing,
        Base64
    }
}
