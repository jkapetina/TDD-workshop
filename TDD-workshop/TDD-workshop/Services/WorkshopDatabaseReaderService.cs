using System.Collections.Generic;
using TDDWorkshop.Interfaces;
using TDDWorkshop.Models;

namespace TDDWorkshop.Services
{
    public class WorkshopDatabaseReaderService
    {
        public IWorkshopDatabase WorkshopDatabase { get; set; }

        public IEnumerable<WorkshopDatabaseEntry> ReadAll()
        {
            // throw new NotImplementedException();
            return WorkshopDatabase.DatabaseEntries;
        }
    }
}
