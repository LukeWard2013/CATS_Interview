using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;

namespace CATS_Interview.Model
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(): base("name=RTMTruckConnection")
        {
        }

        public DbSet<Operator> Operators { get; set; }

        public IDbSet<Contact> Contacts { get; set; }
        public IDbSet<ContactPosition> ContactPositions { get; set; }

        public IDbSet<Call> Calls { get; set; }
        public IDbSet<CallOutcome> CallOutcomes { get; set; } 

        public DbSet<Truck> Trucks { get; set; }
        public DbSet<TruckWeight> TruckWeights { get; set; }

        public DbSet<Body> Bodies { get; set; }
        public DbSet<BodyType> BodyTypes { get; set; }

        public DbSet<Chassis> Chasis { get; set; }
        public DbSet<ChassisMake> ChassisMakes { get; set; }

        public IDbSet<ChassisMakeByWeight> ChassisMakesByWeights { get; set; }

        public IDbSet<WorkshopOption> WorkshopOptions { get; set; }
        public IDbSet<BusinessDescriptionOption> BusinessDescriptionOptions { get; set; }
        public IDbSet<UsedTrucksOrTrailersOption> UsedTrucksOrTrailersOptions { get; set; }
        //public IDbSet<RecordStatus> RecordStatuses { get; set; }

        public IDbSet<FinanceMethod> FinanceMethods { get; set; }
        public IDbSet<FinanceMethodOption> FinanceMethodOptions { get; set; }

        public IDbSet<AxleCombination> AxleCombinations { get; set; }
        public IDbSet<AxleCombinationOption> AxleCombinationValues { get; set; }

        public IDbSet<Isolate> Isolate { get; set; }
    }
}
                