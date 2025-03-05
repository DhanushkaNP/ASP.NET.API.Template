using System.Text.Json.Serialization;

namespace Template.Abstractions.Exceptions
{
    public class ForbiddenException : CustomException
    {
        public ForbiddenException()
            : base()
        {
        }

        [JsonConstructor]
        public ForbiddenException(string message)
            : base(message)
        {
        }
    }
}
