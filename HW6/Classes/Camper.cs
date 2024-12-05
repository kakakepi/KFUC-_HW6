using System;

namespace HW6
{
    /// <summary>
    /// Класс, представляющий участника лагеря.
    /// </summary>
    class Camper : CampMember
    {
        /// <summary>
        /// Группа, к которой относится участник.
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// Конструктор с указанием имени, даты рождения, роста и группы.
        /// </summary>
        public Camper(string name, DateTime age, int height, string group)
            : base(name, age, height)
        {
            Group = group;
        }

        /// <summary>
        /// Конструктор с указанием имени, даты рождения и роста. 
        /// Группа по умолчанию устанавливается в "Общая группа".
        /// </summary>
        public Camper(string name, DateTime age, int height)
            : this(name, age, height, "Общая группа") { }

        /// <summary>
        /// Реализация абстрактного метода PerformDuty. 
        /// Выполняет обязанности, связанные с лагерем.
        /// </summary>
        public override void PerformDuty()
        {
            Console.WriteLine($"{name} участвует в уборке территории.");
        }

        /// <summary>
        /// Участник присоединяется к песням у костра.
        /// </summary>
        public void JoinCampfire()
        {
            Console.WriteLine($"{name} поет песни у костра.");
        }

        /// <summary>
        /// Участник принимает участие в мастер-классе.
        /// </summary>
        public void AttendWorkshop()
        {
            Console.WriteLine($"{name} участвует в мастер-классе.");
        }

        /// <summary>
        /// Участник принимает участие в случайной активности.
        /// </summary>
        public void ParticipateInActivity()
        {
            Console.WriteLine($"{name} участвует в случайной активности.");
        }
    }
}