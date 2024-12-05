using System;
using System.Collections.Generic;

namespace Lab6
{
    /// <summary>
    /// Класс для представления информации о здании.
    /// Содержит данные о высоте, этажах, квартирах, подъездах и методы для работы с этими данными.
    /// </summary>
    class Building
    {
        int buildingNumb;
        int buildingHeight;
        int floorNumb;
        int appartmentNumb;
        int entranceNumb;
        bool flag1 = false;
        static List<int> BuildingCount = new List<int>();

        /// <summary>
        /// Конструктор по умолчанию. Создает здание с уникальным номером.
        /// </summary>
        public Building()
        {
            this.buildingNumb = MakeRandom();
        }

        /// <summary>
        /// Конструктор для создания нового здания.
        /// </summary>
        /// <param name="buildingHeight">Высота здания в метрах.</param>
        /// <param name="floorNumb">Количество этажей.</param>
        /// <param name="appartmentNumb">Количество квартир.</param>
        /// <param name="entranceNumb">Количество подъездов.</param>
        /// <exception cref="Exception">Выбрасывается, если параметры не соответствуют условиям.</exception>
        public Building(int buildingHeight, int floorNumb, int appartmentNumb, int entranceNumb)
        {
            if (floorNumb > 0 && appartmentNumb > 0 && entranceNumb > 0 && buildingHeight > 0 &&
                (double)(appartmentNumb / entranceNumb) % floorNumb == 0)
            {
                this.buildingNumb = MakeRandom();
                this.buildingHeight = buildingHeight;
                this.floorNumb = floorNumb;
                this.appartmentNumb = appartmentNumb;
                this.entranceNumb = entranceNumb;
                this.flag1 = false;
            }
            else
            {
                throw new Exception("Одно из полей невозможно. Все параметры должны быть больше нуля, а также на каждом этаже должно быть одинаковое число квартир.");
            }
        }

        /// <summary>
        /// Генерирует уникальный номер здания.
        /// Уникальность проверяется с использованием списка существующих номеров.
        /// </summary>
        /// <returns>Уникальный номер здания.</returns>
        private int MakeRandom()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 1238957293);
            if (!BuildingCount.Contains(number))
            {
                BuildingCount.Add(number);
                return number;
            }
            else
            {
                while (BuildingCount.Contains(number))
                {
                    number = rnd.Next(1, 1235982375);
                }
                BuildingCount.Add(number);
                return number;
            }
        }

        /// <summary>
        /// Возвращает полную информацию о здании.
        /// </summary>
        /// <returns>Строка с данными здания.</returns>
        public string GetBuildingData()
        {
            if (flag1)
            {
                return "Ошибка: данные здания некорректны.";
            }

            return $"Номер строения: {buildingNumb}\n" +
                   $"Количество квартир: {appartmentNumb}\n" +
                   $"Количество подъездов: {entranceNumb}\n" +
                   $"Высота здания: {buildingHeight} м\n" +
                   $"Количество этажей: {floorNumb}\n";
        }

        /// <summary>
        /// Возвращает высоту потолка в здании.
        /// </summary>
        /// <returns>Строка с высотой потолка.</returns>
        public string GetBuildingHeight()
        {
            if (flag1)
            {
                return "Ошибка: данные здания некорректны.";
            }
            else
            {
                return $"Высота потолка в здании: {(double)(buildingHeight / floorNumb)} м";
            }
        }

        /// <summary>
        /// Возвращает количество квартир в одном подъезде.
        /// </summary>
        /// <returns>Строка с количеством квартир в подъезде.</returns>
        public string GetCountOfEntranceAppartment()
        {
            if (flag1)
            {
                return "Ошибка: данные здания некорректны.";
            }
            else
            {
                return $"Количество квартир в подъезде: {appartmentNumb / entranceNumb}";
            }
        }

        /// <summary>
        /// Возвращает количество квартир на одном этаже.
        /// </summary>
        /// <returns>Строка с количеством квартир на этаже.</returns>
        public string GetCountOfFloorAppartment()
        {
            if (flag1)
            {
                return "Ошибка: данные здания некорректны.";
            }
            else
            {
                return $"Количество квартир на этаже: {appartmentNumb / entranceNumb / floorNumb}";
            }
        }

        /// <summary>
        /// Возвращает количество ступенек в здании.
        /// Предполагается, что между этажами 20 ступенек.
        /// </summary>
        /// <returns>Количество ступенек или 0, если данные некорректны.</returns>
        public int GetCountOfStairs()
        {
            if (flag1)
            {
                return 0;
            }
            else
            {
                return floorNumb > 1 ? (floorNumb - 1) * 20 : 0;
            }
        }
    }
}
