using SugarNewsAPI.Constants;

namespace SugarNewsAPI.Models
{
    public class Error
    {
        public ErrorCodes Code { get; set; }
        public string? Message { get; set; }
    }
}

