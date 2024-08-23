using PKHeX.Core;

namespace PKHeXUtilLib.Pokemon.Species
{
    public static class SpeciesFactory
    {
        /// <summary>
        /// 全国図鑑番号とフォルムIndexからデータを取得します。
        /// <para> * SVに存在しない場合、nullを返します。</para>
        /// </summary>
		public static IPokemon? Create(int speciesIndex, int formIndex, string languageCode)
        {
            var personalInfo = PersonalTable.SV[(ushort)speciesIndex, (byte)formIndex];
            if (personalInfo.IsPresentInGame && formIndex < personalInfo.FormCount)
            {
                return new Internal.Pokemon(personalInfo)
                {
                    Name = Util.GetSpeciesList(languageCode)[speciesIndex],
                    Index = speciesIndex,
                    FormIndex = formIndex,
                };
            }
            return null;
        }
    }
}
