﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models
{
    public class Doacao
    {
        public int DonatarioID { get; set; }
        public int DoacaoID { get; set; }
        public int ItemID { get; set; }

        public Donatario Donatario { get; set; }
        public Usuario Usuario { get; set; }
        public virtual ICollection<ItemDoado> ItemDoado { get; set; }

    }
}
