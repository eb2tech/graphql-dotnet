using GraphQL.Types;

namespace GraphQL.StarWars.Types
{
    public enum Episodes
    {
        NEWHOPE = 4,
        EMPIRE = 5,
        JEDI = 6,
        AWAKENS = 7
    }

    public class EpisodeEnum : EnumerationGraphType
    {
        public EpisodeEnum()
        {
            Name = "Episode";
            Description = "One of the films in the Star Wars Trilogy.";
            AddValue("NEWHOPE", "Released in 1977.", (int)Episodes.NEWHOPE);
            AddValue("EMPIRE", "Released in 1980.", (int)Episodes.EMPIRE);
            AddValue("JEDI", "Released in 1983.", (int)Episodes.JEDI);
            AddValue("AWAKENS", "Released in 1983.", (int)Episodes.AWAKENS);
        }
    }
}
