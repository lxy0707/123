using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class SupermarketInfoSerivce
    {
        //记录查询(菜品销售记录表)
        public static IQueryable SelectRecord()
        {
            SupermarketEntities test = new SupermarketEntities();
            var obj = from p in test.purchaserecords
                      select new
                      {
                          sid = p.sid,
                          cid = p.cid,
                          fid = p.fid,
                          purchDate = p.purchDate,
                          quantity = p.quantity,
                          price = p.price,
                          settlement = p.settlement
                      };
            return obj;
        }

        //统计查询（）
        public static IQueryable SelectCount()
        {
            SupermarketEntities test = new SupermarketEntities();
            var obj = from p in test.food
                      select new
                      {
                          fid = p.fid,
                          fname = p.fname,
                          num = (from pp in p.purchaserecords where pp.fid == p.fid select pp.fid).Count(),
                          maxMony = (from m in p.purchaserecords where m.fid == p.fid select m.settlement).Max(),
                          countMony = (from m in p.purchaserecords where m.fid == p.fid select m.settlement).Sum(),

                      };
            return obj;
        }

       
    }
}
