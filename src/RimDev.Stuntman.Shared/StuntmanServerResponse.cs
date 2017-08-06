using System.Collections.Generic;

namespace RimDev.Stuntman.Shared
{
    public class StuntmanServerResponse
    {
        public IEnumerable<StuntmanUser> Users { get; set; } = new List<StuntmanUser>();
    }
}
