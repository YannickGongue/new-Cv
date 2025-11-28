using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringToolsCV_1.IRepository
{
    public interface IUser
    {
        Task<DataTable> GetUserEmailAsync(string id, string password);
        Task<DataTable> GetUserDataAsync(string email);


    }
}
