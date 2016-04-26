// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.GeometricModelResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPolygonalBoundedHalfSpace
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPolygonalBoundedHalfSpace : IIfcHalfSpaceSolid
	{
		IIfcAxis2Placement3D @Position { get; }
		IIfcBoundedCurve @PolygonalBoundary { get; }
	
	}
}

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[ExpressType("IfcPolygonalBoundedHalfSpace", 623)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPolygonalBoundedHalfSpace : IfcHalfSpaceSolid, IInstantiableEntity, IIfcPolygonalBoundedHalfSpace, IEquatable<@IfcPolygonalBoundedHalfSpace>
	{
		#region IIfcPolygonalBoundedHalfSpace explicit implementation
		IIfcAxis2Placement3D IIfcPolygonalBoundedHalfSpace.Position { get { return @Position; } }	
		IIfcBoundedCurve IIfcPolygonalBoundedHalfSpace.PolygonalBoundary { get { return @PolygonalBoundary; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPolygonalBoundedHalfSpace(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAxis2Placement3D _position;
		private IfcBoundedCurve _polygonalBoundary;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcAxis2Placement3D @Position 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _position;
				((IPersistEntity)this).Activate(false);
				return _position;
			} 
			set
			{
				SetValue( v =>  _position = v, _position, value,  "Position", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 6)]
		public IfcBoundedCurve @PolygonalBoundary 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _polygonalBoundary;
				((IPersistEntity)this).Activate(false);
				return _polygonalBoundary;
			} 
			set
			{
				SetValue( v =>  _polygonalBoundary = v, _polygonalBoundary, value,  "PolygonalBoundary", 4);
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
					_position = (IfcAxis2Placement3D)(value.EntityVal);
					return;
				case 3: 
					_polygonalBoundary = (IfcBoundedCurve)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPolygonalBoundedHalfSpace other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPolygonalBoundedHalfSpace
            var root = (@IfcPolygonalBoundedHalfSpace)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPolygonalBoundedHalfSpace left, @IfcPolygonalBoundedHalfSpace right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPolygonalBoundedHalfSpace left, @IfcPolygonalBoundedHalfSpace right)
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