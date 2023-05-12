using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Addiction_Cure.core.Common
{
    public interface IDBContext
    {
        DbConnection Connection { get; }
    }
}
