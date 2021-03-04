using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Get;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.ById;
using warehouseManagementSystem.DataAcces;
using warehouseManagementSystem.DataAcces.CQRS.Querries;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers.GetById
{
    public class GetItemByIdHandler : IRequestHandler<GetItemByIdRequest, GetItemByIdResponse>
    {
        private readonly IMapper mapper;
        private readonly IQuerryExecutor queryExecutor;

        public GetItemByIdHandler(IMapper mapper, IQuerryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetItemByIdResponse> Handle(GetItemByIdRequest request, CancellationToken cancellationToken)
        {
            var query = new GetItemQuerry()
            {
                Id = request.ItemId
            };

            var item = await this.queryExecutor.Execute(query);

            var mappedItem = this.mapper.Map<Domain.Models.Item>(item);

            var response = new GetItemByIdResponse()
            {
                Data = mappedItem
            };

            return response;
        }
    }
}

