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
using Xbim.Ifc4.GeometricModelResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTriangulatedFaceSet
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTriangulatedFaceSet : IIfcTessellatedFaceSet
	{
		IEnumerable<IEnumerable<IfcPositiveInteger>> @CoordIndex { get; }
		IEnumerable<IEnumerable<IfcPositiveInteger>> @NormalIndex { get; }
		IfcInteger @NumberOfTriangles  { get ; }
	
	}
}

namespace Xbim.Ifc4.GeometricModelResource
{
	[ExpressType("IfcTriangulatedFaceSet", 1304)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTriangulatedFaceSet : IfcTessellatedFaceSet, IInstantiableEntity, IIfcTriangulatedFaceSet, IContainsEntityReferences, IEquatable<@IfcTriangulatedFaceSet>
	{
		#region IIfcTriangulatedFaceSet explicit implementation
		IEnumerable<IEnumerable<IfcPositiveInteger>> IIfcTriangulatedFaceSet.CoordIndex { get { return @CoordIndex; } }	
		IEnumerable<IEnumerable<IfcPositiveInteger>> IIfcTriangulatedFaceSet.NormalIndex { get { return @NormalIndex; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTriangulatedFaceSet(IModel model) : base(model) 		{ 
			Model = model; 
			_coordIndex = new ItemSet<ItemSet<IfcPositiveInteger>>( this, 0,  4);
			_normalIndex = new OptionalItemSet<ItemSet<IfcPositiveInteger>>( this, 0,  5);
		}

		#region Explicit attribute fields
		private ItemSet<ItemSet<IfcPositiveInteger>> _coordIndex;
		private OptionalItemSet<ItemSet<IfcPositiveInteger>> _normalIndex;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.List, 3, 3, 8)]
		public ItemSet<ItemSet<IfcPositiveInteger>> @CoordIndex 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _coordIndex;
				((IPersistEntity)this).Activate(false);
				return _coordIndex;
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.List, 3, 3, 9)]
		public OptionalItemSet<ItemSet<IfcPositiveInteger>> @NormalIndex 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _normalIndex;
				((IPersistEntity)this).Activate(false);
				return _normalIndex;
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 0)]
		public IfcInteger @NumberOfTriangles 
		{
			get 
			{
				//## Getter for NumberOfTriangles
			    return CoordIndex.Count;
			    //##
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_coordIndex
						.InternalGetAt(nestedIndex[0])
						.InternalAdd((IfcPositiveInteger)(value.IntegerVal));
					return;
				case 4: 
					_normalIndex
						.InternalGetAt(nestedIndex[0])
						.InternalAdd((IfcPositiveInteger)(value.IntegerVal));
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTriangulatedFaceSet other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTriangulatedFaceSet
            var root = (@IfcTriangulatedFaceSet)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTriangulatedFaceSet left, @IfcTriangulatedFaceSet right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTriangulatedFaceSet left, @IfcTriangulatedFaceSet right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Coordinates != null)
					yield return @Coordinates;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}