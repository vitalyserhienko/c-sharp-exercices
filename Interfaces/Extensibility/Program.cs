using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\Users\\Vitaly\\source\\repos\\Interfaces\\Extensibility\\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
