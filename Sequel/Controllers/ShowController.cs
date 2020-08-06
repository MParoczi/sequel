using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sequel.Contexts.Contracts;
using Sequel.Models;

namespace Sequel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowController : ControllerBase
    {
        public ShowController(IRepositoryWrapper repository)
        {
            Repository = repository;
        }

        private IRepositoryWrapper Repository { get; }

        [HttpGet]
        public IEnumerable<Show> Get()
        {
            return Repository.Show.FindAll();
        }
    }
}