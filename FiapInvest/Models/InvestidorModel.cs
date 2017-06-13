﻿using System;
using System.Collections.Generic;


namespace FiapInvest.Models
{
    public class InvestidorModel
    {

        public int IdInvestidor { get; set; }
        public String NomeInvestidor { get; set; }
        public String Cpf { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public String Perfil { get; set; }
        public DateTime DataNascimento { get; set; }
        public IList<string> perfis { get; set; }

        public double ValorPatrimonio { get; set; }
                      
    }
}
