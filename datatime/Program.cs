// See https://aka.ms/new-console-template for more information
DateTime currentDate = DateTime.Now;
Console.WriteLine("Current date: " + currentDate);

DateTime customDateTime = new DateTime(2023, 11, 19, 10, 30, 0);
Console.WriteLine("Created date: " + customDateTime);

Console.WriteLine("gunu yazin:");
int day = int.Parse(Console.ReadLine());

Console.WriteLine("ay yazin :");
int month = int.Parse(Console.ReadLine());

while (true)
{
    if (month == currentDate.Month && day == currentDate.Day)
    {
        Console.WriteLine("dugundur");
        break;
    }
    else
    {
        Console.WriteLine("tezden daxil edin sehvdir");
        day = int.Parse(Console.ReadLine());
        month = int.Parse(Console.ReadLine());
    }
}
DateTime BaslangicDate = new DateTime(2023, 1, 1);
DateTime qutarmaDate = new DateTime(2023, 12, 31);
TimeSpan difference = qutarmaDate - BaslangicDate;
Console.WriteLine("İki tarix arasındakı fərq: " + difference.Days + " gün");

void CalculateMyAge(DateTime currentDate, DateTime birthday)
{
    int age = currentDate.Year - birthday.Year;


    if (birthday.Month > currentDate.Month || (birthday.Month == currentDate.Month && birthday.Day > currentDate.Day))
    {

        age--;
    }


    Console.WriteLine("menim yasim: "+age);
}

DateTime current = DateTime.Now;
DateTime birthdate = new DateTime(2008, 2, 21); 

CalculateMyAge(current, birthdate);
DateTime eventTime = new DateTime(2023, 11, 20, 8, 0, 0); 


string NameOfParticipater =Console.ReadLine();


    if(NameOfParticipater == "Nihad")
    {
        if (current > eventTime)
        {
            Console.WriteLine("siz bura gecikmisiniz");
    }
    else
    {
        Console.WriteLine("duzgun vaxta gelmisiz");
    }
    }

DateTime myDate = new DateTime(2015, 12, 25, 10, 30, 45);
int year = myDate.Year;
int month1 = myDate.Month; 
int day1 = myDate.Day; 
int hour = myDate.Hour;
int minute = myDate.Minute; 
int second = myDate.Second; 

string telebeAdi=Console.ReadLine();
if(telebeAdi == "Fuad")
{
    Console.WriteLine("siz dogru kisini vurguladiniz");
    if(current.Hour==15) {
        Console.WriteLine("imtahana duzgun vaxta catmisiz");
    }
    else
    {
        Console.WriteLine("vaxti qacirmirsizniz");
    }
}