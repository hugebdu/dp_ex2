namespace Ex2.FacebookApp.Translator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface ITranslationResult
    {
        string OriginText { get; }

        bool IsTranslated { get; }
        
        string TranslatedText { get; }

        string TranslatedOrOriginText { get; }
        
        string SourceLanguageCode { get; }
    }
}
