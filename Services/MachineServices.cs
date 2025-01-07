using BlazorApp_IM_Park.Models;

namespace BlazorApp_IM_Park.Services
{
    public class MachineServices
    {
        private List<Machine> machinesList = new();

        public MachineServices()
        {
            // Initialize with some dummy data
            machinesList.Add(new Machine { MachineName = "Machine 1", Status = "Online" });
            machinesList.Add(new Machine { MachineName = "Machine 2", Status = "Offline" });
            machinesList.Add(new Machine { MachineName = "Machine 3", Status = "Online" });
            machinesList.Add(new Machine { MachineName = "Machine 4", Status = "Offline" });
        }

        public Task<List<Machine>> GetMachinesAsync()
        {
            return Task.FromResult(machinesList);
        }

        public Task AddMachineAsync(Machine machine)
        {
            machinesList.Add(machine);
            return Task.CompletedTask;
        }

        public Task RemoveMachineAsync(Guid id)
        {
            machinesList.RemoveAll(m => m.Id == id);
            return Task.CompletedTask;
        }

        public Task UpdateMachineStatusAsync(Guid id, string status)
        {
            var machine = machinesList.FirstOrDefault(m => m.Id == id);
            if (machine != null)
            {
                machine.Status = status;
                machine.LastUpdatedTime = DateTime.Now;
            }
            return Task.CompletedTask;
        }
    }
}
