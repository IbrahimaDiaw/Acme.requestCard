using Abp.Application.Services.Dto;
using Acme.requestCard.Services.Dtos;

namespace Acme.requestCard.Services
{
    public class CardRequestAppServiceBase
    {

        public override Task<CardRequestOutputDto> CreateAsync(CardRequestCreateDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<Guid> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<CardRequestOutputDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<CardRequestOutputDto> GetAsync(EntityDto<Guid> input)
        {
            return base.GetAsync(input);
        }

        public override Task<CardRequestOutputDto> UpdateAsync(CardRequestUpdate input)
        {
            return base.UpdateAsync(input);
        }
    }
}