using ThucHanhWebMVC.Models;
namespace ThucHanhWebMVC.Repository
{
    public interface ILoaiSpRepository
    {
        TLoaiSp Add(TLoaiSp loaiSP);
        TLoaiSp Update(TLoaiSp loaiSP);
        TLoaiSp Delete(String maloaiSP);
        TLoaiSp Get(String maloaiSP);
        IEnumerable<TLoaiSp> GetAllLoaiSp();
    }
}
