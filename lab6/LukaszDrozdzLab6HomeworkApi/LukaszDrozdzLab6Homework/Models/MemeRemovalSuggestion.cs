using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab6Homework.Models
{
    public class MemeRemovalSuggestion
    {
        /// <summary>
        /// Auth token
        /// </summary>
        [Required]
        [StringLength(36)]
        public string Token { get; set; }


        /// <summary>
        /// Meme ID
        /// </summary>
        [Required]
        [StringLength(36)]
        public string ID { get; set; }
    }
}
