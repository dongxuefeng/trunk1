using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Ehl.Atms.Tgs.lifebelt_check
{
    public class DataAccess
    {
        DataService.DataService dataService = new DataService.DataService();

        /// <summary>
        /// 获取图片路径
        /// </summary>
        /// <param name="xh"></param>
        /// <returns></returns>
        public DataTable GetCapture(string xh)
        {
            string sql = "select t.zjwjlj from vt_tgs_capture t where xh='" + xh + "' order by zjwjsx asc ";
            try
            {
                return dataService.Get_DataSet(sql).Tables[0];
            }
            catch (Exception ex)
            {
                Log.WriteLog("sql:" + sql);
                Log.WriteLog(ex.ToString());
                return null;
            }
        }

        /// <summary>
        /// 获取违法类型
        /// </summary>
        /// <returns></returns>
        public DataTable GetPeccancy_Type()
        {
            string sql = "select wfxw,wfxwms from T_TMS_PECCNACY_TYPE order by wfxw asc ";
            try
            {
                return dataService.Get_DataSet(sql).Tables[0];
            }
            catch (Exception ex)
            {
                Log.WriteLog("sql:" + sql);
                Log.WriteLog(ex.ToString());
                return null;
            }
        }

        /// <summary>
        /// 获取过车数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetPeccancy( string startTime, string stopTime,string kkid,int cllx)
        {
   //         string sql = string.Format(@"select xh, TO_CHAR(t.gwsj, 'YYYY-MM-DD HH24:MI:SS')as gwsj, kkmc, f_getimagepath(xh, '1') as zjwj , hphm from vt_tgs_passcar t
   //                    where gwsj > to_date('{0}','yyyy-mm-dd hh24:mi:ss') and kkid='{1}' and rownum<=50 order by gwsj", startTime, kkid);

            string sql;
            if (0==cllx)    //
            {
                sql = string.Format(@"
select 
     rn as r,
     xh,
     kkmc,
     kkid,
     hphm,
     hpzl,
     TO_CHAR(t.gwsj, 'YYYY-MM-DD HH24:MI:SS') as gwsj,
     f_getimagepath(xh, '1') as zjwj
     from (select 
             rownum as rn,
             xh,
             kkid,
             f_get_value('kkmc', 't_tgs_set_watch', 'kkid', kkid) as kkmc,
             hphm,
             hpzl,
             gwsj
            from (select 
                     xh,
                     kkid,
                     hphm,
                     hpzl,
                     hpys,
                     gwsj
                     from t_tgs_passcar
                     where gwsj >
                           to_date('{0}', 'yyyy-MM-dd hh24:mi:ss')
                        and gwsj<= to_date('{2}', 'yyyy-MM-dd hh24:mi:ss')
                        and kkid='{1}'
                     order by gwsj)
             where rownum <= 50) t
 where rn >= 1", startTime, kkid, stopTime);
 
            }
            else 
            {
                sql = string.Format(@"
select 
     rn as r,
     xh,
     kkmc,
     kkid,
     hphm,
     hpzl,
     TO_CHAR(t.gwsj, 'YYYY-MM-DD HH24:MI:SS') as gwsj,
     f_getimagepath(xh, '1') as zjwj
     from (select 
             rownum as rn,
             xh,
             kkid,
             f_get_value('kkmc', 't_tgs_set_watch', 'kkid', kkid) as kkmc,
             hphm,
             hpzl,
             gwsj
            from (select 
                     xh,
                     kkid,
                     hphm,
                     hpzl,
                     hpys,
                     gwsj
                     from t_tgs_passcar
                     where gwsj >
                           to_date('{0}', 'yyyy-MM-dd hh24:mi:ss')
                        and gwsj<= to_date('{3}', 'yyyy-MM-dd hh24:mi:ss')
                        and kkid='{1}'
                        and hpzl='{2}'
                     order by gwsj)
             where rownum <= 50) t
 where rn >= 1", startTime, kkid,cllx==1?"02":"01",stopTime);
 
            }
            
            

            Log.WriteLog(string.Format("查询的sql语句：{0}",sql));
            try
            {
                return dataService.Get_DataSet(sql).Tables[0];
            }
            catch (Exception ex)
            {
                Log.WriteLog("错误的sql:" + sql);
                Log.WriteLog(ex.ToString());
                return null;
            }
        }

        public DataTable GetPeccancy(string startTime, string end_time,string hphm,string kkid)
        {
            string sql = string.Format(@"
select 
     rn as r,
     xh,
     kkmc,
     kkid,
     hphm,
     hpzl,
     TO_CHAR(t.gwsj, 'YYYY-MM-DD HH24:MI:SS') as gwsj,
     f_getimagepath(xh, '1') as zjwj
     from (select 
             rownum as rn,
             xh,
             kkid,
             f_get_value('kkmc', 't_tgs_set_watch', 'kkid', kkid) as kkmc,
             hphm,
             hpzl,
             gwsj
            from (select 
                     xh,
                     kkid,
                     hphm,
                     hpzl,
                     hpys,
                     gwsj
                     from t_tgs_passcar
                     where gwsj >to_date('{0}', 'yyyy-MM-dd hh24:mi:ss')
                        and gwsj <to_date('{1}', 'yyyy-MM-dd hh24:mi:ss')
                        and hphm='{2}'
                        and kkid<>'{3}'
                     order by gwsj)
            ) t
 where rn >= 1", 
               startTime, end_time, hphm,kkid);

            Log.WriteLog("相关查询的sql语句：");
            Log.WriteLog(sql);
            try
            {
                return dataService.Get_DataSet(sql).Tables[0];
            }
            catch (Exception ex)
            {
                Log.WriteLog("sql:" + sql);
                Log.WriteLog(ex.ToString());
                return null;
            }
        }
        
        /// <summary>
        /// 更新违法数据状态
        /// </summary>
        /// <returns></returns>
        public int UpdatePeccancy(string xh)
        {
            string sql = string.Format(@"update t_tms_peccancy t set csbj='1' where xh='{0}' ", xh);
            try
            {
                return dataService.Execute_NonQuery(sql);
            }
            catch (Exception ex)
            {
                Log.WriteLog("sql:" + sql);
                Log.WriteLog(ex.ToString());
                return -1;
            }
        }

        /// <summary>
        /// 获取过车数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetSeclectPeccancy(string hphm, string gwsj, int seclect)
        {
            string[,] strtmpdef = new string[6, 2]{{ "3分钟", "3" }, 
                                                   { "5分钟", "5" }, 
                                                   { "10分钟", "10" }, 
                                                   { "20分钟", "20" }, 
                                                   { "40分钟", "40" },
                                                   { "60分钟", "60" }};
            int secl = Int32.Parse(strtmpdef[seclect, 1]);
            string sql = string.Format(@"select xh, gwsj, kkmc, f_getimagepath(xh, '1') as zjwj  from vt_tgs_passcar
                                       where hphm ='{2}' and (gwsj >= (to_date('{0}','yyyy-mm-dd hh24:mi:ss') - numtodsinterval({1},'minute')) 
                                       and gwsj <= (to_date('{0}','yyyy-mm-dd hh24:mi:ss')+ numtodsinterval({1},'minute')))", gwsj, secl, hphm);
            try
            {
                return dataService.Get_DataSet(sql).Tables[0];
            }
            catch (Exception ex)
            {
                Log.WriteLog("sql:" + sql);
                Log.WriteLog(ex.ToString());
                return null;
            }
        }

        public DataTable exe_sql(string sql)
        {
            try
            {
                return dataService.Get_DataSet(sql).Tables[0];
            }
            catch (Exception ex)
            {
                Log.WriteLog("sql:" + sql);
                Log.WriteLog(ex.ToString());
                return null;
            }
        }

    }
}
