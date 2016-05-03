// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.ProfileResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MaterialResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMaterialProfileSet
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMaterialProfileSet : IIfcMaterialDefinition
	{
		IfcLabel? @Name { get; }
		IfcText? @Description { get; }
		IEnumerable<IIfcMaterialProfile> @MaterialProfiles { get; }
		IIfcCompositeProfileDef @CompositeProfile { get; }
	
	}
}

namespace Xbim.Ifc4.MaterialResource
{
	[ExpressType("IfcMaterialProfileSet", 1206)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialProfileSet : IfcMaterialDefinition, IInstantiableEntity, IIfcMaterialProfileSet, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcMaterialProfileSet>
	{
		#region IIfcMaterialProfileSet explicit implementation
		IfcLabel? IIfcMaterialProfileSet.Name { get { return @Name; } }	
		IfcText? IIfcMaterialProfileSet.Description { get { return @Description; } }	
		IEnumerable<IIfcMaterialProfile> IIfcMaterialProfileSet.MaterialProfiles { get { return @MaterialProfiles; } }	
		IIfcCompositeProfileDef IIfcMaterialProfileSet.CompositeProfile { get { return @CompositeProfile; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialProfileSet(IModel model) : base(model) 		{ 
			Model = model; 
			_materialProfiles = new ItemSet<IfcMaterialProfile>( this, 0,  3);
		}

		#region Explicit attribute fields
		private IfcLabel? _name;
		private IfcText? _description;
		private ItemSet<IfcMaterialProfile> _materialProfiles;
		private IfcCompositeProfileDef _compositeProfile;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcLabel? @Name 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _name;
				((IPersistEntity)this).Activate(false);
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _description;
				((IPersistEntity)this).Activate(false);
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description", 2);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 6)]
		public ItemSet<IfcMaterialProfile> @MaterialProfiles 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _materialProfiles;
				((IPersistEntity)this).Activate(false);
				return _materialProfiles;
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 7)]
		public IfcCompositeProfileDef @CompositeProfile 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _compositeProfile;
				((IPersistEntity)this).Activate(false);
				return _compositeProfile;
			} 
			set
			{
				SetValue( v =>  _compositeProfile = v, _compositeProfile, value,  "CompositeProfile", 4);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_description = value.StringVal;
					return;
				case 2: 
					_materialProfiles.InternalAdd((IfcMaterialProfile)value.EntityVal);
					return;
				case 3: 
					_compositeProfile = (IfcCompositeProfileDef)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMaterialProfileSet other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcMaterialProfileSet
            var root = (@IfcMaterialProfileSet)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcMaterialProfileSet left, @IfcMaterialProfileSet right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcMaterialProfileSet left, @IfcMaterialProfileSet right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @MaterialProfiles)
					yield return entity;
				if (@CompositeProfile != null)
					yield return @CompositeProfile;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @MaterialProfiles)
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