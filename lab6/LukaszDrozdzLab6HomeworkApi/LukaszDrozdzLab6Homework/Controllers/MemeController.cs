using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using LukaszDrozdzLab6Homework.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LukaszDrozdzLab6Homework.Controllers
{
    [Route("api/Meme")]
    [ApiController]

    public class MemeController : ControllerBase
    {
        private static List<Meme> _memes = new List<Meme>();
        private static List<User> _users = new List<User>();

        //Old MSDN guidelines state that I should use PascalCase, the newer ones contradict.
        //It shall remain as it is
        private static List<string> _authorizedTokens = new List<string>(); 


        /// <summary>
        /// Contructor for the main meme controller
        /// </summary>
        public MemeController()
        {
            _users.Add(new User("dzida", "jbzd", "dzida@jbzdy.pl"));
        }

        /// <summary>
        /// Check authorization
        /// Return single use token if authorized successfully
        /// </summary>
        /// <param name="user">Basic user credentials</param>
        /// <returns></returns>
        [HttpPost("Auth")]
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(400)]
        public IActionResult Auth([FromBody] UserAuthRequest user)
        {
            RequiredAttribute requiredAttribute = new RequiredAttribute();
            EmailAddressAttribute emailAddressAttribute = new EmailAddressAttribute();

            if (!requiredAttribute.IsValid(user.Username))
            {
                return BadRequest("No username provided");
            }

            if (!requiredAttribute.IsValid(user.Password))
            {
                return BadRequest("No password provided");
            }
            
            User authorizedUser = _users.Where(u => ((u.Username == user.Username) && (u.Password == user.Password))).FirstOrDefault();
            if (authorizedUser == null)
            {
                return Unauthorized();
            }
            else
            {
                var token = Guid.NewGuid().ToString();
                _authorizedTokens.Add(token);
                return Ok(token);
            }
        }

        /// <summary>
        /// Add new user
        /// </summary>
        /// <param name="user">User credentials</param>
        /// <returns></returns>
        [HttpPost("AddUser")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult AddUser([FromBody] User user)
        {
            EmailAddressAttribute emailAddressAttribute = new EmailAddressAttribute();
            RequiredAttribute requiredAttribute = new RequiredAttribute();

            if (!requiredAttribute.IsValid(user.Username))
            {
                return NotFound("User with provided username couldn't be found");
            }

            if (!requiredAttribute.IsValid(user.Password))
            {
                return BadRequest("No password provided");
            }

            if (!requiredAttribute.IsValid(user.Email))
            {
                return BadRequest("No email provided");
            }

            if (!emailAddressAttribute.IsValid(user.Email))
            {
                return BadRequest("Invalid e-mail address");
            }

            _users.Add(user);
            return NoContent();
           
        }


        /// <summary>
        /// Upload a meme
        /// </summary>
        /// <param name="memeSuggestion">Meme suggestion object receiver from user</param>
        /// <returns></returns>
        [HttpPost("AddMeme")]
        [ProducesResponseType(401)]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        public IActionResult AddMeme([FromBody]MemeSuggestion memeSuggestion)
        {
            Console.WriteLine(memeSuggestion.Title);

            UrlAttribute urlAttribute = new UrlAttribute();
            RequiredAttribute requiredAttribute = new RequiredAttribute();
            MinLengthAttribute minLengthAttribute = new MinLengthAttribute(36);
            MaxLengthAttribute maxLengthAttribute = new MaxLengthAttribute(36);

            if (!requiredAttribute.IsValid(memeSuggestion.Token))
            {
                return BadRequest("No token provided");
            }

            if (!requiredAttribute.IsValid(memeSuggestion.URL))
            {
                return BadRequest("No URL provided");
            }

            if (!requiredAttribute.IsValid(memeSuggestion.Title))
            {
                return BadRequest("No title provided");
            }

            if (!urlAttribute.IsValid(memeSuggestion.URL))
            {
                return BadRequest("Invalid URL");
            }

            if (!minLengthAttribute.IsValid(memeSuggestion.Token) || !maxLengthAttribute.IsValid(memeSuggestion.Token))
            {
                return BadRequest("Invalid token");
            }

            if (_authorizedTokens.Contains(memeSuggestion.Token))
            {
                var guid = Guid.NewGuid().ToString();
                Meme newMeme = new Meme
                {
                    ID = guid,
                    Title = memeSuggestion.Title,
                    Desc = memeSuggestion.Desc,
                    URL = memeSuggestion.URL
                };
                _memes.Add(newMeme);
                _authorizedTokens.Remove(memeSuggestion.Token);
                return NoContent();
            }
            else
            {
                return Unauthorized();
            }


        }

        /// <summary>
        /// Update meme
        /// </summary>
        /// <returns></returns>
        [HttpPatch("UpdateMeme")]
        [ProducesResponseType(401)]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        public IActionResult UpdateMeme([FromBody]MemeUpdate meme)
        {
            MinLengthAttribute minLengthAttribute = new MinLengthAttribute(36);
            MaxLengthAttribute maxLengthAttribute = new MaxLengthAttribute(36);
            RequiredAttribute requiredAttribute = new RequiredAttribute();

            if (!requiredAttribute.IsValid(meme.ID))
            {
                return BadRequest("No ID provided");
            }

            if (!requiredAttribute.IsValid(meme.URL))
            {
                return BadRequest("No URL provided");
            }

            if (!requiredAttribute.IsValid(meme.Title))
            {
                return BadRequest("No new title provided");
            }

            if (!requiredAttribute.IsValid(meme.Token))
            {
                return BadRequest("No token provided");
            }

            if (!(minLengthAttribute.IsValid(meme.Token)) || !(maxLengthAttribute.IsValid(meme.Token)))
            {
                return BadRequest("Invalid token");
            }

            if (!(minLengthAttribute.IsValid(meme.ID)) || !(maxLengthAttribute.IsValid(meme.ID)))
            {
                return BadRequest("Invalid ID");
            }

           
            if (_authorizedTokens.Contains(meme.Token))
            {
                Meme modifiedMeme = _memes.Where(m => m.ID == meme.ID).FirstOrDefault();
                if (modifiedMeme == null)
                {
                    return NotFound();
                }

                modifiedMeme.Title = meme.Title;
                modifiedMeme.Desc = meme.Desc;
                modifiedMeme.URL = meme.URL;
                _authorizedTokens.Remove(meme.Token);
                return NoContent();
            }
            else
            {
                return Unauthorized();
            }

          
        }

        /// <summary>
        /// Get all the memes
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        [ProducesResponseType(typeof(List<Meme>), 200)]
        public IActionResult GetAll()
        {
            return Ok(_memes);
        }

        /// <summary>
        /// Get meme with specific ID
        /// </summary>
        /// <param name="id">Meme ID</param>
        /// <returns></returns>
        /// <remarks>
        /// Used to get a meme with specific ID
        /// </remarks>
        [HttpGet("{id}")]
        [ProducesResponseType(404)]
        [ProducesResponseType(400)]
        [ProducesResponseType(typeof(Meme), 200)]
        public IActionResult Get(string id)
        {
            MinLengthAttribute minLengthAttribute = new MinLengthAttribute(36);
            MaxLengthAttribute maxLengthAttribute = new MaxLengthAttribute(36);

            if(minLengthAttribute.IsValid(id) && maxLengthAttribute.IsValid(id))
            {
                Meme meme = _memes.Where(memz => memz.ID == id).FirstOrDefault();
                if (meme == null) return NotFound("No memes with matching ID were found");
                return Ok(meme);
            }
            else
            {
                return BadRequest("Invalid ID");
            }
           
        }
        
        /// <summary>
        /// Remove meme with specific ID
        /// </summary>
        /// <param name="memeToRemove">Meme to be removed</param>
        /// <returns></returns>
        [HttpDelete("RemoveMeme")]
        [ProducesResponseType(401)]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult RemoveMeme([FromBody] MemeRemovalSuggestion memeToRemove)
        {
            MinLengthAttribute minLengthAttribute = new MinLengthAttribute(36);
            MaxLengthAttribute maxLengthAttribute = new MaxLengthAttribute(36);
            RequiredAttribute requiredAttribute = new RequiredAttribute();

            if (!requiredAttribute.IsValid(memeToRemove.ID))
            {
                return BadRequest("No ID provided");
            }

            if (!requiredAttribute.IsValid(memeToRemove.Token))
            {
                return BadRequest("No Token provided");
            }

            if (!(minLengthAttribute.IsValid(memeToRemove.ID)) || (!maxLengthAttribute.IsValid(memeToRemove.ID)))
            {
                return BadRequest("Invalid ID");
            }

            if (!(minLengthAttribute.IsValid(memeToRemove.Token)) || !(maxLengthAttribute.IsValid(memeToRemove.Token)))
            {
                return BadRequest("Invalid Token");
            }

            if (!_authorizedTokens.Contains(memeToRemove.Token))
            {
                return Unauthorized();
            }

            Meme memeTmp = null;

            foreach(Meme meme in _memes)
            {
                if(meme.ID == memeToRemove.ID)
                {
                    memeTmp = meme;
                    break;
                }
            }

            if(memeTmp == null)
            {
                return NotFound("Meme with specified ID couldn't be found");
            }
            else
            {
                _memes.Remove(memeTmp);
            }

            return NoContent();        
        }
    }
}