using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users.Events
{
    public class UserRoleAssignedEvent: DomainEvent
    {
        public Guid UserId { get; }
        public Guid RoleId { get; }
        public UserRoleAssignedEvent(Guid userId, Guid roleId)
        {
            UserId = userId;
            RoleId = roleId;
        }
    }
}
