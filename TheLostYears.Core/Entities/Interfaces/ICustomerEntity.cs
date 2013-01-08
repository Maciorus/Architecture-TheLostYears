using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLostYears.Core.Entities.Interfaces
{
    public interface ICustomerEntity : IEntity
    {
        int Id { get; set; }

        string Title { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string Email { get; set; }

        DateTime DateOfBirth { get; set; }

        string Sex { get; set; }
    }
}
