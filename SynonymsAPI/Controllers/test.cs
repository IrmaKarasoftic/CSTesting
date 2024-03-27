using Microsoft.AspNetCore.Mvc;
using SynonymsAPI.Interfaces;
using SynonymsDB;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
//testing
namespace SynonymsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SynonymsController : ControllerBase
    {
        private readonly ISynonymsService _synonymsService;
        public SynonymsController(ISynonymsService synonymsService)
        {
            _synonymsService = synonymsService;
        }

        //codechecker_critical
        [HttpGet]
        public ActionResult<Message> Get()
        {
            try
            {
                var words = _synonymsService.Get();
                return new Message()
                {
                    Data = words,
                    IsValid = true
                };
            }
            catch (Exception)
            {
                return new Message()
                {
                    IsValid = false
                };
            }

        }

        [HttpGet("search")]
        public ActionResult<Message> Get([FromQuery] string word)
        {
            try
            {
                var words = _synonymsService.SearchByWord(word);
                return new Message()
                {
                    Data = words,
                    IsValid = true
                };
            }
            catch (Exception)
            {
                return new Message()
                {
                    IsValid = false
                };
            }
        }

        [HttpPost]
        public ActionResult<Message> Post(WordDto word)
        {
            try
            {
                _synonymsService.Add(word.WordString, word.Synonyms.ToList());
                return new Message()
                {
                    IsValid = true
                };
            }
            catch (Exception)
            {
                return new Message()
                {
                    IsValid = false
                };
            }
        }
    }
}
