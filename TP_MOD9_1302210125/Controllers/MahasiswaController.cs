using Microsoft.AspNetCore.Mvc;

namespace TP_MOD9_1302210125.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaDbController : ControllerBase
    {
        public static List<Mahasiswa> ListMhs = new List<Mahasiswa>
        {
            new Mahasiswa ("Mochamad Rifqi Barliant","1302210125" ),
            new Mahasiswa ("Muhammad Zaky Fathurahim","1302213067"),
            new Mahasiswa ("Raihan Sulthon Yaafi","1302213074"),
            new Mahasiswa ("Rizki Muhammad Ridwan","1302210097"),
            new Mahasiswa ("Fasya Rayhan Maulana","1302213116"),
            new Mahasiswa ("Reza Adhie Dharmawan","1302213016")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return ListMhs;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return ListMhs[id];
        }
        [HttpPost]
        public void Post(Mahasiswa value)
        {
            ListMhs.Add(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ListMhs.RemoveAt(id);
        }
    }
}
