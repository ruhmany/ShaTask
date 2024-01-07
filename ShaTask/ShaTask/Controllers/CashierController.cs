using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShaTask.Application.Commands.CashierCommands;
using ShaTask.Application.Queries.CashierQueries;
using ShaTask.Domain.Entities;
using ShaTask.Models;

namespace ShaTask.Controllers
{
    public class CashierController : Controller
    {
        private readonly IMediator _mediator;

        public CashierController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var query = new GetAllCashiersQuery();
            var result = await _mediator.Send(query);
            return View(result);
        }

        public IActionResult AddCashier()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddCashier(AddCashierViewModel model)
        {
            if (ModelState.IsValid)
            {
                var command = new AddCashierCommand
                {
                    CashierName = model.CashierName,
                    BranchID = model.BranchID
                };

                await _mediator.Send(command);
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        // GET: Cashier/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var cashier = await _mediator.Send(new GetCashierByIdQuery { Id = id });
            if (cashier == null)
            {
                return NotFound();
            }

            var model = new UpdateCasherViewModel
            {
                ID = cashier.ID,
                BranchID = cashier.BranchID,
                CashierName = cashier.CashierName
            };

            return View(model);
        }

        // POST: Cashier/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CashierName,BranchID")] UpdateCasherViewModel cashier)
        {
            if (id != cashier.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _mediator.Send(new UpdateCashierCommand
                {
                    ID = cashier.ID,
                    CashierName = cashier.CashierName,
                    BranchID = cashier.BranchID
                });

                return RedirectToAction(nameof(Index));
            }
            return View(cashier);
        }


        // GET: Cashier/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var cashier = await _mediator.Send(new GetCashierByIdQuery { Id = id });
            if (cashier == null)
            {
                return NotFound();
            }

            return View(cashier);
        }

        // POST: Cashier/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _mediator.Send(new DeleteCashierCommand { ID = id });
            return RedirectToAction(nameof(Index));
        }
    }
}
