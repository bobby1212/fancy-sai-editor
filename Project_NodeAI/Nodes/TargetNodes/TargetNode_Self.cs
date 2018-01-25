﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeAI.Nodes.TargetNodes
{
    [Node(MenuName = "Self", Type = NodeType.TARGET_SELF, AllowedTypes = new NodeType[] { NodeType.ACTION })]
    public class Self : TargetNode
    {
        public Self()
        {
            Type = NodeType.TARGET_SELF;

            TargetId = "1";

            NodeName.Content = "Self";
        }

        public override Node Clone()
        {
            return new Self();
        }
    }
}
