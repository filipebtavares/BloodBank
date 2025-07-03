using BloodBank.Application.Model;
using BloodBank.Core.Respositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Queries.GetBloodStockById
{
    public class GetBloodStockByIdHandler : IRequestHandler<GetBloodStockByIQuery, ResultViewModel<BloodStockItemViewModel>>
    {
        private IBloodStockRepository _repository;

        public GetBloodStockByIdHandler(IBloodStockRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResultViewModel<BloodStockItemViewModel>> Handle(GetBloodStockByIQuery request, CancellationToken cancellationToken)
        {
            var bloodStock = await _repository.GetBloodStockById(request.Id);

            if (bloodStock is null)
            {
                return ResultViewModel<BloodStockItemViewModel>.Error("This Stock does not exist.");
            }

            var model = BloodStockItemViewModel.FromEntity(bloodStock);

            return ResultViewModel<BloodStockItemViewModel>.Sucess(model);

        }
    }
}
