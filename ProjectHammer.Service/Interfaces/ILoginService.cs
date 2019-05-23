using ProjectHammer.Service.Models;

namespace ProjectHammer.Service.Interfaces
{
    /// <summary>
    /// Login service interface
    /// </summary>
    public  interface ILoginService
    {

      LoginPoco Login(string userName, string password);
    }
}
