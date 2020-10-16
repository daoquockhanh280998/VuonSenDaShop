using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VuonSenDa.ViewModels.System.Users;

namespace VuonSenDa.AdminApp.Service
{
    public interface IUsersAPIClient
    {
        Task<string> Authenticate(LoginRequest request);
    }
}