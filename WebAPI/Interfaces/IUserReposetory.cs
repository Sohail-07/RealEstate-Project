﻿using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface IUserReposetory
    {
        Task<User> Authenticate(string username, string password);
        void Register(string username, string password);
        Task<bool> UserAlreadyExists(string username);
    }
}
