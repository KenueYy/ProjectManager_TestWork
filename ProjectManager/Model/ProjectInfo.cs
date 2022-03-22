using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectManager.Model
{
    class ProjectInfo
    {
        string name { get; set; }
        string customerName { get; set; }
        string contracterName { get; set; }
        List<string> workers = new List<string>();

    }
}
