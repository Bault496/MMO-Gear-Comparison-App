using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO_Gear_Comparison_App
{

    /// <summary>
    /// Represents a single piece of equipment
    /// </summary>
    public class Gear
    {


        /// <summary>
        /// Id of the item
        /// </summary>
        [Key] // Tell EF this is a primary key
        public int ItemID { get; set; }

        /// <summary>
        /// Name of the piece of gear
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// Item level of the piece of gear
        /// </summary>
        public int ItemLevel { get; set; }

        /// <summary>
        /// Value that determines how much damage a weapon does
        /// </summary>
        public int? DamageScaling { get; set; }

        /// <summary>
        /// Value that determines that amount of armor a piece of gear has
        /// </summary>
        public int? ArmorScaling { get; set; }

        /// <summary>
        /// Determines the type of primary stat on the piece of gear
        /// like Intellect, Strength, and Dexterity
        /// </summary>
        public string? PrimaryStat { get; set; }

        /// <summary>
        /// Determines the amount of the primary stat is on a piece of gear
        /// </summary>
        public int? PrimaryStatScaling { get; set; }

        /// <summary>
        /// Determines the type of secondary stat on the piece of gear
        /// like Spirit, Critical Chance, and Speed
        /// </summary>
        public string? SecondaryStat { get; set; }

        /// <summary>
        /// Determines the amount of the secondary stat is on a piece of gear
        /// </summary>
        public int? SecondaryStatScaling { get; set; }

        /// <summary>
        /// Determines how much durability a piece of gear has
        /// </summary>
        public int? Durability { get; set; }

        /// <summary>
        /// Determines what slot the piece of gear goes into
        /// like Helm, Shoulders, Legs, Boots
        /// </summary>
        public string GearSlot { get; set; }

        /// <summary>
        /// Determines what type of armor the gear is
        /// like Cloth, Leather, or Plate
        /// </summary>
        public string? GearType { get; set; }

        public override string ToString()
        {
            return ItemName;
        }

    }
}
