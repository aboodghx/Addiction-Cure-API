using Addiction_Cure.core.Data;
using Addiction_Cure.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.core.Repository
{
    public interface IReqRepository
    {
        List<Req> getbydocid(int id);
        Req getbypatid(int id);
        void accept(accept accept);

        void deleteReq(int id);
        void createReq(Req req);
        void updateReq(Req req);
    }
}
