using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMExercise.Persistence
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
