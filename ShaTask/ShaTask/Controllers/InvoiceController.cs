using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShaTask.Application.Commands.InvoiceDetailCommands;
using ShaTask.Application.Commands.InvoiceHeaderCommands;
using ShaTask.Application.Queries.InvoiceHeaderQueries;

namespace ShaTask.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IMediator _mediator;

        public InvoiceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var request = new GetAllINHQuery();
            var result = await _mediator.Send(request);
            return View(result);
        }

        [HttpPost]
        public IActionResult UpdateInvoice(int invoiceId, string CustomerName, string CashierName, string BranchName)
        {
            try
            {

                var request = new UpdateINHCommand
                {
                    ID = invoiceId,
                    CustomerName = CustomerName,
                };
                var result = _mediator.Send(request);
                return Json(new { success = true, message = "Invoice updated successfully" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "An error occurred while updating the invoice" });
            }
        }

        [HttpPost]
        public IActionResult UpdateItem(int ItemID, string ItemName, double ItemPrice, int ItemCount)
        {
            try
            {

                var request = new UpdateINDCommand
                {
                    ID = ItemID,
                    ItemName = ItemName,
                    ItemCount = ItemCount,
                    ItemPrice = ItemPrice
                };
                var result = _mediator.Send(request);
                return Json(new { success = true, message = "Item updated successfully" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "An error occurred while updating the invoice" });
            }
        }

        [HttpPost]
        public IActionResult DeleteItem(long ItemID)
        {
            try
            {

                var request = new DeleteINDCommand
                {
                    ID = ItemID
                };
                var result = _mediator.Send(request);
                return Json(new { success = true, message = "Invoice Deleted successfully" });
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                return Json(new { success = false, message = "An error occurred while updating the invoice" });
            }
        }

    }
}
