﻿using PI.Domain.Entities;

namespace PI.Domain.Interfaces
{
    public interface IMachineCategoryRepository : IBaseRepository<MachineCategory>
    {
        Task<MachineCategory> GetByName(string name);
        Task<IEnumerable<Machine>> GetMachinesOfCategory(int categoryId);
    }
}
