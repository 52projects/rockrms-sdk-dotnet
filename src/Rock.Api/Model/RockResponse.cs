using System.Net;

namespace Rock.Api.Model {
    public interface IRockResponse {
        string RequestValue { get; set; }
        string JsonResponse { get; set; }
        HttpStatusCode StatusCode { get; set; }
        string ErrorMessage { get; set; }
        bool IsSuccessful { get; }
    }
    public interface IRockResponse<T> : IRockResponse {
        T Data { get; set; }
    }

    public class RockResponse : IRockResponse {
        public string RequestValue { get; set; }

        public string JsonResponse { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public string ErrorMessage { get; set; }

        public bool IsSuccessful {
            get {
                return (int)StatusCode < 300;
            }
        }
    }

    public class RockResponse<T> : RockResponse, IRockResponse<T> where T : new() {
        public T Data { get; set; }
    }
}
