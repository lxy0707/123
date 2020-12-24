using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
namespace BLL
{
    public class SupermarketInfoManager
    {
        //记录查询(菜品销售记录表)
        public static IQueryable SelectRecord()
        {
            return SupermarketInfoSerivce.SelectRecord();
        }

        //统计查询（）
        public static IQueryable SelectCount()
        {
            return SupermarketInfoSerivce.SelectCount();
        }
    }
}
