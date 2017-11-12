using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PGPTool.Data
{
    interface ISQLite
    {
        SQLiteConnection GetConnection();

    }
}
