namespace Workflow_Engine
{
    class EmailNotification : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("sent an email");
        }
    }
}