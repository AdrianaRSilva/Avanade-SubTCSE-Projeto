namespace Avanade.SubTCSE.Projeto.Domain.Aggregate.EmployeeRoles.Entities
{
    class EmployeeRole
    {
        public EmployeeRole(string id, string roleName)
        {
            Id = id;
            RoleName = roleName;
        }

        public string Id { get; private set; }

        public string RoleName { get; init; }

    }

}
