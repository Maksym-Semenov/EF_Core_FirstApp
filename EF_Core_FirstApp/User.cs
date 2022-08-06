using System;
using System.Collections.Generic;

namespace EF_Core_FirstApp
{
    public partial class User
    {
        public long UserId { get; set; }
        public string Name { get; set; }
        public long Age { get; set; }
    }
}
