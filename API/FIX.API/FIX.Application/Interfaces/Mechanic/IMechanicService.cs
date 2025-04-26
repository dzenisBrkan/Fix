using FIX.Application.DTO.Mehanic;

namespace FIX.Application.Interfaces.Mechanic;

public interface IMechanicService
{
    Task<List<MechanicListDto>> GetAllMechanicsAsync();
    Task<MechanicDetailDto> GetMechanicByIdAsync(int id);
    Task CreateMechanicAsync(MechanicCreateDto dto);
    Task UpdateMechanicAsync(int id, MechanicUpdateDto dto);
    Task DeleteMechanicAsync(int id);
}