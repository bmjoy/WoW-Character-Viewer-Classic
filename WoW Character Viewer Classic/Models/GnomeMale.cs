﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WoW_Character_Viewer_Classic.Models
{
    class GnomeMale : Character
    {
        enum Geosets
        {
            Body1,
            Facial01,
            Facial02,
            Facial03,
            Ears1,
            Ears2,
            Facial04,
            Style1,
            Hair01,
            Style2,
            Facial05,
            Facial06,
            Facial07,
            Hair02,
            Style3,
            Hair03,
            Hair04,
            Style4,
            Hair05,
            Style5,
            Hair06,
            Style6,
            Wrist1,
            Wrist5,
            Wrist2,
            Wrist4,
            Sleeve2,
            Sleeve1,
            Wrist3,
            Cape5,
            Buttons5,
            Cape4,
            Buttons4,
            Cape3,
            Buttons3,
            Cape2,
            Buttons2,
            Cape1,
            Buttons1,
            Back1,
            Robe1,
            Legs1,
            Knees2,
            Boots2,
            Boots3,
            Boots4,
            Boots5,
            Skirt1,
            Skirt2,
            Knees1,
            Tabard1
        };

        public GnomeMale() : base(@"Character\Gnome\Male\GnomeMale.xml")
        {
            
        }
    }
}
