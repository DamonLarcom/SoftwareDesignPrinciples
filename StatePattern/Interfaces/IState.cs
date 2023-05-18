using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Interfaces
{
    public interface IState
    {
        void ToggleRed();
        void ToggleYellow();
        void ToggleGreen();
    }
}
