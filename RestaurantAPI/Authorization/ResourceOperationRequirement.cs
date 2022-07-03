using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI.Authorization
{
    public enum ResourceOperation
    {
        Create,
        Read,
        Update,
        Delete
    }
    public class ResourceOperationRequirement : IAuthorizationRequirement
    {
        private readonly ResourceOperation _resourceOperation;

        public ResourceOperationRequirement(ResourceOperation resourceOperation)
        {
            _resourceOperation = resourceOperation;
        }

        public ResourceOperation ResourceOperation { get; }
    }
}
