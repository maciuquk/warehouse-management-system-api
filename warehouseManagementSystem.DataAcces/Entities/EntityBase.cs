using System.ComponentModel.DataAnnotations;

namespace warehouseManagementSystem.DataAcces.Entities
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }

    }
}
