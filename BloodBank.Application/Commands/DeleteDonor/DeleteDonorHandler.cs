using BloodBank.Application.Model;
using BloodBank.Core.Respositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Commands.DeleteDonor
{
    public class DeleteDonorHandler : IRequestHandler<DeleteDonorCommand, ResultViewModel>
    {
        private readonly IDonorRespository _repository;

        public DeleteDonorHandler(IDonorRespository repository)
        {
            _repository = repository;
        }
        public async Task<ResultViewModel> Handle(DeleteDonorCommand request, CancellationToken cancellationToken)
        {
            var donor = await _repository.GetDonorById(request.Id);

            if (donor is null)
            {
                return ResultViewModel.Error("This donor does not exist.");
            }

            donor.SetAsDeleted();
            await _repository.UpdateDonor(donor);

            return ResultViewModel.Sucess();
        }
    }
}
