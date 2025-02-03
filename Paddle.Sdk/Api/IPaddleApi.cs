namespace Paddle.Sdk.Api;

/// <summary>
///     Base interface for CRUD operations
/// </summary>
/// <typeparam name="TResponse">Type of single entity response</typeparam>
/// <typeparam name="TListResponse">Type of list response</typeparam>
/// <typeparam name="TCreate">Type for create operation</typeparam>
/// <typeparam name="TUpdate">Type for update operation</typeparam>
public interface IPaddleApi<TResponse, TListResponse, TCreate, TUpdate> {
    Task<TResponse?> CreateAsync(TCreate request, CancellationToken cancellationToken = default);

    Task<TResponse?> GetAsync(string id, Dictionary<string, string>? queryParams = null, CancellationToken cancellationToken = default);

    Task<TListResponse?> ListAsync(Dictionary<string, string> queryParams, CancellationToken cancellationToken = default);

    Task<TResponse?> UpdateAsync(string id, TUpdate request, CancellationToken cancellationToken = default);
}