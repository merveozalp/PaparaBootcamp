using Owner.API.DataGenerator;
using System;

namespace Owner.API.Model
{
    public class OwnerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime PublishDate { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }
        


    }
}
