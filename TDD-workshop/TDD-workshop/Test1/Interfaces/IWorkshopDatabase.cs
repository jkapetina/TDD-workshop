using System.Collections.Generic;
using TDDWorkshop.Models;

namespace TDDWorkshop.Interfaces
{
    public interface IWorkshopDatabase
    {
        IEnumerable<WorkshopDatabaseEntry> DatabaseEntries { get; set; }
    }
}
