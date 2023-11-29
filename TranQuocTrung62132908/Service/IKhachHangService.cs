// IKhachHangService.cs
using System.Collections.Generic;
using System.Threading.Tasks;
using TranQuocTrung62132908.Models;

namespace TranQuocTrung62132908.Service
{
    public interface IKhachHangService
    {
        Task<List<TKhachHang>> GetAllKhachHangs();
        Task<TKhachHang> GetKhachHangById(string id);
        Task CreateKhachHang(TKhachHang khachHang);
        Task UpdateKhachHang(string id, TKhachHang khachHang);
        Task DeleteKhachHang(string id);
        Task<List<TKhachHang>> GetPagedKhachHangs(int page, int pageSize);
        Task<List<TKhachHang>> SearchKhachHangs(string keyword);
        Task<List<TKhachHang>> GetSortedKhachHangs(string sortBy, bool ascending);
    }
}
