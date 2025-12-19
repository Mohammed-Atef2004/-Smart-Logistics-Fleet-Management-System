using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users.Events
{
    public class UserCreatedEvent: DomainEvent
    {
        public Guid UserId { get; }
        public string Email { get; }
        public Guid Id { get; }

        public UserCreatedEvent(Guid userId, string email)
        {
            UserId = userId;
            Email = email;
        }

        public UserCreatedEvent(Guid id)
        {
            Id = id;
        }
    }
}
