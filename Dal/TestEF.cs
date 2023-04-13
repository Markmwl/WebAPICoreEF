using Dal.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Dal
{
    public class TestEF
    {
        public List<用户表> Test()
        {
            using (var markContext = new ModelContext())
            {
                //开事务
                using (var tran = markContext.Database.BeginTransaction())
                {
                    try
                    {
                        var aaa = markContext.用户表s.ToList();
                        return aaa;
                        //foreach (var item in aaa)
                        //{
                        //    showlog(item);
                        //}
                        //tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        Debug.WriteLine(ex.Message);
                    }
                }
                return null;
            }
        }

        void showlog(用户表 user)
        {
            Debug.WriteLine(DateTime.Now + "：" + string.Format("{0},{1},{2},{3},{4},{5}",
                user.Id, user.Name, user.Age, user.Sex, user.Address, user.Phonenumber));
        }

    }
}