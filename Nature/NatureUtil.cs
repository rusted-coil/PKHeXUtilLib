using PKHeX.Core;

namespace PKHeXUtilLib.Nature
{
    public static class NatureUtil
    {
        /// <summary>
        /// 指定したIndexの性格名称を取得します。
        /// </summary>
        public static string GetNatureName(int natureIndex, string languageCode)
        {
            return Util.GetNaturesList(languageCode)[natureIndex];
        }

        /// <summary>
        /// 性格名称から性格Indexを取得します。
        /// <para> * 存在しない場合は-1を返します。</para>
        /// </summary>
        public static int GetNatureIndex(string natureName, string languageCode)
        {
            var natureList = Util.GetNaturesList(languageCode);
            for (int i = 0; i < natureList.Length; ++i)
            {
                if (natureList[i] == natureName)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
