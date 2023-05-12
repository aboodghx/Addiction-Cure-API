using Addiction_Cure.core.Data;
using Addiction_Cure.core.DTO;
using Addiction_Cure.core.Repository;
using Addiction_Cure.core.Service;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Addiction_Cure.infra.Service
{
    public class ResultTestService : IResultTestService
    {
        private readonly IResultTestRepository resultTestRepository;
        public ResultTestService(IResultTestRepository resultTestRepository)
        {
            this.resultTestRepository = resultTestRepository;
        }

        public List<ResultTestDto> GetAllResult()
        {
            return resultTestRepository.GetAllResult();
        }
        public void CreateResult(Resulttsetac resulttsetac) 
        {
            resultTestRepository.CreateResult(resulttsetac);
        }

        public void UpdateResult(Resulttsetac result)
        {
            resultTestRepository.UpdateResult(result);
        }
        public void DeleteResult(int id)
        {
            resultTestRepository.DeleteResult(id);
        }

       public List<Report> GetResultBetween(DateTime datefrom, DateTime dateto)
        {
            return resultTestRepository.GetResultBetween(datefrom, dateto);
        }
        public Resulttsetac Getbyid(int id)
        {
            return resultTestRepository.Getbyid(id);
        }

        public List<ResultTestDto> GetByDocid(int id)
        {
           return resultTestRepository.GetByDocid(id);
        }
        public List<ResultTestDto> GetBypatid(int id)
        {
            return resultTestRepository.GetBypatid(id);
        }
        public void afterquiz(int id, string result)
        {
            resultTestRepository.afterquiz(id, result);
        }

    }
}
