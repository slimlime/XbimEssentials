// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.QuantityResource;
using Xbim.Ifc4.CostResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ConstructionMgmtDomain;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcConstructionResourceType
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcConstructionResourceType : IIfcTypeResource
	{
		IEnumerable<IIfcAppliedValue> @BaseCosts { get; }
		IIfcPhysicalQuantity @BaseQuantity { get; }
	
	}
}

namespace Xbim.Ifc4.ConstructionMgmtDomain
{
	[ExpressType("IfcConstructionResourceType", 1137)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcConstructionResourceType : IfcTypeResource, IIfcConstructionResourceType, IEquatable<@IfcConstructionResourceType>
	{
		#region IIfcConstructionResourceType explicit implementation
		IEnumerable<IIfcAppliedValue> IIfcConstructionResourceType.BaseCosts { get { return @BaseCosts; } }	
		IIfcPhysicalQuantity IIfcConstructionResourceType.BaseQuantity { get { return @BaseQuantity; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConstructionResourceType(IModel model) : base(model) 		{ 
			Model = model; 
			_baseCosts = new OptionalItemSet<IfcAppliedValue>( this, 0,  10);
		}

		#region Explicit attribute fields
		private OptionalItemSet<IfcAppliedValue> _baseCosts;
		private IfcPhysicalQuantity _baseQuantity;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 19)]
		public OptionalItemSet<IfcAppliedValue> @BaseCosts 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _baseCosts;
				((IPersistEntity)this).Activate(false);
				return _baseCosts;
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 20)]
		public IfcPhysicalQuantity @BaseQuantity 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _baseQuantity;
				((IPersistEntity)this).Activate(false);
				return _baseQuantity;
			} 
			set
			{
				SetValue( v =>  _baseQuantity = v, _baseQuantity, value,  "BaseQuantity", 11);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 9: 
					_baseCosts.InternalAdd((IfcAppliedValue)value.EntityVal);
					return;
				case 10: 
					_baseQuantity = (IfcPhysicalQuantity)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcConstructionResourceType other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcConstructionResourceType
            var root = (@IfcConstructionResourceType)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcConstructionResourceType left, @IfcConstructionResourceType right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcConstructionResourceType left, @IfcConstructionResourceType right)
        {
            return !(left == right);
        }

        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}