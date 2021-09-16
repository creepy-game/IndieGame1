<<<<<<< HEAD
using UnityEngine.ProBuilder;
using UnityEngine;

namespace UnityEditor.ProBuilder.Actions
{
    sealed class OpenVertexColorEditor : MenuAction
    {
        public override ToolbarGroup group { get { return ToolbarGroup.Tool; } }
        public override Texture2D icon { get { return IconUtility.GetIcon("Toolbar/Panel_VertColors", IconSkin.Pro); } }
        public override TooltipContent tooltip { get { return s_Tooltip; } }
        public override string menuTitle { get { return "Vertex Colors"; } }

        static readonly TooltipContent s_Tooltip = new TooltipContent
            (
                "Vertex Colors Editor",
                "Opens the Vertex Color Palette.\n\nApply using Face mode for hard-edged colors.\nApply using Edge or Vertex mode for soft, blended colors."
            );

        public override bool enabled
        {
            get { return ProBuilderEditor.instance != null; }
        }

        public override ActionResult DoAction()
        {
            VertexColorPalette.MenuOpenWindow();
            return new ActionResult(ActionResult.Status.Success, "Open Vertex Color Window");
        }
    }
}
=======
using UnityEngine.ProBuilder;
using UnityEngine;

namespace UnityEditor.ProBuilder.Actions
{
    sealed class OpenVertexColorEditor : MenuAction
    {
        public override ToolbarGroup group { get { return ToolbarGroup.Tool; } }
        public override Texture2D icon { get { return IconUtility.GetIcon("Toolbar/Panel_VertColors", IconSkin.Pro); } }
        public override TooltipContent tooltip { get { return s_Tooltip; } }
        public override string menuTitle { get { return "Vertex Colors"; } }

        static readonly TooltipContent s_Tooltip = new TooltipContent
            (
                "Vertex Colors Editor",
                "Opens the Vertex Color Palette.\n\nApply using Face mode for hard-edged colors.\nApply using Edge or Vertex mode for soft, blended colors."
            );

        public override bool enabled
        {
            get { return ProBuilderEditor.instance != null; }
        }

        public override ActionResult DoAction()
        {
            VertexColorPalette.MenuOpenWindow();
            return new ActionResult(ActionResult.Status.Success, "Open Vertex Color Window");
        }
    }
}
>>>>>>> 7cf0e2f442837203eb7c741f38b2f438425c3367
