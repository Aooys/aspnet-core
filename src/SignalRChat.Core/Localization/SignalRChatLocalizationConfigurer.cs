using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace SignalRChat.Localization
{
    public static class SignalRChatLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(SignalRChatConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(SignalRChatLocalizationConfigurer).GetAssembly(),
                        "SignalRChat.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
