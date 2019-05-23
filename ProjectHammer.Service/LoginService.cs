using AutoMapper;
using ProjectHammer.DAL;
using ProjectHammer.Service.Interfaces;
using ProjectHammer.Service.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectHammer.Service
{

    /// <summary>
    /// Login service class
    /// </summary>
    public class LoginService : ILoginService
    {
        #region Fields

        /// <summary>
        /// Department context field
        /// </summary>
        private readonly CompanyContext context;

        /// <summary>
        /// Mapper
        /// </summary>
        private readonly IMapper mapper;

        #endregion


        #region Constructor

        /// <summary>
        /// Login service constructor
        /// </summary>
        /// <param name="context"></param>
        /// <param name="mapper"></param>
        public LoginService(CompanyContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        #endregion

        #region Methods

        public LoginPoco Login(string userName, string password)
        {
            var user = context.Logins.FirstOrDefault(x => x.LoginUserName == userName && x.LoginPassword == password);
            if (user == null)
                return null;

            var userToLogin = mapper.Map<LoginPoco>(user);

            userToLogin.LoginPassword = null;

            return userToLogin;
        }

        #endregion
    }
}
