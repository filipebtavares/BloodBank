using BloodBank.Application.Model;
using BloodBank.Application.Service;
using BloodBank.Core.Entities;
using BloodBank.Core.Respositories;
using MediatR;

namespace BloodBank.Application.Commands.InsertDonor
{
    public class CreateDonorHandler : IRequestHandler<CreateDonorCommand, ResultViewModel<int>>
    {
        private readonly IDonorRespository _repository;
        private readonly ICepService _cepService;

        public CreateDonorHandler(IDonorRespository repository, ICepService cepService)
        {
            _repository = repository;
            _cepService = cepService;
        }

        public async  Task<ResultViewModel<int>> Handle(CreateDonorCommand request, CancellationToken cancellationToken)
        {
            ViaCepViewModel cepData;
            try
            {
                cepData = await _cepService.GetAddressByCepAsync(request.Cep);

                if (cepData is null || string.IsNullOrEmpty(cepData.Cep))
                    return ResultViewModel<int>.Error("CEP não encontrado.");
            }
            catch
            {
                return ResultViewModel<int>.Error("Erro ao consultar o endereço via CEP.");
            }

            var address = new Address(
                publicPlace: cepData.PublicPlace,
                city: cepData.Locality,
                state: cepData.Uf,
                cep: cepData.Cep,
                district: cepData.District
            );

            var donor = new Donor(
                fullName: request.FullName,
                genre: request.Genre,
                email: request.Email,
                birthDate: request.BirthDate,
                bloodType: request.BloodType,
                rhFactor: request.RhFactor,
                weight: request.Weight,
                address: address
            );

            await _repository.PostDonor(donor);

            return ResultViewModel<int>.Sucess(donor.Id);
        }
    }
}
