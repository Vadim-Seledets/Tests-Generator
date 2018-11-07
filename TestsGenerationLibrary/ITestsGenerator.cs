﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestsGenerationLibrary.Consumers;
using TestsGenerationLibrary.DataProviders;

namespace TestsGenerationLibrary
{
    public interface ITestsGenerator
    {
        IEnumerable<ConsumerResult> Generate(ISourceCodeProvider dataProvider);
    }
}
