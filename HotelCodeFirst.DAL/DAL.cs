using Database.Core.DBContext;
using Microsoft.EntityFrameworkCore;

namespace HotelCodeFirst.DAL
{
    public class DAL
    {
        private static DAL _dalInstance;

        private DAL()
        {

        }

        public static DAL Instance()
        {
            if (_dalInstance == null)
                _dalInstance = new DAL();
            
            return _dalInstance;
            
        }

        /// <summary>
        /// Creates a new Database Migration.
        /// </summary>
        public void Migrate()
        {
            using var context = new DataContext();
            context.Database.Migrate();
        }
    }
}