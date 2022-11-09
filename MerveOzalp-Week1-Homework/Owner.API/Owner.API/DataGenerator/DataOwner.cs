using Owner.API.Model;
using System;
using System.Collections.Generic;

namespace Owner.API.DataGenerator
{
    public class DataOwner
    {
        public List<Model.OwnerModel> OwnerModelsList()
        {
            return new List<Model.OwnerModel>
            {
                new Model.OwnerModel
                {
                Id = 1,
                Name = "Merve",
                Surname ="Ozalp",
                PublishDate= System.DateTime.Now,
                Description =" Başlangıç",
                TypeId =1,
                },
                 new Model.OwnerModel
                 {
                 Id = 2,
                Name = "Mert",
                Surname ="Ozalp",
                PublishDate= System.DateTime.Now,
                Description =" Orta seviye",
                TypeId = 2
                
                 },
                  new Model.OwnerModel
                  {
                      Id = 3,
                Name = "Hasan",
                Surname ="Çay",
                PublishDate= System.DateTime.Now,
                Description ="ileri seviye",
                TypeId =3,
              
                  }
            };
        }
    }
}
