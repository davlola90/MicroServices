using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MicroRabbit.Transfer.Domain.Interfaces;

namespace MicroRabbit.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventhandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _transferRepository;
        public TransferEventHandler(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }
        public Task Handle(TransferCreatedEvent @event)
        {

            _transferRepository.Add(new Models.TransferLog()
            {
                From = @event.From,
                To=@event.To,
                Amount=@event.Amount
            }) ;
            return Task.CompletedTask;
        }
    }
}
