using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationometry
{
    class ElementModMenu
    {
        private enum channelIDs
        {
            POINT_1_X_INPUT_CHANNEL,
            POINT_1_Y_INPUT_CHANNEL,
            POINT_2_X_INPUT_CHANNEL,
            POINT_2_Y_INPUT_CHANNEL,
            POINT_3_X_INPUT_CHANNEL,
            POINT_3_Y_INPUT_CHANNEL,
            POINT_4_X_INPUT_CHANNEL,
            POINT_4_Y_INPUT_CHANNEL,
            POINT_5_X_INPUT_CHANNEL,
            POINT_5_Y_INPUT_CHANNEL,
            DISTANCE_1_INPUT_CHANNEL,
            DISTANCE_2_INPUT_CHANNEL,
            ANGLE_1_INPUT_CHANNEL,
            COUNT_1_INPUT_CHANNEL,

            POINT_1_LABEL,
            POINT_2_LABEL,
            POINT_3_LABEL,
            POINT_4_LABEL,
            POINT_5_LABEL,
            DISTANCE_1_LABEL,
            DISTANCE_2_LABEL,
            ANGLE_1_LABEL,
            COUNT_1_LABEL,

            BORDER_VISIBILITY_INPUT_CHANNEL,
            BORDER_COLOR_INPUT_CHANNEL,
            BORDER_OPACITY_INPUT_CHANNEL,
            BORDER_WEIGHT_INPUT_CHANNEL,
            BORDER_STYLE_INPUT_CHANNEL,
            VERTEX_STYLE_INPUT_CHANNEL,

            BORDER_VISIBILITY_LABEL,
            BORDER_COLOR_LABEL,
            BORDER_OPACITY_LABEL,
            BORDER_WEIGHT_LABEL,
            BORDER_STYLE_LABEL,
            VERTEX_STYLE_LABEL,

            FILL_VISIBILITY_INPUT_CHANNEL,
            FILL_COLOR_INPUT_CHANNEL,
            FILL_OPACITY_INPUT_CHANNEL,

            FILL_VISIBILITY_LABEL,
            FILL_COLOR_LABEL,
            FILL_OPACITY_LABEL,

            ELEMENT_SELECTION_INPUT_CHANNEL,

            ELEMENT_SELECTION_LABEL
        }
    }
}
