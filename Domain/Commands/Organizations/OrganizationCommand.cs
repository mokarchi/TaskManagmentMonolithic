using TaskManagment.Domain.Core.Commands;

namespace TaskManagment.Domain.Commands.Organizations
{
    public abstract class OrganizationCommand : Command
    {
        public OrganizationCommand()
        {

        }

        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public string UserId { get; protected set; }
    }
}
