using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dork.Services.Messages.Models
{
    public class ReactMessage : MessageBase
    {
        public ActMessage ActMessage { get; set; }
        public Note Comment { get; set; }
    }
}
