using Academy.Service.Services;

GroupService groupService = new();

groupService.Update(2, new() { Name="CS1", Capacity=25 });