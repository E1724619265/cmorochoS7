using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace cmorochoS7
{
    public interface database
    {
        SQLiteAsyncConnection GetConnection();
    }
}
