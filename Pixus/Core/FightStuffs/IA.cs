using System;
using System.Collections.Generic;

namespace Pixus.Core.FightStuffs
{
    [Serializable]
    class IA : Script
    {
        //=========================================================================================================================
        //                                                      attributs
        //=========================================================================================================================
        public const int ActionWaitTimeout = 2000; // 2 seconde

        //=========================================================================================================================
        //                                                      propriétés
        //=========================================================================================================================
        public List<string> NextAction { get; set; }

        //=========================================================================================================================
        //                                                      constr.
        //=========================================================================================================================
        public IA(String File): base(File) => NextAction = new List<string>();

        //=========================================================================================================================
        //                                                      méthodes
        //=========================================================================================================================

        // Next(...) : sauvegarde la prochaine action de l'IA
        public void Next(string[] nextActions)
        {
            if (NextAction.Count > 0)
                NextAction.Clear();

            foreach (var nextAction in nextActions)
                NextAction.Add(nextAction);
        }

        // NextActionToString(...) : retourne NextAction sous forme de chaine de caractère séparée par des ','
        public string NextActionToString()
        {
            string nextActionString = "";

            for (int i = 0; i < NextAction.Count; i++)
                nextActionString += NextAction[i] + (i < NextAction.Count - 1 ? "," : "");

            return nextActionString;
        }
    }
}
