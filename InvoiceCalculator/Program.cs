
const decimal PRICE_PER_SMS_LOWER_THAN_FIFTY = 0.18m;
const decimal PRICE_PER_SMS_BETWEEN_FIFTY_AND_HUNDRED = 0.16m;
const decimal PRICE_PER_SMS_LARGER_THAN_HUNDRED = 0.11m;
const decimal PRICE_PER_MMS_LOWER_THAN_FIFTY = 0.25m;
const decimal PRICE_PER_MMS_BETWEEN_FIFTY_AND_HUNDRED = 0.23m;
const decimal PRICE_PER_MMS_LARGER_THAN_HUNDRED = 0.18m;
const decimal PRICE_PER_MINUTE_TO_A1 = 0.03m;
const decimal PRICE_PER_MINUTE_TO_OTHERS = 0.09m;
const decimal PRICE_PER_MINUTE_IN_ROAMING = 0.15m;
const decimal PRICE_PER_MB_IN_BG = 0.02m;
const decimal PRICE_PER_MB_IN_EU = 0.05m;
const decimal PRICE_PER_MB_OUTSIDE_EU = 0.20m;

Console.WriteLine("Въведете месечната такса на клиента:");

decimal monthlyFee = decimal.Parse(Console.ReadLine());

Console.WriteLine("Въведете брой SMS:");

int numberOfSMS = int.Parse(Console.ReadLine());

Console.WriteLine("Въведете брой MMS:");

int numberOfMMS = int.Parse(Console.ReadLine());

Console.WriteLine("Въведете допълнителните минути към А1:");

int extraMinutesToA1 = int.Parse(Console.ReadLine());

Console.WriteLine("Въведете допълнителните минути към Теленор:");

int extraMinutesToTelenor = int.Parse(Console.ReadLine());

Console.WriteLine("Въведете допълнителните минути към Виваком:");

int extraMinutesToVivacom = int.Parse(Console.ReadLine());

Console.WriteLine("Въведете минутите в роуминг:");

int minutesInRoaming = int.Parse(Console.ReadLine());

Console.WriteLine("Въведете допълнителните MБ в страната:");

int extraMbInBG = int.Parse(Console.ReadLine());

Console.WriteLine("Въведете допълнителните MБ в Европейския съюз:");

int extraMbInEU = int.Parse(Console.ReadLine());

Console.WriteLine("Въведете допълнителните MБ извън Европейския съюз:");

int extraMbOutOfEU = int.Parse(Console.ReadLine());

Console.WriteLine("Въведете допълнителните такси:");

decimal otherFees = decimal.Parse(Console.ReadLine());

Console.WriteLine("Въведете отстъпките:");

decimal discount = decimal.Parse(Console.ReadLine());


decimal result = monthlyFee;


if (numberOfSMS > 100)
{
    result += numberOfSMS * PRICE_PER_SMS_LARGER_THAN_HUNDRED;
}
else if (numberOfSMS >= 50 && numberOfSMS <= 100)
{
    result += numberOfSMS * PRICE_PER_SMS_BETWEEN_FIFTY_AND_HUNDRED;
}
else
{
    result += numberOfSMS * PRICE_PER_SMS_LOWER_THAN_FIFTY;
}

if (numberOfMMS > 100)
{
    result += numberOfMMS * PRICE_PER_MMS_LARGER_THAN_HUNDRED;
}
else if (numberOfMMS >= 50 && numberOfMMS <= 100)
{
    result += numberOfMMS * PRICE_PER_MMS_BETWEEN_FIFTY_AND_HUNDRED;
}
else
{
    result += numberOfMMS * PRICE_PER_MMS_LOWER_THAN_FIFTY;
}

result += extraMinutesToA1 * PRICE_PER_MINUTE_TO_A1;
result += (extraMinutesToTelenor + extraMinutesToVivacom) * PRICE_PER_MINUTE_TO_OTHERS;
result += minutesInRoaming * PRICE_PER_MINUTE_IN_ROAMING;
result += extraMbInBG * PRICE_PER_MB_IN_BG;
result += extraMbInEU * PRICE_PER_MB_IN_EU;
result += extraMbOutOfEU * PRICE_PER_MB_OUTSIDE_EU;
result += otherFees;
result -= discount;

Console.WriteLine($"Месечната сметка на клиента е: {result}лв.");