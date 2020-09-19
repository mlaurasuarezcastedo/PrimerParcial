using System.Data.Entity;
namespace Parcial_MariaLauraSuarez_.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }
    }
}