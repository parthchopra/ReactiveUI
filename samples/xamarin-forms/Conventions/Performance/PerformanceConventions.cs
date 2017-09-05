﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using Conventional;
using Xunit;

namespace Conventions.Performance
{
    public class PerformanceConventions : IClassFixture<BaseFixture>
    {
        public PerformanceConventions(BaseFixture baseFixture)
        {
            _baseFixture = baseFixture;
        }

        private readonly BaseFixture _baseFixture;

        [Fact]
        public void AsyncLibrariesMustCallConfigureAwaitFalse()
        {
            _baseFixture.AllAssemblies.MustConformTo(Convention.LibraryCodeShouldCallConfigureAwaitWhenAwaitingTasks);
        }
    }
}
