using MongoDB.Bson;
using System;

namespace TaskManagment.Domain.Core.Models
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            id = ObjectId.GenerateNewId().ToString();
            CreateDateTime = DateTime.Now;
            ModifiedDateTime = DateTime.Now;
        }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string Id
        {
            get => id;
            set
            {
                if (string.IsNullOrEmpty(value))
                    id = ObjectId.GenerateNewId().ToString();
                else
                    id = value;
            }
        }
        private string id { get; set; }
    }
}
