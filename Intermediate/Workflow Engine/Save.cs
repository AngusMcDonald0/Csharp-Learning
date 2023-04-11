namespace Workflow_Engine
{
    class Save : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("saving file to database");
        }
    }
}