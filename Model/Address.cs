using System.ComponentModel.DataAnnotations;

namespace BlazingPizza.Model
{
    public class Address
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Campo obligatorio"), MinLength(3, ErrorMessage="Introduce una cadena con al menos 3 letras"), MaxLength(100, ErrorMessage="Introduce una cadena con menos de 100 letras")]
        public string Name { get; set; }

        [Required(ErrorMessage="Campo obligatorio"), MinLength(5, ErrorMessage="Introduce una cadena con al menos 5 letras"), MaxLength(100, ErrorMessage="Introduce una cadena con menos de 100 letras")]
        public string Line1 { get; set; }

        [MaxLength(100, ErrorMessage="Introduce una cadena con menos de 100 letras")]
        public string Line2 { get; set; }

        [Required(ErrorMessage="Campo obligatorio"), MinLength(3, ErrorMessage="Introduce una cadena con al menos 3 letras"), MaxLength(50, ErrorMessage="Introduce una cadena con menos de 50 letras")]
        public string City { get; set; }

        [Required(ErrorMessage="Campo obligatorio"), MinLength(3, ErrorMessage="Introduce una cadena con al menos 3 letras"), MaxLength(20, ErrorMessage="Introduce una cadena con menos de {0} letras")]
        public string Region { get; set; }

        [Required(ErrorMessage="Campo obligatorio"), RegularExpression(@"^([0-9]{5})$", ErrorMessage="Introduce un Código Postal con 5 dígitos")]
        public string PostalCode { get; set; }
    }
}

