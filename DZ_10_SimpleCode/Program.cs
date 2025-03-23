namespace DZ_10_SimpleCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    throw new ArgumentException("Ошибка 1");
                }
                catch (ArgumentException ex)
                {
                    throw new Exception("Ошибка в обработке", ex); // Вложенная ошибка (InnerException)
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Основное исключение: " + ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Вложенное исключение: " + ex.InnerException.Message);
                }
            }
        }
    }



}
