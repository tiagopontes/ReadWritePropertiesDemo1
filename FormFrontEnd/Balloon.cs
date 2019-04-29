using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFrontEnd
{
    public class Balloon
    {
        private string color;
        private decimal height;
        private decimal diameter;

        public string Color
        {
            get
            {
                return color;
            } 
            set
            {
                if(value.ToUpper() == "RED" || value.ToUpper() == "BLUE")
                {
                    color = value;
                }
                else
                {
                    throw new DataException("Color must be red or blue");
                }
            }
        }

        public decimal Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public decimal Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                if(color == string.Empty)
                {
                    throw new DataException("Please set the color prior to setting the diameter");
                }
                else
                {
                    if(color == "RED")
                    {
                        if(value <= 12)
                        {
                            diameter = value;
                        }
                        else
                        {
                            throw new ConstraintException("Red Balloon must be less than 12 inches");
                        }
                    }
                    else if(color == "WHITE")
                    {
                        if(value <= 10)
                        {
                            diameter = value;
                        }
                        else
                        {
                            throw new ConstraintException("White Balloon must be less than 10 inches");
                        }
                    }
                }
            }
        }
    }
}
