using AutoMapper;
using Domain.Commands.Requests;
using Domain.Commands.Responses;
using Domain.Entities;
using FluentValidation;
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
    public class AddDevHandler : IRequestHandler<AddDevRequest, DevResponse>
    {
        private readonly IDevService _devService;
        private IMapper _mapper;
        public AddDevHandler(IDevService devService, IMapper mapper)
        {
            _devService = devService;
            _mapper = mapper;
        }

        public Task<DevResponse> Handle(AddDevRequest request, CancellationToken cancellationToken)
        {
            var result = new DevResponse
            {
                Message = "Cadastro Realizado com sucesso"
            };

            var validator = new DevValidator();
            var objDev = _mapper.Map<DevEntity>(request);

            var results = validator.Validate(objDev);

            if (results.IsValid) 
            {
                _devService.Add(objDev);

                _devService.Commit();
            }
            else 
                result.Message = results.Errors.First().ErrorMessage;

            return Task.FromResult(result);
        }
    }
}
