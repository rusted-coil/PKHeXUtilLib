namespace PKHeXUtilLib.Pokemon.NameParser.Internal
{
    internal sealed class NameParser : INameParser
    {
        readonly IReadOnlyList<INameParserEntry> m_Entries;

        public NameParser(IReadOnlyList<INameParserEntry> entries)
        {
            m_Entries = entries;
        }

        public (string Name, int FormIndex) Parse(string name)
        {
            for (int i = 0; i < m_Entries.Count; ++i)
            {
                if (name.Contains(m_Entries[i].PokemonName) && name.Contains(m_Entries[i].FormWord))
                {
                    return (m_Entries[i].PokemonName, m_Entries[i].FormIndex);
                }
            }
            return (name, 0);
        }
    }
}
