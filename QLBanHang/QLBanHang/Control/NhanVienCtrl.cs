using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanHang.Object;
using QLBanHang.Model;
using System.Data;

namespace QLBanHang.Control
{
    class NhanVienCtrl
    {
        NhanVienMod nvMod = new NhanVienMod();
        public DataTable getData()
        {
            return nvMod.GetData();
        }
        public bool addData(NhanVienObj nvObj)
        {
            return nvMod.AddData(nvObj);
        }
        public bool updData(NhanVienObj nvObj)
        {
            return nvMod.UpdData(nvObj);
        }
        public bool delData(string ma)
        {
            return nvMod.DelData(ma);
        }
    }
}
