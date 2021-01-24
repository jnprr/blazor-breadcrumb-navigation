﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace Juniperr.Blazor.BreadcrumbNavigation.Services
{
    public interface IBreadcrumbService
    {
        event Action<RenderFragment>? Added;

        event Action? Reset;

        public IBreadcrumbService Clear();

        public IBreadcrumbService Set<TBreadcrumb>()
            where TBreadcrumb : Breadcrumb
            => Set<TBreadcrumb>(new Dictionary<string, object>());

        public IBreadcrumbService Set<TBreadcrumb>(ParameterView parameters)
            where TBreadcrumb : Breadcrumb
            => Set<TBreadcrumb>(parameters.ToDictionary());

        IBreadcrumbService Set<TBreadcrumb>(IReadOnlyDictionary<string, object> parameters)
            where TBreadcrumb : Breadcrumb;
    }
}
