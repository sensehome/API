using Newtonsoft.Json;

namespace SenseHome.DataTransferObjects.Error
{
    public class ExceptionDetailsDto
    {
        public string Message { get; set; }
        public string RequestPath { get; set; }
        public int Status { get; set; }
        public string Details { get; set; }

        public string ToSerializedString()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
        }
    }
}
