namespace HW6
{
        /// <summary>
    /// Класс, представляющий вожатого.
    /// </summary>
    class Counselor : CampMember
    {
        /// <summary>
        /// Специализация вожатого.
        /// </summary>
        public string Specialty { get; set; }

        /// <summary>
        /// Конструктор с указанием имени, даты рождения, роста и специализации.
        /// </summary>
        public Counselor(string name, DateTime dateBirth, int height, string specialty)
            : base(name, dateBirth, height)
        {
            Specialty = specialty;
        }

        /// <summary>
        /// Конструктор с указанием имени, даты рождения и роста. 
        /// Специализация устанавливается по умолчанию.
        /// </summary>
        public Counselor(string name, DateTime dateBirth, int height)
            : base(name, dateBirth, height)
        {
            Specialty = "Общая помощь";
        }

        /// <summary>
        /// Реализация абстрактного метода PerformDuty. 
        /// Выполняет обязанности вожатого.
        /// </summary>
        public override void PerformDuty()
        {
            Console.WriteLine($"{name} выполняет обязанности вожатого.");
        }

        /// <summary>
        /// Организует активность для участников лагеря.
        /// </summary>
        public void OrganizeActivity()
        {
            Console.WriteLine($"{name} организует активность по специальности: {Specialty}.");
        }

        /// <summary>
        /// Помогает участникам лагеря.
        /// </summary>
        public void HelpCampers()
        {
            Console.WriteLine($"{name} помогает участникам лагеря.");
        }

        /// <summary>
        /// Наблюдает за безопасностью в лагере.
        /// </summary>
        public void Supervise()
        {
            Console.WriteLine($"{name} наблюдает за безопасностью лагеря.");
        }

        /// <summary>
        /// Посещает собрания вожатых.
        /// </summary>
        public void AttendMeeting()
        {
            Console.WriteLine($"{name} посещает собрание вожатых.");
        }
    }
}