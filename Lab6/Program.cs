namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
        static void Task1()
        {
            Console.WriteLine("\nУпражнение 1\n");
            Console.WriteLine("Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета");
            int myBankAccName = 1;
            decimal myBankAccBalance = 34.6651m;
            BankAccount myBankAcc = new BankAccount(myBankAccName, myBankAccBalance, TypeOfBankAccount.Сберегательный);
            Console.WriteLine(myBankAcc.GetAccountData());
        }
        static void Task2()
        {
            Console.WriteLine("\nУпражнение 2\n");
            Console.WriteLine("Изменить класс счет в банке из упражнения 7.1 таким образом, чтобы номер счета генерировался сам и был уникальным.");
            Console.WriteLine("Создадим аккаунт номер 1");
            BankAccount secondBankAcc = new BankAccount(253875.3423455453532m, TypeOfBankAccount.Текущий);
            Console.WriteLine(secondBankAcc.GetAccountData());
            Console.WriteLine("Создадим аккаунт номер 2");
            BankAccount thirdBankAcc = new BankAccount(83275823.3592385m, TypeOfBankAccount.Сберегательный);
            Console.WriteLine(thirdBankAcc.GetAccountData());
        }
        static void Task3()
        {
            Console.WriteLine("\nУпражнение 3\n");
            Console.WriteLine("Добавить в класс счет в банке два метода: снять со счета и положить на счет.");
            Console.WriteLine("Создадим аккаунт и снимем с него деньги.");
            BankAccount fourthBankAcc = new BankAccount(233334124.325523523m, TypeOfBankAccount.Текущий);
            Console.WriteLine(fourthBankAcc.GetAccountData());
            fourthBankAcc.TakeMoney(233324.325523523m);
            Console.WriteLine($"После сняти денег на аккаунте осталось\n{fourthBankAcc.GetAccountData()}");
            Console.WriteLine("Теперь добавим деньги на счёт");
            fourthBankAcc.AddMoney(2424244);
            Console.WriteLine($"После добавки денег на аккаунте осталось\n{fourthBankAcc.GetAccountData()}");
        }
        static void Task4() {
            Console.WriteLine("\nДомашняя работа\n");
            Console.WriteLine("Реализовать класс для описания здания (уникальный номер здания, высота, этажность, количество квартир, подъездов).");
            int buildingHeight = 2424;
            int floorNumb = 56;
            int appartmentNumb = 250;
            int entranceNumb = 5;
            Building kpfu = new Building(buildingHeight,floorNumb,appartmentNumb,entranceNumb);
            Console.WriteLine($"{kpfu.GetBuildingData()}");
            Console.WriteLine("Узнаем высоту потолков на каждом этаже.");
            Console.WriteLine($"{kpfu.GetBuildingHeight()}");
            Console.WriteLine("Узнаем количество квартир в одном подъезде.");
            Console.WriteLine($"{kpfu.GetCountOfFloorAppartment()}");
            Console.WriteLine("Узнаем количество квартир на одном этаже.");
            Console.WriteLine($"{kpfu.GetCountOfEntranceAppartment()}");
            Console.WriteLine("Узнаем количество ступенек в одном подъезде.");
            Console.WriteLine($"{kpfu.GetCountOfStairs()}");
        }
    }
}