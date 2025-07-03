using BloodBank.Application.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Queries.GetBloodStockById
{
    public class GetBloodStockByIQuery : IRequest<ResultViewModel<BloodStockItemViewModel>>
    {
        public int Id { get; set; }

        public GetBloodStockByIQuery(int id)
        {
            Id = id;
        }
    }
}
