using Dork.Models;
using Dork.Services.Messages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dork.Services.Messages.Queries
{
    public interface IMessageQueries
    {
        Task<IEnumerable<ActMessage>> GetRecentActsByUserProfileAsync(User userProfile, Page paging);
        Task<Content> GetActContentByContentIdAsync(string id);
        Task<ReactMessage> PersistReactMessageAsync(ReactMessage message);
        Task<ActMessage> PersistActMessageAsync(ActMessage message);
        Task<IDictionary<User, IEnumerable<ActMessage>>> GetActUpdatesFromFriendListAsync(User user);
        Task<IEnumerable<MessageBase>> GetMessageHistoryFromUsersAsync(User user1, User user2);
    }
}
