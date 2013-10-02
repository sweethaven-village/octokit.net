﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Octokit
{
    public interface IApiPagination<T>
    {
        Task<IReadOnlyCollection<T>> GetAllPages(Func<Task<IReadOnlyPagedCollection<T>>> getFirstPage);
        Task<IReadOnlyCollection<TOther>> GetAllPages<TOther>(Func<Task<IReadOnlyPagedCollection<TOther>>> getFirstPage);
    }
}