using System;
using System.ComponentModel.DataAnnotations;

namespace GymProjectMvc.Domain.Entities
{
    public abstract class Entity
    {
        public int Id { get; protected set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? Create { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? Change { get; set; }

        public Entity()
        {
            if (Create is null)
                Create = DateTime.Now;

            Change = DateTime.Now;
        }
    }
}
