﻿namespace QuickStarter.Controls
{
    public interface IControllable
    {
        bool Enabled
        {
            get;
            set;
        }
        void MapInputs();
    }
}
