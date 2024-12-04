using System.Threading.Channels;

namespace Lab6 
{
    class Building {
        int buildingNumb;
        int buildingHeight;
        int floorNumb;
        int appartmentNumb;
        int entranceNumb;
        bool flag1 = false;
        static List<int> BuildingCount = new List<int>();
        public Building() {
            this.buildingNumb = MakeRandom();
        }
        public Building(int buildingHeight, int floorNumb, int appartmentNumb, int entranceNumb){
            if (floorNumb > 0 && appartmentNumb >0 && entranceNumb > 0 && buildingHeight > 0 && (double)(appartmentNumb / entranceNumb)%floorNumb == 0){
                this.buildingNumb = MakeRandom();
                this.buildingHeight = buildingHeight;
                this.floorNumb = floorNumb;
                this.appartmentNumb = appartmentNumb;
                this.entranceNumb = entranceNumb; 
                this.flag1 = false;
                }
            else {
                throw new Exception("Одно из полей невозможно. Все параметры должны быть больше нуля, а также на каждом этаже должно быть одинаковое число квартир.");
                flag1 = true;
            }
        }

        int MakeRandom() {
            Random rnd = new Random();
            int number = rnd.Next(1,1238957293);
            if (!BuildingCount.Contains(number)) {
                BuildingCount.Add(number);
                return number;
            }
            else{
                while (BuildingCount.Contains(number)) {
                    number = rnd.Next(1,1235982375);
                }
                BuildingCount.Add(number);
                return number;
            }
        }
        public string GetBuildingData()
        {
            if (flag1)
            {
                return "Ошибка: данные счета некорректны.";
            }

            return $"Номер строения: {buildingNumb}\n" +
                   $"Количество квартир: {appartmentNumb}\n" +
                   $"Количество подъездов: {entranceNumb}\n" +
                   $"Высота здания: {buildingHeight} м\n" +
                   $"Количество этажей: {floorNumb}\n";
        }
        public string GetBuildingHeight() {
            if (flag1) {
                return "Ошибка: данные счета некорректны.";
            }
            else {
                return $"Высота потолка в здании: {(double)(buildingHeight / floorNumb)}";
            }
        }
        public string  GetCountOfEntranceAppartment() {
            if (flag1) {
                return "Ошибка: данные счета некорректны.";
            }
            else {
                return $"Количество квартир в подъезде: {appartmentNumb / entranceNumb}";
            }
        }
        public string  GetCountOfFloorAppartment() {
            if (flag1) {
                return "Ошибка: данные счета некорректны.";
            }
            else {
                return $"Количество квартир на этаже: {appartmentNumb / entranceNumb / floorNumb}";
            }
        }
        public int  GetCountOfStairs() {
            if (flag1) {
                return 0;
            }
            else {
                return floorNumb > 1 ? (floorNumb - 1) * 20 : 0;
            }
        }
    }
}