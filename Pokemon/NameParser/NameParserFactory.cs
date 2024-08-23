using PKHeXUtilLib.Infrastructure;

namespace PKHeXUtilLib.Pokemon.NameParser
{
    public static class NameParserFactory
    {
        /// <summary>
        /// NameParserのエントリーの一覧を読み込んで返します。
        /// </summary>
        public static IReadOnlyList<INameParserEntry> LoadEntries()
        {
            return Serializer.Deserialize<List<Internal.NameParserEntry>>(Application.FilePath.NameParserDataPath);
        }

        /// <summary>
        /// NameParserを作成します。
        /// </summary>
        public static INameParser Create()
        {
            return new Internal.NameParser(LoadEntries());
        }
    }
}
