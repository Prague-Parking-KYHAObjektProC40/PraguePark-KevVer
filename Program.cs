class Garage
{
    public DateTime parkinglotDT = new DateTime();
    public int[] parkinglot = new int[100];
    public int numberOfparkinglot; 
    public void Run()
    {
        //Här tänkte jag att huvud meny skall vara.
        int menyVal;
        Console.WriteLine("Welcome to our luxury garage");
        do
        {
            Console.WriteLine("Please choose from the menu options"
                + "\n1: Add new customer"
                + "\n2: Remove customer"
                + "\n3: View lot"
                + "\n4: Find vehicle"
                + "\n5: Sort lot"
                + "\n0: Exit the program");
            menyVal = int.Parse(Console.ReadLine());
            switch (menyVal)
            {
                case 1:
                    Add_vehicle();
                    break;
                case 2:
                    Remove_vehicle();
                    break;
                case 3:
                    Print_vehicle();
                    break;
                case 4:
                    Find_vehicle();
                    break;
                case 5:
                    Sort_parking_lot();
                    break;
                case 0:
                    menyVal = 0;
                    break;
                default:
                    Console.WriteLine("Oopsi Daisy. Something went wrong. Please try again!");
                    break;
            }
        }
        while (menyVal !=0);
    }
    public void Add_vehicle()
    {
        //Lägga till fordon
        Console.Clear();
        Console.WriteLine("How many vehicle do you want to park?");
        try
        {
            int pLot = Convert.ToInt32(Console.ReadLine());
            if (pLot > 100)
            {
                Console.WriteLine("The garage is full at the moment. Please come back again later!");
            }
            else
            {
                for (int i = 0;i < pLot; i++)
                {

                }
            }
        }
        catch
        {
            Console.WriteLine("Oopsi Daisy. Something went wrong. Please try again!");
        }
    }
    public void Remove_vehicle()
    {
        //tar bort fordon
    }
    public void Print_vehicle()
    {
        //Skriver ut hur många som är parkerad och hur många plats det finns.
    }
    public void Find_vehicle()
    {
        //Söka fordon i systemet genom att använda räckvidd t.ex. parkerings kvitto mellan nr. 2-5
    }
    public void Sort_parking_lot()
    {
        //Sorterar parkerings plats och flyttar dem.
    }
}
class vehicle_type
{
    //Om bil eller MC
}
class Program
{
    public static void Main(string[] args)
    {
        var parkgarage = new Garage();
        var vehicle = new vehicle_type();
        parkgarage.Run();
        Console.Write("Tryck Enter för att fortsätta...");
        Console.ReadKey(true);
    }  //Här körs hela programmet och anropar alla class och metoder
}