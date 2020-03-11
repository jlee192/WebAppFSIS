using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FSISSystem.ENTITIES
{
    [Table("Team")]
    public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
    }
}

