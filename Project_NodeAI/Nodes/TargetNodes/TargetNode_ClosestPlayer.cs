﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeAI.Nodes.TargetNodes
{
    [Node(MenuName = "Closest Player", Type = NodeType.TARGET_CLOSEST_PLAYER, AllowedTypes = new NodeType[] { NodeType.ACTION })]
    public class ClosestPlayer : TargetNode
    {
        public ClosestPlayer()
        {
            Type = NodeType.TARGET_CLOSEST_PLAYER;

            TargetId = "21";

            NodeName.Content = "Closest Player";

            AddParam(ParamId.PARAM_1, "Max Dist:");
        }

        public override Node Clone()
        {
            return new ClosestPlayer();
        }
    }
}
