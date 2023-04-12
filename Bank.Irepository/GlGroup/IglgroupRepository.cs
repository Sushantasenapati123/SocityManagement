using Bank.Domain.GlGroup;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Irepository.GlGroup
{
    public interface IglgroupRepository
    {
        List<GlgroupEntity> listrgroup();
        int insertgroup(GlgroupEntity rl);
        int updatgroupl(GlgroupEntity rl);
        int deletegroup(int id);
        //public GlgroupEntity groupselect(int id);
        Task<GlgroupEntity> groupselect(int id);
        //public void glgroupbind();
        public List<GlgroupEntity> glgroupbind();
        //Task<IEnumerable<GlgroupEntity>>  Selectone(int grouptype_id);
        public int Selectone(int grouptype_id);
    }
}
