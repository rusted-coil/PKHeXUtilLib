using PKHeX.Core;

namespace PKHeXUtilLib.Type
{
    public static class TypeUtil
    {
        /// <summary>
        /// 指定したIndexのタイプ名称を取得します。
        /// </summary>
        public static string GetTypeName(int typeIndex, string languageCode)
        {
            return Util.GetTypesList(languageCode)[typeIndex];
        }

        /// <summary>
        /// タイプ名称からタイプIndexを取得します。
        /// <para> * 存在しない場合は-1を返します。</para>
        /// </summary>
        public static int GetTypeIndex(string typeName, string languageCode)
        {
            var typeList = Util.GetTypesList(languageCode);
            for (int i = 0; i < typeList.Length; ++i)
            {
                if (typeList[i] == typeName)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
