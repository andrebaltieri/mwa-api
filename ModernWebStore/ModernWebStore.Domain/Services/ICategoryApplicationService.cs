using ModernWebStore.Domain.Commands.CategoryCommands;
using ModernWebStore.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ModernWebStore.Domain.Services
{
    public interface ICategoryApplicationService
    {
        List<Category> Get();
        List<Category> Get(int skip, int take);
        Category Get(Guid id);
        Category Create(CreateCategoryCommand command);
        Category Update(EditCategoryCommand command);
        Category Delete(Guid id);
    }
}
