﻿using SharpGL;
using System;
using System.Collections.Generic;
using System.Windows.Media.Media3D;

namespace WoW_Character_Viewer_Classic.Models
{
    class TaurenMale : CharacterModel
    {
        enum Geosets
        {
            Body1,
            Mane1,
            Hair01,
            Hair02,
            Facial01,
            Facial02,
            Teeth1,
            Ears2,
            Style1,
            Style2,
            Style3,
            Style4,
            Style5,
            Hair03,
            Facial03,
            Hair04,
            Style6,
            Style7,
            Style8,
            Style9,
            Facial04,
            Ears1,
            Facial05,
            Facial06,
            Facial07,
            Facial08,
            Facial09,
            Facial10,
            Facial11,
            Facial12,
            Facial13,
            Hair05,
            Hair06,
            Facial20,
            Sleeve1,
            Wrist5,
            Wrist3,
            Wrist4,
            Wrist2,
            Wrist1,
            Sleeve2,
            Back1,
            Cape5,
            Cape4,
            Cape3,
            Cape1,
            Cape2,
            Buttons5,
            Buttons4,
            Buttons3,
            Buttons1,
            Buttons2,
            Skirt1,
            Doublet1,
            Robe1,
            Legs1,
            Knees1,
            Hoof1,
            Tail6,
            Tail1,
            Tail2,
            Tail3,
            Tail4,
            Tail5,
            Tabard1,
            Feature1,
            Feature2,
            Feature3,
            Feature4,
            Feature5
        };

        List<Geosets> currentGeosets;
        List<Geosets> list;

        public TaurenMale()
            : base(@"Character\Tauren\Male\TaurenMale.xml")
        {
            currentGeosets = new List<Geosets>
            {
                Geosets.Body1,
                Geosets.Mane1,
                Geosets.Teeth1,
                Geosets.Hoof1
            };
            list = new List<Geosets>();
            skinsCount = 19;
            facesCount = 5;
            hairName = "Horn Style: ";
            hairsCount = 8;
            colorName = "Horn Color: ";
            colorsCount = 3;
            facialName = "Facial Hair: ";
            facialsCount = 7;
        }

        protected override void GetHairNames()
        {
            hairNames = new[]
            {
                "Longhorn",
                "Bull",
                "Charger",
                "Broken",
                "Snapped",
                "Tiny",
                "Buffalo",
                "Gorefest"
            };
        }

        protected override void GetFacialNames()
        {
            facialNames = new[]
            {
                "Clean",
                "Triple Braids",
                "Ringed",
                "Braid",
                "Bearded",
                "Double Braids",
                "Ringed && Braided"
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
            return "";
        }

        protected override string GetScalpLower()
        {
            return "00" + "_" + Number(Color);
        }

        protected override string GetHairTexture()
        {
            return "";
        }

        protected override void HairGeosets()
        {
            currentGeosets.RemoveAll(item => item.ToString().Contains("Style"));
            list.Clear();
            switch (Hair)
            {
                case 0:
                    list.AddRange(new List<Geosets>
                    {
                        Geosets.Style1
                    });
                    break;
                case 1:
                    list.AddRange(new List<Geosets>
                    {
                        Geosets.Style2
                    });
                    break;
                case 2:
                    list.AddRange(new List<Geosets>
                    {
                        Geosets.Style3
                    });
                    break;
                case 3:
                    list.AddRange(new List<Geosets>
                    {
                        Geosets.Style4
                    });
                    break;
                case 4:
                    list.AddRange(new List<Geosets>
                    {
                        Geosets.Style6
                    });
                    break;
                case 5:
                    list.AddRange(new List<Geosets>
                    {
                        Geosets.Style9
                    });
                    break;
                case 6:
                    list.AddRange(new List<Geosets>
                    {
                        Geosets.Style7
                    });
                    break;
                case 7:
                    list.AddRange(new List<Geosets>
                    {
                        Geosets.Style8
                    });
                    break;
            }
            currentGeosets.AddRange(list);
        }

        protected override void FacialGeosets()
        {
            currentGeosets.RemoveAll(item => item.ToString().Contains("Hair"));
            currentGeosets.RemoveAll(item => item.ToString().Contains("Feature"));
            currentGeosets.RemoveAll(item => item.ToString().Contains("Facial"));
            list.Clear();
            switch (Facial)
            {
                case 1:
                    list.AddRange(new List<Geosets>
                    {
                        Geosets.Feature1,
                        Geosets.Hair01,
                        Geosets.Facial06,
                        Geosets.Facial10,
                        Geosets.Hair05
                    });
                    break;
                case 2:
                    list.AddRange(new List<Geosets>
                    {
                        Geosets.Feature2,
                        Geosets.Hair03,
                        Geosets.Facial05
                    });
                    break;
                case 3:
                    list.AddRange(new List<Geosets>
                    {
                        Geosets.Hair04,
                        Geosets.Facial07,
                        Geosets.Facial11
                    });
                    break;
                case 4:
                    list.AddRange(new List<Geosets>
                    {
                        Geosets.Facial03
                    });
                    break;
                case 5:
                    list.AddRange(new List<Geosets>
                    {
                        Geosets.Feature3,
                        Geosets.Hair02,
                        Geosets.Hair06
                    });
                    break;
                case 6:
                    list.AddRange(new List<Geosets>
                    {
                        Geosets.Feature4,
                        Geosets.Facial01,
                        Geosets.Facial04
                    });
                    break;
            }
            currentGeosets.AddRange(list);
        }

        protected override void EquipCape()
        {
            currentGeosets.RemoveAll(item => item.ToString().Contains("Back"));
            currentGeosets.RemoveAll(item => item.ToString().Contains("Cape"));
            currentGeosets.RemoveAll(item => item.ToString().Contains("Buttons"));
            currentGeosets.RemoveAll(item => item.ToString().Contains("Tail"));
            if (Gear[3].ID == "0")
            {
                currentGeosets.Add(Geosets.Back1);
                currentGeosets.Add(Geosets.Tail6);
            }
            else
            {
                currentGeosets.Add((Geosets)Enum.Parse(typeof(Geosets), Gear[3].Models.Cape));
                currentGeosets.Add((Geosets)Enum.Parse(typeof(Geosets), Gear[3].Models.Cape.Replace("Cape", "Buttons")));
                currentGeosets.Add((Geosets)Enum.Parse(typeof(Geosets), Gear[3].Models.Cape.Replace("Cape", "Tail")));
            }
        }

        protected override void EquipHands()
        {
            currentGeosets.RemoveAll(item => item.ToString().Contains("Wrist"));
            if (Gear[8].ID == "0")
            {
                currentGeosets.Add(Geosets.Wrist1);
            }
            else
            {
                currentGeosets.Add((Geosets)Enum.Parse(typeof(Geosets), Gear[8].Models.Wrist));
            }
            if (currentGeosets.Contains(Geosets.Wrist3))
            {
                currentGeosets.Add(Geosets.Wrist4);
            }
        }

        protected override void EquipFeet()
        {
        }

        protected override void EquipLegs()
        {
            currentGeosets.RemoveAll(item => item.ToString().Contains("Legs"));
            currentGeosets.RemoveAll(item => item.ToString().Contains("Robe"));
            currentGeosets.RemoveAll(item => item.ToString().Contains("Knees"));
            if (Gear[10].ID != "0")
            {
                if (Gear[10].Models.Robe != "")
                {
                    currentGeosets.Add((Geosets)Enum.Parse(typeof(Geosets), Gear[10].Models.Robe));
                }
                if ((Gear[11].Models == null || Gear[11].Models.Boots == "Boots1") && Gear[10].Models.Knees != "" && Gear[10].Models.Knees != "Knees2")
                {
                    currentGeosets.Add((Geosets)Enum.Parse(typeof(Geosets), Gear[10].Models.Knees));
                }
            }
            if (!currentGeosets.Contains(Geosets.Robe1))
            {
                currentGeosets.Add(Geosets.Legs1);
            }
            else
            {
                currentGeosets.RemoveAll(item => item.ToString().Contains("Knees"));
            }
        }

        protected override void EquipShirt()
        {
            currentGeosets.RemoveAll(item => item.ToString().Contains("Sleeve"));
            if (Gear[5].ID != "0")
            {
                if ((Gear[4].Textures == null || Gear[4].Textures.ArmLower == "") && currentGeosets.Contains(Geosets.Wrist1) && Gear[5].Models.Sleeve != "")
                {
                    currentGeosets.Add((Geosets)Enum.Parse(typeof(Geosets), Gear[5].Models.Sleeve));
                }
            }
        }

        protected override void EquipWrist()
        {
            if (Gear[7].ID != "0")
            {
                currentGeosets.RemoveAll(item => item.ToString().Contains("Sleeve"));
            }
        }

        protected override void EquipChest()
        {
            if (Gear[5].Models == null || Gear[5].Models.Sleeve == "")
            {
                currentGeosets.RemoveAll(item => item.ToString().Contains("Sleeve"));
            }
            if (Gear[4].ID != "0")
            {
                if (currentGeosets.Contains(Geosets.Wrist1) && Gear[4].Models.Sleeve != "")
                {
                    currentGeosets.Add((Geosets)Enum.Parse(typeof(Geosets), Gear[4].Models.Sleeve));
                }
                if (!currentGeosets.Contains(Geosets.Robe1) && Gear[4].Models.Robe != "")
                {
                    currentGeosets.Add((Geosets)Enum.Parse(typeof(Geosets), Gear[4].Models.Robe));
                }
            }
            if (currentGeosets.Contains(Geosets.Robe1))
            {
                currentGeosets.RemoveAll(item => item.ToString().Contains("Legs"));
                currentGeosets.RemoveAll(item => item.ToString().Contains("Knees"));
            }
        }

        protected override void EquipTabard()
        {
            currentGeosets.RemoveAll(item => item.ToString().Contains("Tabard"));
            if (Gear[6].ID != "0" && !currentGeosets.Contains(Geosets.Robe1))
            {
                currentGeosets.Add(Geosets.Tabard1);
            }
        }

        protected override void HideHair()
        {
            if (Gear[0].ID != "0" && Gear[0].Male.Hair[5] == '1')
            {
                currentGeosets.RemoveAll(item => item.ToString().Contains("Style"));
                currentGeosets.RemoveAll(item => item.ToString().Contains("Hair"));
                currentGeosets.Add(Geosets.Style5);
            }
        }

        protected override void HideFacial()
        {
            if (Gear[0].ID != "0" && Gear[0].Male.Beards[5] == '1')
            {
                currentGeosets.RemoveAll(item => item.ToString().Contains("Feature"));
                currentGeosets.RemoveAll(item => item.ToString().Contains("Facial"));
            }
        }

        protected override void HideEars()
        {
            currentGeosets.RemoveAll(item => item.ToString().Contains("Ears"));
            if (Gear[0].ID != "0" && Gear[0].Male.Ears[5] == '1')
            {
                currentGeosets.Add(Geosets.Ears2);
            }
            else
            {
                currentGeosets.Add(Geosets.Ears1);
            }
        }

        public override void Render(OpenGL gl)
        {
            gl.PushMatrix();
            Prepare(gl);
            foreach (Geosets geoset in currentGeosets)
            {
                if (billboards.Contains(vertices[indices[triangles[geosets[(int)geoset].triangle]]].Bones[0].index))
                {
                    RenderBillboard(gl, (int)geoset, geosets[(int)geoset].triangle, geosets[(int)geoset].triangles);
                }
                else
                {
                    RenderGeoset(gl, (int)geoset, geosets[(int)geoset].triangle, geosets[(int)geoset].triangles);
                }
            }
            foreach (ObjectComponent component in components)
            {
                if (!component.Empty)
                {
                    component.Render(gl, Rotation);
                }
            }
            RenderSkeleton(gl);
            gl.PopMatrix();
            if (!mount.Empty)
            {
                mount.Render(gl, Rotation);
            }
        }
    }
}
