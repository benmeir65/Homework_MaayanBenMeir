using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorApp1.Client.Shared.schools
 using TriangleDbRepository;


namespace BlazorApp1.Server.Controllers
{
    public class schoolscontroler
    {

        [Route("api/[controller]")]
        [ApiController]
        public class schoolsController : ControllerBase
        {
            private readonly DbRepository _db;

            public schoolsController(DbRepository db)
            {
                _db = db;

            }


            [HttpGet("Getschools")]
            public async Task<IActionResult> Getschools()
            {
                object param = new { };

                string query = "SELECT ID, manager, num_of_classes, Is_religious from SchoolsDetails";

                var records = await _db.GetRecordsAsync<schools>(query, param);

                schools OneRow = records.FirstOrDefault();

               // List<schools> oneRow = records.ToList();

                return Ok(OneRow);
            }


            [HttpPost ("Insertschool/(school)")]
            public async Task<IActionResult> Insertschool(SchoolToSend school)
            {
                object newSchool = new
                { manager = School.manager; num_of_classes = school.num_of_classes; Is_religious = o };

                 string insertQuery = "INSERT INTO SchoolsDetails ( manager, num_of_classes ,Is_religious ) VALUES (@manager, @num_of_classes, @Isreligious)";

                 int newId = await _db.InsertReturnId(insertQuery, newSchool);
        }


         [HttpPost("Insertschool/school")]
        public async Task<IActionResult> InsertLecturer(SchoolToSend School)
        {
            int newId = await _db.InsertReturnId(insertQuery, school);
            if (newId != 0)
            {
                object param = new
                {
                    id = newId
                };
                string query = "SELECT ID, num_of_classes, manager ,  Is_religious   FROM  SchoolsDetails  WHERE Id=@id";
                var records = await _db.GetRecordsAsync<school>(query, param);

                school createdLecturer = records.FirstOrDefault();

                return Ok(school);
            }
            return BadRequest("school not created");
        }

    }
}
