namespace RimDev.Stuntman.Core
{
    using System.Collections.Generic;

    public class StuntmanServerResponse
    {
        public IEnumerable<StuntmanUser> Users { get; set; } = new List<StuntmanUser>();
    }
}
