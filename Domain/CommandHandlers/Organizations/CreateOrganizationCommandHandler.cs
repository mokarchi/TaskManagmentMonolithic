using CSharpFunctionalExtensions;
using System.Threading;
using System.Threading.Tasks;
using TaskManagment.Domain.Commands.Organizations;
using TaskManagment.Domain.Data;
using TaskManagment.Domain.Models;

namespace TaskManagment.Domain.CommandHandlers.Organizations
{
    public class CreateOrganizationCommandHandler : IRequestHandler<CreateOrganizationCommand, Result>
    {
        private readonly IOrganizationRepository _organizationRepository;

        public CreateOrganizationCommandHandler(IOrganizationRepository organizationRepository)
        {
            _organizationRepository = organizationRepository;
        }


        public async Task<Result> Handle(CreateOrganizationCommand request, CancellationToken cancellationToken)
        {
            //TODO Validation

            var organization = new Organization(request.Name, request.Description, request.UserId);
            await _organizationRepository.CreateAsync(organization);
            return Result.Success();
        }
    }
}
