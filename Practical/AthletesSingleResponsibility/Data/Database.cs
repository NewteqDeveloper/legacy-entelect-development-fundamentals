using AtheletesSingleResponsibility.Athletes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtheletesSingleResponsibility.Data
{
    public static class Database
    {
        public static List<Athelete> Atheletes = new List<Athelete>
        {
            new HighJumper("High", "Jumper", Gender.Male, "ZA"),
            new HighJumper("Girl", "Jumper", Gender.Female, "US"),
            new JavelinThrower("Super", "Armer", Gender.Male, "ZA"),
            new JavelinThrower("Girl", "Javelin", Gender.Female, "UK"),
            new LongJumper("Super", "Long", Gender.Male, "ZA"),
            new Runner("Usain", "Bolt", Gender.Male, "JM"),
            new Runner("Caster", "Semenya", Gender.Female, "ZA"),
            new ShotputThrower("Heavy", "Dude", Gender.Male, "AU"),
            new Swimmer("Fast", "Swimm", Gender.Female, "NZ"),
            new HighJumper("Michael", "Phelps", Gender.Male, "US"),
        };
    }
}
