using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using EngineeringToolsCV_1.Models;

namespace EngineeringToolsCV_1.IRepository
{
    public  interface IBerufInfo
    {

        Task<int> AddFormationInfosAsync(MBerufInfo info);

        Task<int> UpdateFormationInfosAsync(MBerufInfo info);

        Task<int> RemoveFormationInfosAsync(string studentId);

        Task<DataTable> SearchFormationInfosAsync(string search);

    }
}
