using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
