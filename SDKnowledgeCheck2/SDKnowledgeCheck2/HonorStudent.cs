using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKnowledgeCheck2
{
    public class HonorStudent: Student
    {
        public List<string> RequiredHonorsClasses { get; set; }
        public List<string> CompletedHonorsClasses { get; set; }

        public HonorStudent() : base()
        {
            RequiredHonorsClasses = new List<string>();
            CompletedHonorsClasses = new List<string>();
        }
        public override string ToString()
        {
            var baseInfo = base.ToString();  // Get the base class info
            var requiredClassesString = RequiredHonorsClasses.Any() ? string.Join(", ", RequiredHonorsClasses) : "No required honors classes";
            var completedClassesString = CompletedHonorsClasses.Any() ? string.Join(", ", CompletedHonorsClasses) : "No completed honors classes";
            return $"{baseInfo}, Required Honors Classes: {requiredClassesString}, Completed Honors Classes: {completedClassesString}";
        }
    }
}
