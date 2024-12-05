namespace HW6 {

    /// <summary>
    /// Перечисление сезонов работы лагеря.
    /// </summary>
    public enum campSeason
    {
        Зима,
        Весна,
        Лето,
        Осень
    }

    /// <summary>
    /// Класс, представляющий лагерь.
    /// </summary>
    /// <summary>
    /// Класс, представляющий лагерь.
    /// </summary>
    class Camp
    {
        /// <summary>
        /// Название лагеря.
        /// </summary>
        public string campName;

        /// <summary>
        /// Местоположение лагеря.
        /// </summary>
        string location;

        /// <summary>
        /// Список участников лагеря.
        /// </summary>
        List<CampMember> membersNames = new List<CampMember>();

        /// <summary>
        /// Сезон работы лагеря.
        /// </summary>
        campSeason campSeason;

        /// <summary>
        /// Конструктор для создания лагеря.
        /// </summary>
        public Camp(string name, string location, campSeason campSeason)
        {
            this.campName = name;
            this.location = location;
            this.campSeason = campSeason;
        }

        /// <summary>
        /// Добавляет участника в лагерь.
        /// </summary>
        public void AddMember(CampMember member)
        {
            membersNames.Add(member);
            Console.WriteLine($"{member.name} добавлен в лагерь.");
        }

        /// <summary>
        /// Показывает список участников лагеря.
        /// </summary>
        public void ShowMembers()
        {
            Console.WriteLine($"Список участников лагеря \"{campName}\":");
            foreach (var member in membersNames)
            {
                Console.WriteLine($"- {member.name}. Дата рождения - {member.dateBirth}");
            }
        }

        /// <summary>
        /// Удаляет участника из лагеря.
        /// </summary>
        public bool RemoveMember(string memberName)
        {
            CampMember member = null;
            foreach (CampMember m in membersNames)
            {
                if (m.name == memberName)
                {
                    member = m;
                    break; // Прекращаем поиск, как только нашли нужный элемент
                }
            }
            if (member != null)
            {
                membersNames.Remove(member);
                Console.WriteLine($"{member.name} был(а) удален(а) из лагеря.");
                return true;
            }
            Console.WriteLine($"Участник с именем {memberName} не найден.");
            return false;
        }

        /// <summary>
        /// Возвращает информацию о лагере.
        /// </summary>
        public string GetCampInfo()
        {
            string info = $"Лагерь: {campName}\n" +
                          $"Местоположение: {location}\n" +
                          $"Сезон работы: {campSeason}\n" +
                          $"Текущие участники: {membersNames.Count}\n";
            return info;
        }
    }
}