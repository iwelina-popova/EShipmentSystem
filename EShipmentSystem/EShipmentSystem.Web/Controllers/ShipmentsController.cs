namespace EShipmentSystem.Web.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;

    using EShipmentSystem.Services.Contracts;
    using Models.Shipment;

    [Route("api/[controller]")]
    public class ShipmentsController : Controller
    {
        private readonly IMapper mapper;
        private IShipmentDataService shipments;

        public ShipmentsController(
            IMapper mapper,
            IShipmentDataService shipments)
        {
            this.mapper = mapper;
            this.shipments = shipments;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var shipmentDatas = await this.shipments
                .GetAll()
                .ProjectTo<ShipmentViewModel>()
                .ToListAsync();

            return this.Ok(shipmentDatas);
        }
    }
}