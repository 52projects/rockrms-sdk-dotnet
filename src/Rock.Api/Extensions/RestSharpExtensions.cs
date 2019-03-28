using Rock.Api.Model;
using RestSharp;
using System.Collections.Generic;

namespace Rock.Api.Extensions {
    public static class RestSharpExtensions {
        public static IRockResponse ToRockResponse(this IRestResponse restResponse) {
            var response = new RockResponse();

            response.StatusCode = restResponse.StatusCode;
            response.JsonResponse = restResponse.Content;

            if (restResponse.StatusCode != System.Net.HttpStatusCode.OK) {
                response.ErrorMessage = restResponse.ErrorMessage;
            }

            return response;
        }

        public static IRockResponse<S> ToRockResponse<S>(this IRestResponse<S> restResponse) where S : new() {
            var response = new RockResponse<S>();

            response.StatusCode = restResponse.StatusCode;
            response.JsonResponse = restResponse.Content;

            if ((int)restResponse.StatusCode >= 300) {
                response.ErrorMessage = restResponse.ErrorMessage;
            }
            else {
                response.Data = restResponse.Data;
            }
            return response;
        }

        public static IRockResponse<S> ToRockResponse<S>(this IRestResponse<S> restResponse, string requestInput) where S : new() {
            var response = restResponse.ToRockResponse();
            response.RequestValue = requestInput;
            return response;
        }

        public static IRockResponse<RockCollection<S>> ToRockCollectionResponse<S>(this IRestResponse<List<S>> restResponse, string requestInput = null) where S : new() {
            var response = new RockResponse<RockCollection<S>>();

            response.StatusCode = restResponse.StatusCode;
            response.JsonResponse = restResponse.Content;

            if ((int)restResponse.StatusCode >= 300) {
                response.ErrorMessage = restResponse.ErrorMessage;
            }
            else {
                if (restResponse.Data != null) {
                    var collection = new RockCollection<S>();
                    collection.Items.AddRange(restResponse.Data);
                    response.Data = collection;
                }
            }
            return response;
        }
    }
}
