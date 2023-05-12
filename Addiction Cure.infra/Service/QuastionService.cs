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
    public class QuastionService : IQuastionService
    {
        private readonly IQuastionRepository quastionRepository;
        public QuastionService(IQuastionRepository quastionRepository)
        {
            this.quastionRepository = quastionRepository;
        }
        public List<Quastionsac> GetAllQuastions(int id)
        {
            return quastionRepository.GetAllQuastions(id);
        }
        public void CreateQuastion(Quastionsac quastionsac)
        {
            quastionRepository.CreateQuastion(quastionsac);
        }
        public void UpdateQuastion(Quastionsac quastionsac)
        {
            quastionRepository.UpdateQuastion(quastionsac);
        }
        public void DeleteQuastion(int id)
        {
            quastionRepository.DeleteQuastion(id);
        }
        public List<Quastionsac> GetQuastionsById(int id)
        {
            return quastionRepository.GetQuastionsById(id);
        }

        public List<quasWithcat> GetAllQuestionss()
        {
            return quastionRepository.GetAllQuestionss();
        }

    }
}
