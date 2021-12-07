// See https://aka.ms/new-console-template for more information
using Clinic;

Console.WriteLine("Hello, World!");

int[,] diary = new int[4, 7];
Random Random = new Random();

Doctor doc1 = new Doctor("shosh", "levi", "nurse", 40, 1940);
int counter = 0;
List<Doctor> listDoctor = new List<Doctor>();
//===================
int SelectNumFromUser = 0;
void titelMenu()
{
    Console.WriteLine("print 1 to add , print 2 to find doctor , print 3 for doctors , 4 for Another patient , 5 for show patient ,6 for days dwon 5 patient");
   SelectNumFromUser = int.Parse(Console.ReadLine());
}

//Console.WriteLine("print name of doctor");
//string nameOfDoc = Console.ReadLine();
//==================
void oneCase()
{
    Console.WriteLine("name , lname , job , numPatients, yearOfBirth ");
    Doctor docByUser = new Doctor(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
    listDoctor.Add(docByUser);
    FileStream fs3 = new FileStream($@"C:\clinic\doctors.txt", FileMode.Append);
    using (StreamWriter writer = new StreamWriter(fs3))
    {
        for (int i = 0; i < listDoctor.Count; i++)
        {
            writer.WriteLine($"{counter++} - name :{listDoctor[i].name} , lname :{listDoctor[i].lname} , job :{listDoctor[i].job} , numPatients :{listDoctor[i].numPatients} ,yearOfBirth :{listDoctor[i].yearOfBirth},");
            Console.WriteLine($" - name :{listDoctor[i].name} , lname :{listDoctor[i].lname} , job :{listDoctor[i].job} , numPatients :{listDoctor[i].numPatients} ,yearOfBirth :{listDoctor[i].yearOfBirth},");
        }
    }

    FileStream fs = new FileStream($@"C:\clinic\{docByUser.name}.txt", FileMode.Append);
    using (StreamWriter writer = new StreamWriter(fs))
    {
        for (int i = 0; i < listDoctor.Count; i++)
        {
            writer.WriteLine($"{counter++} - name :{listDoctor[i].name} , lname :{listDoctor[i].lname} , job :{listDoctor[i].job} , numPatients :{listDoctor[i].numPatients} ,yearOfBirth :{listDoctor[i].yearOfBirth},");
        }
    }
}
//================================
void twoCase()
{
    Console.WriteLine("print name of the doctor");
    string nameDocFromUser = Console.ReadLine();

    FileStream fileStream = new FileStream($@"C:\clinic\{nameDocFromUser}.txt", FileMode.Open);
    using (StreamReader reader = new StreamReader(fileStream))
    {
        Console.WriteLine(reader.ReadToEnd());
    }
}
//================================
void threeCase()
{
    FileStream fileStream = new FileStream($@"C:\clinic\doctors.txt", FileMode.Open);
    using (StreamReader reader = new StreamReader(fileStream))
    {
        Console.WriteLine(reader.ReadToEnd());
    }
}

//================================
//לא עובד
void fourCase()
{
    Console.WriteLine("print name of the doctor");
    string nameDocFromUser = Console.ReadLine();

    FileStream fileStream = new FileStream($@"C:\clinic\{nameDocFromUser}.txt", FileMode.Open);
    using (StreamReader reader = new StreamReader(fileStream))
    {
        Console.WriteLine(reader.ReadToEnd());
    }
}
//=======================
void menu()
{
    titelMenu();
    switch (SelectNumFromUser)
    {
        case 1:
            oneCase();
           
            break;

        case 2:
            twoCase();

                break;
        case 3:
            threeCase();

            break;

        case 4:
            fourCase();

            break;

        case 5:
            Console.WriteLine("choose num of week & num of days");
            Schedule.fiveCase(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            break;

        case 6:
            Console.WriteLine("choose num of week & num of days");
            Schedule.sixCase(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            break;

        default:
            Console.WriteLine("try again");
            menu();
            break;
    }

}
menu();

//=====================================
try
{
    titelMenu();
}
catch (FormatException)
{ 
    Console.WriteLine("value must be number");
}
catch (DivideByZeroException) 
{ 
    Console.WriteLine("Can't divide by zero");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
//==========================================
try
{
    oneCase();
}
catch (FormatException)
{
    Console.WriteLine("value must be number");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Can't divide by zero");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}

//==========================================
try
{
    twoCase();
}
catch (FormatException)
{
    Console.WriteLine("value must be number");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Can't divide by zero");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
//==========================================
try
{
    threeCase();
}
catch (FormatException)
{
    Console.WriteLine("value must be number");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Can't divide by zero");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
//==========================================
//try
//{
//    fourCase();
//}
//catch (FormatException)
//{
//    Console.WriteLine("value must be number");
//}
//catch (DivideByZeroException)
//{
//    Console.WriteLine("Can't divide by zero");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.ToString());
//}
//==========================================
try
{
    Schedule.fiveCase(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

}
catch (FormatException)
{
    Console.WriteLine("value must be number");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Can't divide by zero");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
//==========================================
try
{
    Schedule.sixCase(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
}
catch (FormatException)
{
    Console.WriteLine("value must be number");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Can't divide by zero");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
//==========================================

//19.הפכו כל יום שביעי ל 0 חולים.
//void array()
//{
//int[,] diary = new int[4, 7];
//Random Random = new Random();
//    for (int i = 0; i < diary.GetLength(0); i++)
//    {
//        Console.WriteLine($"diary : {i}  ");
//        for (int j = 0; j < diary.GetLength(1); j++)
//        {
//            diary[i, j] = Random.Next(1, 10);
//        }
//    }
//        }
//void fiveCase(){
//    //1.צרו מערך דו מימדי בשם יומן.
//    //2.	ביומן יש 4 שבועות ובכל שבוע 7 ימים.
//    array();

////16.בכל יום יש מספר רנדומלי של חולים, המספר נע מ1 עד 10 חולים ביום.

//    for (int i = 0; i <4; i++)
//{
//        Console.WriteLine($"diary : {i}  ");
//    for (int j = 0; j < 7; j++)
//    {
//            if (j==6)
//            {
//                diary[i, 6] = 0;
//            }
//            else
//            {
//                diary[i, j] = Random.Next(1, 10);

//            }
//            Console.Write($" {diary[i, j]} ");
//        }
//    }
//        Console.WriteLine();
//        }

//void sixCase()
//{
//    array();
//    //string text = "bussy";
//    for (int i = 0; i < diary.GetLength(0); i++)
//    {
//        Console.Write($"diary : {i}  -");
//        for (int j = 0; j < diary.GetLength(1); j++)
//        {
//            if (diary[i, j] >= 5)
//            {
//                diary[i,j] = 888;
//                //diary[i, j] = sprintf(diary[i, j], "%d", text);
//            }
//            else
//            {
//                Console.WriteLine(diary[i, j]);
//            }
//        }
//    }
//}
//sixCase();

//לא עשיתי:
//    שאלה 21 להפוך סטרינג למילה
//    שאלה 13