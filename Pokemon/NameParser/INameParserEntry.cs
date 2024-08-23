namespace PKHeXUtilLib.Pokemon.NameParser
{
    public interface INameParserEntry
    {
        /// <summary>
        /// ポケモンの種族名を取得します。
        /// </summary>
        string PokemonName { get; }

        /// <summary>
        /// フォルムを判別するキーワードを取得します。
        /// </summary>
        string FormWord { get; }

        /// <summary>
        /// 全国図鑑番号を取得します。
        /// </summary>
        int DexIndex { get; }

        /// <summary>
        /// フォルム番号を取得します。
        /// </summary>
        int FormIndex { get; }
    }
}
