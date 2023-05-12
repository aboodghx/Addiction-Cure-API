using Addiction_Cure.core.Data;
using Addiction_Cure.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addiction_Cure.core.Repository
{
    public interface IQuastionRepository
    {
        List<Quastionsac> GetAllQuastions(int id);
        void CreateQuastion(Quastionsac quastionsac);
        void UpdateQuastion(Quastionsac quastionsac);
        void DeleteQuastion(int id);
        List<Quastionsac> GetQuastionsById(int id);

        List<quasWithcat> GetAllQuestionss();
    }
}
