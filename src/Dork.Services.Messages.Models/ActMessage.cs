using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dork.Services.Messages.Models
{
    public class ActMessage : MessageBase
    {
        public IList<string> ReceiverIds { get; set; }
        public string Description { get; set; }
        public ActType Type { get; set; }
    }

    public enum ActType
    {
        PrivateAct,
        WildAct
    }
}
