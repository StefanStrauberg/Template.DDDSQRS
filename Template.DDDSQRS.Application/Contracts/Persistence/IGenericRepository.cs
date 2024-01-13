namespace Template.DDDSQRS.Application.Contracts.Persistence;

public interface IGenericRepository<TDocument> 
    where TDocument : BaseEntity
{
    Task<List<TDocument>> GetAllItemsAsync(CancellationToken token);
    Task<List<TDocument>> GetAllItemsByExpressionAsync(Expression<Func<TDocument, bool>> expression,
                                                       CancellationToken token);
    Task<TDocument> GetItemByExpressionAsync(Expression<Func<TDocument, bool>> expression,
                                             CancellationToken token);
    Task InsertOneItemAsync(TDocument document,
                            CancellationToken token);
    Task InsertManyItemsAsync(List<TDocument> documents,
                              CancellationToken token);
    Task UpdateOneItemAsync(TDocument document,
                            CancellationToken token);
    Task DeleteItemsAsync(Expression<Func<TDocument, bool>> expression,
                          CancellationToken token);
    Task<bool> ExistsItemAsync(Expression<Func<TDocument, bool>> expression,
                               CancellationToken token);
}
