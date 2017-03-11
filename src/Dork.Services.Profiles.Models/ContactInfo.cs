using System.Collections.Generic;

namespace Dork.Services.Profiles.Models
{
    public class ContactInfo
    {
        public string FacebookAccount { get; set; }
        public string GooglePlusAccount { get; set; }
        public IList<string> PhoneNumbers { get; set; }
        public IList<string> Emails { get; set; }
    }
}