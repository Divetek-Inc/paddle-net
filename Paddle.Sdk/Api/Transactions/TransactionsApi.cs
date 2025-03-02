using System.Text.Json;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Paddle.Sdk.Dto.Transactions;
using Paddle.Sdk.Entities.Transactions;

namespace Paddle.Sdk.Api.Transactions;

public class TransactionsApi(
    HttpClient httpClient,
    JsonSerializerOptions jsonOptions,
    ILogger? logger = null
) : ApiBase(httpClient, jsonOptions, logger), ITransactionsApi {
    protected override string BasePath => "/transactions";

    public async Task<TransactionResponse?> CreateAsync(TransactionCreate request, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}";
        return await PostAsync<TransactionResponse>(url, request, cancellationToken);
    }

    public async Task<TransactionResponse?> GetAsync(string id, Dictionary<string, string>? queryParams = null, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{id}";
        return await GetAsync<TransactionResponse>(url, cancellationToken);
    }

    public async Task<TransactionListResponse?> ListAsync(Dictionary<string, string> queryParams, CancellationToken cancellationToken = default) {
        string url = QueryHelpers.AddQueryString(BasePath, queryParams!);
        return await GetAsync<TransactionListResponse>(url, cancellationToken);
    }

    public async Task<TransactionResponse?> UpdateAsync(string id, TransactionUpdate request, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{id}";
        return await PatchAsync<TransactionResponse>(url, request, cancellationToken);
    }

    public async Task<InvoiceUrlResponse?> GetInvoiceUrl(string transactionId, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{transactionId}/invoice";
        return await GetAsync<InvoiceUrlResponse>(url, cancellationToken);
    }

    [Obsolete("Transactions can't be archived")]
    public async Task<TransactionResponse?> ArchiveAsync(string id, CancellationToken cancellationToken = default) {
        return null;
    }

    [Obsolete("Transactions can't be activated")]
    public async Task<TransactionResponse?> ActivateAsync(string id, CancellationToken cancellationToken = default) {
        return null;
    }
}