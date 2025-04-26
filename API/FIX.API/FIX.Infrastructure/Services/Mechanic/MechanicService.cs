using FIX.Application.DTO.Mehanic;
using FIX.Application.Interfaces.Mechanic;

namespace FIX.Infrastructure.Services.Mehanic;

public class MechanicService : IMechanicService
{
    //private readonly DbContext _context;
    //private readonly IMapper _mapper;

    public MechanicService(/*AppDbContext context, IMapper mapper*/)
    {
        //_context = context;
        //_mapper = mapper;
    }

    public Task CreateMechanicAsync(MechanicCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteMechanicAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<MechanicListDto>> GetAllMechanicsAsync()
    {
        //var mechanics = await _context.Mechanics.ToListAsync();
        //return _mapper.Map<List<MechanicListDto>>(mechanics);
        return null;
    }

    public Task<MechanicDetailDto> GetMechanicByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateMechanicAsync(int id, MechanicUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    // Other methods...
}