using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    interface CustomerTarget : Target
    {
        bool CustomerInteract(Customer c);
    }
}
