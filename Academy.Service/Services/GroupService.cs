using Academy.Core.Models;
using Academy.Data;
using Academy.Service.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Academy.Service.Services;

public class GroupService
{
    public AcademyDbContext academyDbContext { get; set; }
    
    public GroupService()
    {
        academyDbContext = new();
    }

    public void AddGroup(Group group)
    {
        Group? existingGroup = academyDbContext.Groups.AsNoTracking().SingleOrDefault(g => g.Name == group.Name);
        if (existingGroup is not null) throw new GroupAlreadyExistsException("Group with that name already exists");
        academyDbContext.Groups.Add(group);
        academyDbContext.SaveChanges();
    }

    public void RemoveGroup(int? id)
    {
        if (id is null) throw new IdNotGivenException("Id is not given");
        Group? group = academyDbContext.Groups.SingleOrDefault(g => g.Id == id);
        if (group is null) throw new GroupDoesNotExistException("Group does not exist");
        academyDbContext.Remove(group);
        academyDbContext.SaveChanges();
    }

    public Group GetGroup(int? id)
    {
        if (id is null) throw new IdNotGivenException("Id is not given");
        Group? group = academyDbContext.Groups.SingleOrDefault(g => g.Id == id);
        if (group is null) throw new GroupDoesNotExistException("Group does not exist");
        return group;
    }

    public void Update(int? id, Group group)
    {
        if (id is null) throw new IdNotGivenException("Id is not given");
        Group? existGroup = academyDbContext.Groups.SingleOrDefault(g => g.Id == id);
        if (group is null) throw new GroupDoesNotExistException("Group does not exist");
        Group? existNameGroup = academyDbContext.Groups.SingleOrDefault(g => g.Name == group.Name && g.Id != group.Id);
        if (existNameGroup is not null) throw new GroupAlreadyExistsException("Group with that name already exists");
        existGroup.Name = existNameGroup.Name;
        existGroup.Capacity = existNameGroup.Capacity;
        academyDbContext.SaveChanges();
    }
}
