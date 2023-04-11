namespace Workflow_Engine
{
    class Print : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("printing contents to page");
        }
    }
}