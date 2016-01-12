using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeymapDesigner.Model
{
    public class ActiveLayer : Observable
    {
        private KeymapDefinition KeymapDefinition { get; }

        private int _activeLayersMask = 0;

        public int ActiveLayersMask
        {
            get
            {
                return _activeLayersMask;
            }
            set
            {
                if (SetValue(ref _activeLayersMask, value, nameof(ActiveLayersMask)))
                {
                    RefreshAssignments();
                }
            }
        }

        private bool _showHelpOverlay = false;

        public bool ShowHelpOverlay
        {
            get
            {
                return _showHelpOverlay;
            }
            private set
            {
                SetValue(ref _showHelpOverlay, value, nameof(ShowHelpOverlay));
            }
        }

        public ActiveLayer(KeymapDefinition keymapDefinition)
        {
            KeymapDefinition = keymapDefinition;
            Assignments = KeymapDefinition.Keyboard.PhysicalKeys
                .Select(key => new KeyAssignment(Actions.Transparent, key, KeymapDefinition.Layers.First()))
                .ToArray();
        }

        private void RefreshAssignments()
        {
            var activeLayers = new List<Layer>();
            for (int layer = KeymapDefinition.Layers.Count - 1; layer >= 0; layer--)
            {
                int mask = (1 << layer);
                if ((_activeLayersMask & mask) != 0)
                {
                    activeLayers.Add(KeymapDefinition.Layers[layer]);
                }
            }

            var defaultLayer = KeymapDefinition.Layers.First();
            for (int i = 0; i < KeymapDefinition.Keyboard.PhysicalKeys.Length; i++)
            {
                Action action = Actions.Transparent;
                var actionLayer = defaultLayer;
                foreach (var layer in activeLayers)
                {
                    var assignment = layer.Assignments[i];
                    if (!(assignment.Action is TransparentAction))
                    {
                        action = assignment.Action;
                        actionLayer = assignment.Layer;
                        break;
                    }
                }
                Assignments[i].Action = action;
                Assignments[i].Layer = actionLayer;
            }
            
            ShowHelpOverlay = activeLayers.Any(layer => layer.ShowHelpOverlay);
        }

        public KeyAssignment[] Assignments { get; }
    }
}
