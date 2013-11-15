namespace Ex2.FacebookApp.Translator
{
    public interface ITranslatorHost
    {
        ITranslator ActiveTranslator { get; }
    }
}
