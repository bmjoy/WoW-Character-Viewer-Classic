﻿using SharpGL;
using System.Collections.Generic;

namespace WoW_Character_Viewer_Classic.Models
{
    class HumanFemale : Character
    {
        enum Geosets
        {
            Body1,
            Hair01,
            Hair02,
            Hair03,
            Hair04,
            Hair05,
            Hair06,
            Hair07,
            Hair08,
            Hair09,
            Hair10,
            Ears2,
            Ears1,
            Style1,
            Hair11,
            Style2,
            Hair12,
            Hair13,
            Hair14,
            Hair15,
            Hair16,
            Hair17,
            Hair18,
            Hair19,
            Style3,
            Style4,
            Wrist1,
            Wrist2,
            Wrist3,
            Sleeve1,
            Sleeve2,
            Wrist5,
            Wrist4,
            Cape5,
            Cape4,
            Buttons5,
            Buttons4,
            Cape3,
            Buttons3,
            Cape2,
            Buttons2,
            Cape1,
            Buttons1,
            Back1,
            Robe1,
            Skirt2,
            Tabard1,
            Legs1,
            Boots5,
            Boots2,
            Boots1,
            Boots3,
            Boots4,
            Knees2,
            Knees1,
            Skirt1,
            Eyes1,
            Feature1,
            Feature2,
            Feature3,
            Feature4,
            Feature5,
            Feature6
        };

        List<Geosets> currentGeosets;

        public HumanFemale() : base(@"Character\Human\Female\HumanFemale.xml")
        {
            currentGeosets = new List<Geosets>
            {
                Geosets.Body1,
                Geosets.Ears1,
                Geosets.Back1,
                Geosets.Wrist1,
                Geosets.Legs1,
                Geosets.Boots1
            };
            skinsCount = 10;
            facesCount = 15;
            hairName = "Hair Style: ";
            hairsCount = 19;
            colorName = "Hair Color: ";
            colorsCount = 10;
            facialName = "Piercings: ";
            facialsCount = 7;
        }

        protected override void GetHairNames()
        {
            hairNames = new[]
            {
                "Straight",
                "Loose",
                "Bangs",
                "Full",
                "Parted Long",
                "Flipped",
                "Tomboy",
                "Pony Right",
                "Pony Left",
                "Bobbed",
                "Layered",
                "Short",
                "Flirty",
                "Waved",
                "Bun",
                "Parted Short",
                "Waved Bob",
                "Rushed",
                "Soaked"
            };
        }

        protected override void GetFacialNames()
        {
            facialNames = new[]
            {
                "Unpierced",
                "Earrings",
                "Upper Earrings",
                "Double Upper Earrings",
                "Full Earrings",
                "Nose Ring",
                "Nose && Brow Rings"
            };
        }

        protected override string GetFacialUpper()
        {
            return "";
        }

        protected override string GetFacialLower()
        {
            return "";
        }

        protected override string GetScalpUpper()
        {
            return "00";
        }

        protected override string GetScalpLower()
        {
            return "00";
        }

        protected override string GetHairTexture()
        {
            string hairTexture = "";
            switch(Hair)
            {
                case 0:
                case 2:
                case 3:
                case 4:
                case 6:
                case 7:
                case 8:
                case 9:
                case 15:
                    hairTexture = "00";
                    break;
                case 1:
                case 5:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 16:
                case 17:
                case 18:
                    hairTexture = "01";
                    break;
            }
            return hairTexture;
        }

        protected override void HairGeosets()
        {
            currentGeosets.RemoveAll(item => item.ToString().Contains("Style"));
            currentGeosets.RemoveAll(item => item.ToString().Contains("Hair"));
            List<Geosets> list;
            switch(Hair)
            {
                case 0:
                    list = new List<Geosets>
                    {
                        Geosets.Hair01
                    };
                    break;
                case 1:
                    list = new List<Geosets>
                    {
                        Geosets.Hair02
                    };
                    break;
                case 2:
                    list = new List<Geosets>
                    {
                        Geosets.Hair03
                    };
                    break;
                case 3:
                    list = new List<Geosets>
                    {
                        Geosets.Hair04
                    };
                    break;
                case 4:
                    list = new List<Geosets>
                    {
                        Geosets.Hair05
                    };
                    break;
                case 5:
                    list = new List<Geosets>
                    {
                        Geosets.Hair06
                    };
                    break;
                case 6:
                    list = new List<Geosets>
                    {
                        Geosets.Hair11
                    };
                    break;
                case 7:
                    list = new List<Geosets>
                    {
                        Geosets.Style2,
                        Geosets.Hair07
                    };
                    break;
                case 8:
                    list = new List<Geosets>
                    {
                        Geosets.Style3,
                        Geosets.Hair12
                    };
                    break;
                case 9:
                    list = new List<Geosets>
                    {
                        Geosets.Hair13
                    };
                    break;
                case 10:
                    list = new List<Geosets>
                    {
                        Geosets.Hair08
                    };
                    break;
                case 11:
                    list = new List<Geosets>
                    {
                        Geosets.Hair14
                    };
                    break;
                case 12:
                    list = new List<Geosets>
                    {
                        Geosets.Hair15
                    };
                    break;
                case 13:
                    list = new List<Geosets>
                    {
                        Geosets.Hair09
                    };
                    break;
                case 14:
                    list = new List<Geosets>
                    {
                        Geosets.Hair16
                    };
                    break;
                case 15:
                    list = new List<Geosets>
                    {
                        Geosets.Hair17
                    };
                    break;
                case 16:
                    list = new List<Geosets>
                    {
                        Geosets.Hair18
                    };
                    break;
                case 17:
                    list = new List<Geosets>
                    {
                        Geosets.Style4,
                        Geosets.Hair19
                    };
                    break;
                case 18:
                    list = new List<Geosets>
                    {
                        Geosets.Hair10
                    };
                    break;
                default:
                    list = new List<Geosets>();
                    break;
            }
            currentGeosets.AddRange(list);
        }

        protected override void FacialGeosets()
        {
            currentGeosets.RemoveAll(item => item.ToString().Contains("Feature"));
            List<Geosets> list;
            switch(Facial)
            {
                case 1:
                    list = new List<Geosets>
                    {
                        Geosets.Feature1
                    };
                    break;
                case 2:
                    list = new List<Geosets>
                    {
                        Geosets.Feature2
                    };
                    break;
                case 3:
                    list = new List<Geosets>
                    {
                        Geosets.Feature6
                    };
                    break;
                case 4:
                    list = new List<Geosets>
                    {
                        Geosets.Feature3
                    };
                    break;
                case 5:
                    list = new List<Geosets>
                    {
                        Geosets.Feature4
                    };
                    break;
                case 6:
                    list = new List<Geosets>
                    {
                        Geosets.Feature5
                    };
                    break;
                default:
                    list = new List<Geosets>();
                    break;
            }
            currentGeosets.AddRange(list);
        }

        public override void Render(OpenGL gl)
        {
            HairGeosets();
            FacialGeosets();
            MakeTextures(gl);
            foreach(Geosets geoset in currentGeosets)
            {
                if(billboards.Contains(vertices[indices[triangles[geosets[(int)geoset].triangle]]].Bones[0].index))
                {
                    RenderBillboard(gl, (int)geoset, geosets[(int)geoset].triangle, geosets[(int)geoset].triangles);
                }
                else
                {
                    RenderGeoset(gl, (int)geoset, geosets[(int)geoset].triangle, geosets[(int)geoset].triangles);
                }
            }
            RenderSkeleton(gl);
        }
    }
}