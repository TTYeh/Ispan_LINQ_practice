using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispan_LinQPractice_WinApp.CodeEntity
{

    public class Member
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MebberId { get; set; }
        [Required]
        [MaxLength(50)]
        public string MemberName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string Password { get; set; }

        [Required]
        public int CityId { get; set; }
        public string Description { get; set; }

        public City City { get; set; } //Member關聯到City 1對多
        //public ICollection<Member> Members { get; set; } //City關聯Member 多對1
    }
}
