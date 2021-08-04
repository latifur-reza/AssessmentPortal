using ProblemTwoPortal.Database.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemTwoPortal.DataControl.Interfaces
{
    public interface IObject
    {
        Task<IEnumerable<ObjectDto>> GetObjects();
    }
}
