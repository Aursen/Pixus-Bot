﻿namespace Pixus.Core.JobStuffs
{
    class GoBanque
    {
        //=========================================================================================================================
        //                                                      attributs
        //=========================================================================================================================
        public static GoBanque Empty = new GoBanque();

        //=========================================================================================================================
        //                                                      propriétés
        //=========================================================================================================================
        public bool Enabled { get; set; }
        public Trajet Trajet { get; set; }

        //=========================================================================================================================
        //                                                      constr.
        //=========================================================================================================================
        public GoBanque() => Enabled = false;
    }
}
