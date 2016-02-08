using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSchool.Data
{
    public class ClassRepository : GenericRepository<ClassRepository>
    {

        private Context context;
        public ClassRepository(Context context)
        {
            this.context = context;
        }
        

        public void ExtentionMethod()
        {
           
        }
    }
}
