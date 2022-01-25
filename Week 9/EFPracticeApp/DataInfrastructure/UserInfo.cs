using System;
using System.Collections.Generic;

namespace DataInfrastructure
{
    public partial class UserInfo
    {
        public int UserPasswordsId { get; set; }
        public decimal? SavingsGoal { get; set; }

        public virtual UserPassword UserPasswords { get; set; } = null!;
    }
}
