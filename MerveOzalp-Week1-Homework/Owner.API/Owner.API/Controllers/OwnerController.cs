using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Owner.API.DataGenerator;
using Owner.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Owner.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {

        DataOwner owner = new DataOwner();
        

        [Route("GetOwners")]
       [HttpGet]
        public IActionResult GetAll()
        {
           
            var get = owner.OwnerModelsList();
            return Ok (get);
        }


        [Route("CreateOwnerr")]
        [Consumes("application/json")]
        [HttpPost]
        public IActionResult CreateOwner(OwnerModel ownerModel)
        {
           
            var own = owner.OwnerModelsList().SingleOrDefault(x => x.Id == ownerModel.Id);
            var ownerContaint = ownerModel.Description.Contains("hack");
            if (own is not null)
            {
                return BadRequest("List has this Id");
            }
            else if (ownerContaint == true)
            {
                return NotFound("Description has 'hack' ");
            }
            owner.OwnerModelsList().Add(ownerModel);
            return Ok(ownerModel);
        }
       
         [HttpPut("{Id}")]
         public IActionResult UpdateOwner (int Id ,[FromBody] OwnerModel updateModel)
        {
            

            var own = owner.OwnerModelsList().SingleOrDefault(x => x.Id == Id);
            if (own is null)
                return NotFound();
           // own.Id = updateModel.Id != default ? updateModel.Id : own.Id;
            own.Name = updateModel.Name != default ? updateModel.Name : own.Name;
            own.Surname = updateModel.Surname != default ? updateModel.Surname : own.Surname;
            own.PublishDate = updateModel.PublishDate != default ? updateModel.PublishDate : own.PublishDate;
            own.Description = updateModel.Description != default ? updateModel.Description : own.Description;
            own.TypeId = updateModel.TypeId != default ? updateModel.TypeId: own.TypeId;
            
            return Ok(updateModel);
        }

        [HttpDelete("{Id}")]
        public IActionResult DeleteOwner (int Id)
        {
            
            var own = owner.OwnerModelsList().SingleOrDefault(x => x.Id == Id);
            if (own is null)
                return NotFound();
            owner.OwnerModelsList().Remove(own);
            return Ok(own);
        }

        
    }
}
