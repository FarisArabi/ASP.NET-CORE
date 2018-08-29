using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using firstProjectWebApi.Models;

namespace firstProjectWebApi.Controllers
{
	[Route("api/cat")]
    [ApiController]
	public class CatController : Controller
	{
        //cats List
        public static List <Cat> cats = new List<Cat>();

        // GET api/cat/
        //your code is here uncomment this method and write the required code to handle get request
        [HttpGet]
		 public IEnumerable<Cat> GetAll()
		 {
            return cats;
         }

        
        // POST api/cat
		[HttpPost]
		public Cat Insert([FromBody]Cat cat)
		{
            cats.Add(new Cat("cat"));
            Console.WriteLine(cats);
            return cat;
		}

        // PUT api/cat/name
		[HttpPut("{name}")]
		public void Put(string name, [FromBody] Cat cat)
		{
			//your code is here
		}

        // DELETE api/cat/1

		[HttpDelete("{name}")]
		public void Delete(string name)
		{
			//your code is here
		}


	}
}