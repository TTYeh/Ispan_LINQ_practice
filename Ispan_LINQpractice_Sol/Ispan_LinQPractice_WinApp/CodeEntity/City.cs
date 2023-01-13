using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispan_LinQPractice_WinApp.CodeEntity
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityId { get; set; }
        [Required]
        [MaxLength(50)]
        public string CityName { get; set; }

        public ICollection<Member> Members { get; set; } //關聯

    }
}
