using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow_Engine
{
    public class WorkflowEngine
    {
        private readonly IList<IWorkflow> _workflows;

        public WorkflowEngine()
        {
            _workflows = new List<IWorkflow>();
        }

        public void Run()
        {
            foreach (var workflow in _workflows)
            {
                workflow.Execute();
            }
        }

        public void AddWorkflow(IWorkflow workflow)
        {
            _workflows.Add(workflow);
        }
    }
}
