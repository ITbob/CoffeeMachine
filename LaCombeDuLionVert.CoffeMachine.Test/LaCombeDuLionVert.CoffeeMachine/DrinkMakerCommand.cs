using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCombeDuLionVert.CoffeeMachine
{
    public class DrinkMakerCommand
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

        public override bool Equals(object obj)
        {
            if(!(obj is DrinkMakerCommand))
            {
                return false;
            }

            var command = (DrinkMakerCommand) obj;

            return this.HasStick == command.HasStick 
                && this.SugarCount == command.SugarCount 
                && this.DrinkType == command.DrinkType;
        }

        public override int GetHashCode()
        {
            var hashCode = 1947966917;
            hashCode = hashCode * -1521134295 + DrinkType.GetHashCode();
            hashCode = hashCode * -1521134295 + _sugarCount.GetHashCode();
            hashCode = hashCode * -1521134295 + HasStick.GetHashCode();
            return hashCode;
        }
    }
}
