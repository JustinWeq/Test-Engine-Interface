using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Engine_Interface.Object
{
    /// <summary>
    /// A simple class that contains methods and data for handling an event.
    /// </summary>
    class ObjectEvent
    {
        /// <summary>
        /// defines the type of event associated with this object event
        /// </summary>
        public enum EVENTYPE
        {
            /// <summary>
            /// collision event, happens when two perticular objects collide
            /// </summary>
            COLLISION,
            /// <summary>
            /// load event,happens when an object is first created
            /// </summary>
            LOAD,
            /// <summary>
            /// update event, happens when an object updates
            /// </summary>
            UPDATE,
            /// <summary>
            /// draw event, happens when an object is drawn
            /// </summary>
            DRAW,
            /// <summary>
            /// key press event, happens when a perticular key is pressed
            /// </summary>
            KEYPRESS,
            /// <summary>
            /// key event, happens when a key is held down
            /// </summary>
            KEY,
            /// <summary>
            /// key release event happens when a key is released
            /// </summary>
            KEYRELEASE,
            /// <summary>
            /// right mouse pressed event happens when the right mouse button is pressed
            /// </summary>
            RIGHTMOUSEPRESSED,
            /// <summary>
            /// left mouse button happens when the left mouse button is pressed
            /// </summary>
            LEFTMOUSEPRESSED,
            /// <summary>
            /// left mouse event happens when the left mouse button is held down
            /// </summary>
            LEFTMOUSE,
            /// <summary>
            /// right mouse event , happens when the right mouse is held down
            /// </summary>
            RIGHTMOUSE,
            /// <summary>
            /// mouse hover event, happens when the mouse hovers over this control
            /// </summary>
            MOUSEHOVER,
            /// <summary>
            /// happens when gamepad one is updated
            /// </summary>
            GAMEPAD1,
            /// <summary>
            /// happens when gamepad two is updated
            /// </summary>
            GAMEPAD2,
            /// <summary>
            /// happens when gamepad three is updated
            /// </summary>
            GAMEPAD3,
            /// <summary>
            /// happens when gamepad four is updated
            /// </summary>
            GAMEPAD4,
            /// <summary>
            /// destroy event happens at the objects destruction
            /// </summary>
            DESTROY
        }

        /// <summary>
        /// states the diffrent keys can be in
        /// </summary>
        enum KEYS
        {
            ESC,
            F1,
            F2,
            F3,
            F4,
            F5,
            F6,
            F7,
            F8,
            F9,
            TAB,
            ENTER,
            LEFTSHIFT,
            RIGHTSHIFT,
            LEFTCRTL,
            RIGHTCRTL,
            LEFTALT,
            RIGHTALT,
            FORWARDSLASH,
            BACKWARDSLASH,
            ONE,
            TWO,
            THREE,
            FOUR,
            FIVE,
            SIX,
            SEVEN,
            EIGHT,
            NINE,
            ZERO,
            PLUS,
            MINUS,
            Q,
            W,
            E,
            R,
            T,
            Y,
            U,
            I,
            O,
            P,
            A,
            S,
            D,
            F,
            G,
            H,
            J,
            K,
            L,
            Z,
            X,
            C,
            V,
            B,
            N,
            M
        }
        
        /// <summary>
        /// contains values for the gamepad
        /// </summary>
        enum GAMEPAD
        {
            X,
            A,
            B,
            Y,
            START,
            BACK,
            RIGHTBUMPER,
            LEFTBUMPER,
            RIGHTTRIGGER,
            LEFTTRIGGER,
            LEFTJOYSTICK,
            RIGHTJOYSTICK,
            UP,
            DOWN,
            LEFT,
            RIGHT
        }
    }
}
