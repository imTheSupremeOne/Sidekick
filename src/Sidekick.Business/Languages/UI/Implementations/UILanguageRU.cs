namespace Sidekick.Business.Languages.UI.Implementations
{
    [UILanguage("Русский")]
    public class UILanguageRU : IUILanguage
    {
        public string LanguageName => "Русский";

        public string TrayIconSettings => "Настройки";
        public string TrayIconShowLogs => "Показать логи";
        public string TrayIconExit => "Выход";

        public string SettingsWindowTabGeneral => "Общие";
        public string SettingsWindowTabKeybindings => "Сочетания клавиш";
        public string SettingsWindowWikiSettings => "Настройки Вики";
        public string SettingsWindowWikiDescription => "Выбрать какая страница Вики должна отображаться";
        public string SettingsWindowLanguageSettings => "Настройки языка";
        public string SettingsWindowLanguageDescription => "Сменить язык интерфеса Sideckick";

        public string OverlayAccountName => "Имя аккаунта";
        public string OverlayCharacter => "Персонаж";
        public string OverlayPrice => "Цена";
        public string OverlayItemLevel => "Уровень предмета";
        public string OverlayAge => "Выставленно";
    }
}
