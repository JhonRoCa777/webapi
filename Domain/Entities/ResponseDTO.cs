using System.Net;

namespace webapi.Domain.Entities
{
    public class ResponseDTO<TData>
    {
        public HttpStatusCode Status { get; set; } = HttpStatusCode.OK;
        public List<string>? Message { get; set; }
        public TData? Data { get; set; }
    }
}
