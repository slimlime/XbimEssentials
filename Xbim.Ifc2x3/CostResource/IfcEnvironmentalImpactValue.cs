// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.CostResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcEnvironmentalImpactValue
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcEnvironmentalImpactValue : IIfcAppliedValue
	{
		IfcLabel @ImpactType { get; }
		IfcEnvironmentalImpactCategoryEnum @Category { get; }
		IfcLabel? @UserDefinedCategory { get; }
	
	}
}

namespace Xbim.Ifc2x3.CostResource
{
	[ExpressType("IfcEnvironmentalImpactValue", 78)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcEnvironmentalImpactValue : IfcAppliedValue, IInstantiableEntity, IIfcEnvironmentalImpactValue, IContainsEntityReferences, IEquatable<@IfcEnvironmentalImpactValue>
	{
		#region IIfcEnvironmentalImpactValue explicit implementation
		IfcLabel IIfcEnvironmentalImpactValue.ImpactType { get { return @ImpactType; } }	
		IfcEnvironmentalImpactCategoryEnum IIfcEnvironmentalImpactValue.Category { get { return @Category; } }	
		IfcLabel? IIfcEnvironmentalImpactValue.UserDefinedCategory { get { return @UserDefinedCategory; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcEnvironmentalImpactValue(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel _impactType;
		private IfcEnvironmentalImpactCategoryEnum _category;
		private IfcLabel? _userDefinedCategory;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 10)]
		public IfcLabel @ImpactType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _impactType;
				((IPersistEntity)this).Activate(false);
				return _impactType;
			} 
			set
			{
				SetValue( v =>  _impactType = v, _impactType, value,  "ImpactType", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 11)]
		public IfcEnvironmentalImpactCategoryEnum @Category 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _category;
				((IPersistEntity)this).Activate(false);
				return _category;
			} 
			set
			{
				SetValue( v =>  _category = v, _category, value,  "Category", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 12)]
		public IfcLabel? @UserDefinedCategory 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _userDefinedCategory;
				((IPersistEntity)this).Activate(false);
				return _userDefinedCategory;
			} 
			set
			{
				SetValue( v =>  _userDefinedCategory = v, _userDefinedCategory, value,  "UserDefinedCategory", 9);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
					_impactType = value.StringVal;
					return;
				case 7: 
                    _category = (IfcEnvironmentalImpactCategoryEnum) System.Enum.Parse(typeof (IfcEnvironmentalImpactCategoryEnum), value.EnumVal, true);
					return;
				case 8: 
					_userDefinedCategory = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcEnvironmentalImpactValue other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcEnvironmentalImpactValue
            var root = (@IfcEnvironmentalImpactValue)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcEnvironmentalImpactValue left, @IfcEnvironmentalImpactValue right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcEnvironmentalImpactValue left, @IfcEnvironmentalImpactValue right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@UnitBasis != null)
					yield return @UnitBasis;
				if (@ApplicableDate != null)
					yield return @ApplicableDate;
				if (@FixedUntilDate != null)
					yield return @FixedUntilDate;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}