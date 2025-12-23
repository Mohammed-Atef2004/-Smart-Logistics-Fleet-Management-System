using Domain.Common.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class Route : ValueObject
    {
        public Address From { get; }
        public Address To { get; }

        public Route(Address from, Address to)
        {
            From = from;
            To = to;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return From;
            yield return To;
        }
    }

}
