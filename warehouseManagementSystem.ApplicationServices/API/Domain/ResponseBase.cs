﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouseManagementSystem.ApplicationServices.API.Domain
{
   public class ResponseBase<T>
    {
        public T Data { get; set; }
          
    }
}
