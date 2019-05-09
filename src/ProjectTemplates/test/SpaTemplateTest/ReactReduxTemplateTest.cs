// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.AspNetCore.E2ETesting;
using Microsoft.AspNetCore.Testing;
using Microsoft.AspNetCore.Testing.xunit;
using Templates.Test.Helpers;
using Xunit;
using Xunit.Abstractions;

namespace Templates.Test.SpaTemplateTest
{
    [Collection("SpaTemplateTests")]
    public class ReactReduxTemplateTest : SpaTemplateTestBase
    {
        public ReactReduxTemplateTest(ProjectFactoryFixture projectFactory, BrowserFixture browserFixture, ITestOutputHelper output)
            : base(projectFactory, browserFixture, output)
        {
        }

        [Fact]
        [Flaky("https://github.com/aspnet/AspNetCore-Internal/issues/2407", FlakyOn.AzP.Windows)]
        public Task ReactReduxTemplate_Works_NetCore()
            => SpaTemplateImplAsync("reactredux", "reactredux", useLocalDb: false, usesAuth: false);
    }
}
