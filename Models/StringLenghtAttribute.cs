﻿using System;

namespace GetFit.Models
{
    internal class StringLenghtAttribute : Attribute
    {
        private int v;

        public StringLenghtAttribute(int v)
        {
            this.v = v;
        }
    }
}