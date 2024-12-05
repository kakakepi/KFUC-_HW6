using System;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Camp summerCamp = new Camp("Летний лагерь", "Лесная поляна", campSeason.Лето);
            Console.WriteLine("Лагерь создан:");
            Console.WriteLine(summerCamp.GetCampInfo());

            Camper camper1 = new Camper("Иван Иванов", new DateTime(2010, 5, 15), 140, "Спортсмены");
            Camper camper2 = new Camper("Анна Смирнова", new DateTime(2009, 7, 23), 145);
            Counselor counselor1 = new Counselor("Мария Петрова", new DateTime(1990, 3, 12), 165, "Музыка");

            summerCamp.AddMember(camper1);
            summerCamp.AddMember(camper2);
            summerCamp.AddMember(counselor1);

            camper1.SetCamp(summerCamp);
            camper2.SetCamp(summerCamp);
            counselor1.SetCamp(summerCamp);

            summerCamp.ShowMembers();

            Console.WriteLine("\nДействия участников:");
            camper1.Introduce();
            camper2.JoinCampfire();
            counselor1.OrganizeActivity();

            camper2.AttendWorkshop();
            counselor1.HelpCampers();

            Console.WriteLine("\nУдаление участника:");
            summerCamp.RemoveMember("Иван Иванов");

            Console.WriteLine("\nИтоговая информация о лагере:");
            Console.WriteLine(summerCamp.GetCampInfo());
        }
    }
}
