using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorApp1.Shared.models.courses;

namespace BlazorApp1.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController1 : ControllerBase
	{
		[HttpGet("{stringToCheck}")]
		public async Task<HttpResponseMessage> CheckString(string stringToCheck)
		{
			if (stringToCheck.Contains(" "))

			{
				int spaceIndex = stringToCheck.IndexOf(" ");
				string firstWord = stringToCheck.Substring(0, spaceIndex);
				return ok(firstWord);

			}
			else
			{
				return BadRequest(stringToCheck);
			}
		}
	}

	[HttpPost("singleCourse")]
	public async Task<HttpResponseMessage> CheckCourse(Courses singleCourse)
	{
		if (singleCourse == null)
		{
			return BadRequest();
		}
		if (singleCourse.TeacherName.length == 2)

		{
			return ok(singleCourse);
		}
		else
		{
			ourses newsingleCourse = new Courses();
			newsingleCourse.TeacherName = unknown;
			return ok(newsingleCourse);
		}


	}

