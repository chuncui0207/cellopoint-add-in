using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace CellopointAddin.Localization
{
    public static class CellopointAddinLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(CellopointAddinConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(CellopointAddinLocalizationConfigurer).GetAssembly(),
                        "CellopointAddin.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
