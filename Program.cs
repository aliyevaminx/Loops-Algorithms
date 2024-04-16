
///////////////////////////////Task1 50ə qədər olan ədədləri artan sıra ilə göstərmək
/*
for (int i = 1; i <= 50; i++)
{
    Console.WriteLine(i);
}
*/


///////////////////////////////Task2 40a qədər 3ə bölünən ədədlərin sayını tapmaq
/*
int say = 0;

for (int i = 1; i <= 40; i++)
{
    if (i % 3 == 0)
    {
        say++;
    }
}
Console.WriteLine(say);
*/



//////////////////////////////Task3 100ə qədər həm 3ə həm 7ə bölünən ədədləri tapmaq və göstərmək
/*
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 7 == 0)
    {
        Console.WriteLine(i);
    }
}
*/



//////////////////////////Task4 Ədədin rəqəmlərinin sayını tapmaq
/*
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;



while (number > 0)
{
    number /= 10;
    count++;
} 
Console.WriteLine(count);
*/



///////////////////////////Task5 Ədədi tərsinə yazmaq
/*
int number = Convert.ToInt32(Console.ReadLine());
int reqem;
int reverse = 0;

while (number > 0)
{
    reqem = number % 10;
    reverse = (reverse * 10) + reqem;
    number /= 10;
}
Console.WriteLine(reverse);
*/



/////////////////////////Task6 Ədədin faktorialini tapmaq
/*
int cem = 1;
int number  = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    cem *= i;
}
Console.WriteLine(cem);
*/



///////////////////////Task7 Ədədin sadə və ya mürəkkəb olduğunu tapmaq
/*
int number = Convert.ToInt32(Console.ReadLine());
bool isPrimitive = true;

for (int i = 2; i < number; i++)
{
    if (number % i == 0)
        isPrimitive = false;
}

if (isPrimitive)
{
    Console.WriteLine("Sade");
}
else
{
    Console.WriteLine("Murekkeb");
}
*/




///////////////////////Task8 Ədədin rəqəmlərinin cəminin tapmaq
/*
int number = Convert.ToInt32(Console.ReadLine());
int cem = 0;

while (number > 0)
{
    int reqem = number % 10;
    cem += reqem;
    number /= 10;
}
Console.WriteLine(cem);
*/



//////////////////////////Task9 Ədədin rəqəmləri içərisində ən böyüyü tapmaq
/*
int number = Convert.ToInt32(Console.ReadLine());
int reqem;
int max = 0;

while (number > 0)
{
    reqem = number % 10;

    if (reqem > max)
    {
        max = reqem;
    }
    else 
    {
        number /= 10;
    }  
}
Console.WriteLine(max);
*/



////////////////Task10 70dən kiçik olan ədədlərdən cüt olanları azalan sıra ilə göstərmək
/*
int i = 70;

while (i > 0)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i--;
}
*/



////////////////////////////////Task11
/*
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int say = 0;

for (int i = number1; i <= number2; i++)
{
    if (i % 3 == 0 && i % 4 == 0 )
    {
        say++;
    }
}
Console.WriteLine(say);
*/



///////////////////////////////////////////////////////////////////NEW TASKS

//TASK0 Menfi musbet eded

/*
InitialLine: int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine("Eded musbetdir");
}
else if (number < 0) 
{
    Console.WriteLine("Eded menfidir");
} else
{
    Console.WriteLine("Eded sifirdir");
}

goto InitialLine;
*/




//TASK1 Ixtiyari daxil edilmis 5 ededin cemi

/*For Loop ile
int result = 0;

for (int i = 1; i <=5; i++)
{
    int num = Convert.ToInt32(Console.ReadLine());
    result += num;
}
Console.WriteLine(result);
*/


/* While loop ile
int result = 0;
int i = 1;

while (i <= 5)
{
    int num = Convert.ToInt32(Console.ReadLine());
    result += num;
    i++;
}
Console.WriteLine(result);
*/




//TASK2 Ixtiyari daxil edilmis ededin kvadratini tapin
/*
int a = Convert.ToInt32(Console.ReadLine());
int result = a * a;

Console.WriteLine(result);
*/



//TASK3 Ixtiyari daxil edilmis 3 ededden en boyuyunu tapin.
/*
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
   if (num2 == num3)
    {
        Console.WriteLine("Birinci reqem en boyukdur");
    } 
    else if (num3 > num1) 
    {
        Console.WriteLine("Ucuncu reqem en boyukdur");
    }
} else if (num1 == num2 && num2 == num3)
{
    Console.WriteLine("Ucu de beraberdir");
}
else
{
    Console.WriteLine("Ikinci reqem en boyukdur");
}
*/





//TASK4 Iki ixtiyari eded daxil edilir birincinin kubunun ikinciden boyuk olub olmadigini tapan alqoritma
/*
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 * num1 * num1 > num2)
{
    Console.WriteLine("Boyukdur");
} else 
{
    Console.WriteLine("Kicikdir");
}
*/




//TASK5 Ededin hem 3e, hem 5e bolunub bolunmemesini tapan alqoritm
/*
Console.WriteLine("Ededi daxil edin:");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 3 == 0 && num % 5 == 0)
{
    Console.WriteLine("Eded hem uce hem bese bolunur");
} else
{
    Console.WriteLine("Eded hem 3e hem 5e bolunmur ");
}
*/




//TASK6 Input olaraq kartdaki mebleg ve mehsulun qiymeti goturulur, pulun catib catmadigini tapan alqoritma
/*
Console.WriteLine("Kartdaki mebleg:");
int cardBalance = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Mehsulun qiymeti:");
int itemPrice = Convert.ToInt32(Console.ReadLine());

if (cardBalance >= itemPrice)
{
    Console.WriteLine("Pulun catir");
} else
{
    Console.WriteLine("Pulun catmir");
}
*/



//TASK7 Telebenin kecib kecmediyini yoxlayan alqoritm

int totalPoint = 0;
int i = 1;

for (i = 1; i <= 5; i++)
{
    InitialLine: Console.WriteLine(i + "." + " Fenni daxil edin:");
    int point = Convert.ToInt32(Console.ReadLine());
    if (point >= 0 && point <= 100)
    {
        totalPoint += point;
    }
    else 
    {
        goto InitialLine;
    }
}

int ortalama = totalPoint / (i - 1);

if (ortalama >= 65)
{
    Console.WriteLine("Ortalama: " + ortalama + ". Kecdin...");
} else
{
    Console.WriteLine("Ortalama: " + ortalama + ". Kesildin...");
}




//TASK8 Daxil edilen 2 ededden hansinin boyuk oldgunu tapan
/*
Console.WriteLine("Birinci reqemi daxil edin:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ikinci reqemi daxil edin:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > 0 && num2 > 0)
{
    if (num1 > num2)
    {
        Console.WriteLine("Birinci reqem boyukdur");
    }
    else
    {
        Console.WriteLine("Ikinci reqem boyukdur");
    }
} else
{
    Console.WriteLine("Natural eded deyil");
}
*/

//TASK9 Suyun temperaturu
/*
int waterTemperature = Convert.ToInt32(Console.ReadLine());

if (waterTemperature > 0)
{
    Console.WriteLine("Donma temperaturundan yuxaridir");
} else
{
    Console.WriteLine("Donma temperaturundan asagidir");
}
*/



///////Ulduz Taski 1
/*
Console.WriteLine("Setir sayini daxil edin:");
int setir = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sutun sayini daxil edin:");
int sutun = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= setir; i++)
{
    for (int j = 1; j <= sutun; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
*/

//////Ulduz Taski 2
/*
Console.WriteLine("Setir sayini daxil edin:");
int setir = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= setir; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
} 
*/

///////Ulduz Taski 3
/*
Console.WriteLine("Setir sayini daxil edin:");
int setir = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= setir; i++)
{
    for (int j = i; j <= setir; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
*/




////////////////Switch Case ilin fesli daxil edilir. Meselen 11. Cavab olaraq: Noyabr, Payiz feslidir
/*
Console.WriteLine("Fesli daxil edin:");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 11:
    case 12:
    case 1:
        Console.WriteLine("Qis");
        break;
    case 2:
    case 3:
    case 4:
        Console.WriteLine("Yaz");
        break;
    case 5:
    case 6:
    case 7:
        Console.WriteLine("Yay");
        break;
    case 8:
    case 9:
    case 10:
        Console.WriteLine("Payiz");
        break;
    default:
        break;
}
*/
