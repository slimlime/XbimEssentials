// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.GeometricConstraintResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ProductExtension;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcGrid
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcGrid : IIfcProduct
	{
		IEnumerable<IIfcGridAxis> @UAxes { get; }
		IEnumerable<IIfcGridAxis> @VAxes { get; }
		IEnumerable<IIfcGridAxis> @WAxes { get; }
		IEnumerable<IIfcRelContainedInSpatialStructure> @ContainedInStructure {  get; }
	
	}
}

namespace Xbim.Ifc2x3.ProductExtension
{
	[ExpressType("IfcGrid", 564)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcGrid : IfcProduct, IInstantiableEntity, IIfcGrid, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcGrid>
	{
		#region IIfcGrid explicit implementation
		IEnumerable<IIfcGridAxis> IIfcGrid.UAxes { get { return @UAxes; } }	
		IEnumerable<IIfcGridAxis> IIfcGrid.VAxes { get { return @VAxes; } }	
		IEnumerable<IIfcGridAxis> IIfcGrid.WAxes { get { return @WAxes; } }	
		 
		IEnumerable<IIfcRelContainedInSpatialStructure> IIfcGrid.ContainedInStructure {  get { return @ContainedInStructure; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGrid(IModel model) : base(model) 		{ 
			Model = model; 
			_uAxes = new ItemSet<IfcGridAxis>( this, 0,  8);
			_vAxes = new ItemSet<IfcGridAxis>( this, 0,  9);
			_wAxes = new OptionalItemSet<IfcGridAxis>( this, 0,  10);
		}

		#region Explicit attribute fields
		private ItemSet<IfcGridAxis> _uAxes;
		private ItemSet<IfcGridAxis> _vAxes;
		private OptionalItemSet<IfcGridAxis> _wAxes;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.ListUnique, EntityAttributeType.Class, 1, -1, 14)]
		public ItemSet<IfcGridAxis> @UAxes 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _uAxes;
				((IPersistEntity)this).Activate(false);
				return _uAxes;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.ListUnique, EntityAttributeType.Class, 1, -1, 15)]
		public ItemSet<IfcGridAxis> @VAxes 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _vAxes;
				((IPersistEntity)this).Activate(false);
				return _vAxes;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.ListUnique, EntityAttributeType.Class, 1, -1, 16)]
		public OptionalItemSet<IfcGridAxis> @WAxes 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _wAxes;
				((IPersistEntity)this).Activate(false);
				return _wAxes;
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatedElements")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 17)]
		public IEnumerable<IfcRelContainedInSpatialStructure> @ContainedInStructure 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelContainedInSpatialStructure>(e => e.RelatedElements != null &&  e.RelatedElements.Contains(this), "RelatedElements", this);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 7: 
					_uAxes.InternalAdd((IfcGridAxis)value.EntityVal);
					return;
				case 8: 
					_vAxes.InternalAdd((IfcGridAxis)value.EntityVal);
					return;
				case 9: 
					_wAxes.InternalAdd((IfcGridAxis)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcGrid other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcGrid
            var root = (@IfcGrid)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcGrid left, @IfcGrid right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcGrid left, @IfcGrid right)
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
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
				foreach(var entity in @UAxes)
					yield return entity;
				foreach(var entity in @VAxes)
					yield return entity;
				foreach(var entity in @WAxes)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
				foreach(var entity in @UAxes)
					yield return entity;
				foreach(var entity in @VAxes)
					yield return entity;
				foreach(var entity in @WAxes)
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