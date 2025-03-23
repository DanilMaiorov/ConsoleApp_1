using System.Security.Claims;
using System.Security.Principal;

namespace ConsoleApp_1
{

    //    Создайте систему управления банковскими счетами.

    //    Банковские счета содержатся в банке.У банковского счета есть уникальный номер и баланс.

    //    На счет можно положить деньги, можно снять деньги.

    public class Account
    {
        private int _id;

        public int Id
        {
            get { return _id; }
        }
        private decimal _balance;
        public decimal Balance
        {
            get { return _balance; }
            private set { _balance = value; }
        }

        public Account(decimal balance, int id)
        {
            _id = id;
            Balance = balance;
        }

        public void AccountCashIn(decimal cashIn)
        {
            _balance += cashIn;
        }

        public void AccountCashOut(decimal cashOut)
        {
            _balance -= cashOut;
        }
    }
        
    public class Bank
    {
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }


        private int AccountsNmber = 0;

        public List<Account> Accounts = new List<Account>();

        public Account CreateAccount(decimal balance, int id)
        {
            Account account = new Account(balance, id);

            Accounts.Add(account);

            BankBalanceRefresh(balance);

            return account;
        }

        public void DeleteAccount()
        {
            int id = Console.ReadLine().ValidateAndParseInt();

            Account currentAccount = Accounts.Find(accId => accId.Id == id);

            if (currentAccount != null)
                Accounts.Remove(currentAccount);

            Console.WriteLine("Введён несуществующий номер счёта");
        }

        public decimal CashIn()
        {
            Console.WriteLine("Введите номер счёта для пополнения");
            int id = Console.ReadLine().ValidateAndParseInt();

            Account currentAccount = Accounts.Find(accId => accId.Id == id);

            if (currentAccount == null)
            {
                Console.WriteLine("Введён несуществующий номер счёта");
                CashIn();
            }

            Console.WriteLine("Баланс аккаунта: " + currentAccount.Id + " равен " + currentAccount.Balance);
            Console.WriteLine("Баланс банка: " + balance);


            Console.WriteLine("Введите сумму для внесения наличных");
            decimal money = Console.ReadLine().ValidateAndParse();
            Console.WriteLine("Внесённая сумма: " + money);

            currentAccount.AccountCashIn(money);

            Console.WriteLine("Баланс аккаунта: " + currentAccount.Id + " равен " + currentAccount.Balance);

            return BankBalanceRefresh(money);
        }

        public decimal CashOut()
        {
            Console.WriteLine("Введите номер счёта для снятия");
            int id = Console.ReadLine().ValidateAndParseInt();

            //выбираю текущий акк
            Account currentAccount = Accounts.Find(accId => accId.Id == id);

            if (currentAccount == null)
            {
                Console.WriteLine("Введён несуществующий номер счёта");
                CashOut();
            }

            Console.WriteLine("Баланс аккаунта: " + currentAccount.Id + " равен " + currentAccount.Balance);
            Console.WriteLine("Баланс банка: " + balance);
            decimal money;
            while (true) 
            {
                Console.WriteLine("Введите сумму для снятия наличных");
                money = Console.ReadLine().ValidateAndParse();

                if (currentAccount.Balance > money)
                    break;
                Console.WriteLine($"Невозможно снять больше чем есть на счёте. Вы хотели снять {money}, а баланс вашего счета {currentAccount.Balance}");
                
            }
            Console.WriteLine("Введенная сумма: " + money);
            //снятие с текущего баланса аккаунта
            currentAccount.AccountCashOut(money);

            Console.WriteLine("Баланс аккаунта: " + currentAccount.Id + " равен " + currentAccount.Balance);

            return BankBalanceRefresh(-money);
        }

        //метод запрашивания новой суммы для снятия
        private decimal CheckCashOut()
        {
            Console.WriteLine("Введите сумму для снятия наличных");
            decimal money = Console.ReadLine().ValidateAndParse();
            return money;
        }

        //обновление баланса всего банка
        private decimal BankBalanceRefresh(decimal sum) => Balance += sum;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            Account MyAcc1 = bank.CreateAccount(123, 1);

            Account MyAcc2 = bank.CreateAccount(113, 2);

            Account MyAcc3 = bank.CreateAccount(745, 333);

            Console.WriteLine(MyAcc1.Balance);

            while (true)
            {
                //метод пополнения баланса
                bank.Balance = bank.CashIn();
                Console.WriteLine("Баланс банка: " + bank.Balance);
                //метод пополнения баланса
                bank.Balance = bank.CashOut();
                Console.WriteLine("Баланс банка: " + bank.Balance);
                Console.WriteLine("Удаляем акк");
                bank.DeleteAccount();

                Console.WriteLine();
            }



            ;

            //Student newStudent = new Student("Gena", 15);

            //Dog dog1 = new Dog("babaka", State.sit);

            //dog1.setSitDown();
            //dog1.setStand();
            //dog1.setSitDown();
            //dog1.setLie();
            Console.WriteLine();
        }
    }

    //enum State
    //{
    //    sit, lie, stand
    //}

    //class Dog
    //{
    //    private string name;
    //    private State state;

    //    public void setSitDown()
    //    {
    //        state = State.sit;
    //        Console.WriteLine($"{name} {state}");
    //    }

    //    public void setLie()
    //    {
    //        state = State.lie;
    //        Console.WriteLine($"{name} {state}");
    //    }

    //    public void setStand()
    //    {
    //        state = State.stand;
    //        Console.WriteLine($"{name} {state}");
    //    }

    //    public Dog(string name, State state)
    //    {
    //        this.name = name;
    //        this.state = state;
    //    }
    //}

    //class Student
    //{
    //    private string name;

    //    int age;

    //    public string Name
    //    {
    //        get { return name; }
    //    }

    //    private int GetAge() { return age; }

    //    private bool IsAdult = true;


    //    private bool Adult()
    //    {
    //        if (age < 18)
    //        {
    //            Console.WriteLine("Несовершеннолетний");
    //            return IsAdult = false;
    //        }
    //        Console.WriteLine("Всё ок");
    //        return IsAdult = true;
    //    }

    //    public Student(string name, int age)
    //    {
    //        this.name = name;   
    //        this.age = age;
    //        IsAdult = Adult();
    //    }

    //}

//    Задачи:
//1. Опишите класс Student, который:
//1.1 Содержит имя.
//1.2 Предоставляет имя, через свойство.
//1.3 Содержит возраст.
//1.4 Предоставляет возраст через метод.
//1.5 Содержит конструктор, принимающий имя студента и возраст.
//1.6 Содержит поле, показывающее, является ли студент совершеннолетним.
//1.7 При инициализации поля имени в конструкторе вычисляет, является ли студент совершеннолетним в приватном методе.

//    2. Опишите класс Dog
//2.1 Содержит имя.
//2.2 Содержит состояние: enum { sit, lie, stand }
//2.3 Содержит метод, выполняющий команду "{Имя}, cидеть". Меняет состояние собаки на соответствующее.
//2.4 Содержит метод, выполняющий команду "{Имя}, лежать". Меняет состояние собаки на соответствующее.



//    1 Описать класса-родителя и класс наследника
//1.1 Описать класс Person
//1.1.1 Персона содержит поле "имя".
//1.1.2 Персона содержит не переопределяемый метод, который возвращает значение поля.
//1.1.3 Персона содержит переопределяемый метод SayAboutYourSelf(), в котором сообщает свое имя. (virtual)
//1.1.4 Персона содержит конструктор, который принимает 1 параметр - имя.
//1.2 Описать класс Employee
//1.2.1 Работник содержит поле "Компания".
//1.2.2 Работник содержит переопределяемый метод DoWork().
//1.2.3 Работник переопределяет метод SayAboutYourSelf(), в котором сообщает свое имя и говорит на каком предприятии работает. (override)
//1.2.4 Работник содержит конструктор, который принимает имя и название компании как параметры. (использовать base)


}
