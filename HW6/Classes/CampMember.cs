using System;
using System.Collections.Generic;

namespace HW6 
{
    /// <summary>
    /// Абстрактный класс, представляющий участника лагеря.
    /// </summary>
    abstract class CampMember
    {
        /// <summary>
        /// Имя участника.
        /// </summary>
        public string name;

        /// <summary>
        /// Дата рождения участника.
        /// </summary>
        public DateTime dateBirth;

        /// <summary>
        /// Рост участника.
        /// </summary>
        public int height;

        /// <summary>
        /// Лагерь, в котором находится участник.
        /// </summary>
        public Camp camp;

        /// <summary>
        /// Конструктор для создания участника лагеря.
        /// </summary>
        /// <param name="name">Имя участника.</param>
        /// <param name="dateBirth">Дата рождения участника.</param>
        /// <param name="height">Рост участника.</param>
        protected CampMember(string name, DateTime dateBirth, int height)
        {
            this.name = name;
            this.dateBirth = dateBirth;
            this.height = height;
        }

        /// <summary>
        /// Назначает лагерь для участника.
        /// </summary>
        /// <param name="camp">Объект лагеря.</param>
        public void SetCamp(Camp camp)
        {
            if (camp == null)
            {
                throw new InvalidOperationException("Лагерь не может быть null. Убедитесь, что объект SummerCamp инициализирован.");
            }

            this.camp = camp;
        }

        /// <summary>
        /// Представляет участника лагеря.
        /// </summary>
        public void Introduce()
        {
            if (camp == null)
            {
                Console.WriteLine("Ошибка: Лагерь не назначен для этого участника.");
                return;
            }

            int age = CalculateAge();
            Console.WriteLine($"Привет! Меня зовут {name}. Мне {age} лет, нахожусь в лагере \"{camp.campName}\", мой рост {height} см.");
        }

        /// <summary>
        /// Вычисляет возраст участника.
        /// </summary>
        /// <returns>Возраст участника.</returns>
        private int CalculateAge()
        {
            int age = DateTime.Now.Year - dateBirth.Year;
            if (DateTime.Now.DayOfYear < dateBirth.DayOfYear)
                age--;
            return age;
        }

        /// <summary>
        /// Участник остается спокойным.
        /// </summary>
        public void StayCalm()
        {
            Console.WriteLine($"{name} стоит спокойно.");
        }

        /// <summary>
        /// Абстрактный метод, определяющий обязанности участника.
        /// </summary>
        public abstract void PerformDuty();
    }
}