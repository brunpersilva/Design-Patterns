using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            IFrameworkFullBuilder builder = new FrameworkFullBuilder();
            Framework framework = builder.GetFramework();
            framework.Run();
        }

    }
}
