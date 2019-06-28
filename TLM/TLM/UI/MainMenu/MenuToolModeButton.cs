﻿using ColossalFramework.UI;

namespace TrafficManager.UI.MainMenu {
    public abstract class MenuToolModeButton : MenuButton {
        public abstract ToolMode ToolMode { get; }

        public override bool Active => ToolMode.Equals(UIBase.GetTrafficManagerTool(false)?.GetToolMode());

        public override void OnClickInternal(UIMouseEventParameter p) {
            if (Active) {
                UIBase.GetTrafficManagerTool(true).SetToolMode(ToolMode.None);
            } else {
                UIBase.GetTrafficManagerTool(true).SetToolMode(this.ToolMode);
            }
        }
    }
}