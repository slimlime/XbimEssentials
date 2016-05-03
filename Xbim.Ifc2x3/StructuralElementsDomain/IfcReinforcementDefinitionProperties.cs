// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ProfilePropertyResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.StructuralElementsDomain;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcReinforcementDefinitionProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcReinforcementDefinitionProperties : IIfcPropertySetDefinition
	{
		IfcLabel? @DefinitionType { get; }
		IEnumerable<IIfcSectionReinforcementProperties> @ReinforcementSectionDefinitions { get; }
	
	}
}

namespace Xbim.Ifc2x3.StructuralElementsDomain
{
	[ExpressType("IfcReinforcementDefinitionProperties", 263)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcReinforcementDefinitionProperties : IfcPropertySetDefinition, IInstantiableEntity, IIfcReinforcementDefinitionProperties, IContainsEntityReferences, IEquatable<@IfcReinforcementDefinitionProperties>
	{
		#region IIfcReinforcementDefinitionProperties explicit implementation
		IfcLabel? IIfcReinforcementDefinitionProperties.DefinitionType { get { return @DefinitionType; } }	
		IEnumerable<IIfcSectionReinforcementProperties> IIfcReinforcementDefinitionProperties.ReinforcementSectionDefinitions { get { return @ReinforcementSectionDefinitions; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcReinforcementDefinitionProperties(IModel model) : base(model) 		{ 
			Model = model; 
			_reinforcementSectionDefinitions = new ItemSet<IfcSectionReinforcementProperties>( this, 0,  6);
		}

		#region Explicit attribute fields
		private IfcLabel? _definitionType;
		private ItemSet<IfcSectionReinforcementProperties> _reinforcementSectionDefinitions;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 8)]
		public IfcLabel? @DefinitionType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _definitionType;
				((IPersistEntity)this).Activate(false);
				return _definitionType;
			} 
			set
			{
				SetValue( v =>  _definitionType = v, _definitionType, value,  "DefinitionType", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 9)]
		public ItemSet<IfcSectionReinforcementProperties> @ReinforcementSectionDefinitions 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _reinforcementSectionDefinitions;
				((IPersistEntity)this).Activate(false);
				return _reinforcementSectionDefinitions;
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_definitionType = value.StringVal;
					return;
				case 5: 
					_reinforcementSectionDefinitions.InternalAdd((IfcSectionReinforcementProperties)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcReinforcementDefinitionProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcReinforcementDefinitionProperties
            var root = (@IfcReinforcementDefinitionProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcReinforcementDefinitionProperties left, @IfcReinforcementDefinitionProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcReinforcementDefinitionProperties left, @IfcReinforcementDefinitionProperties right)
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
				foreach(var entity in @ReinforcementSectionDefinitions)
					yield return entity;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}