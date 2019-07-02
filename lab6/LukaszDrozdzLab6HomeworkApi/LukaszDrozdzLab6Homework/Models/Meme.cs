using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab6Homework.Models
{
    public class Meme
    {
       
        /// <summary>
        /// Meme ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Meme URL
        /// </summary>
        [Required]
        public string URL { get; set; }

        /// <summary>
        /// Meme descirption
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// Meme title
        /// </summary>
        [Required]
        public string Title { get; set; }
    }
}
