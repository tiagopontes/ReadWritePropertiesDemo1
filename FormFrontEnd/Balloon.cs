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
        private string colour;
        //private decimal height; this is now auto property
        private decimal diameter;

        public string Colour
        {
            get {return colour;}
            set
            {
                //we now want to support coloured and transparent balloons
               
                //if(value.ToUpper() == "RED" || value.ToUpper() == "BLUE")
                //{
                    colour = value;
                //}
                //else
                //{
                //    throw new DataException("Colour must be red or blue");
                //}
                
            }
        }

        public string BalloonName { get; set; }

        public decimal Height
        {
            get;
            set;
        }

        public decimal Diameter
        {
            get { return diameter; }
            set
            {
                if (string.IsNullOrEmpty(colour))
                {
                    throw new DataException("Balloon colour cannot be empty");
                }
                else
                {
                    if (colour.ToUpper() == "RED")                      
                    {
                        if (value <= 12)
                        {
                            diameter = value;
                        }
                        else
                        {
                            throw new ConstraintException("RED Balloon cannot be greater than 12");
                        }
                                           
                    }
                    else if(colour.ToUpper() == "BLUE")
                    {
                        if(value >= 5)
                        {
                            diameter = value;
                        }
                        else
                        {
                            throw new ConstraintException("BLUE Balloon cannot be less than 5");
                        }
                    }
                }
                                          
            }
        }
    }
}
