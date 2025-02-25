using Paddle.Sdk.Dto.Transactions;
using Paddle.Sdk.Entities.Transactions;

namespace Paddle.Sdk.Api.Transactions;

public interface ITransactionsApi : IPaddleApi<PaddleTransaction, TransactionListResponse, TransactionCreate, TransactionUpdate> {
    Task<InvoiceUrlResponse?> GetInvoiceUrl(string transactionId, CancellationToken cancellationToken = default);
}