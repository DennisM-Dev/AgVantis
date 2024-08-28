using AgVantis.Association.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgVantis.Association
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAssociationAppService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="changeAssociationEmail"></param>
        /// <returns></returns>
        Task ChangeEmail(ChangeAssociationEmailDto changeAssociationEmail);
    }
}
