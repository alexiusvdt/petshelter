// namespace PetShelterApi.Models
// {
//   public class Parameters
//   {
//     const int maxPageSize = 10; // max amount of elements per page
//     public int PageNumber { get; set; } = 10; // how many pages you will have ( Number of element / maxPageSize)
//     private int _pageSize = 100; // works in relation with public PageSize, if not specified default 3 elements will populate
//     public int PageSize // this property value represents how many elements you want to show in a Get
//     {
//         get
//         {
//             return _pageSize;
//         }
//         set
//         {
//             _pageSize = (value > maxPageSize) ? maxPageSize : value ;
//         }
//     }
//   }
// }