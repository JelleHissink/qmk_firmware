using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeymapDesigner.Model
{
    public class WriteCCode
    {
        private const string BeginComment = "BEGIN KEYMAPS";
        private const string EndComment = "END KEYMAPS";

        private bool IsComment(string line, string comment)
        {
            line = line.Trim();
            return
                line.StartsWith("//") &&
                StringComparer.OrdinalIgnoreCase.Equals(line.Substring(2).Trim(), comment);
        }

        public void Update(string fileName, KeymapDefinition definition)
        {
            var allLines = File.ReadAllLines(fileName);
            var startLines = allLines
                .TakeWhile(l => !IsComment(l, BeginComment))
                .ToArray();
            var endLines = allLines
                .Reverse()
                .TakeWhile(l => !IsComment(l, EndComment))
                .Reverse()
                .ToArray();

            var lines = new List<string>();
            lines.AddRange(startLines);
            lines.Add($"// {BeginComment}");
            for (int i = 0; i < definition.Layers.Count; i++)
            {
                lines.AddRange(GetLayerCCode(i, definition.Layers[i]));
            }
            lines.Add($"// {EndComment}");
            lines.AddRange(endLines);

            File.WriteAllLines(fileName, lines);
        }

        private IEnumerable<string> GetLayerCCode(int i, Layer layer)
        {
            yield return $"[{i}] = KEYMAP( // {layer.Name}";

            int keyIndex = -1;
            while (++keyIndex < layer.Assignments.Length)
            {
                var action = layer.Assignments[keyIndex].Action;
                bool isLastKey = keyIndex >= layer.Assignments.Length - 1;

                if (isLastKey)
                {
                    yield return $"{action.CCode}";
                }
                else
                {
                    yield return $"{action.CCode}, ";
                }
            }
            yield return "),";
        }
    }
}
