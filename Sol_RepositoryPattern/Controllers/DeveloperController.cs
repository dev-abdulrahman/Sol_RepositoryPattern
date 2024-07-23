using Microsoft.AspNetCore.Mvc;
using Sol_Domain.Entities;
using Sol_Domain.Interface;

namespace Sol_RepositoryPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeveloperController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeveloperController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetPopularDevelopers([FromQuery] int count)
        {
            var popularDevelopers = _unitOfWork.Developers.GetPopularDevelopers(count);
            return Ok(popularDevelopers);
        }

        [HttpPost]
        public async Task<IActionResult> AddDeveloperAndProject()
        {
            var developer = new Developer
            {
                Followers = 35,
                Name = "Mukesh Murugan"
            };
            var project = new Project
            {
                Name = "codewithmukesh"
            };
            _unitOfWork.Developers.Add(developer);
            _unitOfWork.Projects.Add(project);

            await _unitOfWork.SaveChanges();

            return Ok();

        }
    }
}
