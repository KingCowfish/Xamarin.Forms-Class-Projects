using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessagingCenterEx.Persistence
{
    interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
