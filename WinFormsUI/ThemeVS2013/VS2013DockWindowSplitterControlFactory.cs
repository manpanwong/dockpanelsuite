﻿using WeifenLuo.WinFormsUI.Docking;

namespace WeifenLuo.WinFormsUI.ThemeVS2013
{
    internal class VS2013DockWindowSplitterControlFactory : DockPanelExtender.IDockWindowSplitterControlFactory
    {
        public SplitterBase CreateSplitterControl(ISplitterHost host)
        {
            return new VS2013WindowSplitterControl(host);
        }
    }
}
