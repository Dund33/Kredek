using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab4Homework.Models
{
    public class MemeViewModel
    {
        /// <summary>
        /// Image URL
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Meme ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Meme description
        /// </summary>
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        /// <summary>
        /// Meme title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Returns MemeViewModel object
        /// </summary>
        /// <param name="id"></param>
        /// <param name="image"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        public MemeViewModel(int id, string image,string title ,string description)
        {
            ID = id;
            Image = image;
            Description = description;
            Title = title;
        }

        public MemeViewModel() { }

    }
}
