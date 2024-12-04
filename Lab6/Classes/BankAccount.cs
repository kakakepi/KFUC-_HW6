namespace Lab6
{
    /// <summary>
    /// Перечисление для представления типов банковского счета.
    /// Включает два типа: Текущий и Сберегательный.
    /// </summary>
    enum TypeOfBankAccount
    {
        Текущий,
        Сберегательный
    }

    class BankAccount
    {
        int accountNumber;
        decimal accBalance;
        TypeOfBankAccount accType;
        bool flag = false;
        static List<int> BankAccCount = new List<int>();

        public BankAccount()
        {
            this.accountNumber = MakeRandom();
            this.flag = false;
        }

        /// <summary>
        /// Конструктор для создания нового банковского счета.
        /// </summary>
        /// <param name="accountBalance">Начальный баланс счета.</param>
        /// <param name="newType">Тип банковского счета.</param>
        public BankAccount(decimal accountBalance, TypeOfBankAccount newType)
        {
            if (accountBalance >= 0 && !BankAccCount.Contains(accountNumber))
            {
            this.accountNumber = MakeRandom();
            this.accBalance = accountBalance;
            this.accType = newType;
            this.flag = false; }
            else {
                Console.WriteLine("Невозможный исход. Баланс должен быть больше или равен нулю.");
                this.flag = true;
            }
        }

        /// <summary>
        /// Конструктор для создания нового банковского счета.
        /// </summary>
        /// <param name="accountNumber">Номер счета.</param>
        /// <param name="accountBalance">Начальный баланс счета.</param>
        /// <param name="newType">Тип банковского счета.</param>
        public BankAccount(int accountNumber, decimal accountBalance, TypeOfBankAccount newType)
        {
            if (accountNumber > 0 && accountBalance >= 0 && !BankAccCount.Contains(accountNumber))
            {
                this.accountNumber = accountNumber;
                this.accBalance = accountBalance;
                this.accType = newType;
                this.flag = false;
            }
            else
            {
                Console.WriteLine("Невозможный исход. Баланс должен быть больше или равен нулю, а номер аккаунта должен быть положительным.");
                this.flag = true;
            }
        }

        /// <summary>
        /// Возвращает информацию о счете.
        /// </summary>
        /// <returns>Строка с данными счета.</returns>
        public string GetAccountData()
        {
            if (flag)
            {
                return "Ошибка: данные счета некорректны.";
            }

            return $"Номер счета: {accountNumber}\n" +
                   $"Тип счета: {accType}\n" +
                   $"Баланс: {accBalance:C}";
        }
        public void TakeMoney(decimal money)
        {
            if (money <= this.accBalance) {
                this.accBalance -= money;
            }
        }
        public void AddMoney(decimal money)
        {
            this.accBalance += money;
        }
        int MakeRandom() {
            Random rnd = new Random();
            int number = rnd.Next(1,1238957239);
            if (!BankAccCount.Contains(number)) {
                BankAccCount.Add(number);
                return number;
            }
            else{
                while (BankAccCount.Contains(number)) {
                    number = rnd.Next(1,1235982375);
                }
                BankAccCount.Add(number);
                return number;
            }
        }
    }
}
