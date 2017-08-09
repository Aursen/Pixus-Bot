﻿namespace Pixus.Core.FightStuffs
{
    class Fight
    {
        //=========================================================================================================================
        //                                                      attributs
        //=========================================================================================================================
        public const int TurnTimeout = 60000; // 60 seconde
        public const int WaitTimeAfterPassTurn = 3000; // 3 seconde
        public const int WaitTimeAfterStartFight = 3000; // 3 seconde

        //=========================================================================================================================
        //                                                      propriétés
        //=========================================================================================================================
        public int Turn { get; set; }
        public bool OnGoing { get; set; }
        public IA IA { get; set; }

        //=========================================================================================================================
        //                                                      constr.
        //=========================================================================================================================
        public Fight(IA ia)
        {
            Turn = 0;
            OnGoing = false;
            IA = ia;
        }
    }
}
