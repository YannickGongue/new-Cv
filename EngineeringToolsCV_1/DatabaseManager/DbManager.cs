using EngineeringToolsCV_1.IRepository;
using EngineeringToolsCV_1.Models;
using System.Data;
using System.Threading.Tasks;

namespace EngineeringToolsCV_1.DatabaseManager
{
    public class DbManager
    {
        private readonly IUserInfo _userRepository;
        private readonly IUserWorkInfo _userWorkInfo;

        public DbManager(IUserInfo userRepository, IUserWorkInfo userWorkInfo)
        {
            this._userRepository = userRepository;
            this._userWorkInfo = userWorkInfo;
        }

        public Task<DataTable> SearchStudentInfosAsync(string search)
        {
            return _userRepository.SearchStudentInfosAsync(search);
        }

        public Task<DataTable> GetUserInfoAsync(string id, string password)
        {
            return _userRepository.GetUserInfoAsync(id, password);
        }

        public Task<int> AddStudentInfosAsync(MStudentInformations info)
        {
            return _userRepository.AddStudentInfosAsync(info);
        }

        public Task<int> AddWorkInfosAsync(MUserWorkInfo info)
        {
            return _userWorkInfo.AddWorkInfosAsync(info);
        }

        public Task<int> UpdateStudentInfosAsync(MUser info)
        {
            return _userRepository.UpdateUserInfosAsync(info);
        }

        public Task<int> RemoveStudentInfosAsync(string id)
        {
            return _userRepository.RemoveStudentInfosAsync(id);
        }


    }
}
