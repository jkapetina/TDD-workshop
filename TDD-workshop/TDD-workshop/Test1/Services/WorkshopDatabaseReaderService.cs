using System.Collections.Generic;
using System.Linq;
using TDDWorkshop.Interfaces;
using TDDWorkshop.Models;

namespace TDDWorkshop.Services
{
    public class WorkshopDatabaseReaderService
    {
        public IWorkshopDatabase WorkshopDatabase { get; set; }

        public IEnumerable<WorkshopDatabaseEntry> ReadAllSorted()
        {
            // throw new NotImplementedException();
            return WorkshopDatabase.DatabaseEntries.ToList().OrderBy(entry => entry.Name).ThenBy(entry => entry.LastName);
        }
    }
}
