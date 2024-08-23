namespace PKHeXUtilLib.Pokemon.NameParser
{
    public interface INameParser
    {
        /// <summary>
        /// フォルム情報を含む文字列から、種族名とフォルムIndexの組を返します。
        /// <para> * パースできなかった場合は入力のnameと0を返します。</para>
        /// </summary>
        (string Name, int FormIndex) Parse(string name);
    }
}
