using System;
using static Profile.Domain.CreateProfileWorkflow.CreateProfileResult;

namespace Test.App
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreateProfileResult result = new ProfileValidationFailed();

            
            Console.WriteLine("Hello World!");
        }
    }
}
