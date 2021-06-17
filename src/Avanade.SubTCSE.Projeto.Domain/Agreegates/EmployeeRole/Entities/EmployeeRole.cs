﻿namespace Avanade.SubTCSE.Projeto.Domain.Agreegates.EmployeeRole.Entities
{

    public record EmployeeRole
    {
        public EmployeeRole(string id, string roleName)
        {
            Id = id;
            RoleName = roleName;
        }

        public EmployeeRole(string roleName)
        {
            RoleName = roleName;
        }

        public string Id { get; set; }
        public string RoleName { get; set; }
    }
}
