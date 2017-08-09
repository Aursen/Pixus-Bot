using System;

namespace Pixus.Core
{
    [Serializable]
    class Trajet : Script
    {
        //=========================================================================================================================
        //                                                      propriétés
        //=========================================================================================================================
        public bool Repeat { get; set; }

        //=========================================================================================================================
        //                                                      constr.
        //=========================================================================================================================
        public Trajet(String name, String file, bool repeat = false) : base(file)
        {
            Name = name;
            //this.File = File;
            Repeat = repeat;
        }

        public Trajet(String file, bool repeat = false) : base(file)
        {
            Repeat = repeat;
        }
    }
}
