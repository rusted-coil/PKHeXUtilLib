using PKHeX.Core;

namespace PKHeXUtilLib.Pokemon.Species
{
    public static class SpeciesUtil
    {
        /// <summary>
        /// 種族ごとの名前をリストとして取得します。
        /// <para> * 配列のIndexを全国図鑑番号(1=フシギダネ)とし、フォルムなどの情報は含みません。</para>
        /// <para> * 0は「タマゴ」が入ります。</para>
        /// </summary>
        public static string[] GetSpeciesNames(string languageCode)
        {
            return Util.GetSpeciesList(languageCode);
        }

        /// <summary>
        /// 種族名から全国図鑑番号を取得します。
        /// <para> * 存在しない場合は-1を返します。</para>
        /// </summary>
        public static int GetSpeciesIndex(string speciesName, string languageCode)
        {
            var speciesList = Util.GetSpeciesList(languageCode);
            for (int i = 0; i < speciesList.Length; ++i)
            {
                if (speciesList[i] == speciesName)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
