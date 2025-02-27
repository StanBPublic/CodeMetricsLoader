﻿using System.Collections.Generic;

namespace CodeMetricsLoader.Data
{
    public class DimModule
    {
        public int ModuleId { get; set; }
        public string Name { get; set; }
        public string AssemblyVersion { get; set; }
        public string FileVersion { get; set; }
        public virtual List<DimNamespace> Namespaces { get; set; }
        public virtual List<FactMetrics> Metrics { get; set; }

        public DimModule ()
        {
            Metrics = new List<FactMetrics>();
        }
    }
}
