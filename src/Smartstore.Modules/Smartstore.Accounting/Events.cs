using System;
using Smartstore.Accounting.Models;
using Smartstore.Accounting.Services;
using Smartstore.Core.Checkout.Orders.Events;
using Smartstore.Events;

namespace Smartstore.Accounting
{
    public class Events : IConsumer
    {
        private readonly IAccountingService _accountingService;

        // Inyectar el servicio necesario a través del constructor
        public Events(IAccountingService accountingService)
        {
            _accountingService = accountingService ?? throw new ArgumentNullException(nameof(accountingService));
        }

        // Manejar eventos genéricos
        public void HandleEvent(object eventMessage)
        {
            if (eventMessage is OrderPaidEvent message)
            {
                // Crear una nueva entrada contable cuando se pague un pedido
                var entry = new AccountingEntry
                {
                    Description = $"Pago recibido para el pedido #{message.Order.Id}",
                    Amount = message.Order.OrderTotal,
                    TransactionDate = DateTime.UtcNow,
                    CustomerId = message.Order.CustomerId
                };

                // Usar el servicio inyectado para agregar la entrada
                _accountingService.AddEntry(entry);
            }
        }
    }
}
