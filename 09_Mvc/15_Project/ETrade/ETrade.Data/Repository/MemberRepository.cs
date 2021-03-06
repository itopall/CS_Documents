using ETrade.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Data.Repository
{
    public class MemberRepository : RepositoryBase<Member>, IMemberRepository
    {
        public MemberRepository(ETradeEntities context) : base(context)
        {
        }

        public MemberRepository()
        {
        }
    }

    interface IMemberRepository
    {
    }
}
