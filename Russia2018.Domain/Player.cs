﻿namespace Russia2018.Domain
{
    public class Player : Person
    {
        public virtual Team Team { get; set; }
    }
}