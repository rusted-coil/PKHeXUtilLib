using PKHeX.Core;

namespace PKHeXUtilLib.Pokemon.Species.Internal
{
    internal sealed class Pokemon : IPokemon
    {
        public required string Name { get; init; }
        public required int Index { get; init; }
        public required int FormIndex { get; init; }
        public IReadOnlyList<int> Types { get; init; }

        public int HpBase { get; init; }
        public int AtkBase { get; init; }
        public int DefBase { get; init; }
        public int SpAtkBase { get; init; }
        public int SpDefBase { get; init; }
        public int SpdBase { get; init; }

        public Pokemon(PersonalInfo personalInfo)
        {
            if (personalInfo.Type1 != personalInfo.Type2)
            {
                Types = new int[] { personalInfo.Type1, personalInfo.Type2 };
            }
            else
            {
                Types = new int[] { personalInfo.Type1 };
            }
            HpBase = personalInfo.HP;
            AtkBase = personalInfo.ATK;
            DefBase = personalInfo.DEF;
            SpAtkBase = personalInfo.SPA;
            SpDefBase = personalInfo.SPD;
            SpdBase = personalInfo.SPE;
        }
    }
}
