using System.Collections;
// ReSharper disable All 
namespace Cult.Pagination
{
    public interface IPagedList
    {
        ICollection Items { get; }
        int Count { get; }
        int PageIndex { get; }
        int PageSize { get; }
        int TotalCount { get; }
        int TotalPages { get; }
        bool HasPreviousPage { get; }
        bool HasNextPage { get; }
    }
}
