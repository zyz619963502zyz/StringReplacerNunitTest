﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Centaline.Framework.Kernel.placeholder.Interface
{
   public interface ParameterPreparer<TQuery>
{
        TQuery prepare(TQuery query, IDictionary<String, Object> args);
    }
}
