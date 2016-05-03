// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PropertyResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPropertyBoundedValue
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPropertyBoundedValue : IIfcSimpleProperty
	{
		IIfcValue @UpperBoundValue { get; }
		IIfcValue @LowerBoundValue { get; }
		IIfcUnit @Unit { get; }
		IIfcValue @SetPointValue { get; }
	
	}
}

namespace Xbim.Ifc4.PropertyResource
{
	[ExpressType("IfcPropertyBoundedValue", 3)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPropertyBoundedValue : IfcSimpleProperty, IInstantiableEntity, IIfcPropertyBoundedValue, IContainsEntityReferences, IEquatable<@IfcPropertyBoundedValue>
	{
		#region IIfcPropertyBoundedValue explicit implementation
		IIfcValue IIfcPropertyBoundedValue.UpperBoundValue { get { return @UpperBoundValue; } }	
		IIfcValue IIfcPropertyBoundedValue.LowerBoundValue { get { return @LowerBoundValue; } }	
		IIfcUnit IIfcPropertyBoundedValue.Unit { get { return @Unit; } }	
		IIfcValue IIfcPropertyBoundedValue.SetPointValue { get { return @SetPointValue; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyBoundedValue(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcValue _upperBoundValue;
		private IfcValue _lowerBoundValue;
		private IfcUnit _unit;
		private IfcValue _setPointValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 10)]
		public IfcValue @UpperBoundValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _upperBoundValue;
				((IPersistEntity)this).Activate(false);
				return _upperBoundValue;
			} 
			set
			{
				SetValue( v =>  _upperBoundValue = v, _upperBoundValue, value,  "UpperBoundValue", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 11)]
		public IfcValue @LowerBoundValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lowerBoundValue;
				((IPersistEntity)this).Activate(false);
				return _lowerBoundValue;
			} 
			set
			{
				SetValue( v =>  _lowerBoundValue = v, _lowerBoundValue, value,  "LowerBoundValue", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 12)]
		public IfcUnit @Unit 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _unit;
				((IPersistEntity)this).Activate(false);
				return _unit;
			} 
			set
			{
				SetValue( v =>  _unit = v, _unit, value,  "Unit", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 13)]
		public IfcValue @SetPointValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _setPointValue;
				((IPersistEntity)this).Activate(false);
				return _setPointValue;
			} 
			set
			{
				SetValue( v =>  _setPointValue = v, _setPointValue, value,  "SetPointValue", 6);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_upperBoundValue = (IfcValue)(value.EntityVal);
					return;
				case 3: 
					_lowerBoundValue = (IfcValue)(value.EntityVal);
					return;
				case 4: 
					_unit = (IfcUnit)(value.EntityVal);
					return;
				case 5: 
					_setPointValue = (IfcValue)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPropertyBoundedValue other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPropertyBoundedValue
            var root = (@IfcPropertyBoundedValue)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPropertyBoundedValue left, @IfcPropertyBoundedValue right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPropertyBoundedValue left, @IfcPropertyBoundedValue right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Unit != null)
					yield return @Unit;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}