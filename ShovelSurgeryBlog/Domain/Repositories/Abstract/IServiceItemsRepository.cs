﻿using ShovelSurgeryBlog.Domain.Entities;
using System;
using System.Linq;

namespace ShovelSurgeryBlog.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItemById(Guid id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(Guid id);
    }
}
