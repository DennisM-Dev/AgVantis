using Abp.Domain.Repositories;
using Abp.Runtime.Caching;
using AgVantis.Association.Dto;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AgVantis.Association
{
    /// <summary>
    /// 
    /// </summary>
    public class AssociationAppService : AgVantisAppServiceBase, IAssociationAppService
    {
        private readonly ICacheManager _cacheManager;
        private readonly IRepository<Associations> _associationRepository;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cacheManager"></param>
        /// <param name="associationRepository"></param>
        public AssociationAppService(ICacheManager cacheManager, IRepository<Associations> associationRepository)
        {
            _cacheManager = cacheManager;
            _associationRepository = associationRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="changeAssociationEmail"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task ChangeEmail(ChangeAssociationEmailDto changeAssociationEmail)
        {
            var a = await _associationRepository.GetAllAsync();

            var result = a.Where(x => x.EmailAddress == changeAssociationEmail.CurrentEmailAddress).FirstOrDefault();
            if (result != null)
            {
                result.LastModificationTime = DateTime.UtcNow;
                result.EmailAddress = changeAssociationEmail.NewEmailAddress;
                await CurrentUnitOfWork.SaveChangesAsync();
            }
        }
    }
}
