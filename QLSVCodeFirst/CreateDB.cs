using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSVCodeFirst
{
    class CreateDB :
        CreateDatabaseIfNotExists<QLSVCSDL>
    {
        protected override void Seed(QLSVCSDL context)
        {
            context.LopSHes.AddRange(new LopSH[]
            {
                new LopSH {ID_Lop = 1, NameLop = "LSH1"},
                new LopSH {ID_Lop = 3, NameLop = "LSH3"}
            });
            context.SVs.AddRange(new SV[]
            {
                new SV {MSSV = "101", NameSV = "NVA", Gender = true, NS = DateTime.Now, ID_Lop = 1},
                new SV {MSSV = "102", NameSV = "NVB", Gender = false, NS = DateTime.Now, ID_Lop = 1},
                new SV {MSSV = "103", NameSV = "NVC", Gender = true, NS = DateTime.Now, ID_Lop = 3}
            });
        }
    }
}
