﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Decibase_Model
{
    public partial class Artist
    { 
        public override bool Equals(object obj)
        {
            if (!(obj is Artist)) return false;

            var artist = (Artist)obj;
            if (artist.Name != this.Name) return false;
            if (artist.Nationality != null && this.Nationality != null && artist.Nationality != this.Nationality) return false;

            return true;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() + this.Nationality.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
