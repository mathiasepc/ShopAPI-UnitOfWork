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
    public async Task<IEnumerable<ItemResource>> GetItems()
    {
        var items = await _unitOfWork.ItemRepo.GetItems();

        return _mapper.Map<IEnumerable<Item>, IEnumerable<ItemResource>>(items);
    }

    [HttpPost]
    public async Task<IActionResult> CreateItem([FromBody] ItemResource itemResource)
    {
        var item = _mapper.Map<ItemResource, Item>(itemResource);

        await _unitOfWork.ItemRepo.InsertItem(item);

        int result = await _unitOfWork.CompleteAsync();

        return result > 0 
            ? Ok(item)
            : BadRequest("Noget gik galt.");
    }
}
