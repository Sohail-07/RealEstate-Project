using System.ComponentModel.DataAnnotations;

namespace WebAPI.Dtos
{
    public class CityDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter City Name")]
        [StringLength(50,MinimumLength =2)]
        [RegularExpression(".*[a-zA-z]+.*",ErrorMessage ="Only numerics are not allowed")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please Enter Country Name")]
        [StringLength(50, MinimumLength = 2)]
        public string Country { get; set; }
    }
}
