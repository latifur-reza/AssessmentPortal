using ProblemTwoPortal.Database.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemTwoPortal.DataControl.Interfaces
{
    public interface IDataField
    {
        Task<IEnumerable<DataFieldDto>> GetDataFields();
    }
}
