using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using OneForm.SharedData.Entities;

namespace OneForm.SharedData.RepoInterfaces
{
    public interface IUserRepo:IRepo<User>
    {
        Task Update(User user);
    }
}