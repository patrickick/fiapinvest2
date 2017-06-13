﻿using FiapInvest.Models;
using FiapInvest.Services;
using System.Collections.Generic;

namespace FiapInvest.Business
{
    public class InvestidorBusiness
    {

        public void Gravar(InvestidorModel model)
        {
            new InvestidorService().Gravar(model);
        }

        public InvestidorModel Consultar(int idInvest)
        {
            return new InvestidorService().Consultar(idInvest);
        }

        public IList<string> ListarPerfis()
        {
            return new InvestidorService().ListarPerfis();
        }

    }
}
