using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock.Api.Services {
    public interface ITransactionService {

    }

    public class TransactionService : BaseService, ITransactionService {
        public TransactionService(string domainUrl, string apiToken) : base(domainUrl, apiToken) {

        }
    }
}
