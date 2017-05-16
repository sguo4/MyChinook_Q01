using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;
using ChinookSystem.Data.Entities;
#endregion

namespace ChinookSystem.DAL
{
    //This is an internal class for security reasons
    //Access is restricted ti within this class library project
    //Inherits DbContext for Entity Framework, which requires
    //  System.Data.Entity
    internal class ChinookContext : DbContext
    {
        //pass the connetion string name to the
        //  DbContext using :base()
        //  i.e. connection string name is "ChinookDB"
        public ChinookContext() : base("ChinookDB")
        {

        }
        //Setup all DbSet properties once Entity classes are created
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }

    }
}
