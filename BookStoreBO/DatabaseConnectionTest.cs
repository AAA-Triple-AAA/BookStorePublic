using BookStoreDO.Models.DataLayer;

namespace BookStoreBO;

public static class DatabaseConnectionTest
{
    public static void TestDatabaseConnection()
    {
        try
        {
            using var context = new BookStoreContext();
            Console.WriteLine(context.Database.CanConnect()
                ? "Database connection SUCCESSFUL."
                : "Database connection FAILED.");
        }
        catch
        {
            Console.WriteLine("Database connection FAILED.");
        }
    }
}