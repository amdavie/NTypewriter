﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTypewriter.Tests.CodeModel
{
    class SampleClass
    {
        class SampleNestedClass
        {

        }
    }
    class SampleGenericClass<T>
    {
        class SampleNestedClassInGeneric
        {

        }
        class SampleNestedGenericClass<T1>
        {

        }
    }
}
