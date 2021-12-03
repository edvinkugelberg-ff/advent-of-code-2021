using System.Collections.Generic;
using System.Linq;

namespace Day2.Dive
{
    public static class NavigationService
    {
        public static int GetDepth(IEnumerable<string> inputs)
        {
            var depth = 0;

            var downInputs = inputs.Where(input => input.Contains("down")).ToList();
            var upInputs = inputs.Where(input => input.Contains("up")).ToList();
            downInputs.ForEach(input => depth += int.Parse(input.Split(' ')[1]));
            upInputs.ForEach(input => depth -= int.Parse(input.Split(' ')[1]));

            return depth;
        }

        public static int GetLocation(IEnumerable<string> inputs)
        {
            var position = 0;
            var forwardCommands = inputs.Where(input => input.Contains("forward")).ToList();
            forwardCommands.ForEach(input => position += int.Parse(input.Split(' ')[1]));

            return position;
        }
    }
}