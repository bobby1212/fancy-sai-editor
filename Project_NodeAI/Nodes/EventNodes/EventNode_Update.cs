﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeAI.Nodes.EventNodes
{
    /// <summary>
    /// SMART_EVENT_UPDATE_IC
    /// SMART_EVENT_UPDATE_OOC
    /// </summary>
    [Node(MenuName = "Update", Type = NodeType.EVENT_UPDATE, AllowedTypes = new NodeType[] { NodeType.GENERAL_NPC, NodeType.ACTION })]
    public class Update : EventNode
    {
        /// <summary>
        /// Standard constructor.
        /// Initializes type, node name, tooltips and adds the connectors.
        /// </summary>
        public Update()
        {
            Type = NodeType.EVENT_UPDATE;

            //Update text
            NodeName.Content = "Update";

            AddParam<UpdateTypes>(ParamId.PARAM_SPECIFIC_TYPE, "Type");
            AddParam(ParamId.PARAM_1, "Initial min");
            AddParam(ParamId.PARAM_2, "Initial max");
            AddParam(ParamId.PARAM_3, "Repeat min");
            AddParam(ParamId.PARAM_4, "Repeat max");
        }

        enum UpdateTypes
        {
            UPDATE_IC = 0,
            UPDATE_OCC = 1,
        }

        /// <summary>
        /// Clones the class instance.
        /// </summary>
        /// <returns>Returns clone of this class.</returns>
        public override Node Clone()
        {
            return new Update();
        }
    }
}
