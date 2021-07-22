using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using TaskManager.Shared;

namespace TaskManager.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ILogger<TaskController> _logger;

        private static readonly List<TaskItem> Tasks = new List<TaskItem>()
        {
            new TaskItem{Id=1,TaskName="task 1", DueBy=new DateTime(2021,01,01), IsCompleted=true},
            new TaskItem{Id=2,TaskName="task 2", DueBy=new DateTime(2021,08,04)},
            new TaskItem{Id=3,TaskName = "task 3", DueBy=new DateTime(2021,07,20), IsCompleted=false}
        };

        public TaskController(ILogger<TaskController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<TaskItem> Get()
        {
            return Tasks;
        }
    }
}
