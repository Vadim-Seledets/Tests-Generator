﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace TestsGenerationLibrary.Consumers
{
    public interface IConsumer
    {
        void Consume(IReceivableSourceBlock<TaskResult> testTextsBuffer);
    }
}
