// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Xunit.Abstractions;

namespace Microsoft.EntityFrameworkCore.Benchmarks
{
    public interface IMetricCollector : IXunitSerializable
    {
        IDisposable StartCollection();
        void StopCollection();
        void Reset();
        long TimeElapsed { get; }
        long MemoryDelta { get; }
    }
}