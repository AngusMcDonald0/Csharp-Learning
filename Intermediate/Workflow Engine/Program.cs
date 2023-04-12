namespace Workflow_Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new WorkflowEngine();
            engine.AddWorkflow(new Save());
            engine.AddWorkflow(new Print());
            engine.AddWorkflow(new EmailNotification());
            engine.Run();
        }
    }
}