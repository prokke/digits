
public class NumberToWords
{
    public static string SumProp(long nSum, string sGender, string sCase)
    {
        if (nSum < 0 || nSum >= 1000000000000)
            throw new Exception("вне диапозона");

        var units = GetUnits(sGender, sCase);
        var tens = GetTens(sCase);
        var hundreds = GetHundreds(sCase);
        var thousands = GetThousands(sGender, sCase);
        var millions = GetMillions(sCase);
        var billions = GetBillions(sCase);

        // разбиение по 3 знака
        var parts = new List<string>();
        var billionsPart = nSum / 1000000000;
        var millionsPart = (nSum / 1000000) % 1000;
        var thousandsPart = (nSum / 1000) % 1000;
        var rest = nSum % 1000;
        // --------------------------------------

        if (billionsPart > 0)
            parts.Add(ConvertThreeDigits(billionsPart, billions, units, sCase));
        if (millionsPart > 0)
            parts.Add(ConvertThreeDigits(millionsPart, millions, units, sCase));
        if (thousandsPart > 0)
            parts.Add(ConvertThreeDigits(thousandsPart, thousands, units, sCase));
        if (rest > 0 || nSum == 0)
            parts.Add(ConvertThreeDigits(rest, null , units, sCase));

        return string.Join(" ", parts).Trim();
    }

    private static string ConvertThreeDigits(long number, Dictionary<long, string> moreThanUnits, Dictionary<long, string> units, string sCase)
    {
        var tens = GetTens(sCase);
        var hundreds = GetHundreds(sCase);

        long hundredsPart = number / 100;
        long tensPart = (number / 10) % 10;
        long unitsPart = number % 10;

        var parts = new List<string>();
        if (hundredsPart > 0)
            parts.Add(hundreds[hundredsPart]);

        if (tensPart == 1)
        {
            parts.Add(tens[tensPart * 10 + unitsPart]);
        }
        else
        {
            if (tensPart > 0)
                parts.Add(tens[tensPart * 10]);
            if (unitsPart > 0)
                parts.Add(units[unitsPart]);
            if (moreThanUnits != null)
            {
                if (unitsPart > 0)
                    parts.Add(moreThanUnits[unitsPart]);
            }
                
        }

        return string.Join(" ", parts).Trim();
    }

    private static Dictionary<long, string> GetUnits(string sGender, string sCase)
    {
        var units = new Dictionary<long, string>();

        // единицы
        if (sGender.ToLower() == "м" && sCase.ToLower() == "и")
        {
            units[1] = "один";
            units[2] = "два";
            units[3] = "три";
            units[4] = "четыре";
            units[5] = "пять";
            units[6] = "шесть";
            units[7] = "семь";
            units[8] = "восемь";
            units[9] = "девять";
        }
        else if (sGender.ToLower() == "ж" && sCase.ToLower() == "и")
        {
            units[1] = "одна";
            units[2] = "две";
            units[3] = "три";
            units[4] = "четыре";
            units[5] = "пять";
            units[6] = "шесть";
            units[7] = "семь";
            units[8] = "восемь";
            units[9] = "девять";
        }
        else if (sGender.ToLower() == "с" && sCase.ToLower() == "и")
        {
            units[1] = "одно";
            units[2] = "два";
            units[3] = "три";
            units[4] = "четыре";
            units[5] = "пять";
            units[6] = "шесть";
            units[7] = "семь";
            units[8] = "восемь";
            units[9] = "девять";
        }
        else if (sGender.ToLower() == "м" && sCase.ToLower() == "р")
        {
            units[1] = "одного";
            units[2] = "двух";
            units[3] = "трёх";
            units[4] = "четырёх";
            units[5] = "пяти";
            units[6] = "шести";
            units[7] = "семи";
            units[8] = "восьми";
            units[9] = "девяти";
        }
        else if (sGender.ToLower() == "ж" && sCase.ToLower() == "р")
        {
            units[1] = "одной";
            units[2] = "двух";
            units[3] = "трёх";
            units[4] = "четырёх";
            units[5] = "пяти";
            units[6] = "шести";
            units[7] = "семи";
            units[8] = "восьми";
            units[9] = "девяти";
        }
        else if (sGender.ToLower() == "с" && sCase.ToLower() == "р")
        {
            units[1] = "одного";
            units[2] = "двух";
            units[3] = "трёх";
            units[4] = "четырёх";
            units[5] = "пяти";
            units[6] = "шести";
            units[7] = "семи";
            units[8] = "восьми";
            units[9] = "девяти";
        }
        else if (sGender.ToLower() == "м" && sCase.ToLower() == "д")
        {
            units[1] = "одному";
            units[2] = "двум";
            units[3] = "трём";
            units[4] = "четырём";
            units[5] = "пяти";
            units[6] = "шести";
            units[7] = "семи";
            units[8] = "восьми";
            units[9] = "девяти";
        }
        else if (sGender.ToLower() == "ж" && sCase.ToLower() == "д")
        {
            units[1] = "одной";
            units[2] = "двум";
            units[3] = "трём";
            units[4] = "четырём";
            units[5] = "пяти";
            units[6] = "шести";
            units[7] = "семи";
            units[8] = "восьми";
            units[9] = "девяти";
        }
        else if (sGender.ToLower() == "с" && sCase.ToLower() == "д")
        {
            units[1] = "одному";
            units[2] = "двум";
            units[3] = "трём";
            units[4] = "четырём";
            units[5] = "пяти";
            units[6] = "шести";
            units[7] = "семи";
            units[8] = "восьми";
            units[9] = "девяти";
        }
        else if (sGender.ToLower() == "м" && sCase.ToLower() == "в")
        {
            units[1] = "один";
            units[2] = "два";
            units[3] = "три";
            units[4] = "четыре";
            units[5] = "пять";
            units[6] = "шесть";
            units[7] = "семь";
            units[8] = "восемь";
            units[9] = "девять";
        }
        else if (sGender.ToLower() == "ж" && sCase.ToLower() == "в")
        {
            units[1] = "одну";
            units[2] = "две";
            units[3] = "три";
            units[4] = "четыре";
            units[5] = "пять";
            units[6] = "шесть";
            units[7] = "семь";
            units[8] = "восемь";
            units[9] = "девять";
        }
        else if (sGender.ToLower() == "с" && sCase.ToLower() == "в")
        {
            units[1] = "одно";
            units[2] = "два";
            units[3] = "три";
            units[4] = "четыре";
            units[5] = "пять";
            units[6] = "шесть";
            units[7] = "семь";
            units[8] = "восемь";
            units[9] = "девять";
        }
        else if (sGender.ToLower() == "м" && sCase.ToLower() == "т")
        {
            units[1] = "одним";
            units[2] = "двумя";
            units[3] = "тремя";
            units[4] = "четырьмя";
            units[5] = "пятью";
            units[6] = "шестью";
            units[7] = "семью";
            units[8] = "восьмью";
            units[9] = "девятью";
        }
        else if (sGender.ToLower() == "ж" && sCase.ToLower() == "т")
        {
            units[1] = "одной";
            units[2] = "двумя";
            units[3] = "тремя";
            units[4] = "четырьмя";
            units[5] = "пятью";
            units[6] = "шестью";
            units[7] = "семью";
            units[8] = "восьмью";
            units[9] = "девятью";
        }
        else if (sGender.ToLower() == "с" && sCase.ToLower() == "т")
        {
            units[1] = "одним";
            units[2] = "двумя";
            units[3] = "тремя";
            units[4] = "четырьмя";
            units[5] = "пятью";
            units[6] = "шестью";
            units[7] = "семью";
            units[8] = "восьмью";
            units[9] = "девятью";
        }
        else if (sGender.ToLower() == "м" && sCase.ToLower() == "п")
        {
            units[1] = "одном";
            units[2] = "двух";
            units[3] = "трёх";
            units[4] = "четырёх";
            units[5] = "пяти";
            units[6] = "шести";
            units[7] = "семи";
            units[8] = "восьми";
            units[9] = "девяти";
        }
        else if (sGender.ToLower() == "ж" && sCase.ToLower() == "п")
        {
            units[1] = "одной";
            units[2] = "двух";
            units[3] = "трёх";
            units[4] = "четырёх";
            units[5] = "пяти";
            units[6] = "шести";
            units[7] = "семи";
            units[8] = "восьми";
            units[9] = "девяти";
        }
        else if (sGender.ToLower() == "с" && sCase.ToLower() == "п")
        {
            units[1] = "одном";
            units[2] = "двух";
            units[3] = "трёх";
            units[4] = "четырёх";
            units[5] = "пяти";
            units[6] = "шести";
            units[7] = "семи";
            units[8] = "восьми";
            units[9] = "девяти";
        }

        return units;
    }

    // десятки
    private static Dictionary<long, string> GetTens(string sCase)
    {
        var tens = new Dictionary<long, string>();
        if (sCase.ToLower() == "и")
        {
            tens[10] = "десять";
            tens[11] = "одиннадцать";
            tens[12] = "двенадцать";
            tens[13] = "тринадцать";
            tens[14] = "четырнадцать";
            tens[15] = "пятнадцать";
            tens[16] = "шестнадцать";
            tens[17] = "семнадцать";
            tens[18] = "восемнадцать";
            tens[19] = "девятнадцать";
            tens[20] = "двадцать";
            tens[30] = "тридцать";
            tens[40] = "сорок";
            tens[50] = "пятьдесят";
            tens[60] = "шестьдесят";
            tens[70] = "семьдесят";
            tens[80] = "восемьдесят";
            tens[90] = "девяносто";
        }
        else if (sCase.ToLower() == "р")
        {
            tens[10] = "десяти";
            tens[11] = "одиннадцати";
            tens[12] = "двенадцати";
            tens[13] = "тринадцати";
            tens[14] = "четырнадцати";
            tens[15] = "пятнадцати";
            tens[16] = "шестнадцати";
            tens[17] = "семнадцати";
            tens[18] = "восемнадцати";
            tens[19] = "девятнадцати";
            tens[20] = "двадцати";
            tens[30] = "тридцати";
            tens[40] = "сорока";
            tens[50] = "пятидесяти";
            tens[60] = "шестидесяти";
            tens[70] = "семидесяти";
            tens[80] = "восьмидесяти";
            tens[90] = "девяноста";
        }
        else if (sCase.ToLower() == "д")
        {
            tens[10] = "десяти";
            tens[11] = "одиннадцати";
            tens[12] = "двенадцати";
            tens[13] = "тринадцати";
            tens[14] = "четырнадцати";
            tens[15] = "пятнадцати";
            tens[16] = "шестнадцати";
            tens[17] = "семнадцати";
            tens[18] = "восемнадцати";
            tens[19] = "девятнадцати";
            tens[20] = "двадцати";
            tens[30] = "тридцати";
            tens[40] = "сорока";
            tens[50] = "пятидесяти";
            tens[60] = "шестидесяти";
            tens[70] = "семидесяти";
            tens[80] = "восьмидесяти";
            tens[90] = "девяноста";
        }
        else if (sCase.ToLower() == "в")
        {
            tens[10] = "десять";
            tens[11] = "одиннадцать";
            tens[12] = "двенадцать";
            tens[13] = "тринадцать";
            tens[14] = "четырнадцать";
            tens[15] = "пятнадцать";
            tens[16] = "шестнадцать";
            tens[17] = "семнадцать";
            tens[18] = "восемнадцать";
            tens[19] = "девятнадцать";
            tens[20] = "двадцать";
            tens[30] = "тридцать";
            tens[40] = "сорок";
            tens[50] = "пятьдесят";
            tens[60] = "шестьдесят";
            tens[70] = "семьдесят";
            tens[80] = "восемьдесят";
            tens[90] = "девяносто";
        }
        else if (sCase.ToLower() == "т")
        {
            tens[10] = "десятью";
            tens[11] = "одиннадцатью";
            tens[12] = "двенадцатью";
            tens[13] = "тринадцатью";
            tens[14] = "четырнадцатью";
            tens[15] = "пятнадцатью";
            tens[16] = "шестнадцатью";
            tens[17] = "семнадцатью";
            tens[18] = "восемнадцатью";
            tens[19] = "девятнадцатью";
            tens[20] = "двадцатью";
            tens[30] = "тридцатью";
            tens[40] = "сорока";
            tens[50] = "пятьюдесятью";
            tens[60] = "шестьюдесятью";
            tens[70] = "семьюдесятью";
            tens[80] = "восемьюдесятью";
            tens[90] = "девяноста";
        }
        else if (sCase.ToLower() == "п")
        {
            tens[10] = "десяти";
            tens[11] = "одиннадцати";
            tens[12] = "двенадцати";
            tens[13] = "тринадцати";
            tens[14] = "четырнадцати";
            tens[15] = "пятнадцати";
            tens[16] = "шестнадцати";
            tens[17] = "семнадцати";
            tens[18] = "восемнадцати";
            tens[19] = "девятнадцати";
            tens[20] = "двадцати";
            tens[30] = "тридцати";
            tens[40] = "сорока";
            tens[50] = "пятидесяти";
            tens[60] = "шестидесяти";
            tens[70] = "семидесяти";
            tens[80] = "восьмидесяти";
            tens[90] = "девяноста";
        };

        return tens;
    }

    // сотни
    private static Dictionary<long, string> GetHundreds(string sCase)
    {
        var hundreds = new Dictionary<long, string>();
        if (sCase.ToLower() == "и")
        {
            hundreds[1] = "сто";
            hundreds[2] = "двести";
            hundreds[3] = "триста";
            hundreds[4] = "четыреста";
            hundreds[5] = "пятьсот";
            hundreds[6] = "шестьсот";
            hundreds[7] = "семьсот";
            hundreds[8] = "восемьсот";
            hundreds[9] = "девятьсот";
        }
        else if (sCase.ToLower() == "р")
        {
            hundreds[1] = "ста";
            hundreds[2] = "двухсот";
            hundreds[3] = "трёхсот";
            hundreds[4] = "четырёхсот";
            hundreds[5] = "пятисот";
            hundreds[6] = "шестисот";
            hundreds[7] = "семисот";
            hundreds[8] = "восьмисот";
            hundreds[9] = "девятисот";
        }
        else if (sCase.ToLower() == "д")
        {
            hundreds[1] = "ста";
            hundreds[2] = "двумстам";
            hundreds[3] = "трёмстам";
            hundreds[4] = "четырёмстам";
            hundreds[5] = "пятистам";
            hundreds[6] = "шестистам";
            hundreds[7] = "семистам";
            hundreds[8] = "восьмистам";
            hundreds[9] = "девятистам";
        }
        else if (sCase.ToLower() == "в")
        {
            hundreds[1] = "сто";
            hundreds[2] = "двести";
            hundreds[3] = "триста";
            hundreds[4] = "четыреста";
            hundreds[5] = "пятьсот";
            hundreds[6] = "шестьсот";
            hundreds[7] = "семьсот";
            hundreds[8] = "восемьсот";
            hundreds[9] = "девятьсот";
        }
        else if (sCase.ToLower() == "т")
        {
            hundreds[1] = "ста";
            hundreds[2] = "двумястами";
            hundreds[3] = "тремястами";
            hundreds[4] = "четырьмястами";
            hundreds[5] = "пятьюстами";
            hundreds[6] = "шестьюстами";
            hundreds[7] = "семьюстами";
            hundreds[8] = "восьмьюстами";
            hundreds[9] = "девятьюстами";
        }
        else if (sCase.ToLower() == "п")
        {
            hundreds[1] = "ста";
            hundreds[2] = "двухстах";
            hundreds[3] = "трёхстах";
            hundreds[4] = "четырёхстах";
            hundreds[5] = "пятистах";
            hundreds[6] = "шестистах";
            hundreds[7] = "семистах";
            hundreds[8] = "восьмистах";
            hundreds[9] = "девятистах";
        }

        return hundreds;
    }

    // тысячи
    private static Dictionary<long, string> GetThousands(string sGender, string sCase)
    {
        var thousands = new Dictionary<long, string>();
        if (sCase.ToLower() == "и")
        {
            thousands[1] = "тысяча";
            thousands[2] = "тысячи";
            thousands[3] = "тысячи";
            thousands[4] = "тысячи";
            thousands[5] = "тысяч";
            thousands[6] = "тысяч";
            thousands[7] = "тысяч";
            thousands[8] = "тысяч";
            thousands[9] = "тысяч";
        }
        else if (sCase.ToLower() == "р")
        {
            thousands[1] = "тысячи";
            thousands[2] = "тысяч";
            thousands[3] = "тысяч";
            thousands[4] = "тысяч";
            thousands[5] = "тысяч";
            thousands[6] = "тысяч";
            thousands[7] = "тысяч";
            thousands[8] = "тысяч";
            thousands[9] = "тысяч";
        }
        else if (sCase.ToLower() == "д")
        {
            thousands[1] = "тысяче";
            thousands[2] = "тысячам";
            thousands[3] = "тысячам";
            thousands[4] = "тысячам";
            thousands[5] = "тысячам";
            thousands[6] = "тысячам";
            thousands[7] = "тысячам";
            thousands[8] = "тысячам";
            thousands[9] = "тысячам";
        }
        else if (sCase.ToLower() == "в")
        {
            thousands[1] = "тысячу";
            thousands[2] = "тысячи";
            thousands[3] = "тысячи";
            thousands[4] = "тысячи";
            thousands[5] = "тысяч";
            thousands[6] = "тысяч";
            thousands[7] = "тысяч";
            thousands[8] = "тысяч";
            thousands[9] = "тысяч";
        }
        else if (sCase.ToLower() == "т")
        {
            thousands[1] = "тысячей";
            thousands[2] = "тысячами";
            thousands[3] = "тысячами";
            thousands[4] = "тысячами";
            thousands[5] = "тысячами";
            thousands[6] = "тысячами";
            thousands[7] = "тысячами";
            thousands[8] = "тысячами";
            thousands[9] = "тысячами";
        }
        else if (sCase.ToLower() == "п")
        {
            thousands[1] = "тысяче";
            thousands[2] = "тысячах";
            thousands[3] = "тысячах";
            thousands[4] = "тысячах";
            thousands[5] = "тысячах";
            thousands[6] = "тысячах";
            thousands[7] = "тысячах";
            thousands[8] = "тысячах";
            thousands[9] = "тысячах";
        }

        return thousands;
    }
    // миллионы
    private static Dictionary<long, string> GetMillions(string sCase)
    {
        var millions = new Dictionary<long, string>();
        if (sCase.ToLower() == "и")
        {
            millions[1] = "миллион";
            millions[2] = "миллиона";
            millions[3] = "миллиона";
            millions[4] = "миллиона";
            millions[5] = "миллионов";
            millions[6] = "миллионов";
            millions[7] = "миллионов";
            millions[8] = "миллионов";
            millions[9] = "миллионов";
        }
        else if (sCase.ToLower() == "р")
        {
            millions[1] = "миллиона";
            millions[2] = "миллионов";
            millions[3] = "миллионов";
            millions[4] = "миллионов";
            millions[5] = "миллионов";
            millions[6] = "миллионов";
            millions[7] = "миллионов";
            millions[8] = "миллионов";
            millions[9] = "миллионов";
        }
        else if (sCase.ToLower() == "д")
        {
            millions[1] = "миллиону";
            millions[2] = "миллионам";
            millions[3] = "миллионам";
            millions[4] = "миллионам";
            millions[5] = "миллионам";
            millions[6] = "миллионам";
            millions[7] = "миллионам";
            millions[8] = "миллионам";
            millions[9] = "миллионам";
        }
        else if (sCase.ToLower() == "в")
        {
            millions[1] = "миллион";
            millions[2] = "миллиона";
            millions[3] = "миллиона";
            millions[4] = "миллиона";
            millions[5] = "миллионов";
            millions[6] = "миллионов";
            millions[7] = "миллионов";
            millions[8] = "миллионов";
            millions[9] = "миллионов";
        }
        else if (sCase.ToLower() == "т")
        {
            millions[1] = "миллионом";
            millions[2] = "миллионами";
            millions[3] = "миллионами";
            millions[4] = "миллионами";
            millions[5] = "миллионами";
            millions[6] = "миллионами";
            millions[7] = "миллионами";
            millions[8] = "миллионами";
            millions[9] = "миллионами";
        }
        else if (sCase.ToLower() == "п")
        {
            millions[1] = "миллионе";
            millions[2] = "миллионах";
            millions[3] = "миллионах";
            millions[4] = "миллионах";
            millions[5] = "миллионах";
            millions[6] = "миллионах";
            millions[7] = "миллионах";
            millions[8] = "миллионах";
            millions[9] = "миллионах";
        }

        return millions;
    }
    // миллиарды
    private static Dictionary<long, string> GetBillions(string sCase)
    {
        var billions = new Dictionary<long, string>();
        if (sCase.ToLower() == "и")
        {
            billions[1] = "миллиард";
            billions[2] = "миллиарда";
            billions[3] = "миллиарда";
            billions[4] = "миллиарда";
            billions[5] = "миллиардов";
            billions[6] = "миллиардов";
            billions[7] = "миллиардов";
            billions[8] = "миллиардов";
            billions[9] = "миллиардов";
        }
        else if (sCase.ToLower() == "р")
        {
            billions[1] = "миллиарда";
            billions[2] = "миллиардов";
            billions[3] = "миллиардов";
            billions[4] = "миллиардов";
            billions[5] = "миллиардов";
            billions[6] = "миллиардов";
            billions[7] = "миллиардов";
            billions[8] = "миллиардов";
            billions[9] = "миллиардов";
        }
        else if (sCase.ToLower() == "д")
        {
            billions[1] = "миллиарду";
            billions[2] = "миллиардам";
            billions[3] = "миллиардам";
            billions[4] = "миллиардам";
            billions[5] = "миллиардам";
            billions[6] = "миллиардам";
            billions[7] = "миллиардам";
            billions[8] = "миллиардам";
            billions[9] = "миллиардам";
        }
        else if (sCase.ToLower() == "в")
        {
            billions[1] = "миллиард";
            billions[2] = "миллиард";
            billions[3] = "миллиард";
            billions[4] = "миллиард";
            billions[5] = "миллиардов";
            billions[6] = "миллиардов";
            billions[7] = "миллиардов";
            billions[8] = "миллиардов";
            billions[9] = "миллиардов";
        }
        else if (sCase.ToLower() == "т")
        {
            billions[1] = "миллиардом";
            billions[2] = "миллиардами";
            billions[3] = "миллиардами";
            billions[4] = "миллиардами";
            billions[5] = "миллиардами";
            billions[6] = "миллиардами";
            billions[7] = "миллиардами";
            billions[8] = "миллиардами";
            billions[9] = "миллиардами";
        }
        else if (sCase.ToLower() == "п")
        {
            billions[1] = "миллиарде";
            billions[2] = "миллиардах";
            billions[3] = "миллиардах";
            billions[4] = "миллиардах";
            billions[5] = "миллиардах";
            billions[6] = "миллиардах";
            billions[7] = "миллиардах";
            billions[8] = "миллиардах";
            billions[9] = "миллиардах";
        }

        return billions;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(NumberToWords.SumProp(31, "М", "Р"));
        Console.WriteLine(NumberToWords.SumProp(22, "С", "Т"));
        Console.WriteLine(NumberToWords.SumProp(154323, "М", "И"));
        Console.WriteLine(NumberToWords.SumProp(154323, "М", "Т"));
    }
}
