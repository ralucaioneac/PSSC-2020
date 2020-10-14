using System;
using System.Collections.Generic;
using System.Text;
using CSharp.Choices;

namespace Profile.Domain.CreateProfileWorkflow
{
    [AsChoice]
    public static partial class CreateProfileResult
    {
        public interface ICreateProfileResult { }

        public class ProfileCreated: ICreateProfileResult
        {

        }

        public class ProfileNotCreated: ICreateProfileResult
        {

        }

        public class ProfileValidationFailed: ICreateProfileResult
        {

        }
    }
}
