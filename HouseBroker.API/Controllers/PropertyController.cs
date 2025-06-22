using AutoMapper;
using HouseBroker.API.Models;
using HouseBroker.Application.Services;
using HouseBroker.Infrastructure.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseBroker.API.Controllers
{
    [Route("api/property")]
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyService _propertyService;
        private readonly IMapper _mapper;

        public PropertyController(IPropertyService propertyService, IMapper mapper)
        {
            _propertyService = propertyService;
            _mapper = mapper;
        }

        [Authorize(Roles = "Broker")]
        [Route("create")]
        [HttpPost]
        public async Task<IActionResult> CreatePropertyAsync([FromBody] PropertySaveModel property)
        {
            try
            {
                if (!ModelState.IsValid) //FluentValidation
                {
                    return BadRequest(ModelState);
                }
                Property mProperty = _mapper.Map<Property>(property);
                await _propertyService.CreateAsync(mProperty);
                return Ok("Property added successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetPropertiesAsync()
        {
            try
            {
                List<Property> propertyList = await _propertyService.GetAllAsync();
                var mProperty = _mapper.Map<List<PropertyModel>>(propertyList);
                return Ok(mProperty);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [Authorize]
        [Route("{id}")]
        [HttpGet]
        public async Task<IActionResult> GetPropertyByIdAsync(int id)
        {
            try
            {
                Property property = await _propertyService.GetByIdAsync(id);
                var mProperty = _mapper.Map<PropertyModel>(property);
                return Ok(mProperty);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [Authorize(Roles = "Broker")]
        [Route("update")]
        [HttpPut]
        public async Task<IActionResult> UpdatePropertyAsync([FromBody] PropertySaveModel property)
        {
            try
            {
                if (!ModelState.IsValid) //FluentValidation
                {
                    return BadRequest(ModelState);
                }
                Property mProperty = _mapper.Map<Property>(property);
                await _propertyService.UpdateAsync(mProperty);
                return Ok("Property updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [Authorize(Roles = "Broker")]
        [Route("{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteProperty(int id)
        {
            try
            {
                await _propertyService.DeleteAsync(id);
                return Ok("Property deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
