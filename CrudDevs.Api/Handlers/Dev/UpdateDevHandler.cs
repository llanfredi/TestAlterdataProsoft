using AutoMapper;
using Domain.Commands.Requests;
using Domain.Commands.Responses;
using Domain.Entities;
using Infrastructure.Validators;
using MediatR;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Handlers.Dev
{
    public class UpdateDevHandler : IRequestHandler<UpdateDevRequest, DevResponse>
    {
        private readonly IDevService _devService;
        private IMapper _mapper;

        public UpdateDevHandler(IDevService devService, IMapper mapper)
        {
            _devService = devService;
            _mapper = mapper;
        }

        public Task<DevResponse> Handle(UpdateDevRequest request, CancellationToken cancellationToken)
        {
            var result = new DevResponse
            {
                Message = "Dev atualizado com sucesso"
            };

            var validator = new DevValidator();
            var objDev = _mapper.Map<DevEntity>(request);

            var results = validator.Validate(objDev);

            if (!results.IsValid) 
            {
                result.Message = results.Errors.First().ErrorMessage;

                return Task.FromResult(result);
            }

            var checkEntityDatabase = _devService.GetById(request.Id);

            if(checkEntityDatabase == null) 
            {
                result.Message = "Dev não existente";

                return Task.FromResult(result);
            }

            checkEntityDatabase.Nome = objDev.Nome;
            checkEntityDatabase.Email = objDev.Email;
            checkEntityDatabase.Endereco = objDev.Endereco;
            checkEntityDatabase.Cidade = objDev.Cidade;
            checkEntityDatabase.Estado = objDev.Estado;
            checkEntityDatabase.IdTipoDev = objDev.IdTipoDev;

            _devService.Update(checkEntityDatabase);

            _devService.Commit();

            return Task.FromResult(result);
        }
    }
}
