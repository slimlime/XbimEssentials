// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.StructuralAnalysisDomain;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcStructuralLoadGroup
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcStructuralLoadGroup : IIfcGroup
	{
		IfcLoadGroupTypeEnum @PredefinedType { get; }
		IfcActionTypeEnum @ActionType { get; }
		IfcActionSourceTypeEnum @ActionSource { get; }
		IfcRatioMeasure? @Coefficient { get; }
		IfcLabel? @Purpose { get; }
		IEnumerable<IIfcStructuralResultGroup> @SourceOfResultGroup {  get; }
		IEnumerable<IIfcStructuralAnalysisModel> @LoadGroupFor {  get; }
	
	}
}

namespace Xbim.Ifc4.StructuralAnalysisDomain
{
	[ExpressType("IfcStructuralLoadGroup", 573)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralLoadGroup : IfcGroup, IInstantiableEntity, IIfcStructuralLoadGroup, IContainsEntityReferences, IEquatable<@IfcStructuralLoadGroup>
	{
		#region IIfcStructuralLoadGroup explicit implementation
		IfcLoadGroupTypeEnum IIfcStructuralLoadGroup.PredefinedType { get { return @PredefinedType; } }	
		IfcActionTypeEnum IIfcStructuralLoadGroup.ActionType { get { return @ActionType; } }	
		IfcActionSourceTypeEnum IIfcStructuralLoadGroup.ActionSource { get { return @ActionSource; } }	
		IfcRatioMeasure? IIfcStructuralLoadGroup.Coefficient { get { return @Coefficient; } }	
		IfcLabel? IIfcStructuralLoadGroup.Purpose { get { return @Purpose; } }	
		 
		IEnumerable<IIfcStructuralResultGroup> IIfcStructuralLoadGroup.SourceOfResultGroup {  get { return @SourceOfResultGroup; } }
		IEnumerable<IIfcStructuralAnalysisModel> IIfcStructuralLoadGroup.LoadGroupFor {  get { return @LoadGroupFor; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadGroup(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLoadGroupTypeEnum _predefinedType;
		private IfcActionTypeEnum _actionType;
		private IfcActionSourceTypeEnum _actionSource;
		private IfcRatioMeasure? _coefficient;
		private IfcLabel? _purpose;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 18)]
		public IfcLoadGroupTypeEnum @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 19)]
		public IfcActionTypeEnum @ActionType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _actionType;
				((IPersistEntity)this).Activate(false);
				return _actionType;
			} 
			set
			{
				SetValue( v =>  _actionType = v, _actionType, value,  "ActionType", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 20)]
		public IfcActionSourceTypeEnum @ActionSource 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _actionSource;
				((IPersistEntity)this).Activate(false);
				return _actionSource;
			} 
			set
			{
				SetValue( v =>  _actionSource = v, _actionSource, value,  "ActionSource", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 21)]
		public IfcRatioMeasure? @Coefficient 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _coefficient;
				((IPersistEntity)this).Activate(false);
				return _coefficient;
			} 
			set
			{
				SetValue( v =>  _coefficient = v, _coefficient, value,  "Coefficient", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 22)]
		public IfcLabel? @Purpose 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _purpose;
				((IPersistEntity)this).Activate(false);
				return _purpose;
			} 
			set
			{
				SetValue( v =>  _purpose = v, _purpose, value,  "Purpose", 10);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("ResultForLoadGroup")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 23)]
		public IEnumerable<IfcStructuralResultGroup> @SourceOfResultGroup 
		{ 
			get 
			{
				return Model.Instances.Where<IfcStructuralResultGroup>(e => Equals(e.ResultForLoadGroup), "ResultForLoadGroup", this);
			} 
		}
		[InverseProperty("LoadedBy")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 24)]
		public IEnumerable<IfcStructuralAnalysisModel> @LoadGroupFor 
		{ 
			get 
			{
				return Model.Instances.Where<IfcStructuralAnalysisModel>(e => e.LoadedBy != null &&  e.LoadedBy.Contains(this), "LoadedBy", this);
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
                    _predefinedType = (IfcLoadGroupTypeEnum) System.Enum.Parse(typeof (IfcLoadGroupTypeEnum), value.EnumVal, true);
					return;
				case 6: 
                    _actionType = (IfcActionTypeEnum) System.Enum.Parse(typeof (IfcActionTypeEnum), value.EnumVal, true);
					return;
				case 7: 
                    _actionSource = (IfcActionSourceTypeEnum) System.Enum.Parse(typeof (IfcActionSourceTypeEnum), value.EnumVal, true);
					return;
				case 8: 
					_coefficient = value.RealVal;
					return;
				case 9: 
					_purpose = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcStructuralLoadGroup other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcStructuralLoadGroup
            var root = (@IfcStructuralLoadGroup)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcStructuralLoadGroup left, @IfcStructuralLoadGroup right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcStructuralLoadGroup left, @IfcStructuralLoadGroup right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}