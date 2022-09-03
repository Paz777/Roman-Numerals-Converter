using System;
namespace RomanNumeralsConverter.Models
{
    public class RomanNumerals
    {
        private Dictionary<string, int> RomanNumeralList = new Dictionary<string, int>()
        {
            { "I",1 },
            { "II",2 },
            { "III",3 },
            { "IV",4 },
            { "V",5 },
            { "VI",6 },
            { "VII",7 },
            { "VIII",8 },
            { "IX",9 },
            { "X",10 },
        };

        public int ConvertRomanNumeral(string romanNumeral)
        {
            return romanNumeral != null ? RomanNumeralList[romanNumeral.ToUpper()] : -1;
        }
    }
}

