using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace H2School_CarwashSystem
{
    public class WashingType
    {
        public List<Process> Process { get; set; }

        public WashingType(List<Process> process)
        {
            Process = new List<Process>();
            Process = process;
        }

        public void AddAProcess(Process process)
        {
            Process.Add(process);
        }
    }
}