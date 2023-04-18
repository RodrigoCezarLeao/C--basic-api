using Catalog.Entities;
using Catalog.Repositories;
using Catalog.DTOs;
using Catalog;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository repository;

        public ItemsController(IItemsRepository repository)
        {
            this.repository = repository;
        }


        [HttpGet]
        public IEnumerable<ItemDTO> GetItems()
        {
            var items = repository.GetItems().Select(item => item.AsDTO());
            return items;
        }

        [HttpGet("id")]
        public ActionResult<ItemDTO> GetItem(Guid Id)
        {
            var item = repository.GetItem(Id);
            if (item is null)
                return NotFound();

            return item.AsDTO();
        }

    }
}