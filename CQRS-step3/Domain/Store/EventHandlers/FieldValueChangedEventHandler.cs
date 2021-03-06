﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CQRS_step3.Events;
using MediatR;

namespace CQRS_step3.Domain.Store.EventHandlers
{
    public class FieldValueChangedEventHandler : INotificationHandler<FieldValueChangedEvent>
    {
        private readonly IProductReadModelRepository _repo;

        public FieldValueChangedEventHandler(IProductReadModelRepository repo)
        {
            _repo = repo;
        }

        public void Handle(FieldValueChangedEvent @event)
        {
            var product = _repo.Find(@event.ProductId);
            product.Apply(@event);
            _repo.Update(product);
        }
    }
}