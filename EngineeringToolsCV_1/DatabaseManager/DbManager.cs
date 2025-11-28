using EngineeringToolsCV_1.IRepository;
using EngineeringToolsCV_1.Models;
using System.Data;
using System.Threading.Tasks;

namespace EngineeringToolsCV_1.DatabaseManager
{
    public class DbManager
    {
        private readonly IUserInfo _userRepository;
        private readonly IUser _user;

        public DbManager(IUserInfo userRepository, IUser user)
        {
            this._userRepository = userRepository;
            this._user = user;

        }

        public Task<DataTable> SearchStudentInfosAsync(string search)
        {
            return _userRepository.SearchStudentInfosAsync(search);
        }

        public Task<DataTable> GetUserInfoAsync(string email, string password)
        {
            return _userRepository.GetUserInfoAsync(email, password);
        }

        public Task<DataTable> GetUserDataAsync(string email, string password)
        {
            return _user.GetUserDataAsync(email, password);
        }

        public Task<int> AddStudentInfosAsync(MStudentInformations info)
        {
            return _userRepository.AddStudentInfosAsync(info);
        }

        public Task<int> UpdateStudentInfosAsync(MStudentInformations info)
        {
            return _userRepository.UpdateStudentInfosAsync(info);
        }

        public Task<int> RemoveStudentInfosAsync(string id)
        {
            return _userRepository.RemoveStudentInfosAsync(id);
        }


    }
}
