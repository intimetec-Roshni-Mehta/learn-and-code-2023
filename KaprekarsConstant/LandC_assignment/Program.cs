using LandC_assignment;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter a four-digit number: ");

        if (int.TryParse(Console.ReadLine(), out int userNumber) && userNumber >= 1000 && userNumber <= 9999)
        {
            try
            {
                int iterations = KaprekarRoutine.PerformKaprekarRoutine(userNumber);
                Console.WriteLine($"For the number {userNumber}, Kaprekar's constants converged to 6174 in {iterations} iterations.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"For the number {userNumber}, {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a four-digit number.");
        }
    }
}
