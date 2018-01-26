﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFlex.Core.Query
{
    public interface IPager<TEntity>
    {
        int PageIndex { get;}
        int PageSize { get;}
        int PageCount { get; }
        int TotalCount { get;}
        List<TEntity> Records { get;  }

        IPager<TResult> Convert<TResult>(Func<TEntity, TResult> converter);
    }
}
