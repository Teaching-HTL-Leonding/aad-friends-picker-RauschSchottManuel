using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AadAuthAPI.EFCore
{
    public class Friend
    {
        public int Id { get; set; }
        public string FriendAADId { get; set; }

        public string UId { get; set; }
    }
}
