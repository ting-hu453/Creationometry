using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creationometry
{
    //------------------------------------------------------------------
    // Name:    Megan Baxter, Callie Seehafer
    // Project: Creationometry
    // Purpose: This interface will 
    //------------------------------------------------------------------
    public interface ICommand
    {
        //------------------------------------------------------------------
        // Executes the command
        //------------------------------------------------------------------
        bool execute();

        //------------------------------------------------------------------
        // Executes the command - Overloaded with Design Element parameter
        //------------------------------------------------------------------
        bool execute(DesignElement selectedElement);

        //------------------------------------------------------------------
        // Executes the command - Overloaded with parameters
        //------------------------------------------------------------------
        bool execute(DesignElementTypes elementType, System.Drawing.Point[] points);

        //------------------------------------------------------------------
        // Restores the state to before the command
        //------------------------------------------------------------------
        void undo();

        //------------------------------------------------------------------
        // Restores the state to after the command
        //------------------------------------------------------------------
        void redo();

        //------------------------------------------------------------------
        // Creates a copy of the element state for use by the command
        //------------------------------------------------------------------
        DesignElement copyElementState(DesignElement elementToCopy);
    }
}