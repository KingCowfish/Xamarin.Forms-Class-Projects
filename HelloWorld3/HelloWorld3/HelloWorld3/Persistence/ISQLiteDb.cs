using SQLite;

namespace HelloWorld3
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
