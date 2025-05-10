using Microsoft.AspNetCore.Mvc;
using LinkedListApi.Models;
using LinkedListApi.Services;

namespace LinkedListApi.Controllers
{
    [ApiController]
    [Route("linked-list")]
    public class LinkedListController : ControllerBase
    {
        private readonly LinkedListService _linkedListService;

        public LinkedListController(LinkedListService linkedListService)
        {
            _linkedListService = linkedListService;
        }

        [HttpGet]
        public IActionResult GetLinkedList()
        {
            var list = _linkedListService.GetLinkedList().ToList();
            return Ok(list);
        }

        [HttpPost]
        public IActionResult AddNode([FromBody] AddNodeRequest request)
        {
            if (string.IsNullOrEmpty(request.Value))
                return BadRequest("Value cannot be empty");

            var node = _linkedListService.GetLinkedList().Add(request.Value);
            return Created(string.Empty, new { id = node.Id });
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveNode(string id)
        {
            var result = _linkedListService.GetLinkedList().Remove(id);
            if (!result)
                return NotFound();

            return NoContent();
        }
    }
}