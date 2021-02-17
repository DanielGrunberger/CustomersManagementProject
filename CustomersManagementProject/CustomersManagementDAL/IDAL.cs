﻿using CustomersManagementDP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersManagementDAL
{
    public interface IDAL
    {
       void AddItem(Item item);

        void RemoveItem(int itemId);

        void UpdateItem(Item item);

        List <Item> getAllItems(Func<Item, bool> pred = null);
       

     









    }
}
