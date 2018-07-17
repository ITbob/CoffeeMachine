using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCombeDuLionVert.CoffeeCommand
{
    public class DrinkCommand
    {
        public DrinkType DrinkType { get; set; }

        public Int32 _sugarCount = 0;
        public Int32 SugarCount
        {
            get
            {
                return this._sugarCount;
            }
            set
            {
                if (value < 0 || 2 < value)
                {
                    //customer can only order between 0 and 2 sugars
                    throw new ApplicationException(nameof(value));
                }

                this._sugarCount = value;
            }
        }
        public Boolean HasStick { get; set; }

        //I may not be sure to understand the "message received" feature
        //it sounds weird for me to have the user interface message
        //in the command.
        public String Message { get; set; } = String.Empty;

        public override bool Equals(object obj)
        {
            if(!(obj is DrinkCommand))
            {
                return false;
            }

            var command = (DrinkCommand) obj;

            return this.HasStick == command.HasStick 
                && this.SugarCount == command.SugarCount 
                && this.DrinkType == command.DrinkType
                && this.Message == command.Message;
        }

        public override int GetHashCode()
        {
            var hashCode = 1947966917;
            hashCode = hashCode * -1521134295 + DrinkType.GetHashCode();
            hashCode = hashCode * -1521134295 + _sugarCount.GetHashCode();
            hashCode = hashCode * -1521134295 + HasStick.GetHashCode();
            hashCode = hashCode * -1521134295 + Message.GetHashCode();
            return hashCode;
        }
    }
}
