using BloodBank.Application.Model;
using BloodBank.Core.Respositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Commands.UpdateDonor
{
    public  class UpdateDonorHandler : IRequestHandler<UpdateDonorCommand, ResultViewModel>
    {
        private readonly IDonorRespository _repository;

        public UpdateDonorHandler(IDonorRespository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel> Handle(UpdateDonorCommand request, CancellationToken cancellationToken)
        {
            var donor = await _repository.GetDonorById(request.IdDonor);

            if (donor is null)
            {
                return ResultViewModel.Error("This donor does not exist.");
            }

            donor.Update(request.FullName, request.Genre, request.Weight, request.Email);
            await _repository.UpdateDonor(donor);

            return ResultViewModel.Sucess();
        }
    }
}
