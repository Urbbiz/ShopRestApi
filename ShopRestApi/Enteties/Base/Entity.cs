using System.ComponentModel.DataAnnotations;

namespace ShopRestApi.Enteties.Base
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
