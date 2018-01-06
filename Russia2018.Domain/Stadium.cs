﻿using System.Collections.Generic;

namespace Russia2018.Domain
{
    public class Stadium
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual City City { get; set; }

        public int Capacity { get; set; } 

        public virtual List<View> Views { get; set; }


    }
}