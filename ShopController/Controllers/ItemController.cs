using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Queries.Core.Domain;
using ShopController.Resources;
using Queries.Core;

namespace ShopController.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ItemController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    public ItemController(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<IEnumerable<ItemResources>> GetItems()
    {
        var items = await _unitOfWork.ItemRepo.GetItems();

        return _mapper.Map<IEnumerable<Item>, IEnumerable<ItemResources>>(items);
    }

    [HttpPost]
    public async Task<IActionResult> CreateItem([FromBody] ItemResources itemResource)
    {
        var item = _mapper.Map<ItemResources, Item>(itemResource);

        await _unitOfWork.ItemRepo.InsertItem(item);

        int result = await _unitOfWork.CompleteAsync();

        return result > 0 
            ? Ok(item)
            : BadRequest("Noget gik galt.");
    }
}
