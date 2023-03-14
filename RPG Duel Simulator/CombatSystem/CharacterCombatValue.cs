namespace RPG_Duel_Simulator.CombatSystem
/*
 * Denne klassen er enda ikke implementert i applikasjon og er dermed en plantegning for et fremtidig kampsystem.
 * Denne klassen definerer defensiv og offensive verdier for karakteren,
 * de forskjellige attributene har forskjellig påvirkning på den totale kamp-verdien.
 */
{
    public class CharacterCombatValue
    {
        float defenceTacticModifier = 1; // Modifiserer av defensiv-verdi avhengig av valgt taktikk, 1 er standard verdi.
        float offenciveTacticModifier = 1; // Modifiserer av offensiv-verdi avhengig av valgt taktikk, 1 er standard verdi.
        float baseDefence = 90;
        float baseOffence = 40;
        float characterDefence = 0;
        float characterOffence = 0;
        float characterCS = 0;

        static float CharacterDefence(float baseDefence, int level, int WIL, int AGL, int SPD, int END, int PER, int LUCK, int equipment, float defenceTacticModifier) // Utregning av karakterens deffensive score
        {
            float characterDefence = (float)((baseDefence + level * 10 + WIL * 0.6 + AGL * 0.4 + SPD * 0.2 + END * 1 + PER * 0.1 + ((equipment / 10) * (level * 1.1)) + (LUCK * 0.1)) * defenceTacticModifier);
            return characterDefence;
        }

        static float CharacterOffence(float baseOffence, int level, int STR, int INTL, int WIL, int AGL, int SPD, int PER, int LUCK, int equipment, float offenciveTacticModifier) // Utregning av karakterens offensive score
        {
            float characterOffence = (float)((baseOffence + level * 10 + STR * 0.5 + INTL * 0.5 + WIL * 0.2 + AGL * 0.7 + SPD * 0.3 + PER * 0.1 + ((equipment / 10) * (level * 1.2)) + (LUCK * 0.15)) * offenciveTacticModifier);
            return characterOffence;
        }

        static float CharacterCombatScore(float characterDefence, float characterOffence) // Utregner kamp-verdien til karakteren
        {
            float characterCS = characterDefence + characterOffence;
            return characterCS;
        }

        static void Main(string[] args, float characterDefence, float characterOffence, float characterCS)
        {
            //Console.WriteLine(CharacterDefence(characterDefence));
            //Console.WriteLine(CharacterOffence(characterOffence));
            //Console.WriteLine(CharacterCombatScore(characterCS));
        }
    }
}
