﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Api.Model;

using RestSharp;
using Rock.Api.Model;
using Rock.Api.Extensions;


namespace Rock.Api {
    public abstract class ApiSet<T> : BaseApiSet<T> where T : new() {
        public ApiSet(string baseUrl, string apiToken, ContentType contentType)
            : base(baseUrl, apiToken, contentType) {
        }

        public virtual IRockResponse<RockCollection<T>> FindAll(int? page = null, int? pageSize = null) {
            var collection = new RockCollection<T>();

            if (string.IsNullOrWhiteSpace(ListUrl)) {
                throw new NotImplementedException("The property ListUrl has no value on the ApiSet.");
            }

            var request = CreateRestRequest(Method.GET, ListUrl);

            if (page.HasValue) {
                request.AddParameter("page", page.Value);
            }

            if (pageSize.HasValue) {
                request.AddParameter("pageSize", pageSize.Value);
            }

            var item = base.ExecuteListRequest(request);
            return item.ToRockCollectionResponse();
        }

        public virtual IRockResponse<RockCollection<T>> FindAll(string parentID) {
            var collection = new RockCollection<T>();

            if (string.IsNullOrWhiteSpace(GetChildListUrl)) {
                throw new NotImplementedException("The property GetChildListUrl has no value on the ApiSet.");
            }

            var request = CreateRestRequest(Method.GET, string.Format(GetChildListUrl, parentID));
            var item = ExecuteListRequest(request);
            return item.ToRockCollectionResponse();
        }

        public virtual IRockResponse<RockCollection<T>> FindAll(string parentID, int? page = null) {
            var collection = new RockCollection<T>();

            if (string.IsNullOrWhiteSpace(GetChildListUrl)) {
                throw new NotImplementedException("The property GetChildListUrl has no value on the ApiSet.");
            }

            var request = CreateRestRequest(Method.GET, string.Format(GetChildListUrl, parentID));

            if (page.HasValue) {
                request.AddParameter("page", page.Value);
            }
            
            var item = ExecuteListRequest(request);
            return item.ToRockCollectionResponse();
        }

        public virtual IRockResponse<RockCollection<T>> FindBy(BaseQO qo) {
            var collection = new RockCollection<T>();

            if (string.IsNullOrWhiteSpace(SearchUrl)) {
                throw new NotImplementedException("The property SearchUrl has no value on the ApiSet.");
            }

            var request = CreateRestRequest(Method.GET, SearchUrl);

            foreach (var pair in qo.ToDictionary()) {
                request.AddParameter(pair.Key, pair.Value);
            }

            var item = ExecuteListRequest(request);
            return item.ToRockCollectionResponse();
        }

        public virtual IRockResponse<RockCollection<S>> FindBy<S>(BaseQO qo) where S : new() {
            var collection = new RockCollection<S>();

            if (string.IsNullOrWhiteSpace(SearchUrl)) {
                throw new NotImplementedException("The property SearchUrl has no value on the ApiSet.");
            }

            var request = CreateRestRequest(Method.GET, SearchUrl);

            foreach (var pair in qo.ToDictionary()) {
                request.AddParameter(pair.Key, pair.Value);
            }

            var item = ExecuteCustomRequest<List<S>>(request);
            return item.ToRockCollectionResponse();
        }

        public virtual IRockResponse<RockCollection<T>> FindBy(string parentID, BaseQO qo) {
            var collection = new RockCollection<T>();

            if (string.IsNullOrWhiteSpace(SearchUrl)) {
                throw new NotImplementedException("The property SearchUrl has no value on the ApiSet.");
            }

            var request = CreateRestRequest(Method.GET, string.Format(SearchUrl, parentID));

            foreach (var pair in qo.ToDictionary()) {
                request.AddParameter(pair.Key, pair.Value);
            }

            var item = ExecuteListRequest(request);
            return item.ToRockCollectionResponse();
        }
    }
}