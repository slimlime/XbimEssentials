// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.DateTimeResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.FacilitiesMgmtDomain;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcConditionCriterion
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcConditionCriterion : IIfcControl
	{
		IIfcConditionCriterionSelect @Criterion { get; }
		IIfcDateTimeSelect @CriterionDateTime { get; }
	
	}
}

namespace Xbim.Ifc2x3.FacilitiesMgmtDomain
{
	[ExpressType("IfcConditionCriterion", 688)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConditionCriterion : IfcControl, IInstantiableEntity, IIfcConditionCriterion, IEquatable<@IfcConditionCriterion>
	{
		#region IIfcConditionCriterion explicit implementation
		IIfcConditionCriterionSelect IIfcConditionCriterion.Criterion { get { return @Criterion; } }	
		IIfcDateTimeSelect IIfcConditionCriterion.CriterionDateTime { get { return @CriterionDateTime; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConditionCriterion(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcConditionCriterionSelect _criterion;
		private IfcDateTimeSelect _criterionDateTime;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 12)]
		public IfcConditionCriterionSelect @Criterion 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _criterion;
				((IPersistEntity)this).Activate(false);
				return _criterion;
			} 
			set
			{
				SetValue( v =>  _criterion = v, _criterion, value,  "Criterion", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 13)]
		public IfcDateTimeSelect @CriterionDateTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _criterionDateTime;
				((IPersistEntity)this).Activate(false);
				return _criterionDateTime;
			} 
			set
			{
				SetValue( v =>  _criterionDateTime = v, _criterionDateTime, value,  "CriterionDateTime", 7);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_criterion = (IfcConditionCriterionSelect)(value.EntityVal);
					return;
				case 6: 
					_criterionDateTime = (IfcDateTimeSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcConditionCriterion other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcConditionCriterion
            var root = (@IfcConditionCriterion)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcConditionCriterion left, @IfcConditionCriterion right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcConditionCriterion left, @IfcConditionCriterion right)
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