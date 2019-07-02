using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab6Homework.Models
{
    public class MemeSuggestion
    {

        /// <summary>
        /// Server-generated auth token
        /// </summary>
        [Required]
        [MinLength(36)]
        [MaxLength(36)]
        public string Token { get; set; }

        /// <summary>
        /// Meme url
        /// </summary>
        [Required]
        [Url]
        public string URL { get; set; }

        /// <summary>
        /// Meme description
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// Meme title
        /// </summary>
        [Required]
        public string Title { get; set; }
    }
}
