using Microsoft.AspNetCore.Mvc;
using TapAndPayWebApi.Business.Services;
using TapAndPayWebApi.Models;
using System.Threading.Tasks;

namespace TapAndPayWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionsService _transactionsService;

        public TransactionsController(ITransactionsService transactionsService)
        {
            _transactionsService = transactionsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var transactions = await _transactionsService.GetAllTransactionsAsync();
            return Ok(transactions);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var transaction = await _transactionsService.GetTransactionByIdAsync(id);
            if (transaction == null)
            {
                return NotFound();
            }
            return Ok(transaction);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Transaction transaction)
        {
            await _transactionsService.AddTransactionAsync(transaction);
            return CreatedAtAction(nameof(Get), new { id = transaction.Id }, transaction);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, Transaction transaction)
        {
            if (id != transaction.Id)
            {
                return BadRequest();
            }
            await _transactionsService.UpdateTransactionAsync(transaction);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _transactionsService.DeleteTransactionAsync(id);
            return NoContent();
        }
    }
}