using AutoMapper;
using Domain.Commands.Requests;
using Domain.Commands.Responses;
using MediatR;
using Service.Interface;

namespace Domain.Handlers.Dev
{
    public class DeleteDevHandler : IRequestHandler<DeleteDevRequest, DevResponse>
    {
        private readonly IDevService _devService;
        private IMapper _mapper;

        public DeleteDevHandler(IDevService devService, IMapper mapper)
        {
            _devService = devService;
            _mapper = mapper;
        }

        public Task<DevResponse> Handle(DeleteDevRequest request, CancellationToken cancellationToken)
        {
            var result = new DevResponse 
            {
                Message = "Dev removido com sucesso"
            };

            if (string.IsNullOrEmpty(request.Id.ToString())) 
            {
                result.Message = "Campo id não pode ser nulo";

                return Task.FromResult(result);
            }

            var checkEntityDatabase = _devService.GetById(request.Id);

            if (checkEntityDatabase == null)
            {
                result.Message = "Dev não existente";

                return Task.FromResult(result);
            }

            _devService.Delete(checkEntityDatabase.Id);

            _devService.Commit();

            return Task.FromResult(result);
        }
    }
}
