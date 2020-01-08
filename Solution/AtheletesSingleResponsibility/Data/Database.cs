using AtheletesSingleResponsibility.Athletes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtheletesSingleResponsibility.Data
{
    public static class Database
    {
        public static List<Athlete> Atheletes = new List<Athlete>
        {
            new HighJumper("High", "Jumper", Gender.Male, "ZA"),
            new HighJumper("Girl", "Jumper", Gender.Female, "US"),
            new JavelinThrower("Super", "Armer", Gender.Male, "ZA"),
            new JavelinThrower("Girl", "Javelin", Gender.Female, "UK"),
            new LongJumper("Super", "Long", Gender.Male, "ZA"),
            new Sprinter("Usain", "Bolt", Gender.Male, "JM", SprintDistance.OneHundred),
            new Sprinter("Caster", "Semenya", Gender.Female, "ZA", SprintDistance.TwoHundred),
            new ShotputThrower("Heavy", "Dude", Gender.Male, "AU"),
            new Swimmer("Fast", "Swimm", Gender.Female, "NZ", SwimDistance.TwoHundred),
            new HighJumper("Michael", "Phelps", Gender.Male, "US"),
        };
    }
}
