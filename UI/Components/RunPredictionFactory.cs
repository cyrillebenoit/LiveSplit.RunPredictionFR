using LiveSplit.Model;
using System;

namespace LiveSplit.UI.Components
{
    public class RunPredictionFactory : IComponentFactory
    {
        public string ComponentName => "Prédiction de la run";

        public string Description => "Affiche le chrono final si la run se déroule comme la comparaison actuelle.";

        public ComponentCategory Category => ComponentCategory.Information; 

        public IComponent Create(LiveSplitState state) => new RunPrediction(state);

        public string UpdateName => ComponentName;

        public string XMLURL => "http://livesplit.org/update/Components/update.LiveSplit.RunPrediction.xml";

        public string UpdateURL => "http://livesplit.org/update/";

        public Version Version => Version.Parse("1.8.0");
    }
}
