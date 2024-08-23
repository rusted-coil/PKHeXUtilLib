namespace PKHeXUtilLib.Pokemon.NameParser.Internal
{
    internal sealed class NameParserEntry : INameParserEntry
    {
        public required string PokemonName { get; set; }
        public required string FormWord { get; set; }
        public required int DexIndex { get; set; }
        public required int FormIndex { get; set; }
    }
}
