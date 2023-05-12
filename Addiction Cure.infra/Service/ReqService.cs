using Addiction_Cure.core.Data;
using Addiction_Cure.core.DTO;
using Addiction_Cure.core.Repository;
using Addiction_Cure.core.Service;
using Addiction_Cure.infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.infra.Service
{
    public class ReqService : IReqService
    {
        private readonly IReqRepository reqRepository;
        public ReqService(IReqRepository reqRepository)
        {
            this.reqRepository = reqRepository;
        }

        public List<Req> getbydocid(int id) {
            return reqRepository.getbydocid(id);
                 }
       public Req getbypatid(int id)
        {
        return reqRepository.getbypatid(id);
        }

       public void createReq(Req req){
        reqRepository.createReq(req);
        }
       public void updateReq(Req req) { 
        reqRepository.updateReq(req);
        }
     public void accept(accept accept)
        {
            reqRepository.accept(accept);
        }


     public void deleteReq(int id)
        {
            reqRepository.deleteReq(id);
        }
    }
}
