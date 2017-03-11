using Dork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dork.Services.Profiles.Queries
{
    public interface IProfileQueries
    {
        Task<IEnumerable<User>> GetFriendProfilesFromUserAsync(User user);
    }
}
