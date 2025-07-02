using BloodBank.Application.Model;
using BloodBank.Core.Respositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Commands.UpdateBloodStock
{
    public  class UpdateBloodStockHandler : IRequestHandler<UpdateBloodStockCommand, ResultViewModel>
    {
        private readonly IBloodStockRepository _repository;

        public UpdateBloodStockHandler(IBloodStockRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel> Handle(UpdateBloodStockCommand request, CancellationToken cancellationToken)
        {
            var bloodStock = await _repository.GetBloodStockById(request.IdBloodStock);

            if(bloodStock is null){
                return ResultViewModel.Error("This Blood Stock does not exist.");
            }

            bloodStock.Update(request.BloodType, request.QuantityML);
            await _repository.UpdateBloodStock(bloodStock);

            return ResultViewModel.Sucess();
        }
    }
}
