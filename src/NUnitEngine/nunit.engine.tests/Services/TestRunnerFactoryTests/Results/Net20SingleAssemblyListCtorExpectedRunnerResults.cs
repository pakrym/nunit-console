// Copyright (c) Charlie Poole, Rob Prouse and Contributors. MIT License - see LICENSE.txt

using System;
using NUnit.Engine.Internal;
using NUnit.Engine.Runners;

namespace NUnit.Engine.Tests.Services.TestRunnerFactoryTests.Results
{
#if !NETCOREAPP
    internal static class Net20SingleAssemblyListCtorExpectedRunnerResults
    {
        private static readonly string ExceptionMessage =
            $"No expected Test result provided for {nameof(ProcessModel)}.";

        public static RunnerResult ResultFor(ProcessModel processModel)
        {
            switch (processModel)
            {
                case ProcessModel.Default:
                    return RunnerResult.ProcessRunner;
                case ProcessModel.InProcess:
                    return RunnerResult.TestDomainRunner;
                case ProcessModel.Separate:
                    return RunnerResult.ProcessRunner;
                case ProcessModel.Multiple:
                    return RunnerResult.MultipleProcessRunner(1);
                default:
                    throw new ArgumentOutOfRangeException(nameof(processModel), processModel, ExceptionMessage);
            }
        }
    }
#endif
}