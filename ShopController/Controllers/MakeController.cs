using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Queries.Core;
using Queries.Core.Domain;
using ShopController.Resources;

namespace ShopController.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MakeController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public MakeController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<MakeResource>> GetMake()
    {
        var make = await _unitOfWork.MakeRepo.GetMake();

        return Ok(_mapper.Map<IEnumerable<Make>, IEnumerable<MakeResource>>(make));
    } 
}
