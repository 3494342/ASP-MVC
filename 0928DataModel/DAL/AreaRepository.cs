using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;
using _0928DataModel;

namespace DAL
{
  
    public class AreaRepository: IAreaRepository
    {
        ALGCAMEntities db = new ALGCAMEntities();
        public bool Add(ActivityViewModel model)
        {
            try
            {
                cnc_activity_log act = new cnc_activity_log();
                act.Act_Time = model.Act_Time;
                act.MC_Code = model.MC_Code;
                db.cnc_activity_log.Add(act);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
                throw;
            }
           
        }

       
        public bool Delete(string mc_code)
        {
            try
            {
                cnc_activity_log act = db.cnc_activity_log.Find(mc_code);
                if (act == null)
                {
                    return false;
                }
                else
                {
                    db.cnc_activity_log.Remove(act);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public ActivityViewModel GetByCode(string mc_code)
        {
            throw new NotImplementedException();
        }

        public bool Update(ActivityViewModel model)
        {
            try
            {
                //cnc_activity_log act = db.cnc_activity_log.Find(model.MC_Code);
                //if (act == null)
                //{
                //    return false;

                //}
                //else
                //{
                //    act.Act_Time = model.Act_Time;
                //    act.MC_Code = model.MC_Code;
                //    db.SaveChanges();
                //    return true;
                //}
                cnc_activity_log act = new cnc_activity_log();
                act.Act_Time = model.Act_Time;
                  act.MC_Code = model.MC_Code;
                db.Entry<cnc_activity_log>(act).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
