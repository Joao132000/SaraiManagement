﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models
{
    interface IMovimentacaoRepositorio
    {
        IQueryable<Movimentacao> Movimentacoes { get; }
    }
}
