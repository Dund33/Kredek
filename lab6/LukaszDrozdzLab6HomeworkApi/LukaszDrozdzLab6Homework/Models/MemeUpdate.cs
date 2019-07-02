using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab6Homework.Models
{
    public class MemeUpdate
    {
        /// <summary>
        /// ID of the updated Meme
        /// </summary>
        [Required]
        [MinLength(36)]
        [MaxLength(36)]
        public string ID { get; set; }

        /// <summary>
        /// Server-generated token
        /// </summary>
        [Required]
        [MinLength(36)]
        [MaxLength(36)]
        public string Token { get; set; }

        /// <summary>
        /// New title
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// New url
        /// </summary>
        [Required]
        public string URL { get; set; }

        /// <summary>
        /// New description
        /// </summary>
        public string Desc { get; set; }
    }
}
