using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BE.AccountEntities;
using MongoDB.Driver;

namespace DAL.Repositories
{
    public class AccountRepository : MongoRepository<Account>
    {
        public AccountRepository(IErrorLogger logger) : base(logger)
        {
            
        }
    }
}